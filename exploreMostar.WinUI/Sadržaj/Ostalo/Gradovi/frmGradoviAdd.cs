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

namespace exploreMostar.WinUI.Sadržaj.Ostalo.Gradovi
{
    public partial class frmGradoviAdd : Form
    {
        private readonly APIService _gradovi = new APIService("gradovi");
        private readonly APIService _drzave = new APIService("drzave");
        public frmGradoviAdd()
        {
            InitializeComponent();
        }

        private async void frmGradoviAdd_Load(object sender, EventArgs e)
        {
            var result = await _drzave.Get<List<Model.Drzave>>(null);
            result.Insert(0, new Model.Drzave() { Naziv = "Odaberite drzavu", DrzavaId = 0 });


            comboBox1.DataSource = result;
            comboBox1.DisplayMember = "Naziv";
            comboBox1.ValueMember = "DrzavaId";
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            var request = new GradoviUpsertRequest
            {
                Naziv = txtNazivA.Text,

            };
            if (comboBox1.SelectedIndex != 0)
            {
                request.DrzavaId = (int)comboBox1.SelectedValue;
            }
            else
            {
               
                MessageBox.Show("Molimo odaberite državu!");
                
            }

            if (request != null && comboBox1.SelectedIndex != 0)
            {
                try
                {
                    await _gradovi.Insert<Model.Gradovi>(request);
                    MessageBox.Show("Uspješno ste dodali grad!");
                    //Obrisi();
                }
                catch
                {
                    MessageBox.Show("Greška prilikom dodavanja!");

                }
            }
        }
    }
    }

