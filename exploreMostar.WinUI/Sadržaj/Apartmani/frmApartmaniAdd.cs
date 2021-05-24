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

namespace exploreMostar.WinUI.Sadržaj.Apartmani
{
    public partial class frmApartmaniAdd : Form
    {
        private readonly APIService _apartmani = new APIService("apartmani");

        public frmApartmaniAdd()
        {
            InitializeComponent();
            RadioButtonAppear();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy";
            dateTimePicker1.ShowUpDown = true;

        }

        private void frmApartmaniAdd_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("A");
            comboBox1.Items.Add("B");
            comboBox1.Items.Add("C");
            comboBox1.Items.Add("D");
            comboBox1.Items.Add("E");
            txtNazivA.Focus();
        }
        
        private void RadioButtonAppear()
        {
          
            button1.Text = "Da";
            button2.Text = "Ne";
            button2.BackColor = Color.Red;
            button2.ForeColor = Color.White;
            button2.FlatAppearance.BorderColor = Color.Black;
            bb3.Text = "Da";
            bb4.Text = "Ne";
            bb4.BackColor = Color.Red;
            bb4.ForeColor = Color.White;
            bb4.FlatAppearance.BorderColor = Color.Black;
            bb5.Text = "Da";
            bb6.Text = "Ne";
            bb6.BackColor = Color.Red;
            bb6.ForeColor = Color.White;
            bb6.FlatAppearance.BorderColor = Color.Black;
            bb7.Text = "Da";
            bb8.Text = "Ne";
            bb8.BackColor = Color.Red;
            bb8.ForeColor = Color.White;
            bb8.FlatAppearance.BorderColor = Color.Black;
            bb9.Text = "Da";
            bb10.Text = "Ne";
            bb10.BackColor = Color.Red;
            bb10.ForeColor = Color.White;
            bb10.FlatAppearance.BorderColor = Color.Black;
            bb11.Text = "Da";
            bb12.Text = "Ne";
            bb12.BackColor = Color.Red;
            bb12.ForeColor = Color.White;
            bb12.FlatAppearance.BorderColor = Color.Black;
            //btnOk.Text = "OK";
            //btnOk.BackColor = Color.DarkGreen;
            //btnOk.ForeColor=Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkGreen;
            button1.ForeColor = Color.White;
            button1.FlatAppearance.BorderColor = Color.Black;
            button2.ForeColor = Color.Black;
            button2.BackColor = Color.Transparent;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
            button1.BackColor = Color.Transparent;
            button2.ForeColor = Color.White;
            button2.BackColor = Color.Red;
            button2.FlatAppearance.BorderColor = Color.Black;
        }

        private void bb3_Click(object sender, EventArgs e)
        {
           bb3.BackColor = Color.DarkGreen;
            bb3.ForeColor = Color.White;
            bb3.FlatAppearance.BorderColor = Color.Black;
            bb4.ForeColor = Color.Black;
            bb4.BackColor = Color.Transparent;
        }

        private void bb4_Click(object sender, EventArgs e)
        {
            bb3.ForeColor = Color.Black;
            bb3.BackColor = Color.Transparent;
            bb4.ForeColor = Color.White;
            bb4.BackColor = Color.Red;
            bb4.FlatAppearance.BorderColor = Color.Black;
        }

        private void bb5_Click(object sender, EventArgs e)
        {
            bb5.BackColor = Color.DarkGreen;
            bb5.ForeColor = Color.White;
            bb5.FlatAppearance.BorderColor = Color.Black;
            bb6.ForeColor = Color.Black;
            bb6.BackColor = Color.Transparent;
        }

        private void bb6_Click(object sender, EventArgs e)
        {
            bb5.ForeColor = Color.Black;
            bb5.BackColor = Color.Transparent;
            bb6.ForeColor = Color.White;
            bb6.BackColor = Color.Red;
            bb6.FlatAppearance.BorderColor = Color.Black;
        }

        private void bb7_Click(object sender, EventArgs e)
        {
            bb7.BackColor = Color.DarkGreen;
            bb7.ForeColor = Color.White;
            bb7.FlatAppearance.BorderColor = Color.Black;
            bb8.ForeColor = Color.Black;
            bb8.BackColor = Color.Transparent;
        }

        private void bb8_Click(object sender, EventArgs e)
        {
            bb7.ForeColor = Color.Black;
            bb7.BackColor = Color.Transparent;
            bb8.ForeColor = Color.White;
            bb8.BackColor = Color.Red;
            bb8.FlatAppearance.BorderColor = Color.Black;
        }

        private void bb9_Click(object sender, EventArgs e)
        {
            bb9.BackColor = Color.DarkGreen;
            bb9.ForeColor = Color.White;
            bb9.FlatAppearance.BorderColor = Color.Black;
            bb10.ForeColor = Color.Black;
            bb10.BackColor = Color.Transparent;
        }

