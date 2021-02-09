﻿using exploreMostar.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exploreMostar.WinUI.Korisnici
{
    public partial class frmKorisniciDetalji : Form
    {
        private readonly APIService _service = new APIService("korisnici");
        private int? _id = null;
        public frmKorisniciDetalji(int? korisnikId = null)
        {
            InitializeComponent();
            _id = korisnikId;
            
        }

       
        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            var request = new KorisniciInsertRequest
            {
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                Email = txtEmail.Text,
                Telefon = txtTelefon.Text,
                Password = txtPassword.Text,
                PasswordConfirmation = txtPasswordConfrirm.Text,
                KorisnickoIme=txtKorisnickoIme.Text
            };

            if (_id.HasValue)
            {
                await _service.Update<Model.Korisnici>(_id, request);
            }
            else
            {
                await _service.Insert<Model.Korisnici>(request);

            }
        }

        private async void frmKorisniciDetalji_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var korisnik = await _service.GetById<Model.Korisnici>(_id);
                txtIme.Text = korisnik.Ime;
                txtPrezime.Text = korisnik.Prezime;
                txtEmail.Text = korisnik.Email;
                txtTelefon.Text = korisnik.Telefon;
                
            }
        }

        
    }
}
