
namespace exploreMostar.WinUI.Sadržaj.Apartmani
{
    partial class frmApartmaniAdd
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
            this.Sadrzaj = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLok = new System.Windows.Forms.TextBox();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rb_on = new System.Windows.Forms.RadioButton();
            this.rb_off = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Sadrzaj
            // 
            this.Sadrzaj.AutoSize = true;
            this.Sadrzaj.Location = new System.Drawing.Point(12, 51);
            this.Sadrzaj.Name = "Sadrzaj";
            this.Sadrzaj.Size = new System.Drawing.Size(47, 13);
            this.Sadrzaj.TabIndex = 0;
            this.Sadrzaj.Text = "Lokacija";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lat";
            // 
            // txtLok
            // 
            this.txtLok.Location = new System.Drawing.Point(88, 48);
            this.txtLok.Name = "txtLok";
            this.txtLok.Size = new System.Drawing.Size(286, 20);
            this.txtLok.TabIndex = 2;
            this.txtLok.AcceptsTabChanged += new System.EventHandler(this.txtLok_AcceptsTabChanged);
            this.txtLok.ModifiedChanged += new System.EventHandler(this.txtLok_ModifiedChanged);
            this.txtLok.LocationChanged += new System.EventHandler(this.txtLok_LocationChanged);
            this.txtLok.TextChanged += new System.EventHandler(this.txtLok_TextChanged);
            this.txtLok.Leave += new System.EventHandler(this.txtLok_Leave);
            this.txtLok.ImeModeChanged += new System.EventHandler(this.txtLok_ImeModeChanged);
            // 
            // txtLat
            // 
            this.txtLat.Location = new System.Drawing.Point(88, 77);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(286, 20);
            this.txtLat.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Long";
            // 
            // txtLong
            // 
            this.txtLong.Location = new System.Drawing.Point(88, 111);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(286, 20);
            this.txtLong.TabIndex = 5;
            // 
            // txtNaziv
            // 
            this.txtNaziv.AutoSize = true;
            this.txtNaziv.Location = new System.Drawing.Point(12, 17);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(34, 13);
            this.txtNaziv.TabIndex = 7;
            this.txtNaziv.Text = "Naziv";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(286, 20);
            this.textBox1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(460, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 178);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Location = new System.Drawing.Point(460, 204);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(223, 43);
            this.btnDodajSliku.TabIndex = 10;
            this.btnDodajSliku.Text = "Dodaj";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Rating";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(88, 145);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(286, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Slika";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(88, 176);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(286, 20);
            this.textBox2.TabIndex = 14;
            // 
            // rb_on
            // 
            this.rb_on.AutoSize = true;
            this.rb_on.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_on.FlatAppearance.BorderSize = 0;
            this.rb_on.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.rb_on.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.rb_on.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.rb_on.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_on.Location = new System.Drawing.Point(219, 267);
            this.rb_on.Name = "rb_on";
            this.rb_on.Size = new System.Drawing.Size(14, 13);
            this.rb_on.TabIndex = 17;
            this.rb_on.TabStop = true;
            this.rb_on.UseVisualStyleBackColor = true;
            this.rb_on.Click += new System.EventHandler(this.rb_on_Click);
            // 
            // rb_off
            // 
            this.rb_off.AutoSize = true;
            this.rb_off.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_off.FlatAppearance.BorderSize = 0;
            this.rb_off.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.rb_off.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.rb_off.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.rb_off.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_off.Location = new System.Drawing.Point(252, 267);
            this.rb_off.Name = "rb_off";
            this.rb_off.Size = new System.Drawing.Size(14, 13);
            this.rb_off.TabIndex = 18;
            this.rb_off.TabStop = true;
            this.rb_off.UseVisualStyleBackColor = true;
            this.rb_off.Click += new System.EventHandler(this.rb_off_Click);
            // 
            // frmApartmaniAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 586);
            this.Controls.Add(this.rb_on);
            this.Controls.Add(this.rb_off);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDodajSliku);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.txtLong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLat);
            this.Controls.Add(this.txtLok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Sadrzaj);
            this.Name = "frmApartmaniAdd";
            this.Text = "frmApartmaniAdd";
            this.Load += new System.EventHandler(this.frmApartmaniAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Sadrzaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLok;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.Label txtNaziv;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton rb_on;
        private System.Windows.Forms.RadioButton rb_off;
    }
}