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

        private void button1_Click(object sender, EventArgs e)
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void RadioButtonAppear()
        {
            rb_off.Appearance = Appearance.Button;
            rb_on.Appearance = Appearance.Button;
            rb_on.BackColor = Color.Green;
            rb_off.BackColor = Color.Red;
            
            rb_on.Text = "Da";
            rb_off.Text = "Ne";
        }

        private void rb_on_Click(object sender, EventArgs e)
        {
            rb_off.BackColor = Color.Transparent;
            rb_on.ForeColor = Color.White;
            rb_on.BackColor = Color.Green;
            rb_off.ForeColor = Color.Black;
        }

        private void rb_off_Click(object sender, EventArgs e)
        {
            rb_off.BackColor = Color.Red;
            rb_off.ForeColor = Color.White;
            rb_on.BackColor = Color.Transparent;
            rb_on.ForeColor = Color.Black;

        }
    }
}
