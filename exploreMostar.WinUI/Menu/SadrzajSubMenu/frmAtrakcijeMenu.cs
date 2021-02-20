using exploreMostar.WinUI.Sadržaj.Atrakcije;
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
    public partial class frmAtrakcijeMenu : Form
    {
        public frmAtrakcijeMenu()
        {
            InitializeComponent();
        }

        private void frmAtrakcijeMenu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAtrakcijeAdd frm = new frmAtrakcijeAdd();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAtrakcijeUpdate frm = new frmAtrakcijeUpdate();
            frm.Show();
        }
    }
}
