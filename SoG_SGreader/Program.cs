using System;
using System.Windows.Forms;
using SoG_SGreader.Wrapper;
using CommandLine;

namespace SoG_SGreader
{
    public static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Parser.Default
                .ParseArguments<ComandLineOptions>(args)
                .WithParsed(RunOptions);
        }
        
        static void RunOptions(ComandLineOptions opts)
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
            
            CommandLineTextBox commandLineTextBox = new CommandLineTextBox();
            try
            {
                DataReader.ReadFromFile(savegamePath, commandLineTextBox);
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
