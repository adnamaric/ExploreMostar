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
        private void button3_Click(object sender, EventArgs e)
        {
            if (admintf == true)
            {
                APIService.isUpdate = true;
                APIService.isDelete = false;
                frmKaficiUpdate frm = new frmKaficiUpdate();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Nemate pravo pristupa", "401-Unauthorized", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            if (admintf == true)
            {
                frmKaficiAdd frm = new frmKaficiAdd();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Nemate pravo pristupa", "401-Unauthorized", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmListaKafica frm = new frmListaKafica();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (admintf == true)
            {
                APIService.isUpdate = false;
                APIService.isDelete = true;
                frmKaficiUpdate frm = new frmKaficiUpdate();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Nemate pravo pristupa", "401-Unauthorized", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            }
            
        }
    }
}
