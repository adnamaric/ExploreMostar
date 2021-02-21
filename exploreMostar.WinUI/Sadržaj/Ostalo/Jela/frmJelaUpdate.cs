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

namespace exploreMostar.WinUI.Sadržaj.Ostalo.Jela
{
    public partial class frmJelaUpdate : Form
    {
        private readonly APIService _jela = new APIService("jela");
        private readonly APIService _kjela = new APIService("kategorijejela");
        private int? _id = null;
        public byte[] slika;
        public byte[] origigi;

        public frmJelaUpdate()
        {
            InitializeComponent();
        }

        private async void frmJelaUpdate_Load(object sender, EventArgs e)
        {
            var result = await _jela.Get<List<Model.Jela>>(null);
            var result1 = await _kjela.Get<List<Model.KategorijeJela>>(null);

            result.Insert(0, new Model.Jela() { Naziv = "Odaberite jelo", JeloId = 0 });
            result1.Insert(0, new Model.KategorijeJela() { Naziv = "", KategorijaJelaId = -1 });

            comboBox1.DataSource = result1;
            comboBox1.DisplayMember = "Naziv";
            comboBox1.ValueMember = "KategorijaJelaId";
            comboBox2.DataSource = result;
            comboBox2.DisplayMember = "Naziv";
            comboBox2.ValueMember = "JeloId";

        }

        private async void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSlikaInput.Text.Length != 0)
            {
                btnSlika.Image = null;
                txtSlikaInput.Clear();
            }
            
           
              Model.Jela apid = (Model.Jela)comboBox2.SelectedItem;



            var result = await _jela.Get<List<Model.Jela>>(null);
            if (apid.JeloId != 0)
            {
                var odabrani = result.Where(y => y.JeloId == apid.JeloId).FirstOrDefault();
                txtNazivA.Text = odabrani.Naziv;
                if(odabrani.KategorijaJelaId!=null)
                       comboBox1.SelectedValue = odabrani.KategorijaJelaId;
                _id = odabrani.JeloId;
                txtOpis.Text = odabrani.Sastojci;
                txtOcjena.Text = odabrani.Ocjena.ToString();
                origigi = odabrani.Slika;
                if (odabrani.Slika.Length != 0)
                {
                    txtSlikaInput.Text = odabrani.PutanjaSlike;
                    var file = File.ReadAllBytes(txtSlikaInput.Text);
                    
                    Image image = Image.FromFile(txtSlikaInput.Text);
                    btnSlika.Image = image;
                  


                }
            }
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                //   txtSlikaInput = Convert.ToBase64String(circleButton1.Image.);
              

                // if the original encoding was ASCII
             

                byte[] bytes = Encoding.ASCII.GetBytes(txtSlikaInput.Text);
                string xy = Encoding.ASCII.GetString(bytes);

                var request = new JelaUpsertRequest
                {
                    Naziv = txtNazivA.Text,

                    Slika = bytes,

                    Ocjena = double.Parse(txtOcjena.Text),
                    Sastojci=txtOpis.Text
                };
                if (openFileDialog1.FileName.Length != 0)
                    request.PutanjaSlike = txtSlikaInput.Text;
                else
                //request.Slika = slika;
                if (comboBox2.SelectedIndex != 0)
                    request.KategorijaJelaId = (int)comboBox1.SelectedValue;
                if (_id != null || _id != 0)
                {
                    await _jela.Update<Model.Jela>(_id, request);
                    MessageBox.Show("Operacija uspješna!");

                }
                else
                {
                    MessageBox.Show("Greška prilikom updejtovanja podataka!");

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
