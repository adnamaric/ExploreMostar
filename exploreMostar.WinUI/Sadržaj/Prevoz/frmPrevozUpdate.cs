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

namespace exploreMostar.WinUI.Sadržaj.Prevoz
{
    public partial class frmPrevozUpdate : Form
    {
        private readonly APIService _prevoz = new APIService("prevoz");

        public frmPrevozUpdate()
        {
            InitializeComponent();
            if (APIService.isDelete)
            {
                btnSnimi.BackColor = Color.Red;
                btnSnimi.Text = "Obrišite prevoz";
            }
        }
        public async Task LoadPrevoz()
        {
            var result = await _prevoz.Get<List<Model.Prevoz>>(null);


            comboBox2.DataSource = result;
            comboBox2.DisplayMember = "Naziv";
            comboBox2.ValueMember = "PrevozId";
        }
        private async void frmPrevozUpdate_Load(object sender, EventArgs e)
        {
            var result = await _prevoz.Get<List<Model.Prevoz>>(null);


            comboBox2.DataSource = result;
            comboBox2.DisplayMember = "Naziv";
            comboBox2.ValueMember = "PrevozId";
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
            var apid = (Model.Prevoz)comboBox2.SelectedItem;
            var result = await _prevoz.Get<List<Model.Prevoz>>(null);
            if (apid.PrevozId != 0)
            {
                var odabrani = result.Where(y => y.PrevozId == apid.PrevozId).FirstOrDefault();
                txtNazivA.Text = odabrani.Naziv;
                textBox1.Text = odabrani.Vrsta;
                textBox2.Text = odabrani.Telefon;

                _id = odabrani.PrevozId;
                if (odabrani.Slika.Length != 0)
                {
                    txtSlikaInput.Text = odabrani.PutanjaSlike;
                    var file = File.ReadAllBytes(txtSlikaInput.Text);

                    Image image = Image.FromFile(txtSlikaInput.Text);
                    btnSlika.Image = image;

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
        private void FreeUp()
        {
            txtNazivA.Clear();
            textBox1.Clear();
            textBox2.Clear();
            txtSlikaInput.Clear();
        }
        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                //   txtSlikaInput = Convert.ToBase64String(circleButton1.Image.);


                // if the original encoding was ASCII


                byte[] bytes = Encoding.ASCII.GetBytes(txtSlikaInput.Text);


                var request = new PrevozUpsertRequest
                {
                    Naziv = txtNazivA.Text,

                    Slika = bytes,
                    Telefon=textBox2.Text,
                    Vrsta=textBox1.Text

                };
                if (openFileDialog1.FileName.Length != 0)
                    request.PutanjaSlike = txtSlikaInput.Text;


                if (_id != null || _id != 0 )
                {
                    if (APIService.isUpdate)
                    {
                        await _prevoz.Update<Model.Prevoz>(_id, request);
                        MessageBox.Show("Operacija uspješna!");
                    }
                    else if(APIService.isDelete)
                    {
                        await _prevoz.Delete((int)_id);
                        MessageBox.Show("Uspješno ste obrisali prevoz!");
                    }
                }
               
                FreeUp();
                await LoadPrevoz();
            }
        }
    }
}
