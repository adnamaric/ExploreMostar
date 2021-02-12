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
    public partial class frmSadrzajMenu : Form
    {
        public frmSadrzajMenu()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmAtrakcijeMenu frmAtrakcijeMenu = new frmAtrakcijeMenu();
            frmAtrakcijeMenu.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmHoteliMenu frmHoteliMenu = new frmHoteliMenu();
            frmHoteliMenu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmNocniKluboviMenu frmNocniKluboviMenu = new frmNocniKluboviMenu();
            frmNocniKluboviMenu.Show();
        }

        private void frmSadrzaj_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmApartmaniMenu frmApartmaniMenu = new frmApartmaniMenu();
            frmApartmaniMenu.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            frmRestoraniMenu frmRestoraniMenu = new frmRestoraniMenu();
            frmRestoraniMenu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmKaficiMenu frmKaficiMenu = new frmKaficiMenu();
            frmKaficiMenu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmPrevozMenu frmPrevozMenu = new frmPrevozMenu();
            frmPrevozMenu.Show();
        }
    }
}
