
namespace exploreMostar.WinUI.Sadržaj.Hoteli
{
    partial class frmListaHotela
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.Sortiraj = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvApartmani = new System.Windows.Forms.DataGridView();
            this.RBr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lokacija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GodinaIzgradnje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApartmani)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(118, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 21);
            this.comboBox1.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Ukupno hotela:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Sortiranje po godini";
            // 
            // cmbSort
            // 
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Location = new System.Drawing.Point(491, 75);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(148, 21);
            this.cmbSort.TabIndex = 31;
            // 
            // Sortiraj
            // 
            this.Sortiraj.AutoSize = true;
            this.Sortiraj.Location = new System.Drawing.Point(372, 34);
            this.Sortiraj.Name = "Sortiraj";
            this.Sortiraj.Size = new System.Drawing.Size(100, 13);
            this.Sortiraj.TabIndex = 30;
            this.Sortiraj.Text = "Sortiranje po nazivu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Pretraga po nazivu";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(118, 31);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(203, 20);
            this.txtPretraga.TabIndex = 28;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPrikazi.Location = new System.Drawing.Point(748, 24);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(112, 50);
            this.btnPrikazi.TabIndex = 27;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvApartmani);
            this.groupBox1.Location = new System.Drawing.Point(19, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(844, 423);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Korisnici";
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
            this.Ocjena});
            this.dgvApartmani.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvApartmani.Location = new System.Drawing.Point(3, 16);
            this.dgvApartmani.Name = "dgvApartmani";
            this.dgvApartmani.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApartmani.Size = new System.Drawing.Size(838, 404);
            this.dgvApartmani.TabIndex = 0;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Sortiranje po ocjeni";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(491, 30);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(148, 21);
            this.comboBox2.TabIndex = 37;
            // 
            // frmListaHotela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 530);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSort);
            this.Controls.Add(this.Sortiraj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmListaHotela";
            this.Text = "frmListaHotela";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApartmani)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.Label Sortiraj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvApartmani;
        private System.Windows.Forms.DataGridViewTextBoxColumn RBr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lokacija;
        private System.Windows.Forms.DataGridViewTextBoxColumn GodinaIzgradnje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}