using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using SoG_SGreader.Wrapper;
using CommandLine;
using System.Diagnostics;
using System.Security.Cryptography;
using SoG_SGreader.Enum;

namespace SoG_SGreader
{
    public static class Program
    {
        /*[DllImport("Shcore.dll")]
        static extern int SetProcessDpiAwareness(int PROCESS_DPI_AWARENESS);

        // According to https://msdn.microsoft.com/en-us/library/windows/desktop/dn280512(v=vs.85).aspx
        private enum DpiAwareness
        {
            None = 0,
            SystemAware = 1,
            PerMonitorAware = 2
        }      */

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool FreeConsole();

        [STAThread]
        public static void Main(string[] args)
        {
            PlatformID pid = Environment.OSVersion.Platform;

            if (args.Length > 0)
            {
                // If on Windows, allocate a console.
                if (pid == PlatformID.Win32NT || pid == PlatformID.Win32S ||
                    pid == PlatformID.Win32Windows || pid == PlatformID.WinCE)
                {
                    AllocConsole();

                }

                Parser.Default
                    .ParseArguments<ComandLineOptions>(args)
                    .WithParsed(RunOptions);
            }
            else
            {
                if (pid == PlatformID.Win32NT || pid == PlatformID.Win32S ||
                     pid == PlatformID.Win32Windows || pid == PlatformID.WinCE)
                {
                    FreeConsole();
                }
                RunApp();
            }
        }
        
        private static void RunOptions(ComandLineOptions opts)
        {
            if (opts.ShowText)
            {
                DisplayTextSummary(opts.SavegamePath);
            }
            else if (opts.ShowJson)
            {
                DisplayJson(opts.SavegamePath);
            }
            else if (opts.ShowPatch)
            {
                Console.WriteLine(FrmMain.SupportedPatch);
            }
            else
            {
                RunApp();
            }
        }

        private static void DisplayTextSummary(string savegamePath)
        {
            if (string.IsNullOrEmpty(savegamePath)) 
            {
                Console.WriteLine("Invalid savegame path.");
                return;
            }
            
            CommandLineTextBox commandLineTextBox = new CommandLineTextBox();
            try
            {
                DataReader.ReadFromFile(savegamePath, commandLineTextBox);
            }
            catch (Exception e)
            {
                try // nested try-catch to handle broken pipe
                {
                    Console.WriteLine("Could not read savegame.");
                    Console.WriteLine(e.Message);
                }
                catch (Exception)
                {
                    // ignored, since we cant write to the console anymore
                }
            }
        }

        private static void DisplayJson(string savegamePath)
        {
            if (string.IsNullOrEmpty(savegamePath)) 
            {
                Console.WriteLine("Invalid savegame path.");
                return;
            }

            FakeTextBox fakeTextBox = new FakeTextBox();
            try
            {
                Player playerObject = DataReader.ReadFromFile(savegamePath, fakeTextBox);
                string json = JsonHandler.GetJson(playerObject);
                Console.WriteLine(json);
            }
            catch (Exception e)
            {
                try // nested try-catch to handle broken pipe
                {
                    Console.WriteLine("Could not read savegame.");
                    Console.WriteLine(e.Message);
                }
                catch (Exception)
                {
                    // ignored, since we cant write to the console anymore
                }
            }
        }

        private static void RunApp()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //SetProcessDpiAwareness((int)DpiAwareness.SystemAware);
            GameEnums.InitializeEnums();
            Application.Run(new FrmLoadSaveGame());
        }
    }
}
