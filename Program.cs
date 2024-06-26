using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Textlow
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {


            //CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            //CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en-US");
            string[] args = Environment.GetCommandLineArgs();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainWindow mw = new MainWindow();
            if (args.Length > 1)
            {
                using (StreamReader streamReader = new StreamReader(args[1]))
                {
                    mw.mainTextBox.Text = streamReader.ReadToEnd();
                    streamReader.Close();
                }
                mw.currentFilePath = args[1];
                mw.lastChanges = mw.mainTextBox.Text;
                mw.updatePathDisplay();
            }           
            Application.Run(mw);
        }
    }
}
