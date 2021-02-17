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
            bb3.Text = "Da";
            bb4.Text = "Ne";
            bb4.BackColor = Color.Red;
            bb4.ForeColor = Color.White;
            bb4.FlatAppearance.BorderColor = Color.Black;
            bb5.Text = "Da";
            bb6.Text = "Ne";
            bb6.BackColor = Color.Red;
            bb6.ForeColor = Color.White;
            bb6.FlatAppearance.BorderColor = Color.Black;
            bb7.Text = "Da";
            bb8.Text = "Ne";
            bb8.BackColor = Color.Red;
            bb8.ForeColor = Color.White;
            bb8.FlatAppearance.BorderColor = Color.Black;
            bb9.Text = "Da";
            bb10.Text = "Ne";
            bb10.BackColor = Color.Red;
            bb10.ForeColor = Color.White;
            bb10.FlatAppearance.BorderColor = Color.Black;
            bb11.Text = "Da";
            bb12.Text = "Ne";
            bb12.BackColor = Color.Red;
            bb12.ForeColor = Color.White;
            bb12.FlatAppearance.BorderColor = Color.Black;
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

        private void bb3_Click(object sender, EventArgs e)
        {
           bb3.BackColor = Color.DarkGreen;
            bb3.ForeColor = Color.White;
            bb3.FlatAppearance.BorderColor = Color.Black;
            bb4.ForeColor = Color.Black;
            bb4.BackColor = Color.Transparent;
        }

        private void bb4_Click(object sender, EventArgs e)
        {
            bb3.ForeColor = Color.Black;
            bb3.BackColor = Color.Transparent;
            bb4.ForeColor = Color.White;
            bb4.BackColor = Color.Red;
            bb4.FlatAppearance.BorderColor = Color.Black;
        }

        private void bb5_Click(object sender, EventArgs e)
        {
            bb5.BackColor = Color.DarkGreen;
            bb5.ForeColor = Color.White;
            bb5.FlatAppearance.BorderColor = Color.Black;
            bb6.ForeColor = Color.Black;
            bb6.BackColor = Color.Transparent;
        }

        private void bb6_Click(object sender, EventArgs e)
        {
            bb5.ForeColor = Color.Black;
            bb5.BackColor = Color.Transparent;
            bb6.ForeColor = Color.White;
            bb6.BackColor = Color.Red;
            bb6.FlatAppearance.BorderColor = Color.Black;
        }

        private void bb7_Click(object sender, EventArgs e)
        {
            bb7.BackColor = Color.DarkGreen;
            bb7.ForeColor = Color.White;
            bb7.FlatAppearance.BorderColor = Color.Black;
            bb8.ForeColor = Color.Black;
            bb8.BackColor = Color.Transparent;
        }

        private void bb8_Click(object sender, EventArgs e)
        {
            bb7.ForeColor = Color.Black;
            bb7.BackColor = Color.Transparent;
            bb8.ForeColor = Color.White;
            bb8.BackColor = Color.Red;
            bb8.FlatAppearance.BorderColor = Color.Black;
        }

        private void bb9_Click(object sender, EventArgs e)
        {
            bb9.BackColor = Color.DarkGreen;
            bb9.ForeColor = Color.White;
            bb9.FlatAppearance.BorderColor = Color.Black;
            bb10.ForeColor = Color.Black;
            bb10.BackColor = Color.Transparent;
        }

        private void bb10_Click(object sender, EventArgs e)
        {
            bb9.ForeColor = Color.Black;
            bb9.BackColor = Color.Transparent;
            bb10.ForeColor = Color.White;
            bb10.BackColor = Color.Red;
            bb10.FlatAppearance.BorderColor = Color.Black;
        }

        private void bb11_Click(object sender, EventArgs e)
        {
            bb11.BackColor = Color.DarkGreen;
            bb11.ForeColor = Color.White;
            bb11.FlatAppearance.BorderColor = Color.Black;
            bb12.ForeColor = Color.Black;
            bb12.BackColor = Color.Transparent;
        }

        private void bb12_Click(object sender, EventArgs e)
        {
            bb11.ForeColor = Color.Black;
            bb11.BackColor = Color.Transparent;
            bb12.ForeColor = Color.White;
            bb12.BackColor = Color.Red;
            bb12.FlatAppearance.BorderColor = Color.Black;
        }
    }
}
