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

namespace exploreMostar.WinUI.Sadržaj.Ostalo.Jela
{
    public partial class frmGenerisanjeJelovnika : Form
    {
        private readonly APIService _restorani = new APIService("restorani");
        private readonly APIService _jelovnik = new APIService("jelovnik");
        private readonly APIService _jela = new APIService("jela");
        public int brojOdabranih = 0;
        public frmGenerisanjeJelovnika()
        {
            InitializeComponent();
        }
        public int brojJela = 0;
        private async void frmGenerisanjeJelovnika_Load(object sender, EventArgs e)
        {
            int start1 = 1;
            int max1 = 5;
            while (start1 <= max1)
            {
                cmbBrojJela.Items.Add(start1++.ToString());
            }


            var result = await _jela.Get<List<Model.Jela>>(null);
            var result1 = await _restorani.Get<List<Model.Restorani>>(null);
          
            result1.Insert(0, new Model.Restorani() { Naziv = "Odaberite restoran", RestoranId = 0 });
            cmbRestorani.DataSource = result1;
            cmbRestorani.ValueMember = "RestoranId";
            cmbRestorani.DisplayMember = "Naziv";
            // result.Insert(0, new Model.Jela() { JeloId = 0 });

            listBox1.DataSource = result;
            listBox1.ValueMember = "JeloId";
            listBox1.DisplayMember = "Naziv";
            listBox1.SelectedIndex = -1;
            listBox1.Enabled = false;
           // checkedListBox1.DataBindings = result1;

        }

        private void listBox1_MeasureItem(object sender, MeasureItemEventArgs e)
        {

         

        }

        //private void cmbBrojJela_Leave(object sender, EventArgs e)
        //{
        //    if (cmbBrojJela.SelectedIndex != 0)
        //    {
        //        brojJela = int.Parse(cmbBrojJela.SelectedItem.ToString());
        //        listBox1.Enabled = true;
        //    }
        //}

        private void cmbBrojJela_SelectedIndexChanged(object sender, EventArgs e)
        {

            jela.Text = "Dodana jela su: ";

            if (cmbBrojJela.SelectedIndex != 0)
            {
                brojJela = int.Parse(cmbBrojJela.SelectedItem.ToString());
                listBox1.Enabled = true;
                listBox1.FormattingEnabled = true;
                listBox1.Focus();
                jela.Visible = true;
                
            }
        }
        public List<Model.Jela> lista = new List<Model.Jela>();
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //if (brojJela != 0)
            //{
            //    if (lista.Count() >= brojJela)
            //    {
            //        listBox1.Enabled = false;
            //    }
            //    else
            //    {
            //        lista.Add((Model.Jela)listBox1.SelectedItem);
                    
            //    }
               
            //}
        }


        private async void Sačuvaj_Click(object sender, EventArgs e)
        {
            var request = new JelovnikUpsertRequest
            {
                Naziv = textBox1.Text,

            };
            if (int.Parse(cmbRestorani.SelectedValue.ToString()) != 0)
            {


                foreach (var item in lista)
                {

                   
                    request.Datum = (DateTime)dateTimePicker1.Value;
                    request.JeloId = item.JeloId;

                    request.RestoranId = int.Parse(cmbRestorani.SelectedValue.ToString());

                    if (request != null)
                    {
                        try
                        {
                            await _jelovnik.Insert<Model.Jelovnik>(request);
                            MessageBox.Show("Uspješno ste dodali hranu!");
                            //Obrisi();
                        }
                        catch
                        {
                            MessageBox.Show("Greška prilikom dodavanja!");

                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Molimo odaberite validnu vrijednost za restoran!");

            }

        }

        private void frmGenerisanjeJelovnika_BackColorChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_ForeColorChanged(object sender, EventArgs e)
        {

        }

        private async void listBox1_Click(object sender, EventArgs e)
        {
          
            }

        private async void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            var result = await _jela.Get<List<Model.Jela>>(null);

            if (brojJela != 0)
            {
                if (lista.Count() == brojJela - 1)
                {
                    var temp=result.Where(y => y.JeloId == int.Parse(listBox1.SelectedValue.ToString())).FirstOrDefault();
                    lista.Add(temp);
                    jela.Text += "\n"+ temp.Naziv +"" ;
                    listBox1.Enabled = false;
                }
                else
                {

                    var temp = result.Where(y => y.JeloId == int.Parse(listBox1.SelectedValue.ToString())).FirstOrDefault();
                    lista.Add(temp);
                    jela.Text += "\n" + temp.Naziv + "";
                    //result.Remove(item);
                    //listBox1.DataSource = result;
                    //listBox1.ValueMember = "JeloId";
                    //listBox1.DisplayMember = "Naziv";
                    //listBox1.de
                }

            }
        }

        //private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    if (brojJela != 0)
        //    {
        //        //if (listBox1.SelectedIndex != 0)
        //        //{
        //        lista.AddRange((Model.Jela)listBox1.SelectedItem);

        //        //}
        //        if (listBox1.SelectedItems.Count >= brojJela)
        //        {
        //            listBox1.Enabled = false;

        //        }
        //        if (lista.Count() >= brojJela)
        //            listBox1.Enabled = false;
        //    }
        //}

    }
}
