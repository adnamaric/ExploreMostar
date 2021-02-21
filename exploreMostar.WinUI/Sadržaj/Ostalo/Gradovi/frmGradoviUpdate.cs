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
    public partial class frmGradoviUpdate : Form
    {
        private readonly APIService _gradovi = new APIService("gradovi");
        private readonly APIService _drzave = new APIService("drzave");
        private int? _id = null;
        public frmGradoviUpdate()
        {
            InitializeComponent();
        }

        private async void frmGradoviUpdate_Load(object sender, EventArgs e)
        {
            var result = await _gradovi.Get<List<Model.Gradovi>>(null);
            var result1 = await _drzave.Get<List<Model.Drzave>>(null);

            result.Insert(0, new Model.Gradovi() { Naziv = "Odaberite grad", GradId = 0 });
            result1.Insert(0, new Model.Drzave() { Naziv = "", DrzavaId = 0 });

            comboBox2.DataSource = result;
            comboBox2.DisplayMember = "Naziv";
            comboBox2.ValueMember = "GradId";
            comboBox1.DataSource = result1;
            comboBox1.DisplayMember = "Naziv";
            comboBox1.ValueMember = "DrzavaId";

        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
  

                var request = new GradoviUpsertRequest
                {
                    Naziv = txtNazivA.Text,
                    
                };

                if ((int)comboBox1.SelectedValue == 0)
                {
                    MessageBox.Show("Molimo odaberite državu!");
                }
                else
                {
                    request.DrzavaId = (int)comboBox1.SelectedValue;
                }
                if (_id != null || _id != 0)
                {
                    await _gradovi.Update<Model.Gradovi>(_id, request);
                    MessageBox.Show("Operacija uspješna!");

                }
            }
        }

        private async void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            var apid = (Model.Gradovi)comboBox2.SelectedItem;



            var result = await _gradovi.Get<List<Model.Gradovi>>(null);
            if (apid.GradId != 0)
            {
                var odabrani = result.Where(y => y.GradId == apid.GradId).FirstOrDefault();
                txtNazivA.Text = odabrani.Naziv;

                _id = odabrani.GradId;
                
                comboBox1.SelectedValue = odabrani.DrzavaId;
            }
           
            
        }
    }
}
