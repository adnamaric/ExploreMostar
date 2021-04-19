using exploreMostar.Model.Requests;
using GoogleMaps.LocationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exploreMostar.WinUI.Sadržaj.Apartmani
{
    public partial class frmApartmaniUpdate : Form
    {
        private readonly APIService _apartmani = new APIService("apartmani");
        private int? _id = null;
        private bool? b1 = false;
        private bool? b2 = false;
        private bool? b3 = false;
        private bool? b4 = false;
        private bool? b5 = false;
        private bool? b6 = false;
        

        public frmApartmaniUpdate()
        {
            InitializeComponent();
        }

        private async void frmApartmaniUpdate_Load(object sender, EventArgs e)
        {
            await LoadApartmani();
            
        }
        public double latitude;
        public double longitude;
        private async Task LoadApartmani()
        {
            var result = await _apartmani.Get<List<Model.Apartmani>>(null);

            result.Insert(0, new Model.Apartmani() { Naziv = "Odaberite apartman", ApartmanId = 0 });

            cmbOdabirApartmana.DataSource = result;
            cmbOdabirApartmana.DisplayMember = "Naziv";
            cmbOdabirApartmana.ValueMember = "ApartmanId";
            cmbKat.Items.Add("A");
            cmbKat.Items.Add("B");
            cmbKat.Items.Add("C");
            cmbKat.Items.Add("D");
            cmbKat.Items.Add("E");
            int max = 2021;
            int start = 1990;
            while (start <= max)
            {
                cmbGodine.Items.Add(start++.ToString());
            }
            if (APIService.isDelete == true)
                btnSnimi.Text = "Obriši";
            if(APIService.isUpdate==true)
                btnSnimi.Text = "Sačuvaj";
        }

        private async void cmbOdabirApartmana_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSlikaInput.Text.Length != 0)
            {
                btnSlika.Image = null;
                txtSlikaInput.Clear();
            }
            var apid = (Model.Apartmani)cmbOdabirApartmana.SelectedItem;



            var result = await _apartmani.Get<List<Model.Apartmani>>(null);
            if (apid.ApartmanId != 0)
            {
                var odabrani = result.Where(y => y.ApartmanId == apid.ApartmanId).FirstOrDefault();
                txtNazivA.Text = odabrani.Naziv;
                txtLok.Text = odabrani.Lokacija;
                txtLat.Text = odabrani.Latitude.ToString();
                txtLong.Text = odabrani.Longitude.ToString();
                cmbKat.SelectedItem = odabrani.KategorijaApartmana;
                _id = odabrani.ApartmanId;
                b1 = odabrani.Wifi;
                b2 = odabrani.Bazen;
                b3 = odabrani.Parking;
                b4 = odabrani.Tv;
                b5 = odabrani.Klima;
                b6 = odabrani.AparatZaKafu;
                txtOcjena.Text = odabrani.Ocjena.ToString();
                if (odabrani.GodinaIzgradnje != null)
                {
                    cmbGodine.SelectedItem =  odabrani.GodinaIzgradnje.ToString();
                }
                bool?[] niz = { b1, b2, b3, b4, b5, b6 };
                if(b1!=null && b2!=null && b3!=null && b4!=null && b5!=null && b6!=null)
                      Check(niz);
                if (odabrani.Slika.Length != 0)
                {
                    if (odabrani.PutanjaSlike != null)
                    {
                        txtSlikaInput.Text = odabrani.PutanjaSlike;
                        var file = File.ReadAllBytes(txtSlikaInput.Text);

                        Image image = Image.FromFile(txtSlikaInput.Text);
                        btnSlika.Image = image;

                    }
                }
            }

        }

        private void Check(bool?[] niz)
        {
            int i = 0;
            int j =i+1;
            int additional =i;
            Button[] arrayB = { button1, button2, bb3, bb4, bb5, bb6, bb7, bb8, bb9, bb10, bb11, bb12 };
            //0-11
            //0-5
            while (i < niz.Length)
            {

                if (niz[i].Value == false)
                {
                    arrayB[additional].BackColor = Color.Transparent;
                    arrayB[additional].ForeColor = Color.Black;
                    arrayB[additional].Text = "Da";


                    arrayB[j].BackColor = Color.Red;
                    arrayB[j].ForeColor = Color.White;
                    arrayB[j].FlatAppearance.BorderColor = Color.Black;
                    arrayB[j].Text = "Ne";

                }
                else
                {
                    arrayB[additional].BackColor = Color.DarkGreen;
                    arrayB[additional].ForeColor = Color.White;
                    arrayB[additional].FlatAppearance.BorderColor = Color.Black;

                    arrayB[additional].Text = "Da";

                    arrayB[j].BackColor = Color.Transparent;
                    arrayB[j].ForeColor = Color.Black;
                    arrayB[j].Text = "Ne";
                }
               
                i++;
                if (i == 6)
                {
                    break;
                }
                if (i == 2)
                {
                    additional = i + 2;
                }
                else if (i == 3)
                {
                    additional = i + 3;

                }
                else if (i == 4)
                {
                    additional = i + 4;
                }
                else if (i == 5)
                {
                    additional = i + 5;
                }
                else
                {
                    additional = i + 1;
                }
                j = additional + 1;
               


            }
        }
        public void Check2()
        {
            if (button1.BackColor == Color.Transparent)
            {
                b1 = false;
            }
            else
            {
                b1 = true;
            }
            if (bb3.BackColor == Color.Transparent)
            {
                b2 = false;
            }
            else
            {
                b2 = true;
            }
            if (bb5.BackColor == Color.Transparent)
            {
                b3 = false;
            }
            else
            {
                b3 = true;
            }
            if (bb7.BackColor == Color.Transparent)
            {
                b4 = false;
            }
            else
            {
                b4 = true;
            }
            if (bb9.BackColor == Color.Transparent)
            {
                b5 = false;
            }
            else
            {
                b5 = true;
            }
            if (bb11.BackColor == Color.Transparent)
            {
                b6 = false;
            }
            else
            {
                b6 = true;
            }
        }
        public byte[] slika;
        private async void btnSnimi_Click(object sender, EventArgs e)
        { 
                if (this.ValidateChildren())
                {
                    //   txtSlikaInput = Convert.ToBase64String(circleButton1.Image.);
                    byte[] bytes = Encoding.ASCII.GetBytes(txtSlikaInput.Text);
                Check2();
                if (txtOcjena.Text == "")
                    txtOcjena.Text = "0";
                if (txtLat.Text == "")
                    txtLat.Text = "0";
                if (txtLong.Text == "")
                    txtLong.Text = "0";
                double number = 0;
                bool dialog = double.TryParse(txtOcjena.Text.ToString(), out number);
                if (dialog == false)
                {
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult dialog1 = MessageBox.Show("Molimo ponovo unesite ocjenu", "Abort operation", buttons);
                    if (dialog1 == DialogResult.Yes)
                    {

                    }
                    else
                    {
                        // Do something  
                    }
                }
                else
                {
                    var request = new ApartmaniUpsertRequest
                    {
                        Naziv = txtNazivA.Text,
                        Lokacija = txtLok.Text,
                        Latitude = double.Parse(txtLat.Text),
                        Slika = bytes,
                        Longitude = double.Parse(txtLong.Text),
                        KategorijaApartmana = cmbKat.SelectedItem.ToString(),
                        KategorijaId = 5,
                        Wifi = b1,
                        Bazen = b2,
                        Parking = b3,
                        Tv = b4,
                        Klima = b5,
                        AparatZaKafu = b6,
                        Ocjena = double.Parse(txtOcjena.Text)

                    };
                    if (cmbGodine.SelectedItem != null)
                    {
                        request.GodinaIzgradnje = int.Parse(cmbGodine.SelectedItem.ToString());
                    }
                    if (openFileDialog1.FileName.Length != 0)
                        request.PutanjaSlike = txtSlikaInput.Text;

                    if (_id != null || _id != 0)
                    {
                        if (APIService.isUpdate == true && APIService.isDelete == false)
                        {
                            await _apartmani.Update<Model.Apartmani>(_id, request);
                            MessageBox.Show("Uspješno ste modificirali atribute apartmana!");
                        }
                        else if (APIService.isUpdate == false && APIService.isDelete == true)
                        {
                            await _apartmani.Delete((int)_id);
                            MessageBox.Show("Uspješno ste obrisali apartman!");
                        }
                    }
                    FreeUp();
                    await LoadApartmani();
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

                //circleButton1.Image.Height = 100;
            }
         
            
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

        private void pictureBox1_Click(object sender, EventArgs e)
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
        public void FreeUp()
        {
            txtNazivA.Clear();
            txtLok.Clear();
            txtLat.Clear();
            txtLong.Clear();
            cmbKat.SelectedItem = -1;
            cmbGodine.SelectedItem = null;
            cmbKat.SelectedItem = null;
            txtOcjena.Clear();
            button1.BackColor = Color.Transparent;
            button1.Text = "";
            button2.BackColor = Color.Transparent;
            button2.Text = "";
            bb3.BackColor = Color.Transparent;
            bb3.Text = "";
            bb4.BackColor = Color.Transparent;
            bb4.Text = "";
            bb5.BackColor = Color.Transparent;
            bb5.Text = "";
            bb6.BackColor = Color.Transparent;
            bb6.Text = "";
            bb7.BackColor = Color.Transparent;
            bb7.Text = "";
            bb8.BackColor = Color.Transparent;
            bb8.Text = "";
            bb9.BackColor = Color.Transparent;
            bb9.Text = "";
            bb10.BackColor = Color.Transparent;
            bb10.Text = "";
            bb11.BackColor = Color.Transparent;
            bb11.Text = "";
            bb12.BackColor = Color.Transparent;
            bb12.Text = "";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            FreeUp();
        }
    }
        
}
