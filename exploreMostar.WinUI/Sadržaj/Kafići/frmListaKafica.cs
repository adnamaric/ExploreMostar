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

namespace exploreMostar.WinUI.Sadržaj.Kafići
{
    public partial class frmListaKafica : Form
    {
        private readonly APIService _kafici = new APIService("kafici");
        private readonly APIService _recenzije = new APIService("Recenzije");

        public frmListaKafica()
        {
            InitializeComponent();
            comboBox1.Items.Add("");
            comboBox1.Items.Add("SortByName");
            comboBox1.Items.Add("SortByGrade");
            SetOcjene();
        }

        private async void frmListaKafica_Load(object sender, EventArgs e)
        {
           
            var result = await _kafici.Get<List<Model.Kafici>>(null);


            label4.Text = result.Count().ToString();
          
            int start1 = 1;
            int max1 = 5;
            while (start1 <= max1)
            {
                cmbFilterByGrade.Items.Add(start1++.ToString());
            }
        }
        private async void SetOcjene()
        {
            var result = await _kafici.Get<List<Model.Kafici>>(null);
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
                await _kafici.Update<Model.Kafici>(i.KaficId, i);
            }
        }
        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var temp = 0;
            var search = new ByNameSearchRequest()
            {
                Naziv = txtPretraga.Text

            };
            
            var result = await _kafici.Get<List<Model.Kafici>>(search);

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
                        result = result.Where(y => y.KaficId == item.KaficId).ToList();
                    }

                }
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
                    result = result.Where(y => y.Ocjena != null).OrderByDescending(y => y.Ocjena).ToList();
          
            }
            dgvApartmani.AutoGenerateColumns = false;
            dgvApartmani.DataSource = result;
        }
    }
}
