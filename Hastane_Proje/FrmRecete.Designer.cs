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
            this.TxtDoktorAd = new System.Windows.Forms.TextBox();
            this.MskHastaTC = new System.Windows.Forms.MaskedTextBox();
            this.TxtHastaAd = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
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
            // 
            // TxtDoktorAd
            // 
            this.TxtDoktorAd.Font = new System.Drawing.Font("Corbel", 14.25F);
            this.TxtDoktorAd.Location = new System.Drawing.Point(111, 218);
            this.TxtDoktorAd.Name = "TxtDoktorAd";
            this.TxtDoktorAd.Size = new System.Drawing.Size(168, 31);
            this.TxtDoktorAd.TabIndex = 20;
            // 
            // MskHastaTC
            // 
            this.MskHastaTC.BackColor = System.Drawing.Color.White;
            this.MskHastaTC.Font = new System.Drawing.Font("Corbel", 14.25F);
            this.MskHastaTC.Location = new System.Drawing.Point(193, 299);
            this.MskHastaTC.Mask = "00000000000";
            this.MskHastaTC.Name = "MskHastaTC";
            this.MskHastaTC.Size = new System.Drawing.Size(209, 31);
            this.MskHastaTC.TabIndex = 21;
            // 
            // TxtHastaAd
            // 
            this.TxtHastaAd.Font = new System.Drawing.Font("Corbel", 14.25F);
            this.TxtHastaAd.Location = new System.Drawing.Point(193, 368);
            this.TxtHastaAd.Name = "TxtHastaAd";
            this.TxtHastaAd.Size = new System.Drawing.Size(168, 31);
            this.TxtHastaAd.TabIndex = 20;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(29, 478);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(532, 300);
            this.richTextBox1.TabIndex = 22;
            this.richTextBox1.Text = "";
            // 
            // FrmRecete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Hastane_Proje.Properties.Resources.REÇETE;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(573, 805);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.MskHastaTC);
            this.Controls.Add(this.TxtHastaAd);
            this.Controls.Add(this.TxtDoktorAd);
            this.Controls.Add(this.BtnClose);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRecete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRecete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button BtnClose;
        private System.Windows.Forms.TextBox TxtDoktorAd;
        private System.Windows.Forms.MaskedTextBox MskHastaTC;
        private System.Windows.Forms.TextBox TxtHastaAd;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}