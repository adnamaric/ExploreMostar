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
            button2.Visible = true;
            circleButton1.Visible = false;
            label1.Visible = false;
            circleButton2.Visible = false;
            circleButton3.Visible = false;
            circleButton4.Visible = false;
            button5.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            GetPoruke();
            label2.Visible = false;
            label3.Visible = false;

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

        public int brojP = 0;

        private async void button1_Click(object sender, EventArgs e)
        {
        
            //var posiljalacInicija = posiljalac.Ime.ToCharArray().GetValue(0);
            //var posiljalacInicija2 = posiljalac.Prezime.ToCharArray().GetValue(0);
            //var imeP = posiljalacInicija + ". " + posiljalacInicija2 + ".";
          
            //var prvo = primalac.Ime.ToCharArray();
            //var prvoslovo = prvo.GetValue(0);
            //var drugo = primalac.Prezime.ToCharArray();
            //var drugoslovo = drugo.GetValue(0);
            //var initials = prvoslovo + "." + " " + drugoslovo + ".";
            //if (brojP != 0)
            //{
            //    button2.Visible = true;

            //    circleButton1.Visible = true;
            //    label1.Visible = true;

            //    circleButton1.Text = initials.ToUpper();
            //    button2.Text = richTextBox1.Text;
            //    label1.Text = DateTime.Now.ToShortDateString();
            //    label2.Visible = true;
            //    label2.Text = DateTime.Now.ToString();
             






            //}
            //else
            //{
            //    button5.Visible = true;

            //    circleButton4.Visible = true;
            //    label1.Visible = true;

            //    circleButton4.Text = initials.ToUpper();
            //    button5.Text = richTextBox1.Text;
            //    label1.Text = DateTime.Now.ToShortDateString();
            //}
            //if (brojP == 5)
            //{
            //    Button n = new Button();
            //    //  this.n = new System.Windows.Forms.Button();
            //    n.BackColor = button2.BackColor;
            //    n.Name = "NoviButton";
            //    this.Controls.Add(n);
            //    n.Text = richTextBox1.Text;
            //    n.Location = new Point(333, 313);
            //    n.Size = new Size(269, 87);

            //    this.groupBox3.Controls.Add(n);
            //}
            //if (brojP == 2)
            //{
            //    Button n = new Button();
            //    //  this.n = new System.Windows.Forms.Button();
            //    n.BackColor = button2.BackColor;
            //    n.Name = "NoviButton";
            //    this.Controls.Add(n);
            //    n.Text = richTextBox1.Text;
            //    n.Location = new Point(333, 413);
            //    n.Size = new Size(269, 87);

            //    this.groupBox3.Controls.Add(n);
            //}
       
        }

        private void frmInbox_Load(object sender, EventArgs e)
        {
            Button n = new Button();
            n.Name = "NoviButton";
            this.Controls.Add(n);
            n.Text = "Ovaj tu";
            n.Location = new Point(333, 313);
            n.Size = new Size(269, 87);
        }



        private async void listBox1_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
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
            label2.Visible = false;
          
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
            var imeP = posiljalacInicija + ". " + posiljalacInicija2 + ".";
            var primalacInicija = primalac.Ime.ToCharArray().GetValue(0);
            var primalacInicija2 = primalac.Prezime.ToCharArray().GetValue(0);
            var imeP1 = primalacInicija + ". " + primalacInicija2 + ".";
            List<Model.Poruke> porukeP = new List<Model.Poruke>();
            var imeprezime = primalac.Ime + " " + primalac.Prezime;
            var imeprezime1 = posiljalac.Ime + " " + posiljalac.Prezime;
            foreach (var item in poruke)
            {
                if ((item.Posiljalac == imeprezime1 && item.Primalac == imeprezime) || (item.Posiljalac == imeprezime && item.Primalac == imeprezime1))
                {
                    porukeP.Add(item);
                }
            }
            brojP = porukeP.Count();
            // poruke
            var y = 59;
            
            var cy = 41;
            var cyl = 16;
            var lijevastranacirlce = 43;
            var lijevastranabutton = 54;
            List<Button> noviButtoni = new List<Button>();
            List<CircleButton> circleButtons = new List<CircleButton>();
            List<Label> labele = new List<Label>();
            if (brojP > 4)
            {
               

            }


            for (int i = 0; i < brojP; i++)
            {
                noviButtoni.Add(new Button());
                circleButtons.Add(new CircleButton());
                if (porukeP[i].Posiljalac == imeprezime1)
                {
                    circleButtons[i].Location = new Point(747, cy);
                    noviButtoni[i].Location = new Point(470, y);
                    circleButtons[i].Text = imeP.ToUpper();
                    y += 130;
                    cy += 130;
                    lijevastranacirlce += 130;
                    lijevastranabutton += 130;
                }
                else
                {
                    circleButtons[i].Location = new Point(8, lijevastranacirlce);
                    noviButtoni[i].Location = new Point(141, lijevastranabutton);
                    lijevastranacirlce += 130;
                    lijevastranabutton += 130;
                    circleButtons[i].Text = imeP1.ToUpper();
                    y += 130;
                    cy += 130;
                }
               
                labele.Add(new Label());
                labele[i].Text = porukeP[i].Datum.ToString();
                labele[i].Font = new Font(labele[i].Font, FontStyle.Bold);
                labele[i].Location = new Point(401, cyl);
                circleButtons[i].BackColor = circleButton2.BackColor;
                circleButtons[i].Size = new Size(116, 109);
               
                circleButtons[i].FlatStyle = FlatStyle.Flat;
                circleButtons[i].FlatAppearance.BorderSize = 0;
                noviButtoni[i].Text = porukeP[i].Sadrzaj;
                noviButtoni[i].Size = new Size(269, 87);
                
                noviButtoni[i].BackColor = button2.BackColor;
                noviButtoni[i].FlatStyle = FlatStyle.Flat;
                noviButtoni[i].FlatAppearance.BorderSize = 0;
                
                cyl += 136;
                this.panel1.Controls.Add(noviButtoni[i]);
                this.panel1.Controls.Add(circleButtons[i]);
                this.panel1.Controls.Add(labele[i]);
            }
            //    if (porukeP.Count !=0 )
            //    {

            //        var posiljalacInicija = posiljalac.Ime.ToCharArray().GetValue(0);
            //        var posiljalacInicija2 = posiljalac.Prezime.ToCharArray().GetValue(0);
            //        var imeP = posiljalacInicija + ". " + posiljalacInicija2 + ".";

            //        var prvo = primalac.Ime.ToCharArray();
            //        var prvoslovo = prvo.GetValue(0);
            //        var drugo = primalac.Prezime.ToCharArray();
            //        var drugoslovo = drugo.GetValue(0);
            //        var initials = prvoslovo + "." + " " + drugoslovo + ".";
            //        //taking two
            //        porukeP = porukeP.OrderBy(y => y.Datum).ToList();
            //        if (porukeP.Count !=1)
            //        {
            //            porukeP = porukeP.Take(2).ToList();
            //            poruke = porukeP.OrderBy(y => y.Datum).ToList();
            //        }
            //        if (porukeP[0].Posiljalac == imeprezime1 && porukeP[0].Primalac == imeprezime)
            //        {
            //            button5.Visible = true;
            //            button5.Text = porukeP[0].Sadrzaj;
            //            button5.Location = new Point(333, 58);
            //            circleButton4.Visible = true;
            //            circleButton4.Text = imeP.ToUpper();
            //            circleButton4.Location = new Point(617, 36);
            //            label1.Text = porukeP[0].Datum.ToString();
            //            label1.Visible = true;
            //        }
            //        else
            //        {
            //            button5.Visible = true;
            //            button5.Text = porukeP[0].Sadrzaj;
            //            button5.Location = new Point(142, 47);
            //            circleButton4.Location = new Point(20, 36);
            //            circleButton4.Visible = true;
            //            label1.Text = porukeP[0].Datum.ToString();
            //        }
            //        if (porukeP.Count > 1)
            //        {
            //            if (porukeP[1].Posiljalac == imeprezime1 && porukeP[1].Primalac == imeprezime)
            //            {
            //                button2.Visible = true;
            //                button2.Text = porukeP[1].Sadrzaj;
            //                label2.Visible = true;
            //                label2.Text = porukeP[1].Datum.ToString();
            //                circleButton1.Visible = true;
            //                circleButton1.Text = imeP.ToUpper();
            //                circleButton1.Location = new Point(617, 173);
            //                button2.Location = new Point(333, 184);
            //            }
            //            else
            //            {
            //                button2.Location = new Point(142, 162);
            //                circleButton1.Location = new Point(20, 151);
            //                button2.Visible = true;
            //                button2.Text = porukeP[1].Sadrzaj;

            //                circleButton1.Visible = true;
            //                circleButton1.Text = imeP.ToUpper();

            //            }
            //        }
            //    }
            //    else
            //    {
            //        button5.Visible = false;
            //        circleButton4.Visible = false;
            //        label1.Visible = false;
            //        button2.Visible = false;
            //        circleButton1.Visible = false;
            //    }

            //}

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void circleButton1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void button6_Click_1(object sender, EventArgs e)
        {
            var korisnici = await _korisnici.Get<List<Model.Korisnici>>(null);
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
            var imeprezime = primalac.Ime + " " + primalac.Prezime;
            var imeprezime1 = posiljalac.Ime + " " + posiljalac.Prezime;
            var request = new PorukeUpsertRequest
            {
                Sadrzaj = richTextBox2.Text,
                Primalac = imeprezime,
                PrimalacId = primalac.KorisnikId,
                Posiljalac = imeprezime1,
                PosiljalacId = posiljalac.KorisnikId,
                Datum = DateTime.Now

            };
            if (request != null)
            {
                try
                {
                    await _poruke.Insert<Model.Poruke>(request);
                    this.panel1.Controls.Clear();
                    GetPoruke();

                }
                catch
                {
                    MessageBox.Show("Greška prilikom slanja!");

                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
