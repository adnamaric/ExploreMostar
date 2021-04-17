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
    public partial class frmUklanjanjeKorisnika : Form
    {
        private readonly APIService _korisnici = new APIService("korisnici");
        private readonly APIService _gradovi = new APIService("gradovi");
        private readonly APIService _poruke = new APIService("poruke");
        private readonly APIService _recenzije = new APIService("Recenzije");
        private readonly APIService _favoriti = new APIService("MojiFavoriti");
        private readonly APIService _useractivity = new APIService("UserActivity");

        private int? _id = null;
        public frmUklanjanjeKorisnika(int? korisnikId = null)
        {
            InitializeComponent();

            _id = korisnikId;
        }

        private async void cmbOdaberiKorisnika_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSlikaInput.Text.Length != 0)
            {
                circleButton1.Image = null;
                txtSlikaInput.Clear();
            }
            var korid = (Model.Korisnici)cmbOdaberiKorisnika.SelectedItem;


            var gradovi = await _gradovi.Get<List<Model.Gradovi>>(null);

            var result = await _korisnici.Get<List<Model.Korisnici>>(null);
            if (korid.KorisnikId != 0)
            {
                var odabrani = result.Where(y => y.KorisnikId == korid.KorisnikId).FirstOrDefault();

                txtIme.Text = odabrani.Ime;
                txtPrezime.Text = odabrani.Prezime;
                txtEmail.Text = odabrani.Email;
                txtTelefon.Text = odabrani.Telefon;
                txtKorisnickoIme.Text = odabrani.KorisnickoIme;
                _id = korid.KorisnikId;
                if (odabrani.GradId != 0 )
                {
                    var grad=gradovi.Where(y => y.GradId == odabrani.GradId).FirstOrDefault();
                    txtGrad.Text = grad.Naziv;
                }
                //else
                //{
                //    //cmbGradovi.DisplayMember = -1;
                //}
                if (odabrani.Slika.Length != 0)
                {
                    //MemoryStream stream = new MemoryStream(odabrani.Slika);
                    //var newImage = System.Drawing.Image.FromStream(stream);
                    //MemoryStream ms = new MemoryStream(odabrani.Slika);
                    // Copy data into ms here, e.g. reading from NetworkStream

                    // Rewind the stream ready for reading
                    //  ms.Position = 0;
                    //Bitmap bmp = new Bitmap(ms);

                    //using (var ms = new MemoryStream(odabrani.Slika))

                    //{
                    //    Image img = Image.FromStream(ms);

                    //    circleButton1.Image = img;
                    //}

                    //
                    //return Image.FromStream(ms);
                    using (MemoryStream ms = new MemoryStream(odabrani.Slika))
                    {
                        // Do something with ms..
                        circleButton1.Image = Image.FromStream(ms);
                        txtSlikaInput.Text = System.Text.Encoding.UTF8.GetString(odabrani.Slika);
                    }

                    //txtSlikaInput.Text = Convert.ToBase64String(odabrani.Slika);
                    //var file = File.ReadAllBytes(txtSlikaInput.Text);
                    ////var request = file;


                    //Image image = Image.FromFile(txtSlikaInput.Text);
                    //circleButton1.Image = image;
                    //byte[] imageBytes = Encoding.Unicode.GetBytes(txtSlikaInput.Text);
                    //using (MemoryStream ms = new MemoryStream(imageBytes))
                    //{
                    //    ms.Write();
                    //    circleButton1.Image = new Bitmap(ms);
                    //}
                    // MemoryStream ms = new MemoryStream(odabrani.Slik);
                    // Copy data into ms here, e.g. reading from NetworkStream

                    // Rewind the stream ready for reading
                    //ms.Position = 0;
                    //Bitmap bmp = new Bitmap(ms);
                    //circleButton1.Image = bmp;
                    //byte[] buffer = new byte[txtSlikaInput.Text.Length];
                    ////byte[] buffer = new byte[16 * 1024];
                    //using (MemoryStream ms = new MemoryStream())
                    //{
                    //    int read;
                    //    while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                    //    {
                    //        ms.Write(buffer, 0, read);
                    //    }
                    //    return ms.ToArray();
                    //}
                    //    else
                    //{
                    //    circleButton1.Image = null;
                    //}

                }
            }
        }
        
        private async void frmUklanjanjeKorisnika_Load(object sender, EventArgs e)
        {
            await LoadKorisnici();
        }
        private async Task LoadKorisnici()
        {
            var result = await _korisnici.Get<List<Model.Korisnici>>(null);
            foreach (var item in result)
            {
                item.ImePrezime = item.Ime + " " + item.Prezime;
            }
           

            cmbOdaberiKorisnika.DataSource = result;
            //cmbOdaberiKorisnika.AccessibilityObject.
            cmbOdaberiKorisnika.DisplayMember = "ImePrezime";
            cmbOdaberiKorisnika.ValueMember = "KorisnikID";

        }
       

        private async void btnUkloni_Click(object sender, EventArgs e)
        {
            var result = await _korisnici.Get<List<Model.Korisnici>>(null);
            var odabrani = (Model.Korisnici)cmbOdaberiKorisnika.SelectedItem;
            var poruke = await _poruke.Get<IList<Model.Poruke>>(null);
            var recenzijes = await _recenzije.Get<IList<Model.Recenzije>>(null);
            var mojifavoriti = await _favoriti.Get<List<Model.MojiFavoriti>>(null);
            var userActivity = await _useractivity.Get<List<Model.UserActivity>>(null);

            if (odabrani.KorisnikId != 0)
            {
                foreach (var item in poruke)
                {
                    if (item.PosiljalacId == odabrani.KorisnikId || item.PrimalacId == odabrani.KorisnikId)
                    {
                        await _poruke.Delete(item.PorukaId);
                    }
                }
                foreach(var item in mojifavoriti)
                {
                    if (item.KorisnikId == odabrani.KorisnikId)
                    {
                        await _favoriti.Delete(item.FavoritiId);
                    }
                }
                foreach(var item in recenzijes)
                {
                    if (item.KorisnikId == odabrani.KorisnikId)
                    {
                        await _recenzije.Delete(item.RecenzijaId);
                    }
                }
                foreach(var item in userActivity)
                {
                    if (item.KorisnikId == odabrani.KorisnikId)
                    {
                        await _useractivity.Delete(item.KorisnikId);
                    }
                }
            }
            if (odabrani.KorisnikId != 0)
            {
                await _korisnici.Delete(odabrani.KorisnikId);
                  


            }
            await LoadKorisnici();
        }

    }
}
