
namespace exploreMostar.WinUI.Sadržaj.Restorani
{
    partial class frmListaRestorana
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
            this.label5 = new System.Windows.Forms.Label();
            this.brojApar = new System.Windows.Forms.Label();
            this.cmbFilterByYear = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFilterByGrade = new System.Windows.Forms.ComboBox();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApartmani)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(469, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 21);
            this.comboBox1.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Sort";
            // 
            // brojApar
            // 
            this.brojApar.AutoSize = true;
            this.brojApar.Location = new System.Drawing.Point(127, 9);
            this.brojApar.Name = "brojApar";
            this.brojApar.Size = new System.Drawing.Size(0, 13);
            this.brojApar.TabIndex = 49;
            // 
            // cmbFilterByYear
            // 
            this.cmbFilterByYear.FormattingEnabled = true;
            this.cmbFilterByYear.Location = new System.Drawing.Point(118, 70);
            this.cmbFilterByYear.Name = "cmbFilterByYear";
            this.cmbFilterByYear.Size = new System.Drawing.Size(203, 21);
            this.cmbFilterByYear.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Ukupno restorana:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Filtriranje po godini";
            // 
            // cmbFilterByGrade
            // 
            this.cmbFilterByGrade.FormattingEnabled = true;
            this.cmbFilterByGrade.Location = new System.Drawing.Point(469, 30);
            this.cmbFilterByGrade.Name = "cmbFilterByGrade";
            this.cmbFilterByGrade.Size = new System.Drawing.Size(204, 21);
            this.cmbFilterByGrade.TabIndex = 45;
            this.cmbFilterByGrade.SelectedIndexChanged += new System.EventHandler(this.cmbFilterByGrade_SelectedIndexChanged);
            // 
            // Sortiraj
            // 
            this.Sortiraj.AutoSize = true;
            this.Sortiraj.Location = new System.Drawing.Point(369, 34);
            this.Sortiraj.Name = "Sortiraj";
            this.Sortiraj.Size = new System.Drawing.Size(94, 13);
            this.Sortiraj.TabIndex = 44;
            this.Sortiraj.Text = "Filtriranje po ocjeni";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Pretraga po nazivu";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(118, 31);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(203, 20);
            this.txtPretraga.TabIndex = 42;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPrikazi.Location = new System.Drawing.Point(748, 24);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(112, 50);
            this.btnPrikazi.TabIndex = 41;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvApartmani);
            this.groupBox1.Location = new System.Drawing.Point(19, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(844, 423);
            this.groupBox1.TabIndex = 40;
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
            this.label4.Location = new System.Drawing.Point(115, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 52;
            // 
            // frmListaRestorana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 530);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
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
            this.Name = "frmListaRestorana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListaRestorana";
            this.Load += new System.EventHandler(this.frmListaRestorana_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApartmani)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label brojApar;
        private System.Windows.Forms.ComboBox cmbFilterByYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFilterByGrade;
        private System.Windows.Forms.Label Sortiraj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvApartmani;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn RBr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lokacija;
        private System.Windows.Forms.DataGridViewTextBoxColumn GodinaIzgradnje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
    }
}