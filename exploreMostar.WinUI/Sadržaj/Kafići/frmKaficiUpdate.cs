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

namespace exploreMostar.WinUI.Sadržaj.Kafići
{
    public partial class frmKaficiUpdate : Form
    {
        private readonly APIService _kafici = new APIService("kafici");
        private int? _id = null;
        public frmKaficiUpdate()
        {
            InitializeComponent();
        }

        private async void frmKaficiUpdate_Load(object sender, EventArgs e)
        {
           await LoadKafici();
        }

        private async void cmbOdabirApartmana_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSlikaInput.Text.Length != 0)
            {
                btnSlika.Image = null;
                txtSlikaInput.Clear();
            }
            var apid = (Model.Kafici)cmbOdabirApartmana.SelectedItem;



            var result = await _kafici.Get<List<Model.Kafici>>(null);
            if (apid.KaficId != 0)
            {
                var odabrani = result.Where(y => y.KaficId == apid.KaficId).FirstOrDefault();
                txtNazivA.Text = odabrani.Naziv;
                txtLok.Text = odabrani.Lokacija;
                txtLat.Text = odabrani.Latitude.ToString();
                txtLong.Text = odabrani.Longitude.ToString();
              
                _id = odabrani.KaficId;
              
                txtOcjena.Text = odabrani.Ocjena.ToString();
            
                if (odabrani.Slika.Length != 0)
                {

                    txtSlikaInput.Text = odabrani.PutanjaSlike;
                    var file = File.ReadAllBytes(txtSlikaInput.Text);

                    Image image = Image.FromFile(txtSlikaInput.Text);
                    btnSlika.Image = image;


                }
            }
        }
        public double latitude;
        public double longitude;
        public byte[] slika;
        private async Task LoadKafici()
        {
            var result = await _kafici.Get<List<Model.Kafici>>(null);

            result.Insert(0, new Model.Kafici() { Naziv = "Odaberite kafic", KaficId = 0 });

            cmbOdabirApartmana.DataSource = result;
            cmbOdabirApartmana.DisplayMember = "Naziv";
            cmbOdabirApartmana.ValueMember = "KaficId";
           
          
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

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                //   txtSlikaInput = Convert.ToBase64String(circleButton1.Image.);
                byte[] bytes = Encoding.ASCII.GetBytes(txtSlikaInput.Text);
                var request = new KaficiUpsertRequest
                {
                    Naziv = txtNazivA.Text,
                    Lokacija = txtLok.Text,
                    Latitude = double.Parse(txtLat.Text),
                    Slika = bytes,
                    Longitude = double.Parse(txtLong.Text),
                 
                    KategorijaId = 4,
                    Ocjena = double.Parse(txtOcjena.Text)
                };

                if (openFileDialog1.FileName.Length != 0)
                    request.PutanjaSlike = txtSlikaInput.Text;

                if (_id != null || _id != 0)
                {
                    await _kafici.Update<Model.Kafici>(_id, request);
                    MessageBox.Show("Operacija uspješna!");

                }


            }
        }
    }
}
