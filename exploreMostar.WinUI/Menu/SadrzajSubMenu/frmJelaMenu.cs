using exploreMostar.WinUI.Sadržaj.Ostalo.Jela;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exploreMostar.WinUI.Menu.SadrzajSubMenu
{
    public partial class frmJelaMenu : Form
    {
        public frmJelaMenu()
        {
            InitializeComponent();
            Provjera();
        }
        bool admintf = false;
        private readonly APIService _service = new APIService("korisnici");
        private readonly APIService _korisniciuloge = new APIService("KorisniciUloge");
        private readonly APIService _uloge = new APIService("Uloge");
        private async void Provjera()
        {
            var result = await _service.Get<List<Model.Korisnici>>(null);
            var result1 = await _korisniciuloge.Get<List<Model.KorisniciUloge>>(null);
            var result2 = await _uloge.Get<List<Model.Uloge>>(null);

            var KorisnikId = 0;
            //APIService.Username;
            foreach (var item in result)
            {
                if (APIService.Username == item.KorisnickoIme)
                {
                    KorisnikId = item.KorisnikId;
                }
            }
            var admin = 0;
            foreach (var item in result2)
            {
                if (item.Naziv == "Administrator")
                    admin = item.UlogaId;
            }

            foreach (var item in result1)
            {
                if (item.KorisnikId == KorisnikId && item.UlogaId == admin)
                {
                    admintf = true;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmListaJela frm = new frmListaJela();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (admintf == true)
            {
                frmJelaAdd frm = new frmJelaAdd();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Nemate pravo pristupa", "401-Unauthorized", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (admintf == true)
            {
                frmJelaUpdate frm = new frmJelaUpdate();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Nemate pravo pristupa", "401-Unauthorized", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            }
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (admintf == true)
            {
                frmGenerisanjeJelovnika frm = new frmGenerisanjeJelovnika();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Nemate pravo pristupa", "401-Unauthorized", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            }
         
        }
    }
}
