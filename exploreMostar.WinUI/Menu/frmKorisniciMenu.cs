﻿using exploreMostar.WinUI.Korisnici;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exploreMostar.WinUI.Menu
{
    public partial class frmKorisniciMenu : Form
    {
        private readonly APIService _service = new APIService("korisnici");
        private readonly APIService _korisniciuloge = new APIService("KorisniciUloge");
        private readonly APIService _uloge = new APIService("Uloge");

        public frmKorisniciMenu()
        {
            InitializeComponent();
             Provjera();
        }

        private void frmKorisniciMenu_Load(object sender, EventArgs e)
        {
            
        }

        //private void button5_MouseHover(object sender, EventArgs e)
        //{
        //    button5.BackColor = Color.Black;
        //    button5.ForeColor = Color.White;
            
          
        //}

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.DarkBlue;
            button5.ForeColor = Color.White;
        }

       

        private void button5_Leave(object sender, EventArgs e)
        {

           
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.Red;
            button5.ForeColor = Color.White;
        }

        //private void button1_Enter(object sender, EventArgs e)
        //{
        //    button1.BackColor = Color.Black;
        //    button1.ForeColor = Color.White;
        //}

        //private void button1_MouseLeave(object sender, EventArgs e)
        //{
        //    button1.BackColor = Color.DarkBlue;
        //    button1.ForeColor = Color.White;
        //}

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Black;
            button2.ForeColor = Color.White;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.DarkBlue;
            button2.ForeColor = Color.White;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkBlue;
            button1.ForeColor = Color.White;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.Black;
            button3.ForeColor = Color.White;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.DarkBlue;
            button3.ForeColor = Color.White;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.Black;
            button4.ForeColor = Color.White;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.DarkBlue;
            button4.ForeColor = Color.White;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmKorisnici frm = new frmKorisnici();
            frm.Show();
        }
        bool admintf = false;
        private void button4_Click(object sender, EventArgs e)
        {
            Provjera();
            if (admintf == true)
            {
                frmUklanjanjeKorisnika frm = new frmUklanjanjeKorisnika();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Nemate pravo pristupa", "401-Unauthorized", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            }
        }

        private  void button3_Click(object sender, EventArgs e)
        {
           
            if (admintf == true)
            {
                frmUrediKorisnika frm = new frmUrediKorisnika();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Nemate pravo pristupa", "401-Unauthorized", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
       
        private async void Provjera()
        {
            var result = await _service.Get<List<Model.Korisnici>>(null);
            var result1 = await _korisniciuloge.Get<List<Model.KorisniciUloge>>(null);
            var result2 = await _uloge.Get<List<Model.Uloge>>(null);

            var KorisnikId = 0;
            //APIService.Username;
            foreach (var item in result)
            {
                if (APIService.Username == item.KorisnickoIme)
                {
                    KorisnikId = item.KorisnikId;
                }
            }
            var admin = 0;
            foreach (var item in result2)
            {
                if (item.Naziv == "Administrator")
                    admin = item.UlogaId;
            }
            
            foreach (var item in result1)
            {
                if (item.KorisnikId == KorisnikId && item.UlogaId == admin)
                {
                    admintf = true;
                }
            }
        }
        private   void button2_Click(object sender, EventArgs e)
        {
          
          
            if (admintf == true)
            {
                frmKorisniciDetalji frm = new frmKorisniciDetalji();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Nemate pravo pristupa", "401-Unauthorized", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
          
        }
    }
}
