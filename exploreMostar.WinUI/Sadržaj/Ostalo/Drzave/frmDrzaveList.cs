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

namespace exploreMostar.WinUI.Sadržaj.Ostalo.Drzave
{
    public partial class frmDrzaveList : Form
    {
        private readonly APIService _drzave = new APIService("drzave");
        public frmDrzaveList()
        {
            InitializeComponent();
        }

        private async void frmDrzaveList_Load(object sender, EventArgs e)
        {
           
            var result = await _drzave.Get<List<Model.Drzave>>(null);

        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var temp = 0;
            var search = new ByNameSearchRequest()
            {
                Naziv = txtPretraga.Text

            };
            //pogledati ovo
            var result = await _drzave.Get<List<Model.Drzave>>(search);


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
                        result = result.Where(y => y.DrzavaId == item.DrzavaId).ToList();
                    }


                }
            }
            //Bitmap img;

            //img = new Bitmap();

            //// Create the DGV with an Image column

            //DataGridView dgv = new DataGridView();

            //this.Controls.Add(dgv);

            //DataGridViewImageColumn imageCol = new DataGridViewImageColumn();

            //dgv.Columns.Add(imageCol);

            //// Add a row and set its value to the image

            //dgv.Rows.Add();

            //dgv.Rows[0].Cells[0].Value = img;


            dgvApartmani.AutoGenerateColumns = false;
            dgvApartmani.DataSource = result;
        }
    }
}
