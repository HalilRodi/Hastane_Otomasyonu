namespace Hastane_Proje
{
    partial class FrmRecete
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
            this.BtnClose = new Guna.UI2.WinForms.Guna2Button();
            this.MskHastaTC = new System.Windows.Forms.MaskedTextBox();
            this.TxtHastaAd = new System.Windows.Forms.TextBox();
            this.RchIlac = new System.Windows.Forms.RichTextBox();
            this.MskTarih = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.CheckedState.Parent = this.BtnClose;
            this.BtnClose.CustomImages.Parent = this.BtnClose;
            this.BtnClose.FillColor = System.Drawing.Color.Red;
            this.BtnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.HoverState.Parent = this.BtnClose;
            this.BtnClose.Location = new System.Drawing.Point(528, 2);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.ShadowDecoration.Parent = this.BtnClose;
            this.BtnClose.Size = new System.Drawing.Size(43, 28);
            this.BtnClose.TabIndex = 19;
            this.BtnClose.Text = "X";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // MskHastaTC
            // 
            this.MskHastaTC.BackColor = System.Drawing.Color.White;
            this.MskHastaTC.Font = new System.Drawing.Font("Corbel", 14.25F);
            this.MskHastaTC.Location = new System.Drawing.Point(193, 288);
            this.MskHastaTC.Mask = "00000000000";
            this.MskHastaTC.Name = "MskHastaTC";
            this.MskHastaTC.Size = new System.Drawing.Size(209, 31);
            this.MskHastaTC.TabIndex = 21;
            // 
            // TxtHastaAd
            // 
            this.TxtHastaAd.Font = new System.Drawing.Font("Corbel", 14.25F);
            this.TxtHastaAd.Location = new System.Drawing.Point(193, 358);
            this.TxtHastaAd.Name = "TxtHastaAd";
            this.TxtHastaAd.Size = new System.Drawing.Size(168, 31);
            this.TxtHastaAd.TabIndex = 20;
            // 
            // RchIlac
            // 
            this.RchIlac.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RchIlac.Location = new System.Drawing.Point(42, 475);
            this.RchIlac.Name = "RchIlac";
            this.RchIlac.Size = new System.Drawing.Size(496, 165);
            this.RchIlac.TabIndex = 22;
            this.RchIlac.Text = "";
            // 
            // MskTarih
            // 
            this.MskTarih.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTarih.Location = new System.Drawing.Point(439, 212);
            this.MskTarih.Mask = "00/00/0000";
            this.MskTarih.Name = "MskTarih";
            this.MskTarih.Size = new System.Drawing.Size(117, 31);
            this.MskTarih.TabIndex = 23;
            this.MskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // FrmRecete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Hastane_Proje.Properties.Resources.REÇETE2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(579, 805);
            this.Controls.Add(this.MskTarih);
            this.Controls.Add(this.RchIlac);
            this.Controls.Add(this.MskHastaTC);
            this.Controls.Add(this.TxtHastaAd);
            this.Controls.Add(this.BtnClose);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRecete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRecete";
            this.Load += new System.EventHandler(this.FrmRecete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button BtnClose;
        private System.Windows.Forms.MaskedTextBox MskHastaTC;
        private System.Windows.Forms.TextBox TxtHastaAd;
        private System.Windows.Forms.RichTextBox RchIlac;
        private System.Windows.Forms.MaskedTextBox MskTarih;
    }
}