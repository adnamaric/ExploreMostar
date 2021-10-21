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

namespace exploreMostar.WinUI.Sadržaj.Restorani
{
    public partial class frmRestoraniAdd : Form
    {
        private readonly APIService _restorani = new APIService("restorani");
        private readonly APIService _vrsterestorana = new APIService("VrsteRestorana");
        public double latitude;
        public double longitude;
        public byte[] slika;
        public frmRestoraniAdd()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy";
        }

        private async void frmRestoraniAdd_Load(object sender, EventArgs e)
        {
            await LoadVrsteRestorana();
        }
        private async Task LoadVrsteRestorana()
        {
            var result = await _vrsterestorana.Get<List<Model.VrstaRestorana>>(null);
            result.Insert(0, new Model.VrstaRestorana() { Naziv = "Odaberite vrstu", VrstaId = 0 });


            comboBox1.DataSource = result;
            comboBox1.DisplayMember = "Naziv";
            comboBox1.ValueMember = "VrstaId";

        }
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
                var request = new RestoraniUpsertRequest
                {
                    Naziv = txtNazivA.Text,
                    Lokacija = txtLok.Text,
                    Latitude = latitude,
                    Longitude = longitude,
                    KategorijaId = 5,
                    PutanjaSlike = openFileDialog1.FileName

                };
                if ((int)comboBox1.SelectedValue != 0)
                    request.VrstaId = int.Parse(comboBox1.SelectedValue.ToString());
                else
                    request.VrstaId = 3;

                request.GodinaIzgradnje = int.Parse(dateTimePicker1.Value.Year.ToString());
                request.Ocjena = double.Parse(txtOcjena.Text);
                request.Slika = slika;

                if (request != null)
                {
                    try
                    {
                        await _restorani.Insert<Model.Restorani>(request);
                        MessageBox.Show("Uspješno ste dodali restoran!");

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtLok_Leave(object sender, EventArgs e)
        {
            if (txtLok.Text != "")
            {
                var address = txtLok.Text;
                var locationService = new GoogleLocationService("AIzaSyB62MrChALmKF-AsfInfLwiH6bPvOiHa6Q");
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
