

using exploreMostar.Model;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exploreMostar.WinUI.Reports
{
    public partial class frmPregled : Form
    {
        private readonly APIService _service = new APIService("Kategorije");
        private readonly APIService _restorani = new APIService("Restorani");
        private readonly APIService _atrakacije = new APIService("Atrakcije");
        private readonly APIService _kafici = new APIService("Kafici");
        private readonly APIService _apartmani = new APIService("Apartmani");
        private readonly APIService _hoteli = new APIService("Hoteli");
        private readonly APIService _prevoz = new APIService("Prevoz");

        public frmPregled()
        {
            InitializeComponent();
           
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            List<ReportClass> temp = new List<ReportClass>();
            int rbr1 = 0;
            if (int.Parse(cmbkategorija.SelectedIndex.ToString()) != -1)
            {
                if (cmbkategorija.SelectedItem.ToString() == "Food")
                {
                    var list = await _restorani.Get<List<Model.Restorani>>(null);
                    foreach (var item in list)
                    {
                        string vrstaa = "";

                        var tempna = list.Where(y => y.Naziv == item.Naziv).FirstOrDefault();
                        
                            if (item.VrstaId == 1)
                                 vrstaa = "Restoran";
                            else if (item.VrstaId == 2)
                                vrstaa = "Fast Food";
                            else
                                 vrstaa = "N/A";
                        
                        temp.Add(new ReportClass() {  Naziv = item.Naziv, Ocjena = item.Ocjena,Vrsta=vrstaa});
                      
                    }
                    

                }
                else if(cmbkategorija.SelectedItem.ToString() == "Atractions")
                {
                    var list = await _atrakacije.Get<List<Model.Atrakcije>>(null);
                    foreach (var item in list)
                    {
                        string vrstaa="";
                        var tempna = list.Where(y => y.Naziv == item.Naziv).FirstOrDefault();

                        if (tempna.VrstaAtrakcijeId == 1)
                            vrstaa = "Prirodna atrakcija";
                        else if (tempna.VrstaAtrakcijeId == 2)
                            vrstaa = "Historijska atrakcija";
                        else if (tempna.VrstaAtrakcijeId == 3)
                            vrstaa = "Religijska atrakcija";
                        else
                            vrstaa = "N/A";
                        temp.Add(new ReportClass() {  Naziv = item.Naziv, Ocjena = item.Ocjena,Vrsta=vrstaa });

                        
                    }
                }
                else if (cmbkategorija.SelectedItem.ToString() == "Coffee shops")
                {
                    var list = await _kafici.Get<List<Model.Kafici>>(null);
                    foreach (var item in list)
                    {
                        temp.Add(new ReportClass() { Naziv = item.Naziv, Ocjena = item.Ocjena });
                       
                    }
                }
                else if (cmbkategorija.SelectedItem.ToString() == "Accommodation")
                {
                    var list = await _apartmani.Get<List<Model.Apartmani>>(null);
                    var list1 = await _hoteli.Get<List<Model.Hoteli>>(null);

                    foreach (var item in list)
                    {
                        temp.Add(new ReportClass() {  Naziv = item.Naziv, Ocjena = item.Ocjena });

                    }
                    foreach(var item in list1)
                    {
                        temp.Add(new ReportClass() { Naziv = item.Naziv, Ocjena = item.Ocjena });

                    }
                }
                else if (cmbkategorija.SelectedItem.ToString() == "Transport")
                {
                    var list = await _prevoz.Get<List<Model.Prevoz>>(null);
                   

                    foreach (var item in list)
                    {
                       
                        temp.Add(new ReportClass() {  Naziv = item.Naziv });//Ocjena = item.Ocjena });

                    }
                    
                }
                else
                {

                }
                if (temp != null)
                {
                    if (comboBox1.SelectedItem.ToString() == "BestRated")
                        temp = temp.OrderByDescending(y => y.Ocjena).ToList();
                    else if (comboBox1.SelectedItem.ToString() == "WorstRated")
                        temp = temp.OrderBy(y => y.Ocjena).ToList();
                    //temp=temp.OrderByDescending(y => y.Ocjena).ToList();
                    foreach (var item in temp)
                    {
                        item.Rbr=++rbr1;
                    }
                }
            }
            ReportDataSource rds = new ReportDataSource("DataSet2", temp);
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
            //Warning[] warnings;
            //string[] streamids;
            //string mimeType;
            //string encoding;
            //string filenameExtension;

            //byte[] bytes = reportViewer1.LocalReport.Render(
            //    "PDF", null, out mimeType, out encoding, out filenameExtension,
            //    out streamids, out warnings);

            //using (FileStream fs = new FileStream("output.pdf", FileMode.Create))
            //{
            //    fs.Write(bytes, 0, bytes.Length);
            //}

        }

        private async void frmPregled_Load(object sender, EventArgs e)
        {
            var result = await _service.Get<List<Model.Kategorije>>(null);
            result.Insert(0, new Model.Kategorije() { Naziv = "Odaberite kategoriju", KategorijaId = -1 });

            cmbkategorija.Items.Add("");
            cmbkategorija.Items.Add("Food");
            cmbkategorija.Items.Add("Atractions");
            cmbkategorija.Items.Add("Coffee shops");
            cmbkategorija.Items.Add("Accommodation");
            cmbkategorija.Items.Add("Transport");
            comboBox1.Items.Add("BestRated");
            comboBox1.Items.Add("WorstRated");

            this.reportViewer1.RefreshReport();

            //cmbkategorija.DataSource = result;
            //cmbkategorija.DisplayMember = "Naziv";
            //cmbkategorija.ValueMember = "KategorijaId";
            DataSet ds = new DataSet();
           
        }

        private void kategorija_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
