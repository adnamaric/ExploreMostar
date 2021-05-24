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

namespace exploreMostar.WinUI.Sadržaj.Atrakcije
{
    public partial class frmAtrakcijeUpdate : Form
    {
        private readonly APIService _atrakcije = new APIService("atrakcije");
        private readonly APIService _vrsteatrakcija = new APIService("VrstaAtrakcija");
        public frmAtrakcijeUpdate()
        {
            InitializeComponent();
        }

        private int? _id = null;

        private async void LOadAtrakcije(object sender, EventArgs e)
        {
            var result = await _atrakcije.Get<List<Model.Atrakcije>>(null);

            result.Insert(0, new Model.Atrakcije() { AtrakcijaId = 0 });
            cmbAtrakcije.DataSource = result;
            cmbAtrakcije.DisplayMember = "Naziv";
            cmbAtrakcije.ValueMember = "AtrakcijaId";
            if (APIService.isDelete == true)
                btnSnimi.Text = "Obriši";
            if (APIService.isUpdate == true)
                btnSnimi.Text = "Sačuvaj";

        }
        public double latitude;
        public double longitude;
        private async void cmbAtrakcije_SelectedIndexChanged(object sender, EventArgs e)
        {
           await LoadVrsteAtrakcija();
            if (txtSlikaInput.Text.Length != 0)
            {
                btnSlika.Image = null;
                txtSlikaInput.Clear();
            }
            var apid = (Model.Atrakcije)cmbAtrakcije.SelectedItem;
            var result = await _atrakcije.Get<List<Model.Atrakcije>>(null);
            if (apid.AtrakcijaId != 0)
            {
                var odabrani = result.Where(y => y.AtrakcijaId == apid.AtrakcijaId).FirstOrDefault();
                txtNazivA.Text = odabrani.Naziv;
                txtLok.Text = odabrani.Lokacija;
                txtLat.Text = odabrani.Latitude.ToString();
                txtLong.Text = odabrani.Longitude.ToString();
                txtOcjena.Text = odabrani.Ocjena.ToString();
                txtOpis.Text = odabrani.Opis;
                _id = odabrani.AtrakcijaId;
                if (odabrani.VrstaAtrakcijeId != null)
                {
                    cmbVrsta.SelectedValue = odabrani.VrstaAtrakcijeId;
                }
                if (odabrani.Slika.Length != 0)
                {

                    txtSlikaInput.Text = odabrani.PutanjaSlike;
                    var file = File.ReadAllBytes(txtSlikaInput.Text);

                    Image image = Image.FromFile(txtSlikaInput.Text);
                    btnSlika.Image = image;


                }
            }
        }
        private async Task LoadVrsteAtrakcija()
        {
            var result = await _vrsteatrakcija.Get<List<Model.VrstaAtrakcija>>(null);
            result.Insert(0, new Model.VrstaAtrakcija() { Naziv = "Odaberite atrakciju", VrstaAtrakcijeId = -1 });


            cmbVrsta.DataSource = result;
            cmbVrsta.DisplayMember = "Naziv";
            cmbVrsta.ValueMember = "VrstaAtrakcijeId";

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
                double number;
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
                    var request = new AtrakcijeUpsertRequest
                    {
                        Naziv = txtNazivA.Text,
                        Lokacija = txtLok.Text,
                        Latitude = double.Parse(txtLat.Text),
                        Slika = bytes,
                        Longitude = double.Parse(txtLong.Text),
                        KategorijaId = 3,
                        Ocjena = double.Parse(txtOcjena.Text),
                        Opis = txtOpis.Text,

                    };

                    //if (slika != null)
                    //{
                    //    request.Slika = slika;
                    //}
                    if (openFileDialog1.FileName.Length != 0)
                        request.PutanjaSlike = txtSlikaInput.Text;
                    if (cmbVrsta.SelectedIndex != -1)
                    {
                        request.VrstaAtrakcijeId = int.Parse(cmbVrsta.SelectedValue.ToString());

                    }
                    if (request.VrstaAtrakcijeId == -1)
                    {
                        request.VrstaAtrakcijeId = 4;
                    }
                    if (_id != null || _id != 0)
                    {
                        if (APIService.isUpdate == true && APIService.isDelete == false)
                        {
                            await _atrakcije.Update<Model.Atrakcije>(_id, request);
                            MessageBox.Show("Operacija uspješna!");
                        }
                        else if (APIService.isUpdate == false && APIService.isDelete == true)
                        {
                            await _atrakcije.Delete((int)_id);
                            MessageBox.Show("Uspješno ste obrisali atrakciju!");
                        }
                        FreeUp();
                        await LoadAtrakcije();
                    }

                }
            }
        }
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

        private void label7_Click(object sender, EventArgs e)
        {

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
            txtOcjena.Text = "";
            txtOpis.Text = "";
           
        }

        private async Task LoadAtrakcije()
        {
            var result = await _atrakcije.Get<List<Model.Atrakcije>>(null);

            result.Insert(0, new Model.Atrakcije() { AtrakcijaId = 0 });
            cmbAtrakcije.DataSource = result;
            cmbAtrakcije.DisplayMember = "Naziv";
            cmbAtrakcije.ValueMember = "AtrakcijaId";
            if (APIService.isDelete == true)
                btnSnimi.Text = "Obriši";
            if (APIService.isUpdate == true)
                btnSnimi.Text = "Sačuvaj";
        }

        private async void frmAtrakcijeUpdate_Load(object sender, EventArgs e)
        {
            var result = await _atrakcije.Get<List<Model.Atrakcije>>(null);

            result.Insert(0, new Model.Atrakcije() { AtrakcijaId = 0 });
            cmbAtrakcije.DataSource = result;
            cmbAtrakcije.DisplayMember = "Naziv";
            cmbAtrakcije.ValueMember = "AtrakcijaId";
            if (APIService.isDelete == true)
                btnSnimi.Text = "Obriši";
            if (APIService.isUpdate == true)
                btnSnimi.Text = "Sačuvaj";
        }
    }
}