        private void bb10_Click(object sender, EventArgs e)
        {
            bb9.ForeColor = Color.Black;
            bb9.BackColor = Color.Transparent;
            bb10.ForeColor = Color.White;
            bb10.BackColor = Color.Red;
            bb10.FlatAppearance.BorderColor = Color.Black;
        }

        private void bb11_Click(object sender, EventArgs e)
        {
            bb11.BackColor = Color.DarkGreen;
            bb11.ForeColor = Color.White;
            bb11.FlatAppearance.BorderColor = Color.Black;
            bb12.ForeColor = Color.Black;
            bb12.BackColor = Color.Transparent;
        }

        private void bb12_Click(object sender, EventArgs e)
        {
            bb11.ForeColor = Color.Black;
            bb11.BackColor = Color.Transparent;
            bb12.ForeColor = Color.White;
            bb12.BackColor = Color.Red;
            bb12.FlatAppearance.BorderColor = Color.Black;
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (txtNazivA.Text == "" )
            {
                MessageBox.Show("Molimo pokušajte ponovo sa unosom", "Nedovoljno informacija", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            if (txtLok.Text == "")
            {
                MessageBox.Show("Objekat mora imati lokaciju", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                var request = new ApartmaniUpsertRequest
                {
                    Naziv = txtNazivA.Text,
                    Lokacija = txtLok.Text,
                    Latitude = latitude,
                    Longitude = longitude,
                    KategorijaId = 5,
                    PutanjaSlike = openFileDialog1.FileName

                };

                request.GodinaIzgradnje = int.Parse(dateTimePicker1.Value.Year.ToString());
                request.Ocjena = double.Parse(txtOcjena.Text);
                request.Slika = slika;
                request.KategorijaApartmana = comboBox1.SelectedItem.ToString();
                if (button1.BackColor == Color.DarkGreen)
                {
                    request.Wifi = true;
                }
                else
                {
                    request.Wifi = false;
                }
                if (bb3.BackColor == Color.DarkGreen)
                {
                    request.Bazen = true;
                }
                else
                {
                    request.Bazen = false;
                }
                if (bb5.BackColor == Color.DarkGreen)
                {
                    request.Parking = true;
                }
                else
                {
                    request.Parking = false;
                }
                if (bb7.BackColor == Color.DarkGreen)
                {
                    request.Tv = true;
                }
                else
                {
                    request.Tv = false;
                }
                if (bb9.BackColor == Color.DarkGreen)
                {
                    request.Klima = true;
                }
                else
                {
                    request.Klima = false;
                }
                if (bb11.BackColor == Color.DarkGreen)
                {
                    request.AparatZaKafu = true;
                }
                else
                {
                    request.AparatZaKafu = false;
                }
                if (request != null)
                {
                    try
                    {
                        await _apartmani.Insert<Model.Apartmani>(request);
                        MessageBox.Show("Uspješno ste dodali apartman!");
                        Obrisi();
                    }
                    catch
                    {
                        MessageBox.Show("Greška prilikom dodavanja!");

                    }
                }
            }
        }
        public double latitude;
        public double longitude;

        //private void btnOk_Click(object sender, EventArgs e)
        //{
        //    var address = txtLok.Text;
        //    var locationService = new GoogleLocationService("AIzaSyAcTROi9rcud66EEqgDjPB7w8zXrdfL1yY");
        //    var point = locationService.GetLatLongFromAddress(address);
        //    var latitude = point.Latitude;
        //     var longitude = point.Longitude;
        //    this.latitude = latitude;
        //    this.longitude = longitude;
        //    txtLat.Text = latitude.ToString();
        //    txtLong.Text = longitude.ToString();
        //}

    
        public byte[] slika;
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
                var locationService = new GoogleLocationService("AIzaSyDP-0g1tNQWjpbUKC0uLv3tJ7GGm6a3t8Q");
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

        private void txtLok_TextChanged(object sender, EventArgs e)
        {

        }
        private void SwitchColors()
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {
            Obrisi();

        }
        private void Obrisi()
        {
            txtNazivA.Clear();
            txtLok.Clear();
            txtLat.Clear();
            txtLong.Clear();
            txtLat.Enabled = true;
            txtLong.Enabled = true;
            txtSlikaInput.Clear();
            button2.BackColor = Color.Red;
            Button[] array = { button1, button2, bb3, bb4, bb5, bb6, bb7, bb8, bb9, bb10, bb11, bb12 };
            var i = 0;
            var j = 0;
            foreach (var item in array)
            {
                if (array[i].BackColor == Color.DarkGreen)
                {
                    array[i].BackColor = Color.Transparent;
                    array[i].ForeColor = Color.Black;
                     j = i + 1;
                    array[j].BackColor = Color.Red;
                    array[j].ForeColor = Color.White;
                }
                i++;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
