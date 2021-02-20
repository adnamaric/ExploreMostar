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

namespace exploreMostar.WinUI.Sadržaj.Noćni_klubovi
{
    public partial class frmNocniKluboviUpdate : Form
    {
        private readonly APIService _nightclubs = new APIService("nightclubs");

        public frmNocniKluboviUpdate()
        {
            InitializeComponent();
        }

       

        private async void frmNocniKluboviUpdate_Load(object sender, EventArgs e)
        {
            var result = await _nightclubs.Get<List<Model.Nightclubs>>(null);

            result.Insert(0, new Model.Nightclubs() { NightClubId = 0 });
            cmbNightClubs.DataSource = result;
            cmbNightClubs.DisplayMember = "Naziv";
            cmbNightClubs.ValueMember = "NightClubId";
        }
        private int? _id = null;
        public byte[] slika;
        private async void cmbNightClubs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSlikaInput.Text.Length != 0)
            {
                btnSlika.Image = null;
                txtSlikaInput.Clear();
            }
            var apid = (Model.Nightclubs)cmbNightClubs.SelectedItem;
            var result = await _nightclubs.Get<List<Model.Nightclubs>>(null);
            if (apid.NightClubId != 0)
            {
                var odabrani = result.Where(y => y.NightClubId == apid.NightClubId).FirstOrDefault();
                txtNazivA.Text = odabrani.Naziv;
                txtLok.Text = odabrani.Lokacija;
                txtLat.Text = odabrani.Latitude.ToString();
                txtLong.Text = odabrani.Longitude.ToString();
                txtOcjena.Text = odabrani.Ocjena.ToString();
              
                _id = odabrani.NightClubId;
               
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

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                //   txtSlikaInput = Convert.ToBase64String(circleButton1.Image.);
                byte[] bytes = Encoding.ASCII.GetBytes(txtSlikaInput.Text);

                var request = new NightClubsUpsertRequest
                {
                    Naziv = txtNazivA.Text,
                    Lokacija = txtLok.Text,
                    Latitude = double.Parse(txtLat.Text),
                    Slika = bytes,
                    Longitude = double.Parse(txtLong.Text),
                    KategorijaId = 3,
                    Ocjena = double.Parse(txtOcjena.Text)
                };
                if (slika != null)
                {
                    request.Slika = slika;
                }
                if (_id != null || _id != 0)
                {
                    await _nightclubs.Update<Model.Nightclubs>(_id, request);
                    MessageBox.Show("Operacija uspješna!");

                }


            }
        }

        private void txtSlikaInput_TextChanged(object sender, EventArgs e)
        {

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
    }
}
