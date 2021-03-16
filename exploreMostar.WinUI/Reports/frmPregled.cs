﻿

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
                       
                        temp.Add(new ReportClass() {  Naziv = item.Naziv, Ocjena = item.Ocjena });
                        foreach(var item2 in temp)
                        {
                            if (item.VrstaId == 1)
                                item2.Vrsta = "Restoran";
                            else if (item.VrstaId == 2)
                                item2.Vrsta = "Fast Food";
                            else
                                item2.Vrsta = "N/A";
                        }
                    }
                    
                }
                else if(cmbkategorija.SelectedItem.ToString() == "Atractions")
                {
                    var list = await _atrakacije.Get<List<Model.Atrakcije>>(null);
                    foreach (var item in list)
                    {
                       
                        temp.Add(new ReportClass() {  Naziv = item.Naziv, Ocjena = item.Ocjena });
                        foreach (var item2 in temp)
                        {
                            if (item.VrstaAtrakcijeId == 1)
                                item2.Vrsta = "Prirodna atrakcija";
                            else if (item.VrstaAtrakcijeId == 2)
                                item2.Vrsta = "Historijska atrakcija";
                            else if (item.VrstaAtrakcijeId == 3)
                                item2.Vrsta = "Religijska atrakcija";
                            else
                                item2.Vrsta = "N/A";
                        }
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

                    temp=temp.OrderByDescending(y => y.Ocjena).ToList();
                    foreach(var item in temp)
                    {
                        item.Rbr=++rbr1;
                    }
                }
            }
            ReportDataSource rds = new ReportDataSource("DataSet1", temp);
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
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
