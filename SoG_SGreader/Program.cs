using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using SoG_SGreader.Wrapper;

namespace SoG_SGreader
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length == 1) // pass path to open the UI with a savegame
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                FrmMain frmMain = new FrmMain(args[0]);
                Application.Run(frmMain);
            }             
            else if (args.Length == 1 && (args[0] == "--help" || args[0] == "-h")) // Show help
            {
                Console.WriteLine("SoG_SGreader.exe --help # Show this help");
                Console.WriteLine("SoG_SGreader.exe <savegame path> # Open UI with savegame, path to savegame is optional");
                Console.WriteLine("SoG_SGreader.exe --json <savegame path> # Print json of the savegame to console");
                Console.WriteLine("SoG_SGreader.exe --json <savegame path> <json file path> # Save savegame to json and return path");
                Console.WriteLine("SoG_SGreader.exe --text <savegame path> # Show a short summary of the savegame");
            }
            else if (args.Length == 2 && (args[0] == "--text" || args[0] == "-t")) // Show a short summary of the save game
            {
                ConsoleTextBox consoleTextBox = new ConsoleTextBox();
                DataReader.ReadFromFile(args[1], consoleTextBox);
            }
            else if (args.Length == 2 && (args[0] == "--json" || args[0] == "-j")) // Print json of the savegame to console
            {
                FakeTextBox fakeTextBox = new FakeTextBox();
                Player playerObject = DataReader.ReadFromFile(args[1], fakeTextBox);
                string json = JsonHandler.GetJson(playerObject);
                Console.WriteLine(json);
            }
            else if (args.Length == 3 && (args[0] == "--json" || args[0] == "-j")) // Save savegame to json
            {
                FakeTextBox fakeTextBox = new FakeTextBox();
                Player playerObject = DataReader.ReadFromFile(args[1], fakeTextBox);
                string filePath = JsonHandler.SaveGameToJson(playerObject, args[2]);
                Console.WriteLine(filePath);
            }
            else // open UI to select savegame
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FrmLoadSaveGame());
            }
        }
    }
}
