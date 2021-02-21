using exploreMostar.WinUI.Sadržaj.Ostalo.Drzave;
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
    public partial class frmDrzaveMenu : Form
    {
        public frmDrzaveMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmDrzaveAdd frm = new frmDrzaveAdd();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmDrzaveUpdate frm = new frmDrzaveUpdate();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDrzaveList frm = new frmDrzaveList();
            frm.Show();
        }
    }
}
