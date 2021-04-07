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
    public partial class frmKategorijePregled : Form
    {
        public frmKategorijePregled()
        {
            InitializeComponent();
        }
        private readonly APIService _kategorije = new APIService("Kategorije");
        private readonly APIService _restorani = new APIService("Restorani");
        private readonly APIService _apartmani = new APIService("Apartmani");
        private readonly APIService _atrakcije = new APIService("Atrakcije");
        private readonly APIService _hoteli = new APIService("Hoteli");
        private readonly APIService _kafici = new APIService("Kafici");
        private readonly APIService _prevoz = new APIService("Prevoz");
        private readonly APIService _nightclubs = new APIService("nightclubs");


        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var result = await _kategorije.Get<IList<Model.Kategorije>>(null);
            dgvKorisnici.AutoGenerateColumns = false;
            var r = await _restorani.Get<List<Model.Restorani>>(null);
            var a = await _apartmani.Get<List<Model.Apartmani>>(null);
            var at = await _atrakcije.Get<List<Model.Atrakcije>>(null);
            var h = await _hoteli.Get<List<Model.Hoteli>>(null);
            var k = await _kafici.Get<List<Model.Kafici>>(null);
            var nk= await _nightclubs.Get<List<Model.Nightclubs>>(null);
            var p = await _prevoz.Get<List<Model.Prevoz>>(null);
            var temp = 0;
            foreach(var item in result)
            {
                item.Rbr = ++temp;
                if (item.Naziv == "Food")
                    item.Ukupno = r.Count();
                else if (item.Naziv == "Atractions")
                    item.Ukupno = at.Count();
                else if (item.Naziv == "Coffee shops")
                    item.Ukupno = k.Count();
                else if (item.Naziv == "Accommodation")
                    item.Ukupno = a.Count() + h.Count();
                else if (item.Naziv == "Transport")
                    item.Ukupno = p.Count();
                else if (item.Naziv == "Others")
                    item.Ukupno = nk.Count();
            }
            dgvKorisnici.DataSource = result;

        }

        private async void frmKategorijePregled_Load(object sender, EventArgs e)
        {
            var result = await _kategorije.Get<IList<Model.Kategorije>>(null);
            brojK.Text = result.Count().ToString();
        }
    }
}
