﻿using exploreMostar.Model.Requests;
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

namespace exploreMostar.WinUI.Korisnici
{
    public partial class frmUrediKorisnika : Form
    {
        private int? _id = null;

        public frmUrediKorisnika(int? korisnikId = null)
        {
            InitializeComponent();
            _id = korisnikId;
        }
        private readonly APIService _korisnici = new APIService("korisnici");
        private readonly APIService _gradovi = new APIService("gradovi");
        public byte[] slika;
        private async void frmUrediKorisnika_Load(object sender, EventArgs e)
        {
            await LoadKorisnici();
            await LoadGradovi();
            dateTimePicker1.MinDate = new DateTime(1930, 1, 1);
            dateTimePicker1.MaxDate = new DateTime(2011, 1, 1);
        }
        private async Task LoadGradovi()
        {
            var result = await _gradovi.Get<List<Model.Gradovi>>(null);
            result.Insert(0, new Model.Gradovi() { Naziv = "Odaberite grad", GradId = -1 });


            cmbGradovi.DataSource = result;
            cmbGradovi.DisplayMember = "Naziv";
            cmbGradovi.ValueMember = "GradId";

        }
        //public  Image BytesToImage(byte[] arr)
        //{
        //    MemoryStream ms =  new MemoryStream(arr);
        //    return  Image.FromStream(ms);
        //}
        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSlikaInput.Text.Length != 0)
            {
                circleButton1.Image = null;
                txtSlikaInput.Clear();
            }
            var korid = (Model.Korisnici)cmbOdaberiKorisnika.SelectedItem;
            


            var result = await _korisnici.Get<List<Model.Korisnici>>(null);
            if (korid.KorisnikId != 0)
            {
                var odabrani = result.Where(y => y.KorisnikId == korid.KorisnikId).FirstOrDefault();

                txtIme.Text = odabrani.Ime;
                txtPrezime.Text = odabrani.Prezime;
                txtEmail.Text = odabrani.Email;
                txtTelefon.Text = odabrani.Telefon;
                txtKorisnickoIme.Text = odabrani.KorisnickoIme;
                //var salt = odabrani.LozinkaSalt;
                //var password = ASCIIEncoding.UTF8.GetString(salt);
               
         

                _id = korid.KorisnikId;
                if (odabrani.GradId != null)
                {
                    cmbGradovi.SelectedIndex = (int)odabrani.GradId;
                }
                //else
                //{
                //    //cmbGradovi.DisplayMember = -1;
                //}
                if (odabrani.Slika.Length != 0)
                {
                    txtSlikaInput.Text = odabrani.PutanjaSlike;
                    if (odabrani.PutanjaSlike != null)
                    {
                        var file = File.ReadAllBytes(txtSlikaInput.Text);

                        Image image = Image.FromFile(txtSlikaInput.Text);
                        circleButton1.Image = image;
                    }
                    else
                    {
                        using (MemoryStream ms = new MemoryStream(odabrani.Slika))
                        {
                            // Do something with ms..
                            circleButton1.Image = Image.FromStream(ms);
                            txtSlikaInput.Text = System.Text.Encoding.UTF8.GetString(odabrani.Slika);
                        }
                    }


                }
                if (korid.DatumRodjenja != null)
                    dateTimePicker1.Value = (DateTime)korid.DatumRodjenja;

            }
        }
        private async Task LoadKorisnici()
        {
            var result = await _korisnici.Get<List<Model.Korisnici>>(null);
            foreach(var item in result)
            {
                item.ImePrezime = item.Ime + " " + item.Prezime;
            }
            result.Insert(0, new Model.Korisnici() { Ime = "Odaberite korisnika", KorisnikId = 0 });

            cmbOdaberiKorisnika.DataSource = result;
            //cmbOdaberiKorisnika.AccessibilityObject.
            cmbOdaberiKorisnika.DisplayMember = "ImePrezime";
            cmbOdaberiKorisnika.ValueMember = "KorisnikID";
            
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
                circleButton1.Image = image;

                
            }
        }

        private async void btnSnimi_Click_1(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                //   txtSlikaInput = Convert.ToBase64String(circleButton1.Image.);
                byte[] bytes = Encoding.ASCII.GetBytes(txtSlikaInput.Text);
                if (txtIme.Text == "")
                    MessageBox.Show("Molimo vas unesite ime", "Nedovoljno informacija", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                else if (txtPrezime.Text == "")
                {
                    MessageBox.Show("Molimo vas unesite prezime", "Nedovoljno informacija", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else if (cmbGradovi.SelectedIndex == 0)
                    MessageBox.Show("Molimo vas odaberite grad!", "Nedovoljno informacija", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                else if (txtKorisnickoIme.Text == "")
                {
                    MessageBox.Show("Molimo vas unesite korisnicko ime", "Nedovoljno informacija", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                }
                else if (txtEmail.Text == "")
                {
                    MessageBox.Show("Molimo vas unesite email", "Nedovoljno informacija", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else if (txtTelefon.Text == "(   )    -")
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
                    Slika = bytes,
                    DatumRodjenja=dateTimePicker1.Value,
                    PutanjaSlike=txtSlikaInput.Text,




                };
                if (openFileDialog1.FileName.Length != 0)
                    request.PutanjaSlike = txtSlikaInput.Text;
                if (cmbGradovi.SelectedIndex != 0)
                {
                    request.GradId = cmbGradovi.SelectedIndex;
                }
                var max = new DateTime(2011, 1, 1);

                if (dateTimePicker1.Value != max)
                    request.DatumRodjenja = dateTimePicker1.Value;
                // btnDodajSliku_Click();
                if (_id.HasValue)
                {
                    await _korisnici.Update<Model.Korisnici>(_id, request);
                }
                await LoadKorisnici();
                MessageBox.Show("Operacija uspješna!");

            }
        }
    }
}
