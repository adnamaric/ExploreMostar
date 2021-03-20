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
        private readonly APIService _apartmani = new APIService("apartmani");
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
            APIService.isUpdate = true;
            APIService.isDelete = false;
            frmAtrakcijeUpdate frm = new frmAtrakcijeUpdate();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmListaAtrakcija frm = new frmListaAtrakcija();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            APIService.isDelete = true;
            APIService.isUpdate = false;
            frmAtrakcijeUpdate frm = new frmAtrakcijeUpdate();
            frm.Show();
        }
    }
}
