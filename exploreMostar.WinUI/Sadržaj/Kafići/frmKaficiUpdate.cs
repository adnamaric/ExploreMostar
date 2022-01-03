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
            if (APIService.isDelete == true)
                btnSnimi.Text = "Obriši";
            if (APIService.isUpdate == true)
                btnSnimi.Text = "Sačuvaj";

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
                if (txtOcjena.Text == "")
                    txtOcjena.Text = "0";
                if (txtLat.Text == "")
                    txtLat.Text = "0";
                if (txtLong.Text == "")
                    txtLong.Text = "0";
                //   if(txtOcjena.Text.ToString())
                double number = 0;
                bool dialog = double.TryParse(txtOcjena.Text.ToString(),out number);
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
                        if (APIService.isUpdate == true && APIService.isDelete == false)
                        {
                            await _kafici.Update<Model.Kafici>(_id, request);
                            MessageBox.Show("Operacija uspješna!");
                        }
                        else if (APIService.isUpdate == false && APIService.isDelete == true)
                        {
                            await _kafici.Delete((int)_id);
                            MessageBox.Show("Operacija uspješna!");
                        }
                        FreeUp();
                        await LoadKafici();

                    }

                }
            }
        }

        private void txtLok_Leave(object sender, EventArgs e)
        {
            if (txtLok.Text != "")
            {
                var address = txtLok.Text;
                var locationService = new GoogleLocationService("AIzaSyDaUNNA6dPjzLjU_xFOb4tZqwM_WwOsJKI");
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

        private void button5_Click(object sender, EventArgs e)
        {
            FreeUp();

        }
        public void FreeUp()
        {
            txtNazivA.Clear();
            txtLok.Clear();
            txtLat.Clear();
            txtLong.Clear();
            txtOcjena.Clear();
          
        }
    }
}
