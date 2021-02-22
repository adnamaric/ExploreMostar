
namespace exploreMostar.WinUI.Sadržaj.Ostalo.Drzave
{
    partial class frmDrzaveAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDrzaveAdd));
            this.button5 = new System.Windows.Forms.Button();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.txtNazivA = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtSlikaInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.btnSlika = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(358, 192);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(66, 44);
            this.button5.TabIndex = 93;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btnSnimi
            // 
            this.btnSnimi.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSnimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnimi.ForeColor = System.Drawing.Color.White;
            this.btnSnimi.Location = new System.Drawing.Point(430, 192);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(132, 43);
            this.btnSnimi.TabIndex = 92;
            this.btnSnimi.Text = "Sačuvaj";
            this.btnSnimi.UseVisualStyleBackColor = false;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // txtNazivA
            // 
            this.txtNazivA.Location = new System.Drawing.Point(323, 31);
            this.txtNazivA.Name = "txtNazivA";
            this.txtNazivA.Size = new System.Drawing.Size(239, 20);
            this.txtNazivA.TabIndex = 89;
            // 
            // txtNaziv
            // 
            this.txtNaziv.AutoSize = true;
            this.txtNaziv.Location = new System.Drawing.Point(247, 34);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(34, 13);
            this.txtNaziv.TabIndex = 88;
            this.txtNaziv.Text = "Naziv";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 94;
            this.label1.Text = "Oznaka";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(323, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 20);
            this.textBox1.TabIndex = 95;
            // 
            // txtSlikaInput
            // 
            this.txtSlikaInput.Location = new System.Drawing.Point(323, 105);
            this.txtSlikaInput.Name = "txtSlikaInput";
            this.txtSlikaInput.Size = new System.Drawing.Size(239, 20);
            this.txtSlikaInput.TabIndex = 98;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 97;
            this.label4.Text = "Slika";
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Location = new System.Drawing.Point(512, 131);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(50, 27);
            this.btnDodajSliku.TabIndex = 96;
            this.btnDodajSliku.Text = "Dodaj";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click);
            // 
            // btnSlika
            // 
            this.btnSlika.Location = new System.Drawing.Point(12, 12);
            this.btnSlika.Name = "btnSlika";
            this.btnSlika.Size = new System.Drawing.Size(215, 122);
            this.btnSlika.TabIndex = 99;
            this.btnSlika.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmDrzaveAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 268);
            this.Controls.Add(this.btnSlika);
            this.Controls.Add(this.txtSlikaInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDodajSliku);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.txtNazivA);
            this.Controls.Add(this.txtNaziv);
            this.Name = "frmDrzaveAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDrzaveAdd";
            this.Load += new System.EventHandler(this.frmDrzaveAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.TextBox txtNazivA;
        private System.Windows.Forms.Label txtNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtSlikaInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.Button btnSlika;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}