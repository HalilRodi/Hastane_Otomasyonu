﻿namespace Hastane_Proje
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
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Lblilaç = new System.Windows.Forms.Label();
            this.BtnClose = new Guna.UI2.WinForms.Guna2Button();
            this.BtnReceteYaz = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RchSonuc
            // 
            this.RchSonuc.Location = new System.Drawing.Point(131, 114);
            this.RchSonuc.Name = "RchSonuc";
            this.RchSonuc.Size = new System.Drawing.Size(183, 161);
            this.RchSonuc.TabIndex = 0;
            this.RchSonuc.Text = "";
            // 
            // LblTeshis
            // 
            this.LblTeshis.AutoSize = true;
            this.LblTeshis.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTeshis.Location = new System.Drawing.Point(57, 114);
            this.LblTeshis.Name = "LblTeshis";
            this.LblTeshis.Size = new System.Drawing.Size(68, 23);
            this.LblTeshis.TabIndex = 1;
            this.LblTeshis.Text = "Teşhis: ";
            this.LblTeshis.Click += new System.EventHandler(this.LblSonuc_Click);
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.guna2ComboBox1.FocusedState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.FormattingEnabled = true;
            this.guna2ComboBox1.HoverState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.ItemsAppearance.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Location = new System.Drawing.Point(131, 295);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.ShadowDecoration.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Size = new System.Drawing.Size(183, 36);
            this.guna2ComboBox1.TabIndex = 2;
            this.guna2ComboBox1.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // Lblilaç
            // 
            this.Lblilaç.AutoSize = true;
            this.Lblilaç.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lblilaç.Location = new System.Drawing.Point(84, 295);
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
            this.BtnClose.Location = new System.Drawing.Point(364, 12);
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
            this.BtnReceteYaz.Location = new System.Drawing.Point(227, 377);
            this.BtnReceteYaz.Name = "BtnReceteYaz";
            this.BtnReceteYaz.ShadowDecoration.Parent = this.BtnReceteYaz;
            this.BtnReceteYaz.Size = new System.Drawing.Size(180, 45);
            this.BtnReceteYaz.TabIndex = 19;
            this.BtnReceteYaz.Text = "Reçete Yaz";
            this.BtnReceteYaz.Click += new System.EventHandler(this.BtnReceteYaz_Click);
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
            this.ClientSize = new System.Drawing.Size(419, 434);
            this.Controls.Add(this.BtnReceteYaz);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.Lblilaç);
            this.Controls.Add(this.LblTeshis);
            this.Controls.Add(this.RchSonuc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMuayene";
            this.Text = "FrmMuayene";
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RchSonuc;
        private System.Windows.Forms.Label LblTeshis;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private System.Windows.Forms.Label Lblilaç;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Button BtnClose;
        private Guna.UI2.WinForms.Guna2Button BtnReceteYaz;
    }
}