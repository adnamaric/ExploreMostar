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

namespace exploreMostar.WinUI.Sadržaj.Restorani
{
    public partial class frmListaRestorana : Form
    {
        private readonly APIService _restorani = new APIService("restorani");
        private readonly APIService _recenzije = new APIService("Recenzije");
        public frmListaRestorana()
        {
            InitializeComponent();
            comboBox1.Items.Add("");
            comboBox1.Items.Add("SortByName");
            comboBox1.Items.Add("SortByGrade");
            comboBox1.Items.Add("SortByType");
            comboBox1.Items.Add("SortByYear");
            SetOcjene();

        }

        private async void frmListaRestorana_Load(object sender, EventArgs e)
        {
            var result = await _restorani.Get<List<Model.Restorani>>(null);


            label4.Text = result.Count().ToString();
            int max = 2021;
            int start = 2000;
            while (start <= max)
            {
                cmbFilterByYear.Items.Add(start++.ToString());
            }
            cmbFilterByYear.Items.Add("");
            int start1 = 1;
            int max1 = 5;
            while (start1 <= max1)
            {
                cmbFilterByGrade.Items.Add(start1++.ToString());
            }
        }
        private async void SetOcjene()
        {
            var result = await _restorani.Get<List<Model.Restorani>>(null);
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
                await _restorani.Update<Model.Restorani>(i.RestoranId, i);
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
            var result = await _restorani.Get<List<Model.Restorani>>(search);

            foreach (var i in result)
            {
                i.Rbr = ++temp;
            }
            if (search.Naziv != "")
            {
                foreach (var item in result)
                {
                    if (item.Naziv.Contains(search.Naziv))
                    {
                        result = result.Where(y => y.RestoranId == item.RestoranId).ToList();
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
            if (comboBox1.SelectedIndex != -1)
            {
                if (comboBox1.SelectedItem.ToString() == "SortByName")
                    result = result.OrderBy(y => y.Naziv).ToList();
                if (comboBox1.SelectedItem.ToString() == "SortByGrade")
                    result = result.Where(y=>y.Ocjena!=null).OrderByDescending(y => y.Ocjena).ToList();
                if (comboBox1.SelectedItem.ToString() == "SortByYear")
                    result = result.Where(y => y.GodinaIzgradnje != null).OrderByDescending(y => y.GodinaIzgradnje).ToList();
                if (comboBox1.SelectedItem.ToString() == "SortByType")
                    result = result.OrderBy(y => y.VrstaId).ToList();
            }
            dgvApartmani.AutoGenerateColumns = false;
            dgvApartmani.DataSource = result;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbFilterByGrade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
