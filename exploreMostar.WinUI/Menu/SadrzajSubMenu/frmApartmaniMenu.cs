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
        private readonly APIService _service = new APIService("korisnici");
        private readonly APIService _korisniciuloge = new APIService("KorisniciUloge");
        private readonly APIService _uloge = new APIService("Uloge");
        public frmApartmaniMenu()
        {
            InitializeComponent();
            Provjera();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmListaApartmana frm = new frmListaApartmana();
            frm.Show();
        }
        bool admintf = false;
        private void button2_Click(object sender, EventArgs e)
        {
            
            if (admintf == true)
            {
                frmApartmaniAdd frmApartmaniAdd = new frmApartmaniAdd();
                frmApartmaniAdd.Show();
            }
            else
            {
                MessageBox.Show("Nemate pravo pristupa", "401-Unauthorized", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            APIService.isUpdate = true;
            APIService.isDelete = false;
            if (admintf == true)
            {
                frmApartmaniUpdate frm = new frmApartmaniUpdate();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Nemate pravo pristupa", "401-Unauthorized", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            }

           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            APIService.isDelete = true;
            APIService.isUpdate = false;
            if (admintf == true)
            {
                frmApartmaniUpdate frm = new frmApartmaniUpdate();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Nemate pravo pristupa", "401-Unauthorized", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            }
          
        }
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
    }

}
