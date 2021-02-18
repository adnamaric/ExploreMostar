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
        private async Task LoadApartmani()
        {
            var result = await _apartmani.Get<List<Model.Apartmani>>(null);

            result.Insert(0, new Model.Apartmani() { Naziv = "Odaberite apartman", ApartmanId = 0 });

            cmbOdabirApartmana.DataSource = result;
            cmbOdabirApartmana.DisplayMember = "Naziv";
            cmbOdabirApartmana.ValueMember = "ApartmanId";

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
                bool?[] niz = { b1, b2, b3, b4, b5, b6 };
                Check(niz);
                if (odabrani.Slika.Length != 0)
                {

                    using (MemoryStream ms = new MemoryStream(odabrani.Slika))
                    {

                        btnSlika.Image = Image.FromStream(ms);
                        txtSlikaInput.Text = System.Text.Encoding.UTF8.GetString(odabrani.Slika);
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
                b3 = false;
            }
            else
            {
                b3 = true;
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
                b3 = false;
            }
            else
            {
                b3 = true;
            }
            if (bb9.BackColor == Color.Transparent)
            {
                b3 = false;
            }
            else
            {
                b3 = true;
            }
            if (bb11.BackColor == Color.Transparent)
            {
                b3 = false;
            }
            else
            {
                b3 = true;
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
                var request = new ApartmaniUpsertRequest
                {
                    Naziv = txtNaziv.Text,
                    Lokacija = txtLok.Text,
                    Latitude = double.Parse(txtLat.Text),
                    Slika = bytes,
                    Longitude = double.Parse(txtLong.Text),
                    KategorijaApartmana = cmbKat.SelectedItem.ToString(),
                    KategorijaId=5,
                    Wifi=b1,
                    Bazen=b2,
                    Parking=b3,
                    Tv=b4,
                    Klima=b5,
                    AparatZaKafu=b6

                 };
                    request.Slika = slika;
                   
                    if (_id!=null || _id!=0)
                    {
                        await _apartmani.Update<Model.Apartmani>(_id, request);
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
      
    }
        
}
