using exploreMostar.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exploreMostar.WinUI.Korisnici
{
    public partial class frmOduzimanjePermisija : Form
    {
        private readonly APIService _korisnici = new APIService("korisnici");
        private readonly APIService _uaservice = new APIService("UserActivity");

        private Model.Korisnici korisnik = null;
        public frmOduzimanjePermisija()
        {
            InitializeComponent();
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            var korid = (Model.Korisnici)cmbOdaberiKorisnika.SelectedItem;
            var result = await _uaservice.Get<List<Model.UserActivity>>(null);
            bool vracanjePermisija = false;
            if (btnSnimi.Text == "Vrati permisije")
                vracanjePermisija = true;
            Model.UserActivity user = null;
            if (korid.KorisnikId != 0) {
                foreach (var item in result)
                {
                    if (item.KorisnikId == korid.KorisnikId)
                    {
                        user = item;
                    }
                 }
                if (user == null)
                {
                    var request = new UserActivityUpsertRequest
                    {
                        KorisnikId = korid.KorisnikId,
                        BrojPrijavljivanja = 0,
                        BrojNeuspjesnihPrijavljivanja = 0,
                        Datum = DateTime.Now,
                        Razlog =richTextBox1.Text,
                        Onemogucen = true

                    };
                    await _uaservice.Insert<Model.UserActivity>(request);
                }
                else
                {
                    if (vracanjePermisija)
                    {
                        var request = new UserActivityUpsertRequest
                        {
                            KorisnikId = korid.KorisnikId,
                            BrojPrijavljivanja = user.BrojPrijavljivanja,
                            BrojNeuspjesnihPrijavljivanja = user.BrojNeuspjesnihPrijavljivanja,
                            Datum = DateTime.Now,
                            Razlog = richTextBox1.Text,
                            Onemogucen = false

                        };
                        await _uaservice.Update<Model.UserActivity>(korisnik.KorisnikId, request);
                    }
                    else
                    {
                        var request = new UserActivityUpsertRequest
                        {
                            KorisnikId = korid.KorisnikId,
                            BrojPrijavljivanja = user.BrojPrijavljivanja,
                            BrojNeuspjesnihPrijavljivanja = user.BrojNeuspjesnihPrijavljivanja,
                            Datum = DateTime.Now,
                            Razlog = richTextBox1.Text,
                            Onemogucen = true

                        };
                        await _uaservice.Update<Model.UserActivity>(korisnik.KorisnikId, request);
                    }
                }
            }
           
        }

        private async void OduzimanjePermisija_Load(object sender, EventArgs e)
        {
            await LoadKorisnici();
        }
        private async Task LoadKorisnici()
        {
            var result = await _korisnici.Get<List<Model.Korisnici>>(null);
            foreach (var item in result)
            {
                item.ImePrezime = item.Ime + " " + item.Prezime;
                korisnik = item;
            }
            result.Insert(0, new Model.Korisnici() { Ime = "Odaberite korisnika", KorisnikId = 0 });

            cmbOdaberiKorisnika.DataSource = result;
            //cmbOdaberiKorisnika.AccessibilityObject.
            cmbOdaberiKorisnika.DisplayMember = "ImePrezime";
            cmbOdaberiKorisnika.ValueMember = "KorisnikID";

        }

        private async void cmbOdaberiKorisnika_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSlikaInput.Text.Length != 0)
            {
                circleButton1.Image = null;
                txtSlikaInput.Clear();
            }
            var korid = (Model.Korisnici)cmbOdaberiKorisnika.SelectedItem;
           

            var result = await _korisnici.Get<List<Model.Korisnici>>(null);
            if (korid.KorisnikId != 0)
            {
                var odabrani = result.Where(y => y.KorisnikId == korid.KorisnikId).FirstOrDefault();

                txtIme.Text = odabrani.Ime;
                txtPrezime.Text = odabrani.Prezime;
              
                txtKorisnickoIme.Text = odabrani.KorisnickoIme;
              
              
                //else
                //{
                //    //cmbGradovi.DisplayMember = -1;
                //}
                if (odabrani.Slika.Length != 0)
                {
                    txtSlikaInput.Text = odabrani.PutanjaSlike;
                    var file = File.ReadAllBytes(txtSlikaInput.Text);

                    Image image = Image.FromFile(txtSlikaInput.Text);
                    circleButton1.Image = image;



                }
                

            }
            var resultUS = await _uaservice.Get<List<Model.UserActivity>>(null);
            Model.UserActivity user = null;
            foreach (var item in resultUS)
            {
                if(item.KorisnikId==korid.KorisnikId)
                {
                    user = item;
                }
            }
            if (user != null)
            {
                if (user.Onemogucen == true)
                {
                    btnSnimi.BackColor = Color.DarkGreen;
                    btnSnimi.ForeColor = Color.White;
                    btnSnimi.Text = "Vrati permisije";
                }
                
            }
            else
            {
                btnSnimi.BackColor = Color.DarkRed;
                btnSnimi.ForeColor = Color.White;
                btnSnimi.Text = "Oduzmi permisije";
            }
        }
    }
}
