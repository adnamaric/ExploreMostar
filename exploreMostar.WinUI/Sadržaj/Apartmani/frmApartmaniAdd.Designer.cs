
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmApartmaniAdd));
            this.button1 = new System.Windows.Forms.Button();
            this.lblImePrezime = new System.Windows.Forms.Label();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGodina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLokacija = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOcjena = new System.Windows.Forms.TextBox();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(440, 552);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 44);
            this.button1.TabIndex = 55;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblImePrezime
            // 
            this.lblImePrezime.AutoSize = true;
            this.lblImePrezime.Location = new System.Drawing.Point(499, 161);
            this.lblImePrezime.Name = "lblImePrezime";
            this.lblImePrezime.Size = new System.Drawing.Size(0, 13);
            this.lblImePrezime.TabIndex = 54;
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(429, 402);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(140, 53);
            this.btnSnimi.TabIndex = 43;
            this.btnSnimi.Text = "Sačuvaj";
            this.btnSnimi.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Godina Izgradnje";
            // 
            // txtGodina
            // 
            this.txtGodina.Location = new System.Drawing.Point(47, 289);
            this.txtGodina.Name = "txtGodina";
            this.txtGodina.Size = new System.Drawing.Size(320, 20);
            this.txtGodina.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Lokacija";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Naziv";
            // 
            // txtLokacija
            // 
            this.txtLokacija.Location = new System.Drawing.Point(47, 237);
            this.txtLokacija.Name = "txtLokacija";
            this.txtLokacija.Size = new System.Drawing.Size(320, 20);
            this.txtLokacija.TabIndex = 30;
            this.txtLokacija.TextChanged += new System.EventHandler(this.txtLokacija_TextChanged);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(47, 185);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(320, 20);
            this.txtNaziv.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(47, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 141);
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Ocjena";
            // 
            // txtOcjena
            // 
            this.txtOcjena.Location = new System.Drawing.Point(47, 341);
            this.txtOcjena.Name = "txtOcjena";
            this.txtOcjena.Size = new System.Drawing.Size(320, 20);
            this.txtOcjena.TabIndex = 58;
            // 
            // txtLat
            // 
            this.txtLat.Location = new System.Drawing.Point(440, 237);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(100, 20);
            this.txtLat.TabIndex = 59;
            // 
            // txtLong
            // 
            this.txtLong.Location = new System.Drawing.Point(440, 275);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(100, 20);
            this.txtLong.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(437, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "Lat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(437, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "Long";
            // 
            // gMapControl1
            // 
            //this.gMapControl1.Bearing = 0F;
            //this.gMapControl1.CanDragMap = true;
            //this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            //this.gMapControl1.GrayScaleMode = false;
            //this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            //this.gMapControl1.LevelsKeepInMemmory = 5;
            //this.gMapControl1.Location = new System.Drawing.Point(429, 22);
            //this.gMapControl1.MarkersEnabled = true;
            //this.gMapControl1.MaxZoom = 2;
            //this.gMapControl1.MinZoom = 2;
            //this.gMapControl1.MouseWheelZoomEnabled = true;
            //this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            //this.gMapControl1.Name = "gMapControl1";
            //this.gMapControl1.NegativeMode = false;
            //this.gMapControl1.PolygonsEnabled = true;
            //this.gMapControl1.RetryLoadTile = 0;
            //this.gMapControl1.RoutesEnabled = true;
            //this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            //this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            //this.gMapControl1.ShowTileGridLines = false;
            //this.gMapControl1.Size = new System.Drawing.Size(206, 141);
            //this.gMapControl1.TabIndex = 64;
            //this.gMapControl1.Zoom = 0D;
            // 
            // frmApartmaniAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 487);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLong);
            this.Controls.Add(this.txtLat);
            this.Controls.Add(this.txtOcjena);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblImePrezime);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGodina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLokacija);
            this.Controls.Add(this.txtNaziv);
            this.Name = "frmApartmaniAdd";
            this.Text = "frmApartmaniAdd";
            this.Load += new System.EventHandler(this.frmApartmaniAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblImePrezime;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGodina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLokacija;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOcjena;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
    }
}