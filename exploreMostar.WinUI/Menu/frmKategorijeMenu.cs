using exploreMostar.WinUI.Kategorije;
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
    public partial class frmKategorijeMenu : Form
    {
        public frmKategorijeMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmKategorijePregled frm = new frmKategorijePregled();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmKategorijeAdd frm = new frmKategorijeAdd();
            frm.Show();
        }
    }
}
