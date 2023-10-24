using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using SoG_SGreader.Wrapper;
using CommandLine;

namespace SoG_SGreader
{
    public static class Program
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool AllocConsole();
        
        public static void Main(string[] args)
        {
            if (args.Length <= 0)
            {
                RunApp();
                return;
            }

            PlatformID pid = Environment.OSVersion.Platform;
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
            Application.Run(new FrmLoadSaveGame());
        }
    }
}
