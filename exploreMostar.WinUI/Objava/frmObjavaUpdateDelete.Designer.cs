﻿
namespace exploreMostar.WinUI.Objava
{
    partial class frmObjavaUpdateDelete
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
            this.btnSnimi = new System.Windows.Forms.Button();
            this.txtOpis = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSlika = new System.Windows.Forms.Button();
            this.txtSlikaInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.txtNazivA = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbOdabirApartmana = new System.Windows.Forms.ComboBox();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnSnimi
            // 
            this.btnSnimi.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSnimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnimi.ForeColor = System.Drawing.Color.White;
            this.btnSnimi.Location = new System.Drawing.Point(507, 526);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(120, 59);
            this.btnSnimi.TabIndex = 68;
            this.btnSnimi.Text = "Sačuvaj";
            this.btnSnimi.UseVisualStyleBackColor = false;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(32, 308);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(595, 168);
            this.txtOpis.TabIndex = 67;
            this.txtOpis.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 66;
            this.label5.Text = "Sadržaj";
            // 
            // btnSlika
            // 
            this.btnSlika.Location = new System.Drawing.Point(382, 77);
            this.btnSlika.Name = "btnSlika";
            this.btnSlika.Size = new System.Drawing.Size(236, 183);
            this.btnSlika.TabIndex = 65;
            this.btnSlika.UseVisualStyleBackColor = true;
            // 
            // txtSlikaInput
            // 
            this.txtSlikaInput.Location = new System.Drawing.Point(32, 236);
            this.txtSlikaInput.Name = "txtSlikaInput";
            this.txtSlikaInput.Size = new System.Drawing.Size(235, 20);
            this.txtSlikaInput.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Slika";
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Location = new System.Drawing.Point(283, 230);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(50, 30);
            this.btnDodajSliku.TabIndex = 62;
            this.btnDodajSliku.Text = "Dodaj";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click);
            // 
            // txtNazivA
            // 
            this.txtNazivA.Location = new System.Drawing.Point(32, 92);
            this.txtNazivA.Name = "txtNazivA";
            this.txtNazivA.Size = new System.Drawing.Size(235, 20);
            this.txtNazivA.TabIndex = 61;
            // 
            // txtNaziv
            // 
            this.txtNaziv.AutoSize = true;
            this.txtNaziv.Location = new System.Drawing.Point(33, 76);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(34, 13);
            this.txtNaziv.TabIndex = 60;
            this.txtNaziv.Text = "Naziv";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 70;
            this.label11.Text = "Odaberite objavu:";
            // 
            // cmbOdabirApartmana
            // 
            this.cmbOdabirApartmana.FormattingEnabled = true;
            this.cmbOdabirApartmana.Location = new System.Drawing.Point(109, 30);
            this.cmbOdabirApartmana.Name = "cmbOdabirApartmana";
            this.cmbOdabirApartmana.Size = new System.Drawing.Size(238, 21);
            this.cmbOdabirApartmana.TabIndex = 69;
            this.cmbOdabirApartmana.SelectedIndexChanged += new System.EventHandler(this.cmbOdabirApartmana_SelectedIndexChanged);
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(32, 142);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(235, 20);
            this.txtDatum.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "Datum";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(32, 187);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(235, 20);
            this.txtAutor.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = "Autor";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmObjavaUpdateDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 597);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbOdabirApartmana);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSlika);
            this.Controls.Add(this.txtSlikaInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDodajSliku);
            this.Controls.Add(this.txtNazivA);
            this.Controls.Add(this.txtNaziv);
            this.Name = "frmObjavaUpdateDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmObjavaUpdateDelete";
            this.Load += new System.EventHandler(this.frmObjavaUpdateDelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.RichTextBox txtOpis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSlika;
        private System.Windows.Forms.TextBox txtSlikaInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.TextBox txtNazivA;
        private System.Windows.Forms.Label txtNaziv;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbOdabirApartmana;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}