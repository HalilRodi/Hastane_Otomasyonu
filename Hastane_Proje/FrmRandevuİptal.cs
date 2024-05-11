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
    public partial class FrmRandevuİptal : Form
    {
        public FrmRandevuİptal()
        {
            InitializeComponent();
        }
        sqlbaglanti bgldetay = new sqlbaglanti();

        public string hastatc;
        public string hastaadsoyad;

        private void FrmRandevuİptal_Load(object sender, EventArgs e)
        {
            LblTc.Text = hastatc;

            SqlCommand command = new SqlCommand("Select HastaAd, HastaSoyad from Tbl_Hastalar where HastaTC=@p1", bgldetay.baglanti());
            command.Parameters.AddWithValue("@p1", hastatc);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                LblAdsoyad.Text = reader[0] + " " + reader[1];
            }
            bgldetay.baglanti().Close();

            //Branşları comboboxa aktarma
            SqlCommand komut2 = new SqlCommand("Select Bransad From Tbl_Branslar", bgldetay.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0].ToString());
            }
            bgldetay.baglanti().Close();
        }

      
        private void CmbDoktor_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CmbDoktor.Text = "";
            CmbDoktor.Items.Clear();

            SqlCommand komut3 = new SqlCommand("Select Doktorad,Doktorsoyad From Tbl_Doktorlar where Doktorbrans=@b1", bgldetay.baglanti());
            komut3.Parameters.AddWithValue("@b1", CmbBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                CmbDoktor.Items.Add(dr3[0].ToString() + " " + dr3[1].ToString());
            }
            bgldetay.baglanti().Close();
        }

       
    }
}
