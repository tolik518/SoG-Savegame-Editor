using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace SoG_SGreader
{
    static class GamePatchReader
    {
        public static async Task<string> GetCurrentGamePatchAsync(ITextBoxWrapper txtConsole)
        {
            string gameDataPath = GetGameDataPath(txtConsole);
            if (string.IsNullOrEmpty(gameDataPath) || !Directory.Exists(gameDataPath))
            {
                txtConsole.AppendText("\r\nGame data folder not found under: " + gameDataPath);
                return "?.???a";
            }

            txtConsole.AppendText("\r\nGame data folder located: " + gameDataPath);
            
            string exeFile = Path.Combine(gameDataPath, "Secrets Of Grindea.exe");

            if (!File.Exists(exeFile))
            {
                txtConsole.AppendText("\r\nGame exe not found under: " + exeFile);
                return "?.???a";
            }

            txtConsole.AppendText("\r\nGame patch-version wont be read.");
            return "?.???a";
            return await Task.Run(() => GetLatestGamePatch(exeFile, txtConsole)); // Run the heavy reflection code on a background thread
        }

        private static string GetGameDataPath(ITextBoxWrapper txtConsole)
        {
            PlatformID pid = Environment.OSVersion.Platform;

            switch (pid)
            {
                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                case PlatformID.WinCE:
                    txtConsole.AppendText("\r\nOS: Windows");
                    string steamPath = (string)Microsoft.Win32.Registry.GetValue(@"HKEY_CURRENT_USER\Software\Valve\Steam", "SteamPath", null);
                    return Path.Combine(steamPath, "steamapps", "common", "SecretsOfGrindea");
                case PlatformID.Unix:
                    txtConsole.AppendText("\r\nOS: Linux");
                    return Path.Combine(Environment.GetEnvironmentVariable("HOME"), ".local", "share", "Steam", "steamapps", "common", "SecretsOfGrindea");
                case PlatformID.MacOSX:
                    txtConsole.AppendText("\r\nOS: MacOSX");
                    return Path.Combine(Environment.GetEnvironmentVariable("HOME"), "Library", "Application Support", "Steam", "steamapps", "common", "SecretsOfGrindeaa");
                default:
                    txtConsole.AppendText("\r\nOS: Unknown");
                    return null;
            }
        }

        private static string GetLatestGamePatch(string exeFilePath, ITextBoxWrapper txtConsole)
        {
            try
            {
                // Load the Secrets of Grindea assembly
                Assembly sogAssembly = Assembly.LoadFrom(exeFilePath);

                // Get the Game1 type
                Type game1Type = sogAssembly.GetType("SoG.Game1");

                // Create an instance of Game1
                object game1Instance = Activator.CreateInstance(game1Type);

                // Invoke _Menu_FillPatchNotes to populate the list
                MethodInfo fillPatchNotesMethod = game1Type.GetMethod("_Menu_FillPatchNotes", BindingFlags.NonPublic | BindingFlags.Instance);
                fillPatchNotesMethod.Invoke(game1Instance, null);

                // Get the type for the GlobalData.MainMenu.PatchNoteMenu class
                Type patchNoteMenuType = sogAssembly.GetType("SoG.GlobalData+MainMenu+PatchNoteMenu");

                // Use reflection to get the static lxNotes field from the PatchNoteMenu class
                FieldInfo lxNotesField = patchNoteMenuType.GetField("lxNotes", BindingFlags.Static | BindingFlags.Public);

                // Get the value of the lxNotes list
                IList lxNotes = (IList)lxNotesField.GetValue(null);

                txtConsole.AppendText("\r\nlxNotes.Count: " + lxNotes.Count);

                // If the list is not empty, get the last patch note
                if (lxNotes.Count > 0)
                {
                    // Get the last patch note object
                    object latestPatchNote = lxNotes[0];

                    // Get the type of the PatchNotes class to access its fields
                    Type patchNotesType = latestPatchNote.GetType();

                    // Get the sPatchName field from the PatchNotes class and extract its value
                    FieldInfo sPatchNameField = patchNotesType.GetField("sPatchName");
                    string locatedGamePatch = (string)sPatchNameField.GetValue(latestPatchNote);

                    txtConsole.AppendText("\r\nLocated Game Patch: " + locatedGamePatch);
                    return locatedGamePatch;
                }
            }
            catch (Exception e)
            {
                txtConsole.AppendText("\r\nCouldn't locate game patch version: ");
                txtConsole.AppendText(e.Message);
            }
            return "?.???a";
        }
    }
}
