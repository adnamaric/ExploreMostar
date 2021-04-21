using exploreMostar.Model;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exploreMostar.WinUI.Reports
{
    public partial class frmPregledZemalja : Form
    {
        public frmPregledZemalja()
        {
            InitializeComponent();
        }
        private readonly APIService _service = new APIService("Korisnici");
        private readonly APIService _ua = new APIService("UserActivity");
        private readonly APIService _drzave = new APIService("Drzave");
        private readonly APIService _gradovi = new APIService("Gradovi");
        private void frmPregledZemalja_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var list = await _service.Get<List<Model.Korisnici>>(null);
            var listUA = await _ua.Get<List<Model.UserActivity>>(null);
            var listD = await _drzave.Get<List<Model.Drzave>>(null);
            var listaGradova = await _gradovi.Get<List<Model.Gradovi>>(null);

            List<ReportClassByCountries> lista = new List<ReportClassByCountries>();
            foreach (var item in listD)
            {
                lista.Add(new ReportClassByCountries {  Naziv = item.Naziv });
            }
            bool foundCountry = false;
            foreach(var item in list)
            {
              foreach(var item1 in listaGradova)
                {
                    if (item.GradId == item1.GradId)
                    {
                        foreach(var item2 in listD)
                        {
                            if (item1.DrzavaId == item2.DrzavaId)
                            {
                                item.Drzava = item2.Naziv;
                                foundCountry = true;
                            }
                        }
                        if (foundCountry)
                            break;
                    }
                }
                foundCountry = false;
            }
            foreach(var item in lista)
            {
                item.ukupnoPoDrzavi = list.Where(y => y.Drzava == item.Naziv).Count();
                item.ukupnoPoDrzaviAktivnih = 0;
                item.ukupnoPoDrzaviUdaljenih = 0;
            }
           foreach(var item in list)
            {
                foreach(var item1 in listUA)
                {
                    if (item.KorisnikId == item1.KorisnikId)
                    {
                        foreach(var item2 in lista)
                        {
                            if (item2.Naziv == item.Drzava && item1.Onemogucen==false) 
                            {
                                item2.ukupnoPoDrzaviAktivnih += 1;
                            }
                            else if(item2.Naziv == item.Drzava && item1.Onemogucen == true)
                            {
                                item2.ukupnoPoDrzaviUdaljenih += 1;
                            }
                        }
                    }
                }
            }
            var temp = 0;
            foreach(var item in lista)
            {
                item.DrzavaId = ++temp;
            }
            ReportDataSource rds = new ReportDataSource("DataSet1", lista);
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
