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

namespace exploreMostar.WinUI.Sadržaj.Prevoz
{
    public partial class frmListaPrevoza : Form
    {
        private readonly APIService _prevoz = new APIService("prevoz");
        public frmListaPrevoza()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var temp = 0;
            var search = new ByNameSearchRequest()
            {
             //   Naziv = txtPretraga.Text

            };
            //pogledati ovo
            var result = await _prevoz.Get<List<Model.Prevoz>>(search);


            foreach (var i in result)
            {
                i.Rbr = ++temp;
            }
       

            dgvApartmani.AutoGenerateColumns = false;
            dgvApartmani.DataSource = result;
        }

        private void frmListaPrevoza_Load(object sender, EventArgs e)
        {

        }
    }
}
