
namespace exploreMostar.WinUI.Korisnici
{
    partial class frmUklanjanjeKorisnika
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
            this.cmbOdaberiKorisnika = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.btnUkloni = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // cmbOdaberiKorisnika
            // 
            this.cmbOdaberiKorisnika.FormattingEnabled = true;
            this.cmbOdaberiKorisnika.Location = new System.Drawing.Point(166, 35);
            this.cmbOdaberiKorisnika.Name = "cmbOdaberiKorisnika";
            this.cmbOdaberiKorisnika.Size = new System.Drawing.Size(255, 21);
            this.cmbOdaberiKorisnika.TabIndex = 85;
            this.cmbOdaberiKorisnika.SelectedIndexChanged += new System.EventHandler(this.cmbOdaberiKorisnika_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(71, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 84;
            this.label9.Text = "Odaberi korisnika";
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Location = new System.Drawing.Point(478, 416);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(79, 26);
            this.btnDodajSliku.TabIndex = 83;
            this.btnDodajSliku.Text = "Dodaj";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(152, 403);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 82;
            this.label11.Text = "Slika";
            // 
            // txtSlikaInput
            // 
            this.txtSlikaInput.Location = new System.Drawing.Point(152, 420);
            this.txtSlikaInput.Name = "txtSlikaInput";
            this.txtSlikaInput.Size = new System.Drawing.Size(320, 20);
            this.txtSlikaInput.TabIndex = 81;
            // 
            // circleButton1
            // 
            this.circleButton1.BackColor = System.Drawing.Color.White;
            this.circleButton1.FlatAppearance.BorderSize = 0;
            this.circleButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circleButton1.Location = new System.Drawing.Point(577, 12);
            this.circleButton1.Name = "circleButton1";
            this.circleButton1.Size = new System.Drawing.Size(134, 130);
            this.circleButton1.TabIndex = 80;
            this.circleButton1.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(149, 351);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 79;
            this.label10.Text = "Obavezno polje";
            this.label10.Visible = false;
            // 
            // lbObaveznoP
            // 
            this.lbObaveznoP.AutoSize = true;
            this.lbObaveznoP.ForeColor = System.Drawing.Color.Red;
            this.lbObaveznoP.Location = new System.Drawing.Point(152, 220);
            this.lbObaveznoP.Name = "lbObaveznoP";
            this.lbObaveznoP.Size = new System.Drawing.Size(81, 13);
            this.lbObaveznoP.TabIndex = 78;
            this.lbObaveznoP.Text = "Obavezno polje";
            this.lbObaveznoP.Visible = false;
            // 
            // cmbGradovi
            // 
            this.cmbGradovi.FormattingEnabled = true;
            this.cmbGradovi.Location = new System.Drawing.Point(152, 288);
            this.cmbGradovi.Name = "cmbGradovi";
            this.cmbGradovi.Size = new System.Drawing.Size(320, 21);
            this.cmbGradovi.TabIndex = 77;
            this.cmbGradovi.Text = "Odaberite grad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(152, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 76;
            this.label8.Text = "Grad";
            // 
            // lbObaveznoPrezime
            // 
            this.lbObaveznoPrezime.AutoSize = true;
            this.lbObaveznoPrezime.ForeColor = System.Drawing.Color.Red;
            this.lbObaveznoPrezime.Location = new System.Drawing.Point(155, 168);
            this.lbObaveznoPrezime.Name = "lbObaveznoPrezime";
            this.lbObaveznoPrezime.Size = new System.Drawing.Size(81, 13);
            this.lbObaveznoPrezime.TabIndex = 75;
            this.lbObaveznoPrezime.Text = "Obavezno polje";
            this.lbObaveznoPrezime.Visible = false;
            // 
            // lbObaveznoPolje
            // 
            this.lbObaveznoPolje.AutoSize = true;
            this.lbObaveznoPolje.ForeColor = System.Drawing.Color.Red;
            this.lbObaveznoPolje.Location = new System.Drawing.Point(149, 116);
            this.lbObaveznoPolje.Name = "lbObaveznoPolje";
            this.lbObaveznoPolje.Size = new System.Drawing.Size(81, 13);
            this.lbObaveznoPolje.TabIndex = 74;
            this.lbObaveznoPolje.Text = "Obavezno polje";
            this.lbObaveznoPolje.Visible = false;
            // 
            // btnUkloni
            // 
            this.btnUkloni.Location = new System.Drawing.Point(589, 473);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(112, 44);
            this.btnUkloni.TabIndex = 73;
            this.btnUkloni.Text = "Ukloni";
            this.btnUkloni.UseVisualStyleBackColor = true;
            this.btnUkloni.Click += new System.EventHandler(this.btnUkloni_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(324, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 72;
            this.label7.Text = "Password Confrimation";
            // 
            // txtPasswordConfrirm
            // 
            this.txtPasswordConfrirm.Location = new System.Drawing.Point(327, 380);
            this.txtPasswordConfrirm.Name = "txtPasswordConfrirm";
            this.txtPasswordConfrirm.Size = new System.Drawing.Size(135, 20);
            this.txtPasswordConfrirm.TabIndex = 71;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 70;
            this.label6.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(152, 380);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(143, 20);
            this.txtPassword.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 68;
            this.label5.Text = "Korisnicko ime";
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(152, 328);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(320, 20);
            this.txtKorisnickoIme.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "Telefon";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(152, 249);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(320, 20);
            this.txtTelefon.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(152, 197);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(320, 20);
            this.txtEmail.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Prezime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Ime";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(152, 145);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(320, 20);
            this.txtPrezime.TabIndex = 60;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(152, 93);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(320, 20);
            this.txtIme.TabIndex = 59;
            // 
            // frmUklanjanjeKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 570);
            this.Controls.Add(this.cmbOdaberiKorisnika);
            this.Controls.Add(this.label9);
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
            this.Controls.Add(this.btnUkloni);
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
            this.Name = "frmUklanjanjeKorisnika";
            this.Text = "frmUklanjanjeKorisnika";
            this.Load += new System.EventHandler(this.frmUklanjanjeKorisnika_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOdaberiKorisnika;
        private System.Windows.Forms.Label label9;
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
        private System.Windows.Forms.Button btnUkloni;
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
    }
}