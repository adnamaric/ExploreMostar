
namespace exploreMostar.WinUI.Kategorije
{
    partial class frmKategorijeAdd
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
            this.lbObaveznoPrezime = new System.Windows.Forms.Label();
            this.lbObaveznoPolje = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.sadrzaj = new System.Windows.Forms.RichTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(335, 319);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(103, 54);
            this.btnSnimi.TabIndex = 29;
            this.btnSnimi.Text = "Sačuvaj";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // lbObaveznoPrezime
            // 
            this.lbObaveznoPrezime.AutoSize = true;
            this.lbObaveznoPrezime.ForeColor = System.Drawing.Color.Red;
            this.lbObaveznoPrezime.Location = new System.Drawing.Point(12, 129);
            this.lbObaveznoPrezime.Name = "lbObaveznoPrezime";
            this.lbObaveznoPrezime.Size = new System.Drawing.Size(81, 13);
            this.lbObaveznoPrezime.TabIndex = 36;
            this.lbObaveznoPrezime.Text = "Obavezno polje";
            this.lbObaveznoPrezime.Visible = false;
            // 
            // lbObaveznoPolje
            // 
            this.lbObaveznoPolje.AutoSize = true;
            this.lbObaveznoPolje.ForeColor = System.Drawing.Color.Red;
            this.lbObaveznoPolje.Location = new System.Drawing.Point(12, 70);
            this.lbObaveznoPolje.Name = "lbObaveznoPolje";
            this.lbObaveznoPolje.Size = new System.Drawing.Size(81, 13);
            this.lbObaveznoPolje.TabIndex = 35;
            this.lbObaveznoPolje.Text = "Obavezno polje";
            this.lbObaveznoPolje.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Opis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Naziv";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(13, 106);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(320, 20);
            this.txtPrezime.TabIndex = 32;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(12, 47);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(320, 20);
            this.txtIme.TabIndex = 31;
            this.txtIme.Leave += new System.EventHandler(this.txtIme_Leave);
            // 
            // sadrzaj
            // 
            this.sadrzaj.Location = new System.Drawing.Point(302, 177);
            this.sadrzaj.Name = "sadrzaj";
            this.sadrzaj.Size = new System.Drawing.Size(136, 108);
            this.sadrzaj.TabIndex = 40;
            this.sadrzaj.Text = "";
            this.sadrzaj.Visible = false;
            this.sadrzaj.TextChanged += new System.EventHandler(this.sadrzaj_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 177);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(281, 108);
            this.listBox1.TabIndex = 39;
            this.listBox1.ValueMemberChanged += new System.EventHandler(this.listBox1_ValueMemberChanged);
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Odaberite sadržaj:";
            // 
            // frmKategorijeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 385);
            this.Controls.Add(this.sadrzaj);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbObaveznoPrezime);
            this.Controls.Add(this.lbObaveznoPolje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.btnSnimi);
            this.Name = "frmKategorijeAdd";
            this.Text = "frmKategorijeAdd";
            this.Load += new System.EventHandler(this.frmKategorijeAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.Label lbObaveznoPrezime;
        private System.Windows.Forms.Label lbObaveznoPolje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.RichTextBox sadrzaj;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
    }
}