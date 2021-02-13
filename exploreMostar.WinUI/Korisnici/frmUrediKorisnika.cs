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
    public partial class frmUrediKorisnika : Form
    {
        public frmUrediKorisnika()
        {
            InitializeComponent();
        }
        private readonly APIService _korisnici = new APIService("korisnici");
        private readonly APIService _gradovi = new APIService("gradovi");

        private async void frmUrediKorisnika_Load(object sender, EventArgs e)
        {
            await LoadKorisnici();
            await LoadGradovi();
        }
        private async Task LoadGradovi()
        {
            var result = await _gradovi.Get<List<Model.Gradovi>>(null);
            result.Insert(0, new Model.Gradovi() { Naziv = "Odaberite grad", GradId = -1 });


            cmbGradovi.DataSource = result;
            cmbGradovi.DisplayMember = "Naziv";
            cmbGradovi.ValueMember = "GradId";

        }
        public Image BytesToImage(byte[] arr)
        {
            MemoryStream ms = new MemoryStream(arr);
            return Image.FromStream(ms);
        }
        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var korid = (Model.Korisnici)cmbOdaberiKorisnika.SelectedItem;
            
            

            var result = await _korisnici.Get<List<Model.Korisnici>>(null);
            if (korid.KorisnikId != 0)
            {
                var odabrani = result.Where(y => y.KorisnikId == korid.KorisnikId).FirstOrDefault();

                txtIme.Text = odabrani.Ime;
                txtPrezime.Text = odabrani.Prezime;
                txtEmail.Text = odabrani.Email;
                txtTelefon.Text = odabrani.Telefon;
                txtKorisnickoIme.Text = odabrani.KorisnickoIme;
                if (odabrani.GradId != null)
                {
                    cmbGradovi.SelectedIndex = (int)odabrani.GradId;
                }
                //else
                //{
                //    //cmbGradovi.DisplayMember = -1;
                //}
                if (odabrani.Slika.Length != 0)
                {
                    circleButton1.Image = BytesToImage(odabrani.Slika);
                    txtSlikaInput.Text = Convert.ToBase64String(odabrani.Slika);

                }
                else
                {
                    circleButton1.Image = null;
                }
            }

        }
        private async Task LoadKorisnici()
        {
            var result = await _korisnici.Get<List<Model.Korisnici>>(null);
            foreach(var item in result)
            {
                item.ImePrezime = item.Ime + " " + item.Prezime;
            }
            result.Insert(0, new Model.Korisnici() { Ime = "Odaberite korisnika", KorisnikId = 0 });

            cmbOdaberiKorisnika.DataSource = result;
            //cmbOdaberiKorisnika.AccessibilityObject.
            cmbOdaberiKorisnika.DisplayMember = "ImePrezime";
            cmbOdaberiKorisnika.ValueMember = "KorisnikID";
            
        }
    }
}
