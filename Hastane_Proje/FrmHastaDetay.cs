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
using System.Globalization;

namespace Hastane_Proje
{
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }

        sqlbaglanti bgldetay = new sqlbaglanti();

        public string hastatc;
        public string hastaadsoyad;

       // void randevugecmislistele()
       // {
       // DataTable dt = new DataTable();
       // SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where HastaTC='" + LblTc.Text + "'", bgldetay.baglanti());
       // da.Fill(dt);
       //dataGridView1.DataSource = dt;
       //}

        private void FrmHastaDetay_Load(object sender, EventArgs e)
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


        // Branş seçtikten sonra combobox'a o branşdaki doktorları ekledik
        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
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

        // aktif randevular
        private void CmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where Randevubrans='" + CmbBrans.Text + "'" + " and Randevudoktor='" + CmbDoktor.Text + "' and Randevudurum=0", bgldetay.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;

            
        }

        private void BtnRandevu_Click(object sender, EventArgs e)
        {
            DateTime randevuTarih;
            TimeSpan randevuSaat;

            // Geçerli tarih mi kontrolü
            if (!DateTime.TryParseExact(MskTarih.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out randevuTarih))
            {
                MessageBox.Show("Geçersiz tarih formatı. Lütfen doğru bir tarih girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Geçmiş tarih kontrolü
            if (randevuTarih.Date < DateTime.Today)
            {
                MessageBox.Show("Geçmiş tarih seçilemez. Lütfen ileri bir tarih seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Saat formatı kontrolü
            if (!TimeSpan.TryParse(MskSaat.Text, out randevuSaat))
            {
                MessageBox.Show("Geçersiz saat formatı. Lütfen doğru bir saat girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Veritabanında aynı tarih ve saatte randevu var mı kontrolü
            SqlCommand kontrol = new SqlCommand("SELECT COUNT(*) FROM Tbl_Randevular WHERE RandevuTarih = @p1 AND RandevuSaat = @p2", bgldetay.baglanti());
            kontrol.Parameters.AddWithValue("@p1", randevuTarih.ToString("yyyy-MM-dd"));
            kontrol.Parameters.AddWithValue("@p2", randevuSaat.ToString());
            int randevuSayisi = (int)kontrol.ExecuteScalar();
            bgldetay.baglanti().Close();

            if (randevuSayisi > 0)
            {
                MessageBox.Show("Seçtiğiniz tarih ve saatte randevu alınmış. Lütfen farklı bir tarih ve saat seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Randevuyu kaydetme
            SqlCommand kaydet = new SqlCommand("INSERT INTO Tbl_Randevular (HastaTC, RandevuTarih, RandevuSaat, RandevuBrans, RandevuDoktor) VALUES (@p1, @p2, @p3, @p4, @p5)", bgldetay.baglanti());
            kaydet.Parameters.AddWithValue("@p1", LblTc.Text);
            kaydet.Parameters.AddWithValue("@p2", randevuTarih);
            kaydet.Parameters.AddWithValue("@p3", randevuSaat);
            kaydet.Parameters.AddWithValue("@p4", CmbBrans.Text);
            kaydet.Parameters.AddWithValue("@p5", CmbDoktor.Text);
            kaydet.ExecuteNonQuery();
            bgldetay.baglanti().Close();

            MessageBox.Show("Randevu Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void Rdvİd_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LblTc_Click(object sender, EventArgs e)
        {

        }
    }
}
