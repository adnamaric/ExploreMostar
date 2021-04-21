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
            if (APIService.isDelete == true)
            {
                btnSnimi.BackColor = Color.Red;
                btnSnimi.Text = "Obrišite kategoriju";
            }
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
            var result = await _kategorije.Get<List<Model.Kategorije>>(null);
            var r = await _restorani.Get<List<Model.Restorani>>(null);
            var a = await _apartmani.Get<List<Model.Apartmani>>(null);
            var at = await _atrakcije.Get<List<Model.Atrakcije>>(null);
            var h = await _hoteli.Get<List<Model.Hoteli>>(null);
            var k = await _kafici.Get<List<Model.Kafici>>(null);
            var nk = await _nightclubs.Get<List<Model.Nightclubs>>(null);
            var p = await _prevoz.Get<List<Model.Prevoz>>(null);
            if (this.ValidateChildren())
            {

                int ukupno = 0;
                if (stringPrije.Contains("Apartmani"))
                    ukupno += a.Count();
                if (stringPrije.Contains("Atrakcije"))
                    ukupno += at.Count();
                if (stringPrije.Contains("Restorani"))
                    ukupno += r.Count();
                if (stringPrije.Contains("Hoteli"))
                    ukupno += h.Count();
                if (stringPrije.Contains("Kafici"))
                    ukupno += k.Count();
                if (stringPrije.Contains("Nocni klubovi"))
                    ukupno += nk.Count();
                if (stringPrije.Contains("Prevoz"))
                    ukupno += p.Count();

                var request = new KategorijeUpsertRequest
                {
                    Naziv = txtIme.Text,
                    Opis = txtPrezime.Text,
                    Sadrzaj = sadrzaj.Text,
                    Ukupno = ukupno,
                    
                };
                
                foreach (var item in result)
                {
                    if (item.Naziv == request.Naziv)
                    {
                        _id = item.KategorijaId;
                        if (item.Naziv == "Food" || item.Naziv == "Atractions" || item.Naziv == "Coffee shops" || item.Naziv == "Accommodation" || item.Naziv == "Transport" || item.Naziv == "Others")
                            request.VrstaKategorije = "Default";
                        else
                            request.VrstaKategorije = "New";
                    }
                  

                }
                sadrzaj.Visible = true;
                if (_id != 0 && _id != null)
                {
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
                    FreeUp();
                    await LoadKategorije();

                }
            }
        }
        private async Task LoadKategorije()
        {
            var result = await _kategorije.Get<List<Model.Kategorije>>(null);
            if (APIService.isDelete)
            {
                result = result.Where(y => y.VrstaKategorije != "Default").ToList();
            }
            result.Insert(0, new Model.Kategorije() { Naziv = "Odaberite kategoriju", KategorijaId = 0 });

            cmbOdabirKategorije.DataSource = result;
            cmbOdabirKategorije.DisplayMember = "Naziv";
            cmbOdabirKategorije.ValueMember = "KategorijaId";

        }
        private async void frmKategorijeUpdateDelete_Load(object sender, EventArgs e)
        {
            var result = await _kategorije.Get<List<Model.Kategorije>>(null);
            if (APIService.isDelete)
            {
                result = result.Where(y => y.VrstaKategorije != "Default").ToList();
            }
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
        private void FreeUp()
        {
            sadrzaj.Clear();
            txtIme.Clear();
            txtPrezime.Clear();
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            var temp = listBox1.SelectedValue.ToString();
            if (txtIme.Text != "" && temp != "")
            {
                if ( stringPrije==string.Empty)
                {
                    listaSadrzaja.Add(temp);
                    sadrzaj.Text += "\n" + temp.ToString() + "";
                    stringPrije= temp.ToString() + ",";
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
                    
                    sadrzaj.Text += temp.ToString() + ", ";
                    stringPrije += temp.ToString()+",";
                }
            }
        }
    }
}
