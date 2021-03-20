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
    public partial class frmRestoraniUpdate : Form
    {
        private readonly APIService _restorani = new APIService("restorani");
        private readonly APIService _vrsterestorana = new APIService("VrsteRestorana");
        private int? _id = null;
        public byte[] slika;
        public frmRestoraniUpdate()
        {
            InitializeComponent();
            int max = 2021;
            int start = 1990;
            while (start <= max)
            {
                cmbGodine.Items.Add(start++.ToString());
            }
           
        }

        private async void frmRestoraniUpdate_Load(object sender, EventArgs e)
        {
            var result = await _restorani.Get<List<Model.Restorani>>(null);
            var result1 = await _vrsterestorana.Get<List<Model.VrstaRestorana>>(null);

            result.Insert(0, new Model.Restorani() { RestoranId = 0,Naziv="Odaberite restoran" });

            result1.Insert(0, new Model.VrstaRestorana() { VrstaId = 0});

            comboBox2.DataSource = result;
            comboBox2.DisplayMember = "Naziv";
            comboBox2.ValueMember = "RestoranId";
            comboBox1.DataSource = result1;
            comboBox1.DisplayMember = "Naziv";
            comboBox1.ValueMember = "VrstaId";
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


            }
        }
        public double latitude;
        public double longitude;
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
                    var request = new RestoraniUpsertRequest
                    {
                        Naziv = txtNazivA.Text,
                        Lokacija = txtLok.Text,
                        Latitude = double.Parse(txtLat.Text),
                        Slika = bytes,
                        Longitude = double.Parse(txtLong.Text),
                        KategorijaId = 5,
                        Ocjena = double.Parse(txtOcjena.Text)
                    };
                    if ((int)comboBox1.SelectedValue != 0)
                        request.VrstaId = (int)comboBox1.SelectedValue;
                    if (openFileDialog1.FileName.Length != 0)
                        request.PutanjaSlike = txtSlikaInput.Text;
                    if (cmbGodine.SelectedIndex != 0)
                        request.GodinaIzgradnje = int.Parse(cmbGodine.SelectedItem.ToString());
                    if (comboBox1.SelectedIndex != 0)
                    {
                        request.VrstaId = int.Parse(comboBox1.SelectedValue.ToString());
                    }
                    else
                        request.VrstaId = 3;
                    if (_id != null || _id != 0)
                    {
                        if (APIService.isUpdate == true && APIService.isDelete == false)
                        {
                            await _restorani.Update<Model.Restorani>(_id, request);
                            MessageBox.Show("Operacija uspješna!");
                        }
                        else if (APIService.isUpdate == false && APIService.isDelete == true)
                        {
                            await _restorani.Delete((int)_id);
                            MessageBox.Show("Operacija uspješna!");
                        }

                    }

                }
            }
        }

        private async void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSlikaInput.Text.Length != 0)
            {
                btnSlika.Image = null;
                txtSlikaInput.Clear();
            }
            var apid = (Model.Restorani)comboBox2.SelectedItem;



            var result = await _restorani.Get<List<Model.Restorani>>(null);
            if (apid.RestoranId != 0)
            {
                var odabrani = result.Where(y => y.RestoranId == apid.RestoranId).FirstOrDefault();
                txtNazivA.Text = odabrani.Naziv;
                txtLok.Text = odabrani.Lokacija;
                txtLat.Text = odabrani.Latitude.ToString();
                txtLong.Text = odabrani.Longitude.ToString();
                comboBox1.SelectedItem = odabrani.VrstaId;
                _id = odabrani.RestoranId;
              
                txtOcjena.Text = odabrani.Ocjena.ToString();
                if (odabrani.GodinaIzgradnje != null)
                {
                    cmbGodine.SelectedItem = odabrani.GodinaIzgradnje.ToString();
                }
               
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
    }
}
