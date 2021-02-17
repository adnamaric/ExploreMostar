
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbBazenOff = new System.Windows.Forms.RadioButton();
            this.rbBazenOn = new System.Windows.Forms.RadioButton();
            this.rp2 = new System.Windows.Forms.RadioButton();
            this.rp1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.label4.Location = new System.Drawing.Point(13, 176);
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
            this.rb_on.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.rb_on.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.rb_on.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_on.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_on.Location = new System.Drawing.Point(450, 357);
            this.rb_on.Name = "rb_on";
            this.rb_on.Size = new System.Drawing.Size(13, 12);
            this.rb_on.TabIndex = 17;
            this.rb_on.TabStop = true;
            this.rb_on.UseVisualStyleBackColor = true;
            // 
            // rb_off
            // 
            this.rb_off.AutoSize = true;
            this.rb_off.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_off.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.rb_off.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.rb_off.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_off.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_off.Location = new System.Drawing.Point(483, 357);
            this.rb_off.Name = "rb_off";
            this.rb_off.Size = new System.Drawing.Size(13, 12);
            this.rb_off.TabIndex = 18;
            this.rb_off.TabStop = true;
            this.rb_off.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(16, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 176);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodatne opcije";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(108, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 29);
            this.button2.TabIndex = 30;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(72, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 29);
            this.button1.TabIndex = 29;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(191, 38);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 20);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Parking";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Bazen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Wifi";
            // 
            // rbBazenOff
            // 
            this.rbBazenOff.AutoSize = true;
            this.rbBazenOff.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbBazenOff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.rbBazenOff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.rbBazenOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbBazenOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBazenOff.Location = new System.Drawing.Point(483, 391);
            this.rbBazenOff.Name = "rbBazenOff";
            this.rbBazenOff.Size = new System.Drawing.Size(13, 12);
            this.rbBazenOff.TabIndex = 26;
            this.rbBazenOff.TabStop = true;
            this.rbBazenOff.UseVisualStyleBackColor = true;
            // 
            // rbBazenOn
            // 
            this.rbBazenOn.AutoSize = true;
            this.rbBazenOn.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbBazenOn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.rbBazenOn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.rbBazenOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbBazenOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBazenOn.Location = new System.Drawing.Point(450, 391);
            this.rbBazenOn.Name = "rbBazenOn";
            this.rbBazenOn.Size = new System.Drawing.Size(13, 12);
            this.rbBazenOn.TabIndex = 25;
            this.rbBazenOn.TabStop = true;
            this.rbBazenOn.UseVisualStyleBackColor = true;
            // 
            // rp2
            // 
            this.rp2.AutoSize = true;
            this.rp2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rp2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.rp2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.rp2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rp2.Location = new System.Drawing.Point(483, 428);
            this.rp2.Name = "rp2";
            this.rp2.Size = new System.Drawing.Size(13, 12);
            this.rp2.TabIndex = 28;
            this.rp2.TabStop = true;
            this.rp2.UseVisualStyleBackColor = true;
            // 
            // rp1
            // 
            this.rp1.AutoSize = true;
            this.rp1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rp1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.rp1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.rp1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rp1.Location = new System.Drawing.Point(450, 428);
            this.rp1.Name = "rp1";
            this.rp1.Size = new System.Drawing.Size(13, 12);
            this.rp1.TabIndex = 27;
            this.rp1.TabStop = true;
            this.rp1.UseVisualStyleBackColor = true;
            // 
            // frmApartmaniAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 586);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rp2);
            this.Controls.Add(this.rp1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.rbBazenOff);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbBazenOn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDodajSliku);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rb_off);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.rb_on);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbBazenOff;
        private System.Windows.Forms.RadioButton rbBazenOn;
        private System.Windows.Forms.RadioButton rp2;
        private System.Windows.Forms.RadioButton rp1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}