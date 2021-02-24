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

namespace exploreMostar.WinUI.Sadržaj.Ostalo.Gradovi
{
    public partial class frmGradoviList : Form
    {
        private readonly APIService _gradovi = new APIService("gradovi");
        private readonly APIService _drzave = new APIService("drzave");


        public frmGradoviList()
        {
            InitializeComponent();
        }

        private async void frmGradoviList_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Add("");
            comboBox2.Items.Add("SortByName");
            comboBox2.Items.Add("SortByCountry");
            var result = await _drzave.Get<List<Model.Drzave>>(null);
            result.Insert(0, new Model.Drzave() { Naziv = "", DrzavaId = 0 });

            comboBox1.DataSource = result;
            comboBox1.ValueMember = "DrzavaId";
            comboBox1.DisplayMember = "Naziv";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var result1 = await _drzave.Get<List<Model.Drzave>>(null);

            var temp = 0;
            var search = new ByNameSearchRequest()
            {
                Naziv = txtPretraga.Text

            };
            //pogledati ovo
            var result = await _gradovi.Get<List<Model.Gradovi>>(search);


            foreach (var i in result)
            {
                i.Rbr = ++temp;
                i.Drzava = result1.Where(y => y.DrzavaId == i.DrzavaId).Select(y => y.Naziv).FirstOrDefault();

            }
            if (search.Naziv != "")
            {
                foreach (var item in result)
                {
                    if (item.Naziv.Contains(search.Naziv))
                    {
                        result = result.Where(y => y.DrzavaId == item.DrzavaId).ToList();
                    }
                   

                }
            }
            if (comboBox1.SelectedIndex != 0)
            {
               result=result.Where(y => y.DrzavaId == (int)comboBox1.SelectedValue).ToList();

                
            }
            if (comboBox2.SelectedIndex != -1 )
            {
                if (comboBox2.SelectedItem.ToString() == "SortByName")
                    result = result.OrderBy(y => y.Naziv).ToList();
                if (comboBox2.SelectedItem.ToString() == "SortByCountry" && comboBox1.SelectedIndex==0)
                    result = result.OrderBy(y => y.DrzavaId).ToList();

            }


            dgvApartmani.AutoGenerateColumns = false;
            dgvApartmani.DataSource = result;
        }
    }
}
