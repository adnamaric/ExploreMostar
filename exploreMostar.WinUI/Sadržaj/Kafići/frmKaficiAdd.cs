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

namespace exploreMostar.WinUI.Sadržaj.Kafići
{
    public partial class frmKaficiAdd : Form
    {
        private readonly APIService _kafici = new APIService("kafici");
        public frmKaficiAdd()
        {
            InitializeComponent();
        }
        public double latitude;
        public double longitude;
        public byte[] slika;
        private void frmKaficiAdd_Load(object sender, EventArgs e)
        {

        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            var request = new KaficiUpsertRequest
            {
                Naziv = txtNazivA.Text,
                Lokacija = txtLok.Text,
                Latitude = latitude,
                Longitude = longitude,
                KategorijaId = 4,
                PutanjaSlike = openFileDialog1.FileName

            };

         
            request.Ocjena = double.Parse(txtOcjena.Text);
            request.Slika = slika;
           
          
            if (request != null)
            {
                try
                {
                    await _kafici.Insert<Model.Kafici>(request);
                    MessageBox.Show("Uspješno ste dodali kafić!");
                    //Obrisi();
                }
                catch
                {
                    MessageBox.Show("Greška prilikom dodavanja!");

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

        private void txtLok_TextChanged(object sender, EventArgs e)
        {

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
