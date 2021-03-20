using exploreMostar.WinUI.Sadržaj.Apartmani;
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
    public partial class frmApartmaniMenu : Form
    {
        private readonly APIService _apartmani = new APIService("apartmani");

        public frmApartmaniMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmListaApartmana frm = new frmListaApartmana();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmApartmaniAdd frmApartmaniAdd = new frmApartmaniAdd();
            frmApartmaniAdd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            APIService.isUpdate = true;
            APIService.isDelete = false;

            frmApartmaniUpdate frm = new frmApartmaniUpdate();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            APIService.isDelete = true;
            APIService.isUpdate = false;

            frmApartmaniUpdate frm = new frmApartmaniUpdate();
            frm.Show();
        }
    }
}
