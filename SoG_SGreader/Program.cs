using System;
using System.Windows.Forms;
using SoG_SGreader.Wrapper;
using CommandLine;

namespace SoG_SGreader
{
    class Options
    {
        [Value(0, MetaName = "savegame path", Required = false, HelpText = "Path to the savegame")]
        public string SavegamePath { get; set; }

        [Option('t', "text", HelpText = "Show a short summary of the savegame")]
        public bool ShowText { get; set; }

        [Option('j', "json", HelpText = "Print json of the savegame to console")]
        public bool ShowJson { get; set; }

        [Option('h', "help", HelpText = "Show help")]
        public bool ShowHelp { get; set; }
        
        [Option('p', "patch", HelpText = "Show the current supported patch version")]
        public bool ShowPatch { get; set; }
    }
    
    public static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                .WithParsed(RunOptions);
        }
        
        static void RunOptions(Options opts)
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
                Console.WriteLine(FrmMain.CurrentPatch);
            }
            else
            {
                RunApp();
            }
        }

        public static void DisplayTextSummary(string savegamePath)
        {
            if (string.IsNullOrEmpty(savegamePath)) 
            {
                Console.WriteLine("Invalid savegame path.");
                return;
            }
            
            ConsoleTextBox consoleTextBox = new ConsoleTextBox();
            try
            {
                DataReader.ReadFromFile(savegamePath, consoleTextBox);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void DisplayJson(string savegamePath)
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
                Console.WriteLine(e.Message);
            }
        }

        public static void RunApp()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLoadSaveGame());
        }
    }
}
