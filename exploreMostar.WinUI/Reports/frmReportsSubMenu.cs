using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exploreMostar.WinUI.Reports
{
    public partial class frmReportsSubMenu : Form
    {
        public frmReportsSubMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPregled nova = new frmPregled();
            nova.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmPregledKorisnika frm = new frmPregledKorisnika();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string directory = AppDomain.CurrentDomain.BaseDirectory;
            string binfolder = System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase;
          
            frmPregledZemalja frm = new frmPregledZemalja();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string directory = Application.StartupPath;
           
            directory = directory.Replace("exploreMostar.WinUI\\bin\\Debug", "Reports");
            Process.Start("explorer.exe", directory);
           
            

        }
    }
}
