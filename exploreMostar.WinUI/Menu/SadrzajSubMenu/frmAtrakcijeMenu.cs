using exploreMostar.WinUI.Sadržaj.Atrakcije;
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
    public partial class frmAtrakcijeMenu : Form
    {
        private readonly APIService _apartmani = new APIService("apartmani");
        private readonly APIService _service = new APIService("korisnici");
        private readonly APIService _korisniciuloge = new APIService("KorisniciUloge");
        private readonly APIService _uloge = new APIService("Uloge");
        bool admintf = false;
        public frmAtrakcijeMenu()
        {
            InitializeComponent();
            Provjera();
        }

        private void frmAtrakcijeMenu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (admintf == true)
            {
                
                frmAtrakcijeAdd frm = new frmAtrakcijeAdd();
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
                APIService.isUpdate = true;
                APIService.isDelete = false;
                frmAtrakcijeUpdate frm = new frmAtrakcijeUpdate();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Nemate pravo pristupa", "401-Unauthorized", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmListaAtrakcija frm = new frmListaAtrakcija();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (admintf == true)
            {
                APIService.isDelete = true;
                APIService.isUpdate = false;
                frmAtrakcijeUpdate frm = new frmAtrakcijeUpdate();
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
