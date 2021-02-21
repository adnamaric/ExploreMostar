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

namespace exploreMostar.WinUI.Sadržaj.Ostalo.Drzave
{
    public partial class frmDrzaveUpdate : Form
    {
        private readonly APIService _drzave = new APIService("drzave");
        public frmDrzaveUpdate()
        {
            InitializeComponent();
        }
        private int? _id = null;
        public byte[] slika;
        private async void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSlikaInput.Text.Length != 0)
            {
                btnSlika.Image = null;
                txtSlikaInput.Clear();
            }
            var apid = (Model.Drzave)comboBox2.SelectedItem;
            var result = await _drzave.Get<List<Model.Drzave>>(null);
            if (apid.DrzavaId != 0)
            {
                var odabrani = result.Where(y => y.DrzavaId == apid.DrzavaId).FirstOrDefault();
                txtNazivA.Text = odabrani.Naziv;
                textBox1.Text = odabrani.Oznaka;

                _id = odabrani.DrzavaId;
                if (odabrani.Slika.Length != 0)
                {
                    txtSlikaInput.Text = odabrani.PutanjaSlike;
                    var file = File.ReadAllBytes(txtSlikaInput.Text);

                    Image image = Image.FromFile(txtSlikaInput.Text);
                    btnSlika.Image = image;

                }


            }
        }

        private async void frmDrzaveUpdate_Load(object sender, EventArgs e)
        {
            var result = await _drzave.Get<List<Model.Drzave>>(null);


            comboBox2.DataSource = result;
            comboBox2.DisplayMember = "Naziv";
            comboBox2.ValueMember = "DrzavaId";
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


                // if the original encoding was ASCII


                byte[] bytes = Encoding.ASCII.GetBytes(txtSlikaInput.Text);


                var request = new DrzaveUpsertRequest
                {
                    Naziv = txtNazivA.Text,

                    Slika = bytes,
                    Oznaka = textBox1.Text

                };
                if (openFileDialog1.FileName.Length != 0)
                    request.PutanjaSlike = txtSlikaInput.Text;


                if (_id != null || _id != 0)
                {
                    await _drzave.Update<Model.Drzave>(_id, request);
                    MessageBox.Show("Operacija uspješna!");

                }
                else
                {
                    MessageBox.Show("Greška prilikom updejtovanja podataka!");

                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
