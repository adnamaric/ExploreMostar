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
    public partial class frmMenu : Form
    {
        private readonly APIService _korisnici = new APIService("korisnici");

        public frmMenu()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private async Task LoadKorisnici ()
        {
            var result= await _korisnici.Get<List<Model.Korisnici>>(null);
            var number = result.Count();
            button4.Text= number.ToString();
            button4.Text += " korisnika";
        }

        private async void frmMenu_Load(object sender, EventArgs e)
        {
            await LoadKorisnici();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmKorisniciMenu frm = new frmKorisniciMenu();
            frm.Show();
          
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSadrzaj frmSadrzaj = new frmSadrzaj();
            frmSadrzaj.Show();
        }
    }
}
