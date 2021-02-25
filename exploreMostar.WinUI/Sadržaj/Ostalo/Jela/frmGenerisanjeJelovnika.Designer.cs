
namespace exploreMostar.WinUI.Sadržaj.Ostalo.Jela
{
    partial class frmGenerisanjeJelovnika
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRestorani = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBrojJela = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.Sačuvaj = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.jela = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Odaberite restoran:";
            // 
            // cmbRestorani
            // 
            this.cmbRestorani.FormattingEnabled = true;
            this.cmbRestorani.Location = new System.Drawing.Point(131, 21);
            this.cmbRestorani.Name = "cmbRestorani";
            this.cmbRestorani.Size = new System.Drawing.Size(270, 21);
            this.cmbRestorani.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Naziv";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(270, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Broj jela na jelovniku:";
            // 
            // cmbBrojJela
            // 
            this.cmbBrojJela.FormattingEnabled = true;
            this.cmbBrojJela.Location = new System.Drawing.Point(131, 99);
            this.cmbBrojJela.Name = "cmbBrojJela";
            this.cmbBrojJela.Size = new System.Drawing.Size(270, 21);
            this.cmbBrojJela.TabIndex = 6;
            this.cmbBrojJela.SelectedIndexChanged += new System.EventHandler(this.cmbBrojJela_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Odaberite jela:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(131, 238);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(270, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Datum kreiranja:";
            // 
            // Sačuvaj
            // 
            this.Sačuvaj.Location = new System.Drawing.Point(428, 239);
            this.Sačuvaj.Name = "Sačuvaj";
            this.Sačuvaj.Size = new System.Drawing.Size(109, 55);
            this.Sačuvaj.TabIndex = 11;
            this.Sačuvaj.Text = "Sačuvaj";
            this.Sačuvaj.UseVisualStyleBackColor = true;
            this.Sačuvaj.Click += new System.EventHandler(this.Sačuvaj_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(131, 136);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(270, 82);
            this.listBox1.TabIndex = 12;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            this.listBox1.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.listBox1_MeasureItem);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            this.listBox1.ForeColorChanged += new System.EventHandler(this.listBox1_ForeColorChanged);
            // 
            // jela
            // 
            this.jela.Location = new System.Drawing.Point(407, 136);
            this.jela.Name = "jela";
            this.jela.Size = new System.Drawing.Size(136, 82);
            this.jela.TabIndex = 13;
            this.jela.Text = "";
            this.jela.Visible = false;
            // 
            // frmGenerisanjeJelovnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(555, 306);
            this.Controls.Add(this.jela);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Sačuvaj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbBrojJela);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbRestorani);
            this.Controls.Add(this.label1);
            this.Name = "frmGenerisanjeJelovnika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGenerisanjeJelovnika";
            this.Load += new System.EventHandler(this.frmGenerisanjeJelovnika_Load);
            this.BackColorChanged += new System.EventHandler(this.frmGenerisanjeJelovnika_BackColorChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRestorani;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBrojJela;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Sačuvaj;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox jela;
    }
}