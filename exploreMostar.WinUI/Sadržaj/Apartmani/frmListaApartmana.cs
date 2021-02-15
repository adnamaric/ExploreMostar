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

namespace exploreMostar.WinUI.Sadržaj.Apartmani
{
    public partial class frmListaApartmana : Form
    {
        private readonly APIService _apartmani = new APIService("apartmani");
        private readonly APIService _kategorije = new APIService("kategorije");

        public frmListaApartmana()
        {
            InitializeComponent();
        }

        private async void frmListaApartmana_Load(object sender, EventArgs e)
        {
            var result = await _kategorije.Get<List<Model.Apartmani>>(null);
            cmbSort.Items.Add("SortByName");
            cmbSort.Items.Add("SortByYear");
            cmbSort.Items.Add("SortByRate");

            brojApar.Text = result.Count().ToString();

        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var temp = 0;
            var search = new ByNameSearchRequest()
            {
                Naziv = txtPretraga.Text

            };
            var result = await _apartmani.Get<List<Model.Apartmani>>(search);
           
            foreach(var i in result)
            {
                i.Rbr = ++temp;
            }
            if (cmbSort.SelectedIndex == 0)
            {
                result = result.OrderBy(y => y.Naziv).ToList();
            }
            else if (cmbSort.SelectedIndex == 1)
            {
                result = result.OrderBy(y => y.GodinaIzgradnje).ToList();
            }
            else
            {
                result = result.OrderBy(y => y.Ocjena).ToList();
            }
            dgvApartmani.AutoGenerateColumns = false;
            dgvApartmani.DataSource = result;
            //var gradovi = await _gradovi.Get<IList<Model.Gradovi>>(null);
        }
    }
}
