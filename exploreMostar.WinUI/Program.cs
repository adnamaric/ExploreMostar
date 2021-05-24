using exploreMostar.WinUI.Korisnici;
using exploreMostar.WinUI.Menu;
//using exploreMostar.WinUI.Menu;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exploreMostar.WinUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //var ps1File = @"C:\Users\User\source\repos\ExploreMostar2345\Script.ps1";
            //var startInfo = new ProcessStartInfo()
            //{
            //    FileName = "powershell.exe",
            //    Arguments = $"-NoProfile -ExecutionPolicy unrestricted \"{ps1File}\"",
            //    UseShellExecute = false
            //};
            //Process.Start(startInfo);
            //var ps2File = @"C:\Users\User\source\repos\ExploreMostar2345\Script2.sh";
            //var start2Info = new ProcessStartInfo()
            //{
            //    FileName = "powershell.exe",
            //    Arguments = $"-NoProfile -ExecutionPolicy unrestricted \"{ps2File}\"",
            //    UseShellExecute = false
            //};
            //Process.Start(start2Info);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
