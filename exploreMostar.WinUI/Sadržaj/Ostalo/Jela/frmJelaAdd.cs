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
    public partial class frmJelaAdd : Form
    {
        private readonly APIService _jela = new APIService("jela");
        private readonly APIService _kjela = new APIService("kategorijejela");

        public frmJelaAdd()
        {
            InitializeComponent();
        }

        private async void frmJelaAdd_Load(object sender, EventArgs e)
        {
            var result = await _kjela.Get<List<Model.KategorijeJela>>(null);
            result.Insert(0, new Model.KategorijeJela() { Naziv = "Odaberite vrstu", KategorijaJelaId = 0 });


            comboBox1.DataSource = result;
            comboBox1.DisplayMember = "Naziv";
            comboBox1.ValueMember = "KategorijaJelaId";
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

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (txtNazivA.Text == "")
            {

                MessageBox.Show("Molimo pokušajte ponovo sa unosom", "Nedovoljno informacija", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
            else
            {
                var request = new JelaUpsertRequest
                {
                    Naziv = txtNazivA.Text,
                    Sastojci = txtOpis.Text,
                    PutanjaSlike = openFileDialog1.FileName
                };
                if (comboBox1.SelectedIndex != 0)
                {
                    request.KategorijaJelaId = (int)comboBox1.SelectedValue;
                }
                else
                {
                    request.KategorijaJelaId = 3;
                }
                request.Ocjena = double.Parse(txtOcjena.Text);
                request.Slika = slika;

                if (request != null)
                {
                    try
                    {
                        await _jela.Insert<Model.Jela>(request);
                        MessageBox.Show("Uspješno ste dodali hranu!");
                        //Obrisi();
                    }
                    catch
                    {
                        MessageBox.Show("Greška prilikom dodavanja!");

                    }
                }
            }
        }
    }
}
