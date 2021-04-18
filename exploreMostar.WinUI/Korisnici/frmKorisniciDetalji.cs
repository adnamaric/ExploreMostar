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
        private readonly APIService _uloge = new APIService("Uloge");

        private int? _id = null;
        public frmKorisniciDetalji(int? korisnikId = null)
        {
            InitializeComponent();
            _id = korisnikId;
            //setovanje minimalnih vrijednosti i maksi
            dateTimePicker1.MinDate = new DateTime(1930, 1, 1);

            dateTimePicker1.MaxDate = new DateTime(2011, 1, 1);

        }

        public byte[] slika;
        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (txtIme.Text == "")
                MessageBox.Show("Molimo vas unesite ime", "Nedovoljno informacija", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            else if (txtPrezime.Text == "")
            {
                MessageBox.Show("Molimo vas unesite prezime", "Nedovoljno informacija", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else if  (cmbGradovi.SelectedIndex == 0)
                MessageBox.Show("Molimo vas odaberite grad!", "Nedovoljno informacija", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
          
            else if (txtKorisnickoIme.Text == "")
            {
                MessageBox.Show("Molimo vas unesite korisnicko ime", "Nedovoljno informacija", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            }
            else if (txtTelefon.Text == "")
            {
                MessageBox.Show("Molimo vas unesite email", "Nedovoljno informacija", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else if( txtEmail.Text=="")
            {
                MessageBox.Show("Molimo vas unesite email", "Nedovoljno informacija", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            if (txtEmail.TextLength > 0)
            {
                try
                {
                    new System.Net.Mail.MailAddress(this.txtEmail.Text);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Prazno polje za email", "MailError", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Nepravilan format za email", "MailError", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (this.ValidateChildren())
                {
                    var uloge = checkedListBox1.SelectedItems.Cast<Model.Uloge>().Select(y => y.UlogaId).ToList();
                    var phoneNumber = txtTelefon.Text.Trim()
                                                     .Replace(" ", "")
                                                     .Replace("-", "")
                                                     .Replace("(", "")
                                                     .Replace(")", "");
                    var request = new KorisniciInsertRequest
                    {
                        Ime = txtIme.Text,
                        Prezime = txtPrezime.Text,
                        Email = txtEmail.Text,
                        Telefon = phoneNumber,
                        KorisnickoIme = txtKorisnickoIme.Text,
                        GradId = cmbGradovi.SelectedIndex,
                        PutanjaSlike = openFileDialog1.FileName,
                        Password = txtPassword.Text,
                        PasswordConfirmation = txtPasswordConfrirm.Text,
                        Uloge = uloge,
                        
                    };
                    //defaultni datum
                    var max = new DateTime(2011, 1, 1);

                    if (dateTimePicker1.Value != max)
                        request.DatumRodjenja = dateTimePicker1.Value;
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

        }
       
        private async Task LoadGradovi()
        {
            var result = await _gradovi.Get<List<Model.Gradovi>>(null);
            result.Insert(0, new Model.Gradovi() {Naziv="Odaberite grad", GradId=-1 });
            
            
            cmbGradovi.DataSource = result;
            cmbGradovi.DisplayMember = "Naziv";
            cmbGradovi.ValueMember = "GradId";
            
        }
        private async Task LoadUloge()
        {
            var result = await _uloge.Get<List<Model.Uloge>>(null);
          


            checkedListBox1.DataSource = result;
            checkedListBox1.DisplayMember = "Naziv";
            checkedListBox1.ValueMember = "UlogaId";

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
            await LoadUloge();
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
                    if(cmbGradovi.SelectedIndex!=0)
                    {

                    }
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



        //private void txtEmail_Validating(object sender, CancelEventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(txtEmail.Text))
        //    {
        //        errorProvider1.SetError(txtEmail, Properties.Resources.Validation_RequiredField);
        //        e.Cancel = true;
        //        lbObaveznoP.Visible = true;
        //    }
        //    else
        //    {
        //        errorProvider1.SetError(txtEmail, null);
        //    }
        //}
        //private void txtTelefon_Validating(object sender, CancelEventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(txtTelefon.Text))
        //    {
        //        errorProvider1.SetError(txtTelefon, Properties.Resources.Validation_RequiredField);
        //        e.Cancel = true;
        //    }
        //    else
        //    {
        //        errorProvider1.SetError(txtTelefon, null);
        //    }
        //}
        //private void txtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(txtKorisnickoIme.Text) || txtKorisnickoIme.Text.Length <= 3)
        //    {
        //        errorProvider1.SetError(txtKorisnickoIme, Properties.Resources.Validation_RequiredField);
        //        e.Cancel = true;
        //    }
        //    else
        //    {
        //        errorProvider1.SetError(txtKorisnickoIme, null);
        //    }
        //}



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
            txtPassword.Clear();
            txtPasswordConfrirm.Clear();
            txtIme.Clear();
            txtPrezime.Clear();
            txtEmail.Clear();
            txtKorisnickoIme.Clear();
            txtSlikaInput.Clear();
            lblImePrezime.Text = "";
            txtTelefon.Clear();
            cmbGradovi.SelectedIndex = 0;
        }

        private void txtIme_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {

                e.Cancel = false;
                lbObaveznoPolje.Visible = true;
                
            }
            else
            {
                lbObaveznoPolje.Visible = false;


            }
            if (txtIme.Text != "")
            {
                lblImePrezime.Text = txtIme.Text + " ";
            }
        }

        private void txtPrezime_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                
                e.Cancel = true;
                lbObaveznoPrezime.Visible = true;
            }
            else
            {
                lbObaveznoPrezime.Visible = false;
                

            }
            if (txtPrezime.Text != "")
            {
                lblImePrezime.Text += txtPrezime.Text;
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
               
                e.Cancel = true;
                lbObaveznoP.Visible = true;
            }
            else
            {
                lbObaveznoP.Visible = false;
            }
        }

        private void txtTelefon_Validating(object sender, CancelEventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                lbl123.Visible = true;
                e.Cancel = true;
            }
            else
            {
                lbl123.Visible = false;
            }
           
            
        }

        private void txtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKorisnickoIme.Text) || txtKorisnickoIme.Text.Length <= 3)
            {
                label10.Visible = true;

                e.Cancel = true;
            }
            else
            {
                label10.Visible = false;
            }
            if (label12.Visible == true)
            {
                e.Cancel = true;
            }
         
        }

        private async void txtKorisnickoIme_Leave(object sender, EventArgs e)
        {
            var result = await _service.Get<List<Model.Korisnici>>(null);
            bool postoji = false;
            foreach (var temp in result)
            {
                if (txtKorisnickoIme.Text == temp.KorisnickoIme)
                {
                    postoji = true;

                }
                if (postoji == true)
                    break;
            }
            if (postoji == true)
            {
                label12.Visible = true;
               
            }
            else
            {
                label12.Visible = false;
            }

        }

        private void cmbGradovi_Validating(object sender, CancelEventArgs e)
        {
            if (cmbGradovi.SelectedIndex == 0)
                label13.Visible = true;
            else
                label13.Visible = false;

        }
    }
}
