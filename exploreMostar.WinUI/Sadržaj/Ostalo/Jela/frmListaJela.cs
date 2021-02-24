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

namespace exploreMostar.WinUI.Sadržaj.Ostalo.Jela
{
    public partial class frmListaJela : Form
    {
        private readonly APIService _jela = new APIService("jela");
        private readonly APIService _kjela = new APIService("kategorijejela");

        public frmListaJela()
        {
            InitializeComponent();
        }

        private async void frmListaJela_Load(object sender, EventArgs e)
        {
            cmbSort.Items.Add("");
            cmbSort.Items.Add("SortByName");
            cmbSort.Items.Add("SortByGrade");
            var result = await _jela.Get<List<Model.Jela>>(null);
            label3.Text = result.Count().ToString();
            int start1 = 0;
            int max1 = 5;
            while (start1 <= max1)
            {
                cmbFilterByGrade.Items.Add(start1++.ToString());
            }
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
           var result1 = await _kjela.Get<List<Model.KategorijeJela>>(null);

            var temp = 0;
            var search = new ByNameSearchRequest()
            {
                Naziv = txtPretraga.Text

            };
            //pogledati ovo
            var result = await _jela.Get<List<Model.Jela>>(search);


            foreach (var i in result)
            {
                i.Rbr = ++temp;
                i.Vrsta = result1.Where(y => y.KategorijaJelaId == i.KategorijaJelaId).Select(y => y.Naziv).FirstOrDefault();

            }
            if (search.Naziv != "")
            {
                foreach (var item in result)
                {
                    if (item.Naziv.Contains(search.Naziv))
                    {
                       // result = result.Where(y => y.JeloId == item.JeloId).FirstOrDefault();
                    }


                }
            }
            if (cmbFilterByGrade.SelectedItem != null)
            {
                int? broj = int.Parse(cmbFilterByGrade.SelectedItem.ToString());

                if (cmbFilterByGrade.SelectedIndex != 0)
                {
                    result = result.Where(y => Convert.ToInt32(y.Ocjena) == broj).ToList();
                }
            }
            if (cmbSort.SelectedIndex != -1)
            {
                if (cmbSort.SelectedItem.ToString() == "SortByName")
                    result = result.OrderBy(y => y.Naziv).ToList();
                if (cmbSort.SelectedItem.ToString() == "SortByGrade")
                    result = result.OrderByDescending(y => y.Ocjena).ToList();

            }


            dgvHoteli.AutoGenerateColumns = false;
            dgvHoteli.DataSource = result;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
