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

namespace exploreMostar.WinUI.Kategorije
{
    public partial class frmKategorijeUpdateDelete : Form
    {
        public frmKategorijeUpdateDelete()
        {
            InitializeComponent();
        }
        private int? _id = null;
        private readonly APIService _kategorije = new APIService("Kategorije");
        List<string> listaSadrzaja = new List<string>();
   
        private readonly APIService _restorani = new APIService("Restorani");
        private readonly APIService _apartmani = new APIService("Apartmani");
        private readonly APIService _atrakcije = new APIService("Atrakcije");
        private readonly APIService _hoteli = new APIService("Hoteli");
        private readonly APIService _kafici = new APIService("Kafici");
        private readonly APIService _prevoz = new APIService("Prevoz");
        private readonly APIService _nightclubs = new APIService("nightclubs");
        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            var request = new KategorijeUpsertRequest
            {
                Naziv = txtIme.Text,
                Opis = txtPrezime.Text,
                Sadrzaj=sadrzaj.Text
            };

            sadrzaj.Visible = true;
            if (APIService.isUpdate == true && APIService.isDelete == false)
            {
                await _kategorije.Update<Model.Objava>(_id, request);
                MessageBox.Show("Uspješno ste modificirali objavu!");
            }
            else if (APIService.isUpdate == false && APIService.isDelete == true)
            {
                await _kategorije.Delete((int)_id);
                MessageBox.Show("Uspješno ste obrisali objavu!");
            }
           
            await LoadKategorije();
        }
        private async Task LoadKategorije()
        {
            var result = await _kategorije.Get<List<Model.Kategorije>>(null);

            result.Insert(0, new Model.Kategorije() { Naziv = "Odaberite kategoriju", KategorijaId = 0 });

            cmbOdabirKategorije.DataSource = result;
            cmbOdabirKategorije.DisplayMember = "Naziv";
            cmbOdabirKategorije.ValueMember = "KategorijaId";

        }
        private async void frmKategorijeUpdateDelete_Load(object sender, EventArgs e)
        {
            var result = await _kategorije.Get<List<Model.Kategorije>>(null);

            result.Insert(0, new Model.Kategorije() { Naziv = "Odaberite kategoriju", KategorijaId = 0 });

            cmbOdabirKategorije.DataSource = result;
            cmbOdabirKategorije.DisplayMember = "Naziv";
            cmbOdabirKategorije.ValueMember = "KategorijaId";
            List<string> result1 = new List<string>();
            result1.Add("Apartmani");
            result1.Add("Atrakcije");
            result1.Add("Kafici");
            result1.Add("Hoteli");
            result1.Add("Nocni klubovi");
            result1.Add("Restorani");
            result1.Add("Prevoz");
            listBox1.Enabled = true;
            listBox1.DataSource = result1;

          
        }

        private async void cmbOdabirKategorije_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            var apid = (Model.Kategorije)cmbOdabirKategorije.SelectedItem;
            var result = await _kategorije.Get<List<Model.Kategorije>>(null);


            if (apid.KategorijaId != 0)
            {
                var odabrani = result.Where(y => y.KategorijaId == apid.KategorijaId).FirstOrDefault();
                if (odabrani != null)
                {
                    txtIme.Text = odabrani.Naziv;
                    txtPrezime.Text = odabrani.Opis;
                    sadrzaj.Text = odabrani.Sadrzaj;
                    if (sadrzaj.Text != "" && sadrzaj.Text != null)
                        stringPrije = sadrzaj.Text;
                }
            }
        }
        private string stringPrije = string.Empty;
        private void sadrzaj_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            var temp = listBox1.SelectedValue.ToString();
            if (txtIme.Text != "" && temp != "")
            {
                if (listaSadrzaja.Count() == 0 && stringPrije==string.Empty)
                {
                    listaSadrzaja.Add(temp);
                    sadrzaj.Text += "\n" + temp.ToString() + "";
                    
                }
                bool postoji = false;
                //foreach (var item in listaSadrzaja)
                //{

                //    if (item == temp)
                //    {
                //        postoji = true;
                //        break;
                //    }
                //}
                if (stringPrije.Contains(temp))
                {
                    postoji = true;
                    
                }
                if (!postoji)
                {
                    listaSadrzaja.Add(temp);
                    
                    sadrzaj.Text += "\n" + temp.ToString() + ", ";
                }
            }
        }
    }
}
