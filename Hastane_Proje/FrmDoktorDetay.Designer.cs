namespace Hastane_Proje
{
    partial class FrmDoktorDetay
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorDetay));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RchSikayet = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnMuayene = new System.Windows.Forms.Button();
            this.BtnDuyuru = new System.Windows.Forms.Button();
            this.BtnBilgiDuzenle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblAdsoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblTc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnClose = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.groupBox2.Controls.Add(this.RchSikayet);
            this.groupBox2.ForeColor = System.Drawing.Color.BlueViolet;
            this.groupBox2.Location = new System.Drawing.Point(12, 393);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 272);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hastanın Şikayetleri";
            // 
            // RchSikayet
            // 
            this.RchSikayet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RchSikayet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RchSikayet.Location = new System.Drawing.Point(3, 25);
            this.RchSikayet.Name = "RchSikayet";
            this.RchSikayet.Size = new System.Drawing.Size(366, 244);
            this.RchSikayet.TabIndex = 18;
            this.RchSikayet.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.ForeColor = System.Drawing.Color.BlueViolet;
            this.groupBox3.Location = new System.Drawing.Point(391, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(867, 618);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PapayaWhip;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(861, 590);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.groupBox4.Controls.Add(this.BtnMuayene);
            this.groupBox4.Controls.Add(this.BtnDuyuru);
            this.groupBox4.Controls.Add(this.BtnBilgiDuzenle);
            this.groupBox4.ForeColor = System.Drawing.Color.BlueViolet;
            this.groupBox4.Location = new System.Drawing.Point(12, 220);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(372, 167);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hızlı Erişim";
            // 
            // BtnMuayene
            // 
            this.BtnMuayene.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.BtnMuayene.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMuayene.ForeColor = System.Drawing.Color.White;
            this.BtnMuayene.Location = new System.Drawing.Point(190, 41);
            this.BtnMuayene.Name = "BtnMuayene";
            this.BtnMuayene.Size = new System.Drawing.Size(150, 48);
            this.BtnMuayene.TabIndex = 20;
            this.BtnMuayene.Text = "Muayene Et";
            this.BtnMuayene.UseVisualStyleBackColor = false;
            this.BtnMuayene.Click += new System.EventHandler(this.BtnDuyuru_Click);
            // 
            // BtnDuyuru
            // 
            this.BtnDuyuru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.BtnDuyuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDuyuru.ForeColor = System.Drawing.Color.White;
            this.BtnDuyuru.Location = new System.Drawing.Point(111, 95);
            this.BtnDuyuru.Name = "BtnDuyuru";
            this.BtnDuyuru.Size = new System.Drawing.Size(150, 48);
            this.BtnDuyuru.TabIndex = 20;
            this.BtnDuyuru.Text = "Duyurular";
            this.BtnDuyuru.UseVisualStyleBackColor = false;
            this.BtnDuyuru.Click += new System.EventHandler(this.BtnDuyuru_Click);
            // 
            // BtnBilgiDuzenle
            // 
            this.BtnBilgiDuzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.BtnBilgiDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBilgiDuzenle.ForeColor = System.Drawing.Color.White;
            this.BtnBilgiDuzenle.Location = new System.Drawing.Point(32, 41);
            this.BtnBilgiDuzenle.Name = "BtnBilgiDuzenle";
            this.BtnBilgiDuzenle.Size = new System.Drawing.Size(150, 48);
            this.BtnBilgiDuzenle.TabIndex = 19;
            this.BtnBilgiDuzenle.Text = "Bilgilerimi Düzenle";
            this.BtnBilgiDuzenle.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.groupBox1.Controls.Add(this.LblAdsoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LblTc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.groupBox1.Location = new System.Drawing.Point(13, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 167);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Bilgileri";
            // 
            // LblAdsoyad
            // 
            this.LblAdsoyad.AutoSize = true;
            this.LblAdsoyad.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAdsoyad.Location = new System.Drawing.Point(186, 51);
            this.LblAdsoyad.Name = "LblAdsoyad";
            this.LblAdsoyad.Size = new System.Drawing.Size(41, 23);
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
            this.LblTc.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTc.ForeColor = System.Drawing.Color.MediumSpringGreen;
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
            // BtnClose
            // 
            this.BtnClose.CheckedState.Parent = this.BtnClose;
            this.BtnClose.CustomImages.Parent = this.BtnClose;
            this.BtnClose.FillColor = System.Drawing.Color.Red;
            this.BtnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.HoverState.Parent = this.BtnClose;
            this.BtnClose.Location = new System.Drawing.Point(1215, 12);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.ShadowDecoration.Parent = this.BtnClose;
            this.BtnClose.Size = new System.Drawing.Size(43, 28);
            this.BtnClose.TabIndex = 28;
            this.BtnClose.Text = "X";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrmDoktorDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1270, 695);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Ana Ekran";
            this.Load += new System.EventHandler(this.FrmDoktorDetay_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox RchSikayet;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnDuyuru;
        private System.Windows.Forms.Button BtnBilgiDuzenle;
        private System.Windows.Forms.Button BtnMuayene;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblAdsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblTc;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button BtnClose;
    }
}