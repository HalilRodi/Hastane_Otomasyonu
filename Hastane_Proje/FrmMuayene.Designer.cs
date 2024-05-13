namespace Hastane_Proje
{
    partial class FrmMuayene
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
            this.RchSonuc = new System.Windows.Forms.RichTextBox();
            this.LblTeshis = new System.Windows.Forms.Label();
            this.Cmbİlac = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Lblilaç = new System.Windows.Forms.Label();
            this.BtnClose = new Guna.UI2.WinForms.Guna2Button();
            this.BtnReceteYaz = new Guna.UI2.WinForms.Guna2Button();
            this.LblHastaAdSoyad = new System.Windows.Forms.Label();
            this.TxtAdSoyad = new System.Windows.Forms.TextBox();
            this.LblHastaTC = new System.Windows.Forms.Label();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.LblTarih = new System.Windows.Forms.Label();
            this.MskTarih = new System.Windows.Forms.MaskedTextBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RchSonuc
            // 
            this.RchSonuc.Location = new System.Drawing.Point(235, 238);
            this.RchSonuc.Name = "RchSonuc";
            this.RchSonuc.Size = new System.Drawing.Size(183, 99);
            this.RchSonuc.TabIndex = 3;
            this.RchSonuc.Text = "";
            // 
            // LblTeshis
            // 
            this.LblTeshis.AutoSize = true;
            this.LblTeshis.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTeshis.Location = new System.Drawing.Point(147, 238);
            this.LblTeshis.Name = "LblTeshis";
            this.LblTeshis.Size = new System.Drawing.Size(68, 23);
            this.LblTeshis.TabIndex = 1;
            this.LblTeshis.Text = "Teşhis: ";
            this.LblTeshis.Click += new System.EventHandler(this.LblSonuc_Click);
            // 
            // Cmbİlac
            // 
            this.Cmbİlac.BackColor = System.Drawing.Color.Transparent;
            this.Cmbİlac.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cmbİlac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmbİlac.FocusedColor = System.Drawing.Color.Empty;
            this.Cmbİlac.FocusedState.Parent = this.Cmbİlac;
            this.Cmbİlac.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Cmbİlac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Cmbİlac.FormattingEnabled = true;
            this.Cmbİlac.HoverState.Parent = this.Cmbİlac;
            this.Cmbİlac.ItemHeight = 30;
            this.Cmbİlac.ItemsAppearance.Parent = this.Cmbİlac;
            this.Cmbİlac.Location = new System.Drawing.Point(235, 352);
            this.Cmbİlac.Name = "Cmbİlac";
            this.Cmbİlac.ShadowDecoration.Parent = this.Cmbİlac;
            this.Cmbİlac.Size = new System.Drawing.Size(183, 36);
            this.Cmbİlac.TabIndex = 4;
            this.Cmbİlac.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // Lblilaç
            // 
            this.Lblilaç.AutoSize = true;
            this.Lblilaç.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lblilaç.Location = new System.Drawing.Point(174, 352);
            this.Lblilaç.Name = "Lblilaç";
            this.Lblilaç.Size = new System.Drawing.Size(41, 23);
            this.Lblilaç.TabIndex = 1;
            this.Lblilaç.Text = "İlaç:";
            this.Lblilaç.Click += new System.EventHandler(this.LblSonuc_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.CheckedState.Parent = this.BtnClose;
            this.BtnClose.CustomImages.Parent = this.BtnClose;
            this.BtnClose.FillColor = System.Drawing.Color.Red;
            this.BtnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.HoverState.Parent = this.BtnClose;
            this.BtnClose.Location = new System.Drawing.Point(560, 12);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.ShadowDecoration.Parent = this.BtnClose;
            this.BtnClose.Size = new System.Drawing.Size(43, 28);
            this.BtnClose.TabIndex = 18;
            this.BtnClose.Text = "X";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnReceteYaz
            // 
            this.BtnReceteYaz.CheckedState.Parent = this.BtnReceteYaz;
            this.BtnReceteYaz.CustomImages.Parent = this.BtnReceteYaz;
            this.BtnReceteYaz.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnReceteYaz.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnReceteYaz.ForeColor = System.Drawing.Color.White;
            this.BtnReceteYaz.HoverState.Parent = this.BtnReceteYaz;
            this.BtnReceteYaz.Location = new System.Drawing.Point(332, 429);
            this.BtnReceteYaz.Name = "BtnReceteYaz";
            this.BtnReceteYaz.ShadowDecoration.Parent = this.BtnReceteYaz;
            this.BtnReceteYaz.Size = new System.Drawing.Size(180, 45);
            this.BtnReceteYaz.TabIndex = 5;
            this.BtnReceteYaz.Text = "Reçete Yaz";
            this.BtnReceteYaz.Click += new System.EventHandler(this.BtnReceteYaz_Click);
            // 
            // LblHastaAdSoyad
            // 
            this.LblHastaAdSoyad.AutoSize = true;
            this.LblHastaAdSoyad.Font = new System.Drawing.Font("Corbel", 14.25F);
            this.LblHastaAdSoyad.Location = new System.Drawing.Point(75, 96);
            this.LblHastaAdSoyad.Name = "LblHastaAdSoyad";
            this.LblHastaAdSoyad.Size = new System.Drawing.Size(140, 23);
            this.LblHastaAdSoyad.TabIndex = 20;
            this.LblHastaAdSoyad.Text = "Hasta Ad-Soyad:";
            // 
            // TxtAdSoyad
            // 
            this.TxtAdSoyad.Font = new System.Drawing.Font("Corbel", 14.25F);
            this.TxtAdSoyad.Location = new System.Drawing.Point(235, 93);
            this.TxtAdSoyad.Name = "TxtAdSoyad";
            this.TxtAdSoyad.Size = new System.Drawing.Size(183, 31);
            this.TxtAdSoyad.TabIndex = 0;
            // 
            // LblHastaTC
            // 
            this.LblHastaTC.AutoSize = true;
            this.LblHastaTC.Font = new System.Drawing.Font("Corbel", 14.25F);
            this.LblHastaTC.Location = new System.Drawing.Point(129, 145);
            this.LblHastaTC.Name = "LblHastaTC";
            this.LblHastaTC.Size = new System.Drawing.Size(86, 23);
            this.LblHastaTC.TabIndex = 22;
            this.LblHastaTC.Text = "Hasta TC:";
            // 
            // MskTC
            // 
            this.MskTC.Font = new System.Drawing.Font("Corbel", 14.25F);
            this.MskTC.Location = new System.Drawing.Point(235, 145);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(183, 31);
            this.MskTC.TabIndex = 1;
            // 
            // LblTarih
            // 
            this.LblTarih.AutoSize = true;
            this.LblTarih.Font = new System.Drawing.Font("Corbel", 14.25F);
            this.LblTarih.Location = new System.Drawing.Point(161, 197);
            this.LblTarih.Name = "LblTarih";
            this.LblTarih.Size = new System.Drawing.Size(54, 23);
            this.LblTarih.TabIndex = 22;
            this.LblTarih.Text = "Tarih:";
            // 
            // MskTarih
            // 
            this.MskTarih.Font = new System.Drawing.Font("Corbel", 14.25F);
            this.MskTarih.Location = new System.Drawing.Point(235, 189);
            this.MskTarih.Mask = "00/00/0000";
            this.MskTarih.Name = "MskTarih";
            this.MskTarih.Size = new System.Drawing.Size(183, 31);
            this.MskTarih.TabIndex = 2;
            this.MskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::Hastane_Proje.Properties.Resources._49057b6b_8776_46b5_ab74_174403ff5913;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(12, 12);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(98, 80);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 3;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // FrmMuayene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 552);
            this.Controls.Add(this.MskTarih);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.LblTarih);
            this.Controls.Add(this.LblHastaTC);
            this.Controls.Add(this.TxtAdSoyad);
            this.Controls.Add(this.LblHastaAdSoyad);
            this.Controls.Add(this.BtnReceteYaz);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.Cmbİlac);
            this.Controls.Add(this.Lblilaç);
            this.Controls.Add(this.LblTeshis);
            this.Controls.Add(this.RchSonuc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMuayene";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMuayene";
            this.Load += new System.EventHandler(this.FrmMuayene_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RchSonuc;
        private System.Windows.Forms.Label LblTeshis;
        private Guna.UI2.WinForms.Guna2ComboBox Cmbİlac;
        private System.Windows.Forms.Label Lblilaç;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Button BtnClose;
        private Guna.UI2.WinForms.Guna2Button BtnReceteYaz;
        private System.Windows.Forms.Label LblHastaAdSoyad;
        private System.Windows.Forms.TextBox TxtAdSoyad;
        private System.Windows.Forms.Label LblHastaTC;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.Label LblTarih;
        private System.Windows.Forms.MaskedTextBox MskTarih;
    }
}