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

namespace exploreMostar.WinUI.Objava
{
    public partial class frmObjavaAdd : Form
    {
        private readonly APIService _objave = new APIService("Objava");
        private readonly APIService _korisnici = new APIService("Korisnici");

        public frmObjavaAdd()
        {
            InitializeComponent();
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (txtNazivA.Text == "")
            {
                MessageBox.Show("Molimo pokušajte ponovo sa unosom", "Nedovoljno informacija", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                var result = await _korisnici.Get<List<Model.Korisnici>>(null);
                var trazeniId = 0;
                var usename = APIService.Username;
                var autor = String.Empty;
                foreach (var item in result)
                {
                    if (item.KorisnickoIme == APIService.Username)
                    {
                        trazeniId = item.KorisnikId;
                        autor = item.Ime + " " + item.Prezime;
                    }
                }
                var request = new ObjavaUpsertRequest
                {
                    Naziv = txtNazivA.Text,
                    Datum = DateTime.Now,
                    PutanjaSlike = openFileDialog1.FileName,
                    Sadrzaj = txtOpis.Text,
                    KorisnikId = trazeniId,
                    Autor = autor

                };
                if (request != null)
                {
                    try
                    {
                        await _objave.Insert<Model.Objava>(request);
                        MessageBox.Show("Uspješno ste dodali objavu!");

                    }
                    catch
                    {
                        MessageBox.Show("Greška prilikom dodavanja!");

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

        private void frmObjavaAdd_Load(object sender, EventArgs e)
        {

        }

        private void txtOpis_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
