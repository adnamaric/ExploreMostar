
namespace exploreMostar.WinUI.Korisnici
{
    partial class frmOduzimanjePermisija
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
            this.circleButton1 = new exploreMostar.WinUI.CircleButton();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSlikaInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbOdaberiKorisnika
            // 
            this.cmbOdaberiKorisnika.FormattingEnabled = true;
            this.cmbOdaberiKorisnika.Location = new System.Drawing.Point(118, 17);
            this.cmbOdaberiKorisnika.Name = "cmbOdaberiKorisnika";
            this.cmbOdaberiKorisnika.Size = new System.Drawing.Size(255, 21);
            this.cmbOdaberiKorisnika.TabIndex = 87;
            this.cmbOdaberiKorisnika.SelectedIndexChanged += new System.EventHandler(this.cmbOdaberiKorisnika_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 86;
            this.label9.Text = "Odaberi korisnika";
            // 
            // circleButton1
            // 
            this.circleButton1.BackColor = System.Drawing.Color.White;
            this.circleButton1.FlatAppearance.BorderSize = 0;
            this.circleButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circleButton1.Location = new System.Drawing.Point(415, 12);
            this.circleButton1.Name = "circleButton1";
            this.circleButton1.Size = new System.Drawing.Size(134, 130);
            this.circleButton1.TabIndex = 82;
            this.circleButton1.UseVisualStyleBackColor = false;
            // 
            // btnSnimi
            // 
            this.btnSnimi.BackColor = System.Drawing.Color.DarkRed;
            this.btnSnimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnimi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSnimi.Location = new System.Drawing.Point(401, 348);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(163, 57);
            this.btnSnimi.TabIndex = 75;
            this.btnSnimi.Text = "Oduzmi permisije";
            this.btnSnimi.UseVisualStyleBackColor = false;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 70;
            this.label5.Text = "Korisnicko ime";
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(16, 181);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(320, 20);
            this.txtKorisnickoIme.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Prezime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Ime";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(16, 130);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(320, 20);
            this.txtPrezime.TabIndex = 62;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(16, 78);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(320, 20);
            this.txtIme.TabIndex = 61;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(16, 243);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(320, 88);
            this.richTextBox1.TabIndex = 88;
            this.richTextBox1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 89;
            this.label3.Text = "Razlog:";
            // 
            // txtSlikaInput
            // 
            this.txtSlikaInput.Location = new System.Drawing.Point(16, 348);
            this.txtSlikaInput.Name = "txtSlikaInput";
            this.txtSlikaInput.Size = new System.Drawing.Size(320, 20);
            this.txtSlikaInput.TabIndex = 90;
            this.txtSlikaInput.Visible = false;
            // 
            // frmOduzimanjePermisija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 417);
            this.Controls.Add(this.txtSlikaInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.cmbOdaberiKorisnika);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.circleButton1);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Name = "frmOduzimanjePermisija";
            this.Text = "OduzimanjePermisija";
            this.Load += new System.EventHandler(this.OduzimanjePermisija_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOdaberiKorisnika;
        private System.Windows.Forms.Label label9;
        private CircleButton circleButton1;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSlikaInput;
    }
}