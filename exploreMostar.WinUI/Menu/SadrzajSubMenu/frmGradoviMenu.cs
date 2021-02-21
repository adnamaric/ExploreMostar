using exploreMostar.WinUI.Sadržaj.Ostalo.Gradovi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exploreMostar.WinUI.Menu.SadrzajSubMenu
{
    public partial class frmGradoviMenu : Form
    {
        public frmGradoviMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmGradoviAdd frm = new frmGradoviAdd();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGradoviList frm = new frmGradoviList();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmGradoviUpdate frm = new frmGradoviUpdate();
            frm.Show();
        }
    }
}
