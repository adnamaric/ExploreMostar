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
        private readonly APIService _objave = new APIService("Objava");
        private readonly APIService _korisnici = new APIService("Korisnici");
        public frmInbox()
        {
            InitializeComponent();
            Set();
            button2.Visible = false;
            circleButton1.Visible = false;
            label1.Visible = false;
          
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            circleButton1.Visible = true;
            label1.Visible = true;
            var korisnici= await _korisnici.Get<List<Model.Korisnici>>(null);
            Model.Korisnici korisnik = new Model.Korisnici();
            foreach(var item in korisnici)
            {
                if (item.KorisnikId == int.Parse(listBox1.SelectedValue.ToString()))
                {
                    korisnik = item;
                }
            }

           var imeprezime= korisnik.Ime+" "+korisnik.Prezime;
            var prvo = korisnik.Ime.ToCharArray();
             var prvoslovo=prvo.GetValue(0);
            var drugo = korisnik.Prezime.ToCharArray();
            var drugoslovo = drugo.GetValue(0);
            var initials = prvoslovo + "." +" " + drugoslovo+".";
             circleButton1.Text=initials.ToUpper();
            button2.Text = richTextBox1.Text;
            label1.Text = DateTime.Now.ToShortDateString();
           

        }

        private void frmInbox_Load(object sender, EventArgs e)
        {

        }
    }
}
