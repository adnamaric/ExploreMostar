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
    public partial class frmDrzaveAdd : Form
    {
        private readonly APIService _drzave = new APIService("drzave");
        public frmDrzaveAdd()
        {
            InitializeComponent();
        }

        private void frmDrzaveAdd_Load(object sender, EventArgs e)
        {

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
            var request = new DrzaveUpsertRequest
            {
                Naziv = txtNazivA.Text,
                Oznaka = textBox1.Text,

            };
            if (request.Oznaka == "")
            {
                request.Oznaka = "/";
            }
            if (openFileDialog1.FileName.Length !=0)
            {
                request.PutanjaSlike = openFileDialog1.FileName;
            }
            request.Slika = slika;
            if (request != null)
            {
                try
                {
                    await _drzave.Insert<Model.Drzave>(request);
                    MessageBox.Show("Uspješno ste dodali državu!");
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
