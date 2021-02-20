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
         

            brojApar.Text = result.Count().ToString();
            int max = 2021;
            int start = 2000;
            while (start <= max)
            {
                cmbFilterByYear.Items.Add(start++.ToString());
            }
            int start1 = 1;
            int max1 = 5;
            while (start1 <= max1)
            {
                cmbFilterByGrade.Items.Add(start1++.ToString());
            }

        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var temp = 0;
            var search = new ByNameSearchRequest()
            {
                Naziv = txtPretraga.Text

            };
            //pogledati ovo
            var result = await _apartmani.Get<List<Model.Apartmani>>(search);
           
            foreach(var i in result)
            {
                i.Rbr = ++temp;
            }
            if (search.Naziv != "")
            {
                foreach(var item in result)
                {
                    if (item.Naziv.Contains(search.Naziv))
                    {
                        result = result.Where(y => y.ApartmanId == item.ApartmanId).ToList();
                    }
                   
                }
            }
            if (cmbFilterByYear.SelectedIndex != -1)
            {
                result = result.Where(y => y.GodinaIzgradnje == int.Parse(cmbFilterByYear.SelectedItem.ToString())).ToList();
            }
            if (cmbFilterByGrade.SelectedItem != null)
            {
                int? broj = int.Parse(cmbFilterByGrade.SelectedItem.ToString());

                if (cmbFilterByGrade.SelectedIndex != -1)
                {
                    result = result.Where(y => Convert.ToInt32(y.Ocjena) == broj).ToList();
                }
            }
            dgvApartmani.AutoGenerateColumns = false;
            dgvApartmani.DataSource = result;
            //var gradovi = await _gradovi.Get<IList<Model.Gradovi>>(null);
        }
    }
}
