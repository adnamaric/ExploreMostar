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
    public partial class frmObjavaUpdateDelete : Form
    {
        private readonly APIService _objave = new APIService("Objava");
        private readonly APIService _korisnici = new APIService("Korisnici");

        public frmObjavaUpdateDelete()
        {
            InitializeComponent();
            if(APIService.isDelete)
            {
                btnSnimi.BackColor = Color.Red;
                btnSnimi.Text = "Obrišite objavu";
            }
        }

        private async void frmObjavaUpdateDelete_Load(object sender, EventArgs e)
        {
            var result = await _objave.Get<List<Model.Objava>>(null);

            result.Insert(0, new Model.Objava() { Naziv = "Odaberite objavu", ObjavaId= 0 });

            cmbOdabirApartmana.DataSource = result;
            cmbOdabirApartmana.DisplayMember = "Naziv";
            cmbOdabirApartmana.ValueMember = "ObjavaId";
        }
        private int? _id = null;
        public byte[] slika;
        public DateTime datum;
        public string autor = string.Empty;

        private  async void cmbOdabirApartmana_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSlikaInput.Text.Length != 0)
            {
                btnSlika.Image = null;
                txtSlikaInput.Clear();
            }
            var apid = (Model.Objava)cmbOdabirApartmana.SelectedItem;
            var result = await _objave.Get<List<Model.Objava>>(null);


            if (apid.ObjavaId != 0)
            {
                var odabrani = result.Where(y => y.ObjavaId == apid.ObjavaId).FirstOrDefault();
                if (odabrani != null)
                {
                    txtNazivA.Text = odabrani.Naziv;
                    txtOpis.Text = odabrani.Sadrzaj;
                    if (odabrani.AutorModifikacije == null)
                        txtAutor.Text = odabrani.Autor;
                    else
                        txtAutor.Text = odabrani.AutorModifikacije;
                    if (odabrani.DatumModificiranja == null)
                        txtDatum.Text = ((DateTime)odabrani.Datum).ToShortDateString();
                    else
                        txtDatum.Text = ((DateTime)odabrani.DatumModificiranja).ToShortDateString();

                    datum = odabrani.Datum;
                    autor = odabrani.Autor;
                    _id = odabrani.ObjavaId;
                    //if (odabrani.Slika.Length != 0)
                    //{
                    //    txtSlikaInput.Text = odabrani.PutanjaSlike;
                    //    var file = File.ReadAllBytes(txtSlikaInput.Text);

                    //    Image image = Image.FromFile(txtSlikaInput.Text);
                    //    btnSlika.Image = image;

                    //}

                    if (odabrani.PutanjaSlike != null && odabrani.PutanjaSlike != "openFileDialog1")
                    {

                        txtSlikaInput.Text = odabrani.PutanjaSlike;
                        var file = File.ReadAllBytes(txtSlikaInput.Text);

                        Image image = Image.FromFile(txtSlikaInput.Text);
                        btnSlika.Image = image;


                    }
                }
            }
        }
        public async Task LoadObjave()
        {
            var result = await _objave.Get<List<Model.Objava>>(null);

            result.Insert(0, new Model.Objava() { Naziv = "Odaberite objavu", ObjavaId = 0 });

            cmbOdabirApartmana.DataSource = result;
            cmbOdabirApartmana.DisplayMember = "Naziv";
            cmbOdabirApartmana.ValueMember = "ObjavaId";
        }
        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (cmbOdabirApartmana.SelectedValue.ToString() == "0" && APIService.isUpdate == true)
            {
                MessageBox.Show("Nedozvoljena operacija", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (cmbOdabirApartmana.SelectedValue.ToString() == "0" && APIService.isDelete == true)
            {
                MessageBox.Show("Nedozvoljena operacija", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

            }
            else
            {
                var result = await _korisnici.Get<List<Model.Korisnici>>(null);
                string imePrezime = string.Empty;
                foreach (var item in result)
                {
                    if (item.KorisnickoIme == APIService.Username)
                    {
                        imePrezime = item.Ime + " " + item.Prezime;
                    }
                }
                var request = new ObjavaUpsertRequest
                {
                    Naziv = txtNazivA.Text,
                    Sadrzaj = txtOpis.Text,
                    Autor = autor,

                    AutorModifikacije = imePrezime,
                    Datum = datum,
                    DatumModificiranja = DateTime.Now
                };
                if (txtSlikaInput.Text != "")
                    request.PutanjaSlike = txtSlikaInput.Text;





                if (APIService.isUpdate == true && APIService.isDelete == false)
                {
                    await _objave.Update<Model.Objava>(_id, request);
                    MessageBox.Show("Uspješno ste modificirali objavu!");
                }
                else if (APIService.isUpdate == false && APIService.isDelete == true)
                {
                    await _objave.Delete((int)_id);
                    MessageBox.Show("Uspješno ste obrisali objavu!");
                }
                FreeUp();
                await LoadObjave();
            }
        }
        public void FreeUp()
        {
            txtNazivA.Clear();
            txtAutor.Clear();
            txtDatum.Clear();
            txtOpis.Clear();
            txtSlikaInput.Clear();
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
