using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using GoogleMaps.LocationServices;
namespace exploreMostar.WinUI.Sadržaj.Apartmani
{
    public partial class frmApartmaniAdd : Form
    {
        public frmApartmaniAdd()
        {
            InitializeComponent();
        }
        private readonly APIService _apartmani = new APIService("apartmani");
        private void frmApartmaniAdd_Load(object sender, EventArgs e)
        {

        }

        private void txtLokacija_TextChanged(object sender, EventArgs e)
        {
            //var address = txtLokacija.Text;
            //var locationService = new GoogleLocationService("AIzaSyAcTROi9rcud66EEqgDjPB7w8zXrdfL1yY");
            //var point = locationService.GetLatLongFromAddress(address);
            //var latitude = point.Latitude;
            //var longitude = point.Longitude;
            //txtLat.Text = latitude.ToString();
            //txtLong.Text = longitude.ToString();
        }
    }
}
