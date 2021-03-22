using exploreMostar.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exploreMostar.WinUI.Poruke
{
    public partial class frmInbox : Form
    {
        private readonly APIService _poruke = new APIService("Poruke");
        private readonly APIService _korisnici = new APIService("Korisnici");
        public frmInbox()
        {
            InitializeComponent();
            Set();
            button2.Visible = false;
            circleButton1.Visible = false;
            label1.Visible = false;
            circleButton2.Visible = false;
            circleButton3.Visible = false;
            circleButton4.Visible = false;
            button5.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            GetPoruke();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
           
        }

        

        private void button6_Click(object sender, EventArgs e)
        {

        }
        private async void Set()
        {

            listBox1.DataSource = await _korisnici.Get<List<Model.Korisnici>>(null);
            listBox1.DisplayMember = "Ime";
            listBox1.ValueMember = "KorisnikId";

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

       

        private async void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            
            circleButton1.Visible = true;
            label1.Visible = true;
            var korisnici= await _korisnici.Get<List<Model.Korisnici>>(null);
            Model.Korisnici primalac = new Model.Korisnici();
            Model.Korisnici posiljalac = new Model.Korisnici();
            //primalac
            foreach (var item in korisnici)
            {
                if (item.KorisnikId == int.Parse(listBox1.SelectedValue.ToString()))
                {
                    primalac = item;
                }
                if (item.KorisnickoIme == APIService.Username)
                {
                    posiljalac = item;
                }
            }
            var posiljalacInicija = posiljalac.Ime.ToCharArray().GetValue(0);
            var posiljalacInicija2 = posiljalac.Prezime.ToCharArray().GetValue(0);
            var imeP=posiljalacInicija+". "+posiljalacInicija2+".";
            var imeprezime = primalac.Ime+" "+ primalac.Prezime;
            var imeprezime1 = posiljalac.Ime + " " + posiljalac.Prezime;
            var prvo = primalac.Ime.ToCharArray();
             var prvoslovo=prvo.GetValue(0);
            var drugo = primalac.Prezime.ToCharArray();
            var drugoslovo = drugo.GetValue(0);
            var initials = prvoslovo + "." +" " + drugoslovo+".";
             circleButton1.Text= imeprezime1.ToUpper();
            button2.Text = richTextBox1.Text;
            label1.Text = DateTime.Now.ToShortDateString();
            var request = new PorukeUpsertRequest
            {
               Sadrzaj= richTextBox1.Text,
               Primalac=imeprezime,
               PrimalacId= primalac.KorisnikId,
               Posiljalac= imeprezime1,
               PosiljalacId=posiljalac.KorisnikId,
               Datum=DateTime.Now

            };
            if (request != null)
            {
                try
                {
                    await _poruke.Insert<Model.Apartmani>(request);
                    MessageBox.Show("Uspješno ste poslali poruku!");
                  
                }
                catch
                {
                    MessageBox.Show("Greška prilikom slanja!");

                }
            }
        }

        private void frmInbox_Load(object sender, EventArgs e)
        {

        }

        private void circleButton3_Click(object sender, EventArgs e)
        {

        }

        private async void listBox1_Click(object sender, EventArgs e)
        {
            GetPoruke();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        private async void GetPoruke()
        {
            var poruke = await _poruke.Get<List<Model.Poruke>>(null);
            var korisnici = await _korisnici.Get<List<Model.Korisnici>>(null);
            Model.Korisnici primalac = new Model.Korisnici();
            Model.Korisnici posiljalac = new Model.Korisnici();

            foreach (var item in korisnici)
            {
                if (item.KorisnikId == int.Parse(listBox1.SelectedValue.ToString()))
                {
                    primalac = item;
                }
                if (item.KorisnickoIme == APIService.Username)
                {
                    posiljalac = item;
                }
            }
            List<Model.Poruke> porukeP = new List<Model.Poruke>();
            var imeprezime = primalac.Ime + " " + primalac.Prezime;
            var imeprezime1 = posiljalac.Ime + " " + posiljalac.Prezime;
            foreach (var item in poruke)
            {
                if (item.Posiljalac == imeprezime1 && item.Primalac == imeprezime)
                {
                    porukeP.Add(item);
                }
            }
            if (porukeP.Count != 0)
            {
                var posiljalacInicija = posiljalac.Ime.ToCharArray().GetValue(0);
                var posiljalacInicija2 = posiljalac.Prezime.ToCharArray().GetValue(0);
                var imeP = posiljalacInicija + ". " + posiljalacInicija2 + ".";

                var prvo = primalac.Ime.ToCharArray();
                var prvoslovo = prvo.GetValue(0);
                var drugo = primalac.Prezime.ToCharArray();
                var drugoslovo = drugo.GetValue(0);
                var initials = prvoslovo + "." + " " + drugoslovo + ".";
                //taking two
                porukeP = porukeP.OrderByDescending(y => y.Datum).ToList();
                if (porukeP.Count !=1)
                {
                    porukeP = porukeP.Take(2).ToList();
                    poruke = porukeP.OrderBy(y => y.Datum).ToList();
                }
                if (porukeP[0].Posiljalac == imeprezime1 && porukeP[0].Primalac == imeprezime)
                {
                    button5.Visible = true;
                    button5.Text = porukeP[0].Sadrzaj;
                    button5.Location = new Point(333, 58);
                    circleButton4.Visible = true;
                    circleButton4.Text = imeP.ToUpper();
                    circleButton4.Location = new Point(617, 36);
                    label1.Text = porukeP[0].Datum.ToString();
                    label1.Visible = true;
                }
                else
                {
                    button5.Visible = true;
                    button5.Text = porukeP[0].Sadrzaj;
                    button5.Location = new Point(142, 47);
                    circleButton4.Location = new Point(20, 36);
                    label1.Text = porukeP[0].Datum.ToString();
                }
                if (porukeP.Count != 1)
                {
                    if (porukeP[1].Posiljalac == imeprezime1 && porukeP[1].Primalac == imeprezime)
                    {
                        button2.Visible = true;
                        button2.Text = porukeP[0].Sadrzaj;
                        button2.Location = new Point(142, 162);
                        circleButton1.Visible = true;
                        circleButton1.Text = imeP.ToUpper();
                        circleButton1.Location = new Point(20, 151);

                    }
                    else
                    {
                        button2.Visible = true;
                        button2.Text = porukeP[0].Sadrzaj;
                        button2.Location = new Point(333, 184);
                        circleButton1.Visible = true;
                        circleButton1.Text = imeP.ToUpper();
                        circleButton1.Location = new Point(116, 109);
                    }
                }
            }
            else
            {
                button5.Visible = false;
                circleButton4.Visible = false;
                label1.Visible = false;
            }
           
        }
        //TODO
        //Kada prvi pot du
    }
}
