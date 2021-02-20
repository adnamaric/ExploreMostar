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
        }

        private async void frmListaHotela_Load(object sender, EventArgs e)
        {
            //await LoadGradovi();
            //cmbSort.Items.Add("SortByName");
            //cmbSort.Items.Add("SortByLastName");
            //cmbSort.Items.Add("SortByUser");
            var result = await _hoteli.Get<IList<Model.Hoteli>>(null);
            label5.Text = result.Count().ToString();

        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new ByNameSearchRequest()
            {
                Naziv = txtPretraga.Text

            };
            int temp = 0;
            var result = await _hoteli.Get<IList<Model.Hoteli>>(search);
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
            int? broj = int.Parse(cmbFilterByGrade.SelectedItem.ToString());
            if (cmbFilterByGrade.SelectedIndex != -1)
            {   
               result = result.Where(y => Convert.ToInt32(y.Ocjena) == broj).ToList();
            }
            dgvHoteli.AutoGenerateColumns = false;
            dgvHoteli.DataSource = result;

        }

        private void cmbFilterByGrade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
