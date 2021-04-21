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
    public partial class frmPregledKorisnika : Form
    {
        private readonly APIService _service = new APIService("Korisnici");
        private readonly APIService _ua = new APIService("UserActivity");
        private readonly APIService _recenzije = new APIService("Recenzije");

        public frmPregledKorisnika()
        {
            InitializeComponent();
        }

        private void frmPregledKorisnika_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("SortByNumberOfReviews");
            comboBox1.Items.Add("SortByMostActive");

            this.reportViewer1.RefreshReport();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var list = await _service.Get<List<Model.Korisnici>>(null);
            var listUA = await _ua.Get<List<Model.UserActivity>>(null);
            var listR = await _recenzije.Get<List<Model.Recenzije>>(null);

            List<ReportClassUA> users = new List<ReportClassUA>();
            var temp = 0;
            foreach(var item in list)
            {
                users.Add(new ReportClassUA { KorisnikID = item.KorisnikId, ImePrezime = item.Ime + " " + item.Prezime, Username = item.KorisnickoIme,brojRecenzija=0 });
               
            }
            
            foreach(var item in listUA)
            {
                foreach(var item1 in users)
                {
                    if (item.KorisnikId == item1.KorisnikID)
                    {
                        item1.brojPrijavljivanja = (int)item.BrojPrijavljivanja;
                       
                    }
                }
            }

            foreach(var item in listR)
            {
                foreach(var item1 in users)
                {
                    if (item.KorisnikId == item1.KorisnikID)
                    {
                        item1.brojRecenzija += 1;
                    }
                }
            }
            if (comboBox1.SelectedItem != null)
            {
                if (comboBox1.SelectedItem.ToString() == "SortByMostActive")
                    users = users.OrderByDescending(y => y.brojPrijavljivanja).ToList();
                else if (comboBox1.SelectedItem.ToString() == "SortByNumberOfReviews")
                    users = users.OrderByDescending(y => y.brojRecenzija).ToList();
            }
            foreach(var item in users)
            {
                item.Rbr = ++temp;
            }
            ReportDataSource rds = new ReportDataSource("DataSet1", users);
            
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
