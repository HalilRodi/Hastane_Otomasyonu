using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Proje
{
    public partial class HastaEkran : Form
    {
        public HastaEkran(string tc, string adSoyad)
        {
            InitializeComponent();
            hastatc = tc;
            hastaadsoyad = adSoyad;
        }

        
        public string hastatc;
        public string hastaadsoyad;


        sqlbaglanti bgl = new sqlbaglanti();

        private void HastaEkran_Load(object sender, EventArgs e)
        {
            LblTc.Text = hastatc;
            LblAdsoyad.Text = hastaadsoyad;

            SqlCommand command = new SqlCommand("Select HastaAd, HastaSoyad from Tbl_Hastalar where HastaTC=@p1", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", hastatc);
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                LblAdsoyad.Text= reader[0] + " " + reader[1];
            }
            bgl.baglanti().Close();
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            FrmHastaGiris hastaGiris = new FrmHastaGiris();
            hastaGiris.Show();
            this.Hide();
        }

        private void BtnRandevu_Click(object sender, EventArgs e)
        {
            FrmHastaDetay frmHastaDetay = new FrmHastaDetay();
            frmHastaDetay.hastatc = LblTc.Text; 
            frmHastaDetay.Show();
           
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            FrmHastaGuncelle frmHastaGuncelle = new FrmHastaGuncelle();
            frmHastaGuncelle.tcno = LblTc.Text;
            frmHastaGuncelle.Show();
            this.Hide();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnRandevular_Click(object sender, EventArgs e)
        {
            FrmRandevuListe frmRandevuListe = new FrmRandevuListe();
            frmRandevuListe.Show();
            this.Hide();
        }
    }
}
