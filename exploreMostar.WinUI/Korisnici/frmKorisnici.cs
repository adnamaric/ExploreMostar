using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl.Http;
using Flurl;
using exploreMostar.Model.Requests;

namespace exploreMostar.WinUI.Korisnici
{
    public partial class frmKorisnici : Form
    {
        private readonly APIService _aPIService = new APIService ("korisnici");
        private readonly APIService _gradovi = new APIService("gradovi");

        public frmKorisnici()
        {
            InitializeComponent();
        }

        private async void frmKorisnici_Load(object sender, EventArgs e)
        {
            await LoadGradovi();
            cmbSort.Items.Add("SortByName");
            cmbSort.Items.Add("SortByLastName");
            cmbSort.Items.Add("SortByUser");
            var result = await _aPIService.Get<IList<Model.Korisnici>>(null);
            brojK.Text = result.Count().ToString();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            // var result = "https://localhost:44333/api/Korisnici".GetJsonAsync<IList<Model.Korisnici>>().Result;
            var search = new KorisniciSearchRequest()
            {
                Ime = txtPretraga.Text

            };
            var result = await _aPIService.Get<IList<Model.Korisnici>>(search);
            var gradovi = await _gradovi.Get<IList<Model.Gradovi>>(null);
            if (search.Ime != "")
            {
                result = result.Where(y => y.Ime == search.Ime).ToList();
            }
            if (txtPrezimePretraga.Text != "")
            {
                result = result.Where(y => y.Prezime == txtPrezimePretraga.Text).ToList();

            }
            if(cmbSort.SelectedIndex== 0)
            {
                result = result.OrderBy(y => y.Ime).ToList();
            }
            if (cmbSort.SelectedIndex ==1)
            {
                result = result.OrderBy(y => y.Prezime).ToList();
            }
            if (cmbSort.SelectedIndex == 2)
            {
                result = result.OrderBy(y => y.KorisnickoIme).ToList();
            }
            if (cmbGradovi.SelectedIndex != 0)
            {
               result=result.Where(y => y.GradId == cmbGradovi.SelectedIndex).ToList();
            }
            else if(cmbGradovi.SelectedIndex == 0 )
            {
                result = result.ToList();
            }
            foreach (var korisnik in result)
            {
                korisnik.Grad= gradovi.Where(y => y.GradId == korisnik.GradId).Select(y => y.Naziv).FirstOrDefault();
                if(korisnik.Grad==null)
                {
                    korisnik.Grad = "/";
                }
            }
           
       
            dgvKorisnici.DataSource = result;
            
        }

        private void dgvKorisnici_DoubleClick(object sender, EventArgs e)
        {
            //var id = dgvKorisnici.SelectedRows[0].Cells[0].Value;
            //frmKorisniciDetalji frm = new frmKorisniciDetalji(int.Parse(id.ToString()));
            //frm.Show();
        }

        private void dgvKorisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private async Task LoadGradovi()
        {
            var result = await _gradovi.Get<List<Model.Gradovi>>(null);
            result.Insert(0, new Model.Gradovi() { Naziv = "Odaberite grad", GradId = -1 });


            cmbGradovi.DataSource = result;
            cmbGradovi.DisplayMember = "Naziv";
            cmbGradovi.ValueMember = "GradId";

        }

    }
}
