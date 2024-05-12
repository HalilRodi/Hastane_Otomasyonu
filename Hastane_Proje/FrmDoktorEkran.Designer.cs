namespace Hastane_Proje
{
    partial class FrmDoktorEkran
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblAdsoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblTc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCikis = new Guna.UI2.WinForms.Guna2Button();
            this.BtnClose = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.BtnGuncelle = new Guna.UI2.WinForms.Guna2Button();
            this.BtnRandevular = new Guna.UI2.WinForms.Guna2Button();
            this.BtnDetay = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.LblAdsoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LblTc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(412, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 247);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Bilgileri";
            // 
            // LblAdsoyad
            // 
            this.LblAdsoyad.AutoSize = true;
            this.LblAdsoyad.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAdsoyad.Location = new System.Drawing.Point(186, 51);
            this.LblAdsoyad.Name = "LblAdsoyad";
            this.LblAdsoyad.Size = new System.Drawing.Size(44, 23);
            this.LblAdsoyad.TabIndex = 11;
            this.LblAdsoyad.Text = "Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(74, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ad Soyad :";
            // 
            // LblTc
            // 
            this.LblTc.AutoSize = true;
            this.LblTc.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTc.ForeColor = System.Drawing.Color.Black;
            this.LblTc.Location = new System.Drawing.Point(186, 91);
            this.LblTc.Name = "LblTc";
            this.LblTc.Size = new System.Drawing.Size(120, 23);
            this.LblTc.TabIndex = 9;
            this.LblTc.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(32, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "TC Kimlik No :";
            // 
            // BtnCikis
            // 
            this.BtnCikis.BackColor = System.Drawing.Color.Transparent;
            this.BtnCikis.BorderRadius = 25;
            this.BtnCikis.CheckedState.Parent = this.BtnCikis;
            this.BtnCikis.CustomImages.Parent = this.BtnCikis;
            this.BtnCikis.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(43)))), ((int)(((byte)(49)))));
            this.BtnCikis.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnCikis.ForeColor = System.Drawing.Color.White;
            this.BtnCikis.HoverState.Parent = this.BtnCikis;
            this.BtnCikis.Location = new System.Drawing.Point(959, 498);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.ShadowDecoration.Parent = this.BtnCikis;
            this.BtnCikis.Size = new System.Drawing.Size(160, 48);
            this.BtnCikis.TabIndex = 25;
            this.BtnCikis.Text = "Çıkış Yap";
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.CheckedState.Parent = this.BtnClose;
            this.BtnClose.CustomImages.Parent = this.BtnClose;
            this.BtnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(43)))), ((int)(((byte)(49)))));
            this.BtnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.HoverState.Parent = this.BtnClose;
            this.BtnClose.Location = new System.Drawing.Point(1084, 4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.ShadowDecoration.Parent = this.BtnClose;
            this.BtnClose.Size = new System.Drawing.Size(43, 28);
            this.BtnClose.TabIndex = 24;
            this.BtnClose.Text = "X";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::Hastane_Proje.Properties.Resources._49057b6b_8776_46b5_ab74_174403ff5913;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(4, 4);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(151, 124);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 23;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuncelle.BorderRadius = 25;
            this.BtnGuncelle.CheckedState.Parent = this.BtnGuncelle;
            this.BtnGuncelle.CustomImages.Parent = this.BtnGuncelle;
            this.BtnGuncelle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnGuncelle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnGuncelle.ForeColor = System.Drawing.Color.Black;
            this.BtnGuncelle.HoverState.Parent = this.BtnGuncelle;
            this.BtnGuncelle.Location = new System.Drawing.Point(135, 357);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.ShadowDecoration.Parent = this.BtnGuncelle;
            this.BtnGuncelle.Size = new System.Drawing.Size(232, 55);
            this.BtnGuncelle.TabIndex = 22;
            this.BtnGuncelle.Text = "Bilgilerimi Güncelle";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnRandevular
            // 
            this.BtnRandevular.BackColor = System.Drawing.Color.Transparent;
            this.BtnRandevular.BorderRadius = 25;
            this.BtnRandevular.CheckedState.Parent = this.BtnRandevular;
            this.BtnRandevular.CustomImages.Parent = this.BtnRandevular;
            this.BtnRandevular.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnRandevular.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnRandevular.ForeColor = System.Drawing.Color.Black;
            this.BtnRandevular.HoverState.Parent = this.BtnRandevular;
            this.BtnRandevular.Location = new System.Drawing.Point(135, 278);
            this.BtnRandevular.Name = "BtnRandevular";
            this.BtnRandevular.ShadowDecoration.Parent = this.BtnRandevular;
            this.BtnRandevular.Size = new System.Drawing.Size(232, 55);
            this.BtnRandevular.TabIndex = 21;
            this.BtnRandevular.Text = "Randevularım";
            // 
            // BtnDetay
            // 
            this.BtnDetay.BackColor = System.Drawing.Color.Transparent;
            this.BtnDetay.BorderRadius = 25;
            this.BtnDetay.CheckedState.Parent = this.BtnDetay;
            this.BtnDetay.CustomImages.Parent = this.BtnDetay;
            this.BtnDetay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnDetay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnDetay.ForeColor = System.Drawing.Color.Black;
            this.BtnDetay.HoverState.Parent = this.BtnDetay;
            this.BtnDetay.Location = new System.Drawing.Point(135, 192);
            this.BtnDetay.Name = "BtnDetay";
            this.BtnDetay.ShadowDecoration.Parent = this.BtnDetay;
            this.BtnDetay.Size = new System.Drawing.Size(232, 55);
            this.BtnDetay.TabIndex = 27;
            this.BtnDetay.Text = "Muayene";
            this.BtnDetay.Click += new System.EventHandler(this.BtnDetay_Click);
            // 
            // FrmDoktorEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hastane_Proje.Properties.Resources.doktor_ana_ekran1;
            this.ClientSize = new System.Drawing.Size(1147, 611);
            this.Controls.Add(this.BtnDetay);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnCikis);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnRandevular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDoktorEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDoktorEkran";
            this.Load += new System.EventHandler(this.FrmDoktorEkran_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblAdsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblTc;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button BtnCikis;
        private Guna.UI2.WinForms.Guna2Button BtnClose;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Button BtnGuncelle;
        private Guna.UI2.WinForms.Guna2Button BtnRandevular;
        private Guna.UI2.WinForms.Guna2Button BtnDetay;
    }
}