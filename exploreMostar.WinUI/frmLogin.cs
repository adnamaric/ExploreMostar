using exploreMostar.WinUI.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exploreMostar.WinUI
{
    public partial class frmLogin : Form
    {
        APIService _service = new APIService("Korisnici");
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
           
            try
            {
                APIService.Username = txtUsername.Text;
                APIService.Password = txtPassword.Text;
                await _service.Get<dynamic>(null);
                frmMenu frmMenu = new frmMenu();
                frmMenu.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Authentifikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
