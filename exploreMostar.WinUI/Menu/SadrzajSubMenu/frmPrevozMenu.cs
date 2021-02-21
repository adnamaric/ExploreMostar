using exploreMostar.WinUI.Sadržaj.Prevoz;
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
    public partial class frmPrevozMenu : Form
    {
        public frmPrevozMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmListaPrevoza frm = new frmListaPrevoza();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmPrevozUpdate frm = new frmPrevozUpdate();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPrevozAdd frm = new frmPrevozAdd();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
