using exploreMostar.WinUI.Sadržaj.Hoteli;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exploreMostar.WinUI.Menu
{
    public partial class frmHoteliMenu : Form
    {
        public frmHoteliMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmHoteliAdd frm = new frmHoteliAdd();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmHoteliUpdate frm = new frmHoteliUpdate();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmListaHotela frm = new frmListaHotela();
            frm.Show();
        }
    }
}
