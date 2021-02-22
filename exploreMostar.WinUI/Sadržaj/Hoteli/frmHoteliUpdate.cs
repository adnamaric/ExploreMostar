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

namespace exploreMostar.WinUI.Sadržaj.Hoteli
{
    public partial class frmHoteliUpdate : Form
    {
        private readonly APIService _hoteli = new APIService("hoteli");
        private int? _id = null;
        private bool? b1 = false;
        private bool? b2 = false;
        private bool? b3 = false;
        private bool? b4 = false;
        private bool? b5 = false;
        private bool? b6 = false;
        public frmHoteliUpdate()
        {
            InitializeComponent();
        }

        private async void frmHoteliUpdate_Load(object sender, EventArgs e)
        {
            await LoadHoteli();
        }
        private async Task LoadHoteli()
        {
            var result = await _hoteli.Get<List<Model.Hoteli>>(null);

            result.Insert(0, new Model.Hoteli() { Naziv = "Odaberite hotel", HotelId = 0 });

            cmbOdabirApartmana.DataSource = result;
            cmbOdabirApartmana.DisplayMember = "Naziv";
            cmbOdabirApartmana.ValueMember = "HotelId";
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
        }

        private async void cmbOdabirApartmana_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSlikaInput.Text.Length != 0)
            {
                btnSlika.Image = null;
                txtSlikaInput.Clear();
            }
            var apid = (Model.Hoteli)cmbOdabirApartmana.SelectedItem;



            var result = await _hoteli.Get<List<Model.Hoteli>>(null);
            if (apid.HotelId != 0)
            {
                var odabrani = result.Where(y => y.HotelId == apid.HotelId).FirstOrDefault();
                txtNazivA.Text = odabrani.Naziv;
                txtLok.Text = odabrani.Lokacija;
                txtLat.Text = odabrani.Latitude.ToString();
                txtLong.Text = odabrani.Longitude.ToString();
                cmbKat.SelectedItem = odabrani.Kategorija;
                _id = odabrani.HotelId;
                b1 = odabrani.Wifi;
                b2 = odabrani.Bazen;
                b3 = odabrani.Parking;
                b4 = odabrani.Tv;
                b5 = odabrani.Klima;
                b6 = odabrani.AparatZaKafu;
                txtOcjena.Text = odabrani.Ocjena.ToString();
                if (odabrani.GodinaIzgradnje != null)
                {
                    cmbGodine.SelectedItem = odabrani.GodinaIzgradnje.ToString();
                }
                bool?[] niz = { b1, b2, b3, b4, b5, b6 };
                Check(niz);
                if (odabrani.Slika.Length != 0)
                {

                    txtSlikaInput.Text = odabrani.PutanjaSlike;
                    var file = File.ReadAllBytes(txtSlikaInput.Text);

                    Image image = Image.FromFile(txtSlikaInput.Text);
                    btnSlika.Image = image;


                }
            }
        }
        private void Check(bool?[] niz)
        {
            int i = 0;
            int j = i + 1;
            int additional = i;
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
                var request = new HoteliUpsertRequest
                {
                    Naziv = txtNazivA.Text,
                    Lokacija = txtLok.Text,
                    Latitude = double.Parse(txtLat.Text),
                    Slika = bytes,
                    Longitude = double.Parse(txtLong.Text),
                    Kategorija = cmbKat.SelectedItem.ToString(),
                    KategorijaId = 5,
                    Wifi = b1,
                    Bazen = b2,
                    Parking = b3,
                    Tv = b4,
                    Klima = b5,
                    AparatZaKafu = b6,
                    Ocjena = double.Parse(txtOcjena.Text)
                };
           
                if (openFileDialog1.FileName.Length != 0)
                    request.PutanjaSlike = txtSlikaInput.Text;

                if (_id != null || _id != 0)
                {
                    await _hoteli.Update<Model.Hoteli>(_id, request);
                    MessageBox.Show("Operacija uspješna!");

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
    }
}
