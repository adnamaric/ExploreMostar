
namespace exploreMostar.WinUI.Objava
{
    partial class frmObjavaAdd
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
            this.btnSlika = new System.Windows.Forms.Button();
            this.txtNazivA = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.Label();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSlikaInput = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSlika
            // 
            this.btnSlika.Location = new System.Drawing.Point(348, 12);
            this.btnSlika.Name = "btnSlika";
            this.btnSlika.Size = new System.Drawing.Size(236, 198);
            this.btnSlika.TabIndex = 47;
            this.btnSlika.UseVisualStyleBackColor = true;
            // 
            // txtNazivA
            // 
            this.txtNazivA.Location = new System.Drawing.Point(12, 69);
            this.txtNazivA.Name = "txtNazivA";
            this.txtNazivA.Size = new System.Drawing.Size(239, 20);
            this.txtNazivA.TabIndex = 41;
            // 
            // txtNaziv
            // 
            this.txtNaziv.AutoSize = true;
            this.txtNaziv.Location = new System.Drawing.Point(13, 39);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(34, 13);
            this.txtNaziv.TabIndex = 40;
            this.txtNaziv.Text = "Naziv";
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Location = new System.Drawing.Point(269, 136);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(50, 30);
            this.btnDodajSliku.TabIndex = 42;
            this.btnDodajSliku.Text = "Dodaj";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Slika";
            // 
            // txtSlikaInput
            // 
            this.txtSlikaInput.Location = new System.Drawing.Point(16, 142);
            this.txtSlikaInput.Name = "txtSlikaInput";
            this.txtSlikaInput.Size = new System.Drawing.Size(235, 20);
            this.txtSlikaInput.TabIndex = 46;
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(12, 241);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(572, 168);
            this.txtOpis.TabIndex = 58;
            this.txtOpis.Text = "";
            this.txtOpis.TextChanged += new System.EventHandler(this.txtOpis_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Sadržaj";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSnimi
            // 
            this.btnSnimi.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSnimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnimi.ForeColor = System.Drawing.Color.White;
            this.btnSnimi.Location = new System.Drawing.Point(464, 431);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(120, 59);
            this.btnSnimi.TabIndex = 59;
            this.btnSnimi.Text = "Sačuvaj";
            this.btnSnimi.UseVisualStyleBackColor = false;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // frmObjavaAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 502);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSlika);
            this.Controls.Add(this.txtSlikaInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDodajSliku);
            this.Controls.Add(this.txtNazivA);
            this.Controls.Add(this.txtNaziv);
            this.Name = "frmObjavaAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmObjavaAdd";
            this.Load += new System.EventHandler(this.frmObjavaAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSlika;
        private System.Windows.Forms.TextBox txtNazivA;
        private System.Windows.Forms.Label txtNaziv;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSlikaInput;
        private System.Windows.Forms.RichTextBox txtOpis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSnimi;
    }
}