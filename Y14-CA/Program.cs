using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Y14_CA
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string Location = AppDomain.CurrentDomain.BaseDirectory;
            int Index = Location.IndexOf("bin");
            string Path;

            if(Index > 0)
            {
                Path = Location.Remove(Index);
            }
            else
            {
                Path = Location;
            }

            AppDomain.CurrentDomain.SetData("DataDirectory", Path);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
