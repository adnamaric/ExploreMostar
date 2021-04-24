using exploreMostar.Model.Requests;
using GoogleMaps.LocationServices;
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

namespace exploreMostar.WinUI.Sadržaj.Noćni_klubovi
{
    public partial class frmNocniKluboviAdd : Form
    {
        private readonly APIService _nightclubs = new APIService("nightclubs");
        public frmNocniKluboviAdd()
        {
            InitializeComponent();
        }

        private void frmNocniKluboviAdd_Load(object sender, EventArgs e)
        {

        }
        public double latitude;
        public double longitude;
        public byte[] slika;
        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (txtNazivA.Text == "")
            {
                MessageBox.Show("Molimo pokušajte ponovo sa unosom", "Nedovoljno informacija", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            if (txtLok.Text == "")
            {
                MessageBox.Show("Objekat mora imati lokaciju", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                var request = new NightClubsUpsertRequest
                {
                    Naziv = txtNazivA.Text,
                    Lokacija = txtLok.Text,
                    Latitude = latitude,
                    Longitude = longitude,
                    KategorijaId = 7,
                    PutanjaSlike = openFileDialog1.FileName

                };

                request.Ocjena = double.Parse(txtOcjena.Text);
                request.Slika = slika;
                if (request != null)
                {
                    try
                    {
                        await _nightclubs.Insert<Model.Nightclubs>(request);
                        MessageBox.Show("Uspješno ste dodali noćni klub!");
                        //Obrisi();
                    }
                    catch
                    {
                        MessageBox.Show("Greška prilikom dodavanja!");

                    }
                }
            }
        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                var file = File.ReadAllBytes(fileName);
                //var request = file;
                txtSlikaInput.Text = fileName;
                slika = file;
                Image image = Image.FromFile(fileName);
                btnSlika.Image = image;


            }
        }

        private void txtLok_Leave(object sender, EventArgs e)
        {

            if (txtLok.Text != "")
            {
                var address = txtLok.Text;
                var locationService = new GoogleLocationService("AIzaSyAcTROi9rcud66EEqgDjPB7w8zXrdfL1yY");
                var point = locationService.GetLatLongFromAddress(address);
                var latitude = point.Latitude;
                var longitude = point.Longitude;
                this.latitude = latitude;
                this.longitude = longitude;
                txtLat.Text = latitude.ToString();
                txtLong.Text = longitude.ToString();
                txtLat.Enabled = false;
                txtLong.Enabled = false;

                //this.latitude = 0;
                //this.longitude = 0;
            }

        }
    }
}
