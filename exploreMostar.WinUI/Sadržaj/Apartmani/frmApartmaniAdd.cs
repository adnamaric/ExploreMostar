using GoogleMaps.LocationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exploreMostar.WinUI.Sadržaj.Apartmani
{
    public partial class frmApartmaniAdd : Form
    {
        public frmApartmaniAdd()
        {
            InitializeComponent();
            RadioButtonAppear();
        }

        private void frmApartmaniAdd_Load(object sender, EventArgs e)
        {
            
        }

        private void txtLok_TextChanged(object sender, EventArgs e)
        {

         
        }

     

        private void txtLok_LocationChanged(object sender, EventArgs e)
        {
        }

        private void txtLok_ImeModeChanged(object sender, EventArgs e)
        {
            var dovedimeovdje = "tu sam";

        }

        private void txtLok_AcceptsTabChanged(object sender, EventArgs e)
        {

        }

        private void txtLok_Leave(object sender, EventArgs e)
        {

        }

        private void txtLok_ModifiedChanged(object sender, EventArgs e)
        {
            var address = txtLok.Text;
            var locationService = new GoogleLocationService("AIzaSyAcTROi9rcud66EEqgDjPB7w8zXrdfL1yY");
            var point = locationService.GetLatLongFromAddress(address);
            var latitude = point.Latitude;
            var longitude = point.Longitude;
            txtLat.Text = latitude.ToString();
            txtLong.Text = longitude.ToString();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        private void RadioButtonAppear()
        {
            //rb_off.Appearance = Appearance.Button;
            //rb_on.Appearance = Appearance.Button;
            //rb_off.BackColor = Color.Red;
            //rbBazenOff.BackColor = Color.Red;
            //rbBazenOff.Appearance = Appearance.Button;
            //rbBazenOn.Appearance = Appearance.Button;
            //rb_on.Text = "Da";
            //rb_off.Text = "Ne";
            //rbBazenOn.Text = "Da";
            //rbBazenOff.Text = "Ne";
            //rp1.Appearance = Appearance.Button;
            //rp1.Text = "Da";
            //rp2.Appearance = Appearance.Button;
            //rp2.Text = "Ne";
            //rp2.BackColor = Color.Red;
            button1.Text = "Da";
            button2.Text = "Ne";
            button2.BackColor = Color.Red;
            button2.ForeColor = Color.White;
            button2.FlatAppearance.BorderColor = Color.Black;


        }

        //private void rb_on_Click(object sender, EventArgs e)
        //{
        //    rb_off.BackColor = Color.Transparent;
           
          

        //    rb_on.FlatAppearance.BorderColor = Color.Black;
        //    rb_on.BackColor = Color.Green;
        //    rb_off.ForeColor = Color.Black;
        //}

        //private void rb_off_Click(object sender, EventArgs e)
        //{
        //    rb_off.BackColor = Color.Red;
         
        //    rb_off.FlatAppearance.BorderColor = Color.Black;
        //    rb_on.BackColor = Color.Transparent;
        //    rb_on.ForeColor = Color.Black;

        //}

       


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        

       

        //private void rbBazenOn_Click(object sender, EventArgs e)
        //{
        //    rbBazenOff.BackColor = Color.Transparent;
        //    rbBazenOn.FlatAppearance.BorderColor = Color.Black;
        //}

        //private void rbBazenOff_Click(object sender, EventArgs e)
        //{

        //    rbBazenOn.BackColor = Color.Transparent;
        //    rbBazenOff.FlatAppearance.BorderColor = Color.Black;
        //}

        //private void rP1_Click(object sender, EventArgs e)
        //{
            
        //}

   

        //private void rP2_Click(object sender, EventArgs e)
        //{

        //    rP1.BackColor = Color.Transparent;
        //    rP2.FlatAppearance.BorderColor = Color.Black;
        //}

        //private void rp1_Click_1(object sender, EventArgs e)
        //{
        //    rp2.BackColor = Color.Transparent;
        //    rp1.FlatAppearance.BorderColor = Color.Black;
        //}

        //private void rp2_Click(object sender, EventArgs e)
        //{
        //    rp1.BackColor = Color.Transparent;
        //    rp2.FlatAppearance.BorderColor = Color.Black;
        //}

        

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkGreen;
            button1.ForeColor = Color.White;
            button1.FlatAppearance.BorderColor = Color.Black;
            button2.ForeColor = Color.Black;
            button2.BackColor = Color.Transparent;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
            button1.BackColor = Color.Transparent;
            button2.ForeColor = Color.White;
            button2.BackColor = Color.Red;
            button2.FlatAppearance.BorderColor = Color.Black;
        }
    }
}
