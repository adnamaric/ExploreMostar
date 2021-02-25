using exploreMostar.WinUI.Sadržaj.Ostalo.Jela;
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
    public partial class frmJelaMenu : Form
    {
        public frmJelaMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmListaJela frm = new frmListaJela();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmJelaAdd frm = new frmJelaAdd();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmJelaUpdate frm = new frmJelaUpdate();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmGenerisanjeJelovnika frm = new frmGenerisanjeJelovnika();
            frm.Show();
        }
    }
}
