namespace Hastane_Proje
{
    partial class FrmGirisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            this.BtnHasta = new System.Windows.Forms.Button();
            this.BtnDoktor = new System.Windows.Forms.Button();
            this.BtnSekreter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnHasta
            // 
            this.BtnHasta.BackColor = System.Drawing.Color.Transparent;
            this.BtnHasta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnHasta.BackgroundImage")));
            this.BtnHasta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnHasta.FlatAppearance.BorderSize = 0;
            this.BtnHasta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHasta.Location = new System.Drawing.Point(18, 342);
            this.BtnHasta.Name = "BtnHasta";
            this.BtnHasta.Size = new System.Drawing.Size(187, 217);
            this.BtnHasta.TabIndex = 5;
            this.BtnHasta.UseVisualStyleBackColor = false;
            this.BtnHasta.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnDoktor
            // 
            this.BtnDoktor.BackColor = System.Drawing.Color.Transparent;
            this.BtnDoktor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDoktor.BackgroundImage")));
            this.BtnDoktor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDoktor.FlatAppearance.BorderSize = 0;
            this.BtnDoktor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDoktor.Location = new System.Drawing.Point(271, 348);
            this.BtnDoktor.Name = "BtnDoktor";
            this.BtnDoktor.Size = new System.Drawing.Size(186, 204);
            this.BtnDoktor.TabIndex = 6;
            this.BtnDoktor.UseVisualStyleBackColor = false;
            this.BtnDoktor.Click += new System.EventHandler(this.BtnDoktor_Click);
            // 
            // BtnSekreter
            // 
            this.BtnSekreter.BackColor = System.Drawing.Color.Transparent;
            this.BtnSekreter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSekreter.BackgroundImage")));
            this.BtnSekreter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSekreter.FlatAppearance.BorderSize = 0;
            this.BtnSekreter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSekreter.Location = new System.Drawing.Point(498, 329);
            this.BtnSekreter.Name = "BtnSekreter";
            this.BtnSekreter.Size = new System.Drawing.Size(216, 243);
            this.BtnSekreter.TabIndex = 7;
            this.BtnSekreter.UseVisualStyleBackColor = false;
            this.BtnSekreter.Click += new System.EventHandler(this.BtnSekreter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(71, 562);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(315, 562);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Doktor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(549, 562);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sekreter";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.guna2Button1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1027, 52);
            this.panel2.TabIndex = 14;
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Red;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(972, 12);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(43, 28);
            this.guna2Button1.TabIndex = 18;
            this.guna2Button1.Text = "X";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(269, 33);
            this.label5.TabIndex = 11;
            this.label5.Text = "Hastane Otomasyonu\r\n";
            // 
            // FrmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Hastane_Proje.Properties.Resources.Sağlığınız_emin_ellerde___;
            this.ClientSize = new System.Drawing.Size(1027, 695);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSekreter);
            this.Controls.Add(this.BtnDoktor);
            this.Controls.Add(this.BtnHasta);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmGirisler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hastane Bilgi Sistemine Giriş Ekranı";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnHasta;
        private System.Windows.Forms.Button BtnDoktor;
        private System.Windows.Forms.Button BtnSekreter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}

