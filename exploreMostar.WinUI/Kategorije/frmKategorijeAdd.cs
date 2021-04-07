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
    public partial class frmKategorijeAdd : Form
    {
        public frmKategorijeAdd()
        {
            InitializeComponent();
        }
        List<string> listaSadrzaja = new List<string>();
        private readonly APIService _kategorije = new APIService("Kategorije");
        private readonly APIService _restorani = new APIService("Restorani");
        private readonly APIService _apartmani = new APIService("Apartmani");
        private readonly APIService _atrakcije = new APIService("Atrakcije");
        private readonly APIService _hoteli = new APIService("Hoteli");
        private readonly APIService _kafici = new APIService("Kafici");
        private readonly APIService _prevoz = new APIService("Prevoz");
        private readonly APIService _nightclubs = new APIService("nightclubs");
        private void frmKategorijeAdd_Load(object sender, EventArgs e)
        {
            List<string> result=new List<string>();
            result.Add( "Apartmani");
            result.Add ("Atrakcije");
            result.Add( "Kafici");
            result.Add( "Hoteli");
            result.Add( "Nocni klubovi");
            result.Add( "Restorani");
            result.Add( "Prevoz");
            listBox1.Enabled = false;
            listBox1.DataSource = result;
            
            listBox1.SelectedIndex = 1;
            
        }

     

        private void listBox1_ValueMemberChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            var temp = listBox1.SelectedValue.ToString();
            if (txtIme.Text != "" && temp != "")
            {
                if (listaSadrzaja.Count() == 0)
                {
                    listaSadrzaja.Add(temp);
                    sadrzaj.Text += "\n" + temp.ToString() + "";
                }
                bool postoji = false;
                foreach (var item in listaSadrzaja)
                {
                    if (item == temp)
                    {
                        postoji = true;
                        break;
                    }
                }
                if (!postoji)
                {
                    listaSadrzaja.Add(temp);
                    sadrzaj.Text += "\n" + temp.ToString() + "";
                }
            }
        }

        private void sadrzaj_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIme_Leave(object sender, EventArgs e)
        {
            sadrzaj.Text = "Dodani sadržaj:";
            if (txtIme.Text != "")
            {
                listBox1.Enabled = true;
                listBox1.FormattingEnabled = true;
                listBox1.Focus();
                sadrzaj.Visible = true;
            }
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            var r = await _restorani.Get<List<Model.Restorani>>(null);
            var a = await _apartmani.Get<List<Model.Apartmani>>(null);
            var at = await _atrakcije.Get<List<Model.Atrakcije>>(null);
            var h = await _hoteli.Get<List<Model.Hoteli>>(null);
            var k = await _kafici.Get<List<Model.Kafici>>(null);
            var nk = await _nightclubs.Get<List<Model.Nightclubs>>(null);
            var p = await _prevoz.Get<List<Model.Prevoz>>(null);
            if (this.ValidateChildren())
            {
                string sadrzaj = "";
                int ukupno = 0;
               foreach(var item in listaSadrzaja)
                {
                    sadrzaj += item + ", ";
                    if (item == "Apartmani")
                        ukupno += a.Count();
                    else if (item == "Atrakcije")
                        ukupno += at.Count();
                    else if (item == "Restorani")
                        ukupno += r.Count();
                    else if (item == "Hoteli")
                        ukupno += h.Count();
                    else if (item == "Kafici")
                        ukupno += k.Count();
                    else if (item == "Nocni klubovi")
                        ukupno += nk.Count();
                    else if (item == "Prevoz")
                        ukupno += p.Count();
                }
                var request = new KategorijeUpsertRequest
                {
                    Naziv = txtIme.Text,
                    Opis = txtPrezime.Text,
                    Sadrzaj=sadrzaj,
                    Ukupno=ukupno
                };
             
                if(request!=null)
                {
                    await _kategorije.Insert<Model.Kategorije>(request);
                    MessageBox.Show("Operacija uspješna!");
                }
                else
                {
                    MessageBox.Show("Pokušajte ponovo!");
                }

               

            }
        }
    }
}
