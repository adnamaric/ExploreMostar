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
        private readonly APIService _apartmani = new APIService("apartmani");
        public frmKaficiMenu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            APIService.isUpdate = true;
            APIService.isDelete = false;
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

        private void button4_Click(object sender, EventArgs e)
        {

            APIService.isUpdate = false;
            APIService.isDelete = true;
            frmKaficiUpdate frm = new frmKaficiUpdate();
            frm.Show();
        }
    }
}
