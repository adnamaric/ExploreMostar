
namespace exploreMostar.WinUI.Korisnici
{
    partial class frmKorisniciDetalji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKorisniciDetalji));
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPasswordConfrirm = new System.Windows.Forms.TextBox();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.lbObaveznoPolje = new System.Windows.Forms.Label();
            this.lbObaveznoPrezime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbGradovi = new System.Windows.Forms.ComboBox();
            this.lbObaveznoP = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSlikaInput = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.lblImePrezime = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lbl123 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.circleButton1 = new exploreMostar.WinUI.CircleButton();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(31, 78);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(320, 20);
            this.txtIme.TabIndex = 0;
            this.txtIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtIme_Validating_1);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(31, 130);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(320, 20);
            this.txtPrezime.TabIndex = 1;
            this.txtPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrezime_Validating_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(31, 182);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(320, 20);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefon";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(31, 234);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(320, 20);
            this.txtTelefon.TabIndex = 7;
            this.txtTelefon.Validating += new System.ComponentModel.CancelEventHandler(this.txtTelefon_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Korisnicko ime";
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(31, 313);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(320, 20);
            this.txtKorisnickoIme.TabIndex = 9;
            this.txtKorisnickoIme.Leave += new System.EventHandler(this.txtKorisnickoIme_Leave);
            this.txtKorisnickoIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtKorisnickoIme_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(31, 365);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(143, 20);
            this.txtPassword.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Password Confrimation";
            // 
            // txtPasswordConfrirm
            // 
            this.txtPasswordConfrirm.Location = new System.Drawing.Point(206, 365);
            this.txtPasswordConfrirm.Name = "txtPasswordConfrirm";
            this.txtPasswordConfrirm.PasswordChar = '*';
            this.txtPasswordConfrirm.Size = new System.Drawing.Size(135, 20);
            this.txtPasswordConfrirm.TabIndex = 13;
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(487, 573);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(112, 44);
            this.btnSnimi.TabIndex = 15;
            this.btnSnimi.Text = "Sačuvaj";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // lbObaveznoPolje
            // 
            this.lbObaveznoPolje.AutoSize = true;
            this.lbObaveznoPolje.ForeColor = System.Drawing.Color.Red;
            this.lbObaveznoPolje.Location = new System.Drawing.Point(28, 101);
            this.lbObaveznoPolje.Name = "lbObaveznoPolje";
            this.lbObaveznoPolje.Size = new System.Drawing.Size(81, 13);
            this.lbObaveznoPolje.TabIndex = 17;
            this.lbObaveznoPolje.Text = "Obavezno polje";
            this.lbObaveznoPolje.Visible = false;
            // 
            // lbObaveznoPrezime
            // 
            this.lbObaveznoPrezime.AutoSize = true;
            this.lbObaveznoPrezime.ForeColor = System.Drawing.Color.Red;
            this.lbObaveznoPrezime.Location = new System.Drawing.Point(31, 153);
            this.lbObaveznoPrezime.Name = "lbObaveznoPrezime";
            this.lbObaveznoPrezime.Size = new System.Drawing.Size(81, 13);
            this.lbObaveznoPrezime.TabIndex = 18;
            this.lbObaveznoPrezime.Text = "Obavezno polje";
            this.lbObaveznoPrezime.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Grad";
            // 
            // cmbGradovi
            // 
            this.cmbGradovi.FormattingEnabled = true;
            this.cmbGradovi.Location = new System.Drawing.Point(31, 273);
            this.cmbGradovi.Name = "cmbGradovi";
            this.cmbGradovi.Size = new System.Drawing.Size(320, 21);
            this.cmbGradovi.TabIndex = 20;
            this.cmbGradovi.Text = "Odaberite grad";
            this.cmbGradovi.SelectedIndexChanged += new System.EventHandler(this.cmbGradovi_SelectedIndexChanged);
            this.cmbGradovi.Validating += new System.ComponentModel.CancelEventHandler(this.cmbGradovi_Validating);
            // 
            // lbObaveznoP
            // 
            this.lbObaveznoP.AutoSize = true;
            this.lbObaveznoP.ForeColor = System.Drawing.Color.Red;
            this.lbObaveznoP.Location = new System.Drawing.Point(31, 205);
            this.lbObaveznoP.Name = "lbObaveznoP";
            this.lbObaveznoP.Size = new System.Drawing.Size(81, 13);
            this.lbObaveznoP.TabIndex = 21;
            this.lbObaveznoP.Text = "Obavezno polje";
            this.lbObaveznoP.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(28, 336);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Obavezno polje";
            this.label10.Visible = false;
            // 
            // txtSlikaInput
            // 
            this.txtSlikaInput.Location = new System.Drawing.Point(31, 405);
            this.txtSlikaInput.Name = "txtSlikaInput";
            this.txtSlikaInput.Size = new System.Drawing.Size(320, 20);
            this.txtSlikaInput.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 388);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Slika";
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Location = new System.Drawing.Point(367, 404);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(59, 20);
            this.btnDodajSliku.TabIndex = 26;
            this.btnDodajSliku.Text = "Dodaj";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click_1);
            // 
            // lblImePrezime
            // 
            this.lblImePrezime.AutoSize = true;
            this.lblImePrezime.Location = new System.Drawing.Point(454, 155);
            this.lblImePrezime.Name = "lblImePrezime";
            this.lblImePrezime.Size = new System.Drawing.Size(0, 13);
            this.lblImePrezime.TabIndex = 27;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(421, 573);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 44);
            this.button1.TabIndex = 28;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 429);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Uloge:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(34, 445);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(317, 94);
            this.checkedListBox1.TabIndex = 31;
            // 
            // lbl123
            // 
            this.lbl123.AutoSize = true;
            this.lbl123.ForeColor = System.Drawing.Color.Red;
            this.lbl123.Location = new System.Drawing.Point(357, 237);
            this.lbl123.Name = "lbl123";
            this.lbl123.Size = new System.Drawing.Size(81, 13);
            this.lbl123.TabIndex = 32;
            this.lbl123.Text = "Obavezno polje";
            this.lbl123.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(357, 316);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(225, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Korisnik sa tim korisnickim imenom vec postoji!";
            this.label12.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(357, 276);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Obavezno polje";
            this.label13.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(37, 552);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Datum rodjenja";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(34, 573);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(317, 20);
            this.dateTimePicker1.TabIndex = 36;
            // 
            // circleButton1
            // 
            this.circleButton1.BackColor = System.Drawing.Color.White;
            this.circleButton1.FlatAppearance.BorderSize = 0;
            this.circleButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circleButton1.Location = new System.Drawing.Point(418, 22);
            this.circleButton1.Name = "circleButton1";
            this.circleButton1.Size = new System.Drawing.Size(131, 130);
            this.circleButton1.TabIndex = 23;
            this.circleButton1.UseVisualStyleBackColor = false;
            this.circleButton1.Click += new System.EventHandler(this.circleButton1_Click);
            // 
            // frmKorisniciDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 629);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbl123);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
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
            this.Name = "frmKorisniciDetalji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmKorisniciDetalji";
            this.Load += new System.EventHandler(this.frmKorisniciDetalji_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPasswordConfrirm;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.Label lbObaveznoPolje;
        private System.Windows.Forms.Label lbObaveznoPrezime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbGradovi;
        private System.Windows.Forms.Label lblImePrezime;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSlikaInput;
        private CircleButton circleButton1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbObaveznoP;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label lbl123;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}