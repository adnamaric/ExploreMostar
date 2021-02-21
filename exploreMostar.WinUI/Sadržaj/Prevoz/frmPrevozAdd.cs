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
    public partial class frmPrevozAdd : Form
    {
        private readonly APIService _prevoz = new APIService("prevoz");
        public byte[] slika;
        public frmPrevozAdd()
        {
            InitializeComponent();
        }

        private void frmPrevozAdd_Load(object sender, EventArgs e)
        {

        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            var request = new PrevozUpsertRequest
            {
                Naziv = txtNazivA.Text,
                Telefon=textBox2.Text,
                Vrsta=textBox1.Text

            };
         
            if (openFileDialog1.FileName.Length != 0)
            {
                request.PutanjaSlike = openFileDialog1.FileName;
            }
            request.Slika = slika;
            if (request != null)
            {
                try
                {
                    await _prevoz.Insert<Model.Prevoz>(request);
                    MessageBox.Show("Uspješno ste dodali prevoz!");
                    //Obrisi();
                }
                catch
                {
                    MessageBox.Show("Greška prilikom dodavanja!");

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


            }
        }
    }
}
