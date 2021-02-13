
namespace exploreMostar.WinUI.Korisnici
{
    partial class frmUrediKorisnika
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblImePrezime = new System.Windows.Forms.Label();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSlikaInput = new System.Windows.Forms.TextBox();
            this.circleButton1 = new exploreMostar.WinUI.CircleButton();
            this.label10 = new System.Windows.Forms.Label();
            this.lbObaveznoP = new System.Windows.Forms.Label();
            this.cmbGradovi = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbObaveznoPrezime = new System.Windows.Forms.Label();
            this.lbObaveznoPolje = new System.Windows.Forms.Label();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPasswordConfrirm = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbOdaberiKorisnika = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblImePrezime
            // 
            this.lblImePrezime.AutoSize = true;
            this.lblImePrezime.Location = new System.Drawing.Point(525, 166);
            this.lblImePrezime.Name = "lblImePrezime";
            this.lblImePrezime.Size = new System.Drawing.Size(0, 13);
            this.lblImePrezime.TabIndex = 54;
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Location = new System.Drawing.Point(429, 420);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(79, 26);
            this.btnDodajSliku.TabIndex = 53;
            this.btnDodajSliku.Text = "Dodaj";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(103, 407);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "Slika";
            // 
            // txtSlikaInput
            // 
            this.txtSlikaInput.Location = new System.Drawing.Point(103, 424);
            this.txtSlikaInput.Name = "txtSlikaInput";
            this.txtSlikaInput.Size = new System.Drawing.Size(320, 20);
            this.txtSlikaInput.TabIndex = 51;
            // 
            // circleButton1
            // 
            this.circleButton1.BackColor = System.Drawing.Color.White;
            this.circleButton1.FlatAppearance.BorderSize = 0;
            this.circleButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circleButton1.Location = new System.Drawing.Point(528, 16);
            this.circleButton1.Name = "circleButton1";
            this.circleButton1.Size = new System.Drawing.Size(134, 130);
            this.circleButton1.TabIndex = 50;
            this.circleButton1.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(100, 355);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "Obavezno polje";
            this.label10.Visible = false;
            // 
            // lbObaveznoP
            // 
            this.lbObaveznoP.AutoSize = true;
            this.lbObaveznoP.ForeColor = System.Drawing.Color.Red;
            this.lbObaveznoP.Location = new System.Drawing.Point(103, 224);
            this.lbObaveznoP.Name = "lbObaveznoP";
            this.lbObaveznoP.Size = new System.Drawing.Size(81, 13);
            this.lbObaveznoP.TabIndex = 48;
            this.lbObaveznoP.Text = "Obavezno polje";
            this.lbObaveznoP.Visible = false;
            // 
            // cmbGradovi
            // 
            this.cmbGradovi.FormattingEnabled = true;
            this.cmbGradovi.Location = new System.Drawing.Point(103, 292);
            this.cmbGradovi.Name = "cmbGradovi";
            this.cmbGradovi.Size = new System.Drawing.Size(320, 21);
            this.cmbGradovi.TabIndex = 47;
            this.cmbGradovi.Text = "Odaberite grad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(103, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Grad";
            // 
            // lbObaveznoPrezime
            // 
            this.lbObaveznoPrezime.AutoSize = true;
            this.lbObaveznoPrezime.ForeColor = System.Drawing.Color.Red;
            this.lbObaveznoPrezime.Location = new System.Drawing.Point(106, 172);
            this.lbObaveznoPrezime.Name = "lbObaveznoPrezime";
            this.lbObaveznoPrezime.Size = new System.Drawing.Size(81, 13);
            this.lbObaveznoPrezime.TabIndex = 45;
            this.lbObaveznoPrezime.Text = "Obavezno polje";
            this.lbObaveznoPrezime.Visible = false;
            // 
            // lbObaveznoPolje
            // 
            this.lbObaveznoPolje.AutoSize = true;
            this.lbObaveznoPolje.ForeColor = System.Drawing.Color.Red;
            this.lbObaveznoPolje.Location = new System.Drawing.Point(100, 120);
            this.lbObaveznoPolje.Name = "lbObaveznoPolje";
            this.lbObaveznoPolje.Size = new System.Drawing.Size(81, 13);
            this.lbObaveznoPolje.TabIndex = 44;
            this.lbObaveznoPolje.Text = "Obavezno polje";
            this.lbObaveznoPolje.Visible = false;
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(540, 477);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(112, 44);
            this.btnSnimi.TabIndex = 43;
            this.btnSnimi.Text = "Sačuvaj";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Password Confrimation";
            // 
            // txtPasswordConfrirm
            // 
            this.txtPasswordConfrirm.Location = new System.Drawing.Point(278, 384);
            this.txtPasswordConfrirm.Name = "txtPasswordConfrirm";
            this.txtPasswordConfrirm.Size = new System.Drawing.Size(135, 20);
            this.txtPasswordConfrirm.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(103, 384);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(143, 20);
            this.txtPassword.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Korisnicko ime";
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(103, 332);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(320, 20);
            this.txtKorisnickoIme.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Telefon";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(103, 253);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(320, 20);
            this.txtTelefon.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(103, 201);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(320, 20);
            this.txtEmail.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Prezime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Ime";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(103, 149);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(320, 20);
            this.txtPrezime.TabIndex = 30;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(103, 97);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(320, 20);
            this.txtIme.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 57;
            this.label9.Text = "Odaberi korisnika";
            // 
            // cmbOdaberiKorisnika
            // 
            this.cmbOdaberiKorisnika.FormattingEnabled = true;
            this.cmbOdaberiKorisnika.Location = new System.Drawing.Point(146, 31);
            this.cmbOdaberiKorisnika.Name = "cmbOdaberiKorisnika";
            this.cmbOdaberiKorisnika.Size = new System.Drawing.Size(255, 21);
            this.cmbOdaberiKorisnika.TabIndex = 58;
            this.cmbOdaberiKorisnika.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmUrediKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 548);
            this.Controls.Add(this.cmbOdaberiKorisnika);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblImePrezime);
            this.Controls.Add(this.btnDodajSliku);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtSlikaInput);
            this.Controls.Add(this.circleButton1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbObaveznoP);
            this.Controls.Add(this.cmbGradovi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbObaveznoPrezime);
            this.Controls.Add(this.lbObaveznoPolje);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPasswordConfrirm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Name = "frmUrediKorisnika";
            this.Text = "frmUrediKorisnika";
            this.Load += new System.EventHandler(this.frmUrediKorisnika_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblImePrezime;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSlikaInput;
        private CircleButton circleButton1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbObaveznoP;
        private System.Windows.Forms.ComboBox cmbGradovi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbObaveznoPrezime;
        private System.Windows.Forms.Label lbObaveznoPolje;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPasswordConfrirm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbOdaberiKorisnika;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}