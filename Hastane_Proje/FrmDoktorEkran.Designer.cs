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
            this.BtnMuayene = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.LblAdsoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LblTc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.groupBox1.Location = new System.Drawing.Point(635, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 167);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Bilgileri";
            // 
            // LblAdsoyad
            // 
            this.LblAdsoyad.AutoSize = true;
            this.LblAdsoyad.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAdsoyad.Location = new System.Drawing.Point(186, 51);
            this.LblAdsoyad.Name = "LblAdsoyad";
            this.LblAdsoyad.Size = new System.Drawing.Size(53, 23);
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
            this.LblTc.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTc.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.LblTc.Location = new System.Drawing.Point(186, 91);
            this.LblTc.Name = "LblTc";
            this.LblTc.Size = new System.Drawing.Size(153, 23);
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
            this.BtnCikis.FillColor = System.Drawing.Color.Red;
            this.BtnCikis.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnCikis.ForeColor = System.Drawing.Color.White;
            this.BtnCikis.HoverState.Parent = this.BtnCikis;
            this.BtnCikis.Location = new System.Drawing.Point(967, 521);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.ShadowDecoration.Parent = this.BtnCikis;
            this.BtnCikis.Size = new System.Drawing.Size(160, 48);
            this.BtnCikis.TabIndex = 25;
            this.BtnCikis.Text = "Çıkış Yap";
            // 
            // BtnClose
            // 
            this.BtnClose.CheckedState.Parent = this.BtnClose;
            this.BtnClose.CustomImages.Parent = this.BtnClose;
            this.BtnClose.FillColor = System.Drawing.Color.Red;
            this.BtnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.HoverState.Parent = this.BtnClose;
            this.BtnClose.Location = new System.Drawing.Point(1084, 4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.ShadowDecoration.Parent = this.BtnClose;
            this.BtnClose.Size = new System.Drawing.Size(43, 28);
            this.BtnClose.TabIndex = 24;
            this.BtnClose.Text = "X";
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
            this.BtnGuncelle.FillColor = System.Drawing.Color.White;
            this.BtnGuncelle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnGuncelle.ForeColor = System.Drawing.Color.Black;
            this.BtnGuncelle.HoverState.Parent = this.BtnGuncelle;
            this.BtnGuncelle.Location = new System.Drawing.Point(135, 406);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.ShadowDecoration.Parent = this.BtnGuncelle;
            this.BtnGuncelle.Size = new System.Drawing.Size(232, 55);
            this.BtnGuncelle.TabIndex = 22;
            this.BtnGuncelle.Text = "Bilgilerimi Güncelle";
            // 
            // BtnRandevular
            // 
            this.BtnRandevular.BackColor = System.Drawing.Color.Transparent;
            this.BtnRandevular.BorderRadius = 25;
            this.BtnRandevular.CheckedState.Parent = this.BtnRandevular;
            this.BtnRandevular.CustomImages.Parent = this.BtnRandevular;
            this.BtnRandevular.FillColor = System.Drawing.Color.White;
            this.BtnRandevular.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnRandevular.ForeColor = System.Drawing.Color.Black;
            this.BtnRandevular.HoverState.Parent = this.BtnRandevular;
            this.BtnRandevular.Location = new System.Drawing.Point(135, 288);
            this.BtnRandevular.Name = "BtnRandevular";
            this.BtnRandevular.ShadowDecoration.Parent = this.BtnRandevular;
            this.BtnRandevular.Size = new System.Drawing.Size(232, 55);
            this.BtnRandevular.TabIndex = 21;
            this.BtnRandevular.Text = "Randevularım";
            // 
            // BtnMuayene
            // 
            this.BtnMuayene.BackColor = System.Drawing.Color.Transparent;
            this.BtnMuayene.BorderRadius = 25;
            this.BtnMuayene.CheckedState.Parent = this.BtnMuayene;
            this.BtnMuayene.CustomImages.Parent = this.BtnMuayene;
            this.BtnMuayene.FillColor = System.Drawing.Color.White;
            this.BtnMuayene.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnMuayene.ForeColor = System.Drawing.Color.Black;
            this.BtnMuayene.HoverState.Parent = this.BtnMuayene;
            this.BtnMuayene.Location = new System.Drawing.Point(135, 180);
            this.BtnMuayene.Name = "BtnMuayene";
            this.BtnMuayene.ShadowDecoration.Parent = this.BtnMuayene;
            this.BtnMuayene.Size = new System.Drawing.Size(232, 55);
            this.BtnMuayene.TabIndex = 20;
            this.BtnMuayene.Text = "Muayene Et";
            // 
            // FrmDoktorEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hastane_Proje.Properties.Resources.Kayıt1;
            this.ClientSize = new System.Drawing.Size(1131, 572);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnCikis);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnRandevular);
            this.Controls.Add(this.BtnMuayene);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDoktorEkran";
            this.Text = "FrmDoktorEkran";
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
        private Guna.UI2.WinForms.Guna2Button BtnMuayene;
    }
}