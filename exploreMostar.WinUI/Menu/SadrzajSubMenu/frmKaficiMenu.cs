using exploreMostar.WinUI.Sadržaj.Kafići;
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
    public partial class frmKaficiMenu : Form
    {
        public frmKaficiMenu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmKaficiUpdate frm = new frmKaficiUpdate();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmKaficiAdd frm = new frmKaficiAdd();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmListaKafica frm = new frmListaKafica();
            frm.Show();
        }
    }
}
