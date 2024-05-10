using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastane_Proje
{
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }

        sqlbaglanti bglgiris = new sqlbaglanti();

        private void LnkKayıt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayıt frmkayıt = new FrmHastaKayıt();
            frmkayıt.Show();
        }

        
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            if (MskTc.Text == "" || TxtSifre.Text == "" ) 
            {
                MessageBox.Show("Boş kalan alanları lütfen doldurunuz .", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                SqlCommand komutgiris = new SqlCommand("Select * From Tbl_Hastalar where Hastatc=@p1 and Hastasifre=@p2", bglgiris.baglanti());
                komutgiris.Parameters.AddWithValue("@p1", MskTc.Text);
                komutgiris.Parameters.AddWithValue("@p2", TxtSifre.Text);
                SqlDataReader dr = komutgiris.ExecuteReader();
                if (dr.Read())
                {
                    HastaEkran hastaEkran = new HastaEkran(MskTc.Text, dr["HastaAd"].ToString() + " " + dr["HastaSoyad"].ToString());
                    hastaEkran.hastatc = MskTc.Text;
                    hastaEkran.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("TC Kimlik No veya Şifre hatalı lütfen tekrar deneyiniz .", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                bglgiris.baglanti().Close();              
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FrmGirisler frmGirisler = new FrmGirisler();
            frmGirisler.Show();
            this.Hide();
        }
    }
}
