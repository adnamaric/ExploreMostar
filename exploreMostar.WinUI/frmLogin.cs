using exploreMostar.Model.Requests;
using exploreMostar.WinUI.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exploreMostar.WinUI
{
    public partial class frmLogin : Form
    {
        APIService _service = new APIService("Korisnici");
        APIService _uaservice = new APIService("UserActivity");

        public frmLogin()
        {
            InitializeComponent();
        }
        protected string salt = GenerateSalt();
        protected string hash;


        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var result = await _service.Get<List<Model.Korisnici>>(null);
            var resultUA = await _uaservice.Get<List<Model.UserActivity>>(null);

            Model.Korisnici korisnik = new Model.Korisnici();
            bool pronadjen = false;
            bool pronadjen2 = false;
            
           
            foreach (var temp in result)
            {
                if (temp.KorisnickoIme == txtUsername.Text)
                {
                    korisnik = temp;
                    pronadjen = true;
                    hash = GenerateHash(korisnik.LozinkaSalt, txtPassword.Text);
                    if (temp.LozinkaHash == hash)
                    {
                        pronadjen2 = true;
                    }
                }
               
               
            }
            Model.UserActivity userActivity = null;
            bool udaljen = false;
            foreach(var item in resultUA)
            {
                if (item.KorisnikId == korisnik.KorisnikId)
                {
                    userActivity = item;
                    if (item.BrojNeuspjesnihPrijavljivanja >= 3)
                    {
                        item.Onemogucen = true;
                        MessageBox.Show("Nemate pravo pristupa", "Authentifikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        udaljen = true;
                    }
                }
            }
            bool takeThis = false;
            if (udaljen == true)
            {
                MessageBox.Show("Banovani ste sa sistema!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (pronadjen2 == true && pronadjen==true && udaljen==false)
            {
                try
                {
                    APIService.Username = txtUsername.Text;
                    APIService.Password = txtPassword.Text;
                    if(userActivity!=null)
                         userActivity.BrojPrijavljivanja += 1;
                    await _service.Get<dynamic>(null);
                   
                    frmMenu frmMenu = new frmMenu();
                    frmMenu.Show();
                    //this.Hide();
                    takeThis = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Authentifikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if(userActivity!=null)
                       userActivity.BrojNeuspjesnihPrijavljivanja += 1;
                    takeThis = false;
                }
                
               
            }
            else if(pronadjen==true && udaljen == false)
            {
                if (userActivity != null)
                    userActivity.BrojNeuspjesnihPrijavljivanja += 1;
                takeThis = false;
                MessageBox.Show("Molimo vas unesite ispravno korisničko ime i/ili lozinku", "Pokušajte ponovo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                MessageBox.Show("Molimo vas unesite ispravno korisničko ime i/ili lozinku", "Pokušajte ponovo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            try
            {
                if (userActivity != null)
                {
                    
                    var request = new UserActivityUpsertRequest
                    {
                        KorisnikId = userActivity.KorisnikId,
                        BrojPrijavljivanja = userActivity.BrojPrijavljivanja,
                        BrojNeuspjesnihPrijavljivanja = userActivity.BrojNeuspjesnihPrijavljivanja,
                        Datum = DateTime.Now,
                        Razlog = "",
                        Onemogucen = false

                    };
                    await _uaservice.Update<Model.UserActivity>(userActivity.KorisnikId, request);
                }
                else
                {
                    if (takeThis)
                    {
                        var request = new UserActivityUpsertRequest
                        {
                            KorisnikId = korisnik.KorisnikId,
                            BrojPrijavljivanja = 1,
                            BrojNeuspjesnihPrijavljivanja = 0,
                            Datum = DateTime.Now,
                            Razlog = "",
                            Onemogucen = false

                        };
                        await _uaservice.Insert<Model.UserActivity>(request);
                    }
                    else
                    {
                        var request = new UserActivityUpsertRequest
                        {
                            KorisnikId = korisnik.KorisnikId,
                            BrojPrijavljivanja = 0,
                            BrojNeuspjesnihPrijavljivanja =1,
                            Datum = DateTime.Now,
                            Razlog = "",
                            Onemogucen = false

                        };
                        await _uaservice.Insert<Model.UserActivity>(request);
                    }
                }
            }
            catch
            {

            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
        //private static byte[] GetHash(string inputString)
        //{
        //    using (HashAlgorithm algorithm = SHA1.Create())
        //        return algorithm.ComputeHash(Encoding.Unicode.GetBytes(inputString));
        //}
        //private static string GetHashString(string inputString)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    foreach (byte b in GetHash(inputString))
        //        sb.Append(b.ToString("X2"));

        //    return sb.ToString();
        //}
        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }
        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            
            return Convert.ToBase64String(inArray);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }
    }
}
