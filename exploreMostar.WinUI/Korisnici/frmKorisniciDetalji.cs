using exploreMostar.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exploreMostar.WinUI.Korisnici
{
    public partial class frmKorisniciDetalji : Form
    {
        private readonly APIService _service = new APIService("korisnici");
        private readonly APIService _gradovi = new APIService("gradovi");

        private int? _id = null;
        public frmKorisniciDetalji(int? korisnikId = null)
        {
            InitializeComponent();
            _id = korisnikId;

        }

        public byte[] slika;
        private async void btnSnimi_Click(object sender, EventArgs e)
        {
           
            if (this.ValidateChildren())
            {
                var request = new KorisniciInsertRequest
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Email = txtEmail.Text,
                    Telefon = txtTelefon.Text,
                    Password = txtPassword.Text,
                    PasswordConfirmation = txtPasswordConfrirm.Text,
                    KorisnickoIme = txtKorisnickoIme.Text,
                    GradId = cmbGradovi.SelectedIndex,
                    PutanjaSlike = openFileDialog1.FileName
                };
                
               request.Slika = slika;
               // btnDodajSliku_Click();
                if (_id.HasValue)
                {
                    await _service.Update<Model.Korisnici>(_id, request);
                }
                else
                {
                    await _service.Insert<Model.Korisnici>(request);

                }
                MessageBox.Show("Operacija uspješna!");
               
            }
            

        }
       
        private async Task LoadGradovi()
        {
            var result = await _gradovi.Get<List<Model.Gradovi>>(null);
            result.Insert(0, new Model.Gradovi() {Naziv="Odaberite grad", GradId=-1 });
            
            
            cmbGradovi.DataSource = result;
            cmbGradovi.DisplayMember = "Naziv";
            cmbGradovi.ValueMember = "GradId";
            
        }
     
        private async void frmKorisniciDetalji_Load(object sender, EventArgs e)
        {
            cmbGradovi.Text = "Odaberite grad";
            //try
            //{
            //    await LoadGradovi();
            //}
            //catch(AggregateException err)
            //{
            //    foreach (var errInner in err.InnerExceptions)
            //    {
            //        Debug.WriteLine(errInner); //this will call ToString() on the inner execption and get you message, stacktrace and you could perhaps drill down further into the inner exception of it if necessary 
            //    }
            await LoadGradovi();
            //}
            if (_id.HasValue)
            {
               // lblImePrezime.Text = txtIme.Text + " " + txtPrezime.Text;
                var korisnik = await _service.GetById<Model.Korisnici>(_id);
                if (korisnik != null)
                {
                    txtIme.Text = korisnik.Ime;
                    txtPrezime.Text = korisnik.Prezime;
                    txtEmail.Text = korisnik.Email;
                    txtTelefon.Text = korisnik.Telefon;
                   // txtSlikaInput.Text = korisnik.Slika.ToString();
                    if (korisnik.GradId != null)
                    {
                        cmbGradovi.SelectedIndex = (int)korisnik.GradId;
                    }
                    else
                    {
                        cmbGradovi.SelectedIndex = 0;
                    }
                    txtKorisnickoIme.Text = korisnik.KorisnickoIme;
                    if (korisnik.Slika.Length != 0)
                    {
                        circleButton1.Image = BytesToImage(korisnik.Slika);
                        txtSlikaInput.Text = System.Text.Encoding.UTF8.GetString(korisnik.Slika);


                    }
                    else
                    {
                        circleButton1.Image = null;
                    }
                }
            }
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                errorProvider.SetError(txtIme, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
                lbObaveznoPolje.Visible = true;
            }
            else
            {
                lbObaveznoPolje.Visible = false;
                errorProvider.SetError(txtIme, null);

            }
            if (txtIme.Text != "")
            {
                lblImePrezime.Text = txtIme.Text+" ";
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
                lbObaveznoP.Visible = true;
            }
            else
            {
                errorProvider.SetError(txtEmail, null);
            }
        }
        private void txtTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                errorProvider.SetError(txtTelefon, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtTelefon, null);
            }
        }
        private void txtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKorisnickoIme.Text) || txtKorisnickoIme.Text.Length <= 3)
            {
                errorProvider.SetError(txtKorisnickoIme, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtKorisnickoIme, null);
            }
        }


        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                errorProvider.SetError(txtPrezime, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
                lbObaveznoPrezime.Visible = true;
            }
            else
            {
                lbObaveznoPrezime.Visible = false;
                errorProvider.SetError(txtPrezime, null);

            }
            if (txtPrezime.Text != "")
            {
                lblImePrezime.Text += txtPrezime.Text;
            }
        }
        ////if (result..Length != 0)
        ////{
        ////    pictureBox.Image = BytesToImage(clanak.Slika);
        ////}
        ////else
        ////{
        ////    pictureBox.Image = Properties.Resources.Noimage;
        ////}

        //dgvKorisnici.AutoGenerateColumns = false;
            
        //    dgvKorisnici.DataSource = result;
            
        //}
    public Image BytesToImage(byte[] arr)
    {
        MemoryStream ms = new MemoryStream(arr);
        return Image.FromStream(ms);
    }
    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       

        private void cmbGradovi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void circleButton1_Click(object sender, EventArgs e)
        {

        }
        private void PrikaziSliku()
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
                circleButton1.Image = image;

                //circleButton1.Image.Height = 100;
            }
        }
       

        private void btnDodajSliku_Click_1(object sender, EventArgs e)
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
                circleButton1.Image = image;
                
                //circleButton1.Image.Height = 100;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            txtIme.Clear();
            txtPrezime.Clear();
            txtEmail.Clear();
            txtKorisnickoIme.Clear();
            txtPassword.Clear();
            txtPasswordConfrirm.Clear();
            txtSlikaInput.Clear();
            lblImePrezime.Text = "";
            txtTelefon.Clear();
            cmbGradovi.SelectedIndex = 0;
        }
    }
}
