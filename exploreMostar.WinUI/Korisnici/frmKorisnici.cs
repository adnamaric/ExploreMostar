using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl.Http;
using Flurl;
using exploreMostar.Model.Requests;

namespace exploreMostar.WinUI.Korisnici
{
    public partial class frmKorisnici : Form
    {
        private readonly APIService _aPIService = new APIService ("korisnici");
        public frmKorisnici()
        {
            InitializeComponent();
        }

        private void frmKorisnici_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            // var result = "https://localhost:44333/api/Korisnici".GetJsonAsync<IList<Model.Korisnici>>().Result;
            var search = new KorisniciSearchRequest()
            {
                Ime = txtPretraga.Text

            };
            var result = await _aPIService.Get<IList<Model.Korisnici>>(search);

            dgvKorisnici.DataSource = result;
        }
    }
}
