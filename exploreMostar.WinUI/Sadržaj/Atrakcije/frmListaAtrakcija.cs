﻿using exploreMostar.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exploreMostar.WinUI.Sadržaj.Atrakcije
{
    public partial class frmListaAtrakcija : Form
    {
        private readonly APIService _atrakcije = new APIService("atrakcije");
        private readonly APIService _vrsteatrakcija = new APIService("VrstaAtrakcija");


        public frmListaAtrakcija()
        {
            InitializeComponent();
        }

        private async void frmListaAtrakcija_Load(object sender, EventArgs e)
        {
            var result = await _atrakcije.Get<List<Model.Atrakcije>>(null);
            var result1= await _vrsteatrakcija.Get<List<Model.VrstaAtrakcija>>(null);


            label4.Text = result.Count().ToString();
            int start1 = 1;
            int max1 = 5;
            while (start1 <= max1)
            {
                cmbFilterByGrade.Items.Add(start1++.ToString());
            }
            result1.Insert(0, new Model.VrstaAtrakcija() { Naziv = "", VrstaAtrakcijeId = 0 });


            cmbFilterByType.DisplayMember = "Naziv";

            cmbFilterByType.DisplayMember = "Naziv";
            cmbFilterByType.ValueMember = "VrstaAtrakcijeID";
            cmbFilterByType.DataSource = result1;

        }

        private void dgvApartmani_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var temp = 0;
            var search = new ByNameSearchRequest()
            {
                Naziv = txtPretraga.Text

            };
            //pogledati ovo
            var result = await _atrakcije.Get<List<Model.Atrakcije>>(search);
            var result1 = await _vrsteatrakcija.Get<List<Model.VrstaAtrakcija>>(search);

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
                        result = result.Where(y => y.AtrakcijaId == item.AtrakcijaId).ToList();
                    }
                    

                }
            }
            foreach(var item in result)
            {
                item.Vrsta = result1.Where(y => y.VrstaAtrakcijeId == item.VrstaAtrakcijeId).Select(y => y.Naziv).FirstOrDefault();
            }
            if (cmbFilterByGrade.SelectedItem != null)
            {
                int? broj = int.Parse(cmbFilterByGrade.SelectedItem.ToString());

                if (cmbFilterByGrade.SelectedIndex != -1)
                {
                    result = result.Where(y => Convert.ToInt32(y.Ocjena) == broj).ToList();
                }
            }
            if (cmbFilterByType.SelectedIndex != 0)
            {
                if (cmbFilterByType.SelectedIndex==1)
                {
                    result = result.Where(y => y.VrstaAtrakcijeId == 1).ToList();
                }
                else if(cmbFilterByType.SelectedIndex == 2)
                {
                    result = result.Where(y => y.VrstaAtrakcijeId == 2).ToList();

                }
                else
                {
                    result = result.Where(y => y.VrstaAtrakcijeId == 3).ToList();

                }
            }
            dgvApartmani.AutoGenerateColumns = false;
            dgvApartmani.DataSource = result;
        }
    }
}
