using exploreMostar.WinUI.Sadržaj.Noćni_klubovi;
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
    public partial class frmNocniKluboviMenu : Form
    {
        private readonly APIService _apartmani = new APIService("apartmani");
        public frmNocniKluboviMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmNocniKluboviAdd frm = new frmNocniKluboviAdd();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            APIService.isUpdate = true;
            APIService.isDelete = false;
            frmNocniKluboviUpdate frm = new frmNocniKluboviUpdate();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmListaNightClubs frm = new frmListaNightClubs();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            APIService.isUpdate = false;
            APIService.isDelete = true;
            frmNocniKluboviUpdate frm = new frmNocniKluboviUpdate();
            frm.Show();
        }
    }
}
