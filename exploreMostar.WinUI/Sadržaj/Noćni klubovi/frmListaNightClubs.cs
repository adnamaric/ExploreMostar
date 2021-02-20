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

namespace exploreMostar.WinUI.Sadržaj.Noćni_klubovi
{
    public partial class frmListaNightClubs : Form
    {
        private readonly APIService _nightclubs = new APIService("nightclubs");
        public frmListaNightClubs()
        {
            InitializeComponent();
        }

        private async void frmListaNightClubs_Load(object sender, EventArgs e)
        {
            var result = await _nightclubs.Get<List<Model.Nightclubs>>(null);
            label4.Text = result.Count().ToString();
            int start1 = 1;
            int max1 = 5;
            while (start1 <= max1)
            {
                cmbFilterByGrade.Items.Add(start1++.ToString());
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var temp = 0;
            var search = new ByNameSearchRequest()
            {
                Naziv = txtPretraga.Text

            };
            //pogledati ovo
            var result = await _nightclubs.Get<List<Model.Nightclubs>>(search);
          

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
                        result = result.Where(y => y.NightClubId == item.NightClubId).ToList();
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



            dgvApartmani.AutoGenerateColumns = false;
            dgvApartmani.DataSource = result;
        }
    }
}
