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

namespace exploreMostar.WinUI.Sadržaj.Hoteli
{
    public partial class frmListaHotela : Form
    {
        private readonly APIService _hoteli = new APIService("hoteli");
        private readonly APIService _recenzije = new APIService("Recenzije");

        public frmListaHotela()
        {
            InitializeComponent();
            int max = 2021;
            int start = 1990;
            while (start <= max)
            {
                cmbFilterYear.Items.Add(start++.ToString());
            }
            int start1 = 1;
            int max1 = 5;
            while (start1 <= max1)
            {
                cmbFilterByGrade.Items.Add(start1++.ToString());
            }
            SetOcjene();
        }

        private async void frmListaHotela_Load(object sender, EventArgs e)
        {
            //await LoadGradovi();
            //cmbSort.Items.Add("SortByName");
            //cmbSort.Items.Add("SortByLastName");
            //cmbSort.Items.Add("SortByUser");
            var result = await _hoteli.Get<List<Model.Hoteli>>(null);
            label5.Text = result.Count().ToString();

        }
        private async void SetOcjene()
        {
            var result = await _hoteli.Get<List<Model.Hoteli>>(null);
            var recenzije = await _recenzije.Get<List<Model.Recenzije>>(null);

            foreach (var i in result)
            {
                if (i.Ocjena == null)
                    i.Ocjena = 0;
                double ukupna = (double)i.Ocjena;
                int brojac = 0;
                if (i.Ocjena != 0)
                    brojac++;

                foreach (var item in recenzije)
                {
                    if (item.Objekat == i.Naziv)
                    {
                        ukupna += (double)item.Ocjena;
                        brojac++;
                    }
                }
                if (brojac == 0)
                    brojac++;
                ukupna /= brojac;
                i.Ocjena = ukupna;
                await _hoteli.Update<Model.Hoteli>(i.HotelId, i);
            }
        }
        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new ByNameSearchRequest()
            {
                Naziv = txtPretraga.Text

            };
            int temp = 0;
            var result = await _hoteli.Get<IList<Model.Hoteli>>(null);
            foreach (var hotel in result)
            {
                hotel.Rbr = ++temp;
               

            }
            if (search.Naziv != "")
            {
                foreach (var item in result)
                {
                    if (item.Naziv.Contains(search.Naziv))
                    {
                        result = result.Where(y => y.HotelId == item.HotelId).ToList();
                    }

                }
            }
            if (cmbFilterYear.SelectedIndex != -1)
            {
                result = result.Where(y => y.GodinaIzgradnje == int.Parse(cmbFilterYear.SelectedItem.ToString())).ToList();
            }
            if (cmbFilterByGrade.SelectedIndex != -1)
            {
                int? broj = int.Parse(cmbFilterByGrade.SelectedItem.ToString());

                result = result.Where(y => Convert.ToInt32(y.Ocjena) == broj).ToList();
            }
            dgvHoteli.AutoGenerateColumns = false;
            dgvHoteli.DataSource = result;

        }

        private void cmbFilterByGrade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
