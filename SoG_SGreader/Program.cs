using System;
using System.Windows.Forms;

namespace Sog_SGreader
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length != 0)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                FrmMain frmMain = new FrmMain(args[0]);
                Application.Run(frmMain);
                //frmMain.ShowDialog();

            }
            else
            {
                //Start normally
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FrmLoadSaveGame());
            }
        }
    }
}
