
namespace exploreMostar.WinUI.Sadržaj.Apartmani
{
    partial class frmListaApartmana
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
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFilterByGrade = new System.Windows.Forms.ComboBox();
            this.Sortiraj = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvApartmani = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFilterByYear = new System.Windows.Forms.ComboBox();
            this.brojApar = new System.Windows.Forms.Label();
            this.RBr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lokacija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GodinaIzgradnje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategorija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dodatneopcije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApartmani)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Filtriranje po godini";
            // 
            // cmbFilterByGrade
            // 
            this.cmbFilterByGrade.FormattingEnabled = true;
            this.cmbFilterByGrade.Location = new System.Drawing.Point(471, 36);
            this.cmbFilterByGrade.Name = "cmbFilterByGrade";
            this.cmbFilterByGrade.Size = new System.Drawing.Size(204, 21);
            this.cmbFilterByGrade.TabIndex = 19;
            // 
            // Sortiraj
            // 
            this.Sortiraj.AutoSize = true;
            this.Sortiraj.Location = new System.Drawing.Point(371, 40);
            this.Sortiraj.Name = "Sortiraj";
            this.Sortiraj.Size = new System.Drawing.Size(94, 13);
            this.Sortiraj.TabIndex = 18;
            this.Sortiraj.Text = "Filtriranje po ocjeni";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Pretraga po nazivu";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(120, 37);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(203, 20);
            this.txtPretraga.TabIndex = 14;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPrikazi.Location = new System.Drawing.Point(750, 30);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(112, 50);
            this.btnPrikazi.TabIndex = 13;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvApartmani);
            this.groupBox1.Location = new System.Drawing.Point(21, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(844, 423);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Apartmani";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgvApartmani
            // 
            this.dgvApartmani.AllowDrop = true;
            this.dgvApartmani.AllowUserToOrderColumns = true;
            this.dgvApartmani.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApartmani.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RBr,
            this.Naziv,
            this.Lokacija,
            this.GodinaIzgradnje,
            this.Ocjena,
            this.Kategorija,
            this.Dodatneopcije});
            this.dgvApartmani.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvApartmani.Location = new System.Drawing.Point(3, 16);
            this.dgvApartmani.Name = "dgvApartmani";
            this.dgvApartmani.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApartmani.Size = new System.Drawing.Size(838, 404);
            this.dgvApartmani.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ukupno apartmana:";
            // 
            // cmbFilterByYear
            // 
            this.cmbFilterByYear.FormattingEnabled = true;
            this.cmbFilterByYear.Location = new System.Drawing.Point(120, 76);
            this.cmbFilterByYear.Name = "cmbFilterByYear";
            this.cmbFilterByYear.Size = new System.Drawing.Size(203, 21);
            this.cmbFilterByYear.TabIndex = 24;
            // 
            // brojApar
            // 
            this.brojApar.AutoSize = true;
            this.brojApar.Location = new System.Drawing.Point(128, 9);
            this.brojApar.Name = "brojApar";
            this.brojApar.Size = new System.Drawing.Size(0, 13);
            this.brojApar.TabIndex = 25;
            // 
            // RBr
            // 
            this.RBr.DataPropertyName = "RBr";
            this.RBr.HeaderText = "Redni Broj";
            this.RBr.Name = "RBr";
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            // 
            // Lokacija
            // 
            this.Lokacija.DataPropertyName = "Lokacija";
            this.Lokacija.HeaderText = "Lokacija";
            this.Lokacija.Name = "Lokacija";
            // 
            // GodinaIzgradnje
            // 
            this.GodinaIzgradnje.DataPropertyName = "GodinaIzgradnje";
            this.GodinaIzgradnje.HeaderText = "Godina Izgradnje";
            this.GodinaIzgradnje.Name = "GodinaIzgradnje";
            // 
            // Ocjena
            // 
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.Name = "Ocjena";
            // 
            // Kategorija
            // 
            this.Kategorija.HeaderText = "Kategorija";
            this.Kategorija.Name = "Kategorija";
            // 
            // Dodatneopcije
            // 
            this.Dodatneopcije.DataPropertyName = "DodatneOpcije";
            this.Dodatneopcije.HeaderText = "Dodatne opcije";
            this.Dodatneopcije.Name = "Dodatneopcije";
            // 
            // frmListaApartmana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 530);
            this.Controls.Add(this.brojApar);
            this.Controls.Add(this.cmbFilterByYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbFilterByGrade);
            this.Controls.Add(this.Sortiraj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmListaApartmana";
            this.Text = "frmListaApartmana";
            this.Load += new System.EventHandler(this.frmListaApartmana_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApartmani)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFilterByGrade;
        private System.Windows.Forms.Label Sortiraj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvApartmani;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFilterByYear;
        private System.Windows.Forms.Label brojApar;
        private System.Windows.Forms.DataGridViewTextBoxColumn RBr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lokacija;
        private System.Windows.Forms.DataGridViewTextBoxColumn GodinaIzgradnje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategorija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dodatneopcije;
    }
}