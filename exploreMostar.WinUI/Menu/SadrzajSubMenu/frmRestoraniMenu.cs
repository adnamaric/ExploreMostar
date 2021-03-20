using exploreMostar.WinUI.Sadržaj.Restorani;
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
    public partial class frmRestoraniMenu : Form
    {
        private readonly APIService _apartmani = new APIService("apartmani");
        public frmRestoraniMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmListaRestorana frm = new frmListaRestorana();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmRestoraniAdd frm = new frmRestoraniAdd();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            APIService.isUpdate = true;
            APIService.isDelete = false;
            frmRestoraniUpdate frm = new frmRestoraniUpdate();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            APIService.isUpdate = false;
            APIService.isDelete = true;
            frmRestoraniUpdate frm = new frmRestoraniUpdate();
            frm.Show();
        }
    }
}
