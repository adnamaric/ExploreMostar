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
        private readonly APIService _restorani = new APIService("UserActivity");
        public frmPregledKorisnika()
        {
            InitializeComponent();
        }

        private void frmPregledKorisnika_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
