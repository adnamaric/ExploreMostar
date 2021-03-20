using exploreMostar.WinUI.Objava;
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
    public partial class frmObjavaMenu : Form
    {
        public frmObjavaMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmListaObjava n = new frmListaObjava();
            n.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmObjavaAdd frmObjavaAdd = new frmObjavaAdd();
            frmObjavaAdd.Show();
        }
    }
}
