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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();

        public string sekretertc;

        void temizle()
        {
            CmbBrans.Text = "";
            CmbDoktor.Text = "";
            MskTarih.Text = "";
            MskSaat.Text = "";
        }

        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            LblTc.Text = sekretertc;

            // ad soyad çekme
            SqlCommand komut = new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreter where SekreterTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdsoyad.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();

            // branşları datagride aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Tbl_Branslar", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            // doktorları datagride aktarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd + ' ' + DoktorSoyad) as 'Doktorlar',DoktorBrans From Tbl_Doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            // branşları comboboxa aktarma
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            DateTime randevuTarih;
            TimeSpan randevuSaat;
            if (CmbBrans.Text == "" || CmbDoktor.Text == "" || MskTarih.MaskFull == false || MskSaat.MaskFull == false)
            {
                MessageBox.Show("Boş kalan alanları lütfen doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
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

                // Kullanıcı tarafından girilen saati parçalara ayırma
                string[] saatParcalari = MskSaat.Text.Split(':');
                int saat, dakika;
                if (saatParcalari.Length == 2 && int.TryParse(saatParcalari[0], out saat) && int.TryParse(saatParcalari[1], out dakika))
                {
                    randevuSaat = new TimeSpan(saat, dakika, 0); // Yeni TimeSpan oluşturma
                }
                else
                {
                    MessageBox.Show("Geçersiz saat formatı. Lütfen doğru bir saat girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                TimeSpan simdikiZaman = DateTime.Now.TimeOfDay; // Mevcut zamanın TimeSpan karşılığı
                if (randevuSaat < simdikiZaman)
                {
                    MessageBox.Show("Geçmiş saat seçilemez. Lütfen ileri bir saat seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Convert the date to the format expected by SQL Server
                string formattedDate = randevuTarih.ToString("yyyy-MM-dd");

                // Check if the appointment already exists
                SqlCommand kontrolKomut = new SqlCommand("SELECT COUNT(*) FROM Tbl_Randevular WHERE RandevuTarih = @p1 AND RandevuSaat = @p2", bgl.baglanti());
                kontrolKomut.Parameters.AddWithValue("@p1", formattedDate); // Use the formatted date
                kontrolKomut.Parameters.AddWithValue("@p2", randevuSaat); // HH:MM formatında saat
                int existingAppointmentsCount = (int)kontrolKomut.ExecuteScalar();
                bgl.baglanti().Close();

                // If any appointment exists, show an error message
                if (existingAppointmentsCount > 0)
                {
                    MessageBox.Show("Bu tarihte ve saatte bir randevu zaten mevcut.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Yeni randevuyu veritabanına ekliyoruz
                SqlCommand komutkaydet = new SqlCommand("INSERT INTO Tbl_Randevular (HastaTC, RandevuBrans, RandevuDoktor, RandevuTarih, RandevuSaat, HastaSikayet) VALUES (@p1, @p2, @p3, @p4, @p5, @p6)", bgl.baglanti());
                komutkaydet.Parameters.AddWithValue("@p1", MskTC.Text);
                komutkaydet.Parameters.AddWithValue("@p2", CmbBrans.Text);
                komutkaydet.Parameters.AddWithValue("@p3", CmbDoktor.Text);
                komutkaydet.Parameters.AddWithValue("@p4", formattedDate); // YYYY-MM-DD formatında tarih
                komutkaydet.Parameters.AddWithValue("@p5", randevuSaat.ToString()); // HH:MM formatında saat
                komutkaydet.Parameters.AddWithValue("@p6", RchSikayet.Text);
                komutkaydet.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Randevu oluşturuldu.", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
            }
        }






        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        // Branş seçtikten sonra combobox'a o branşdaki doktorları ekledik
        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();

            SqlCommand komut = new SqlCommand("Select (DoktorAd+' '+DoktorSoyad) From Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CmbBrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbDoktor.Items.Add(dr[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void BtnDoktorPanel_Click(object sender, EventArgs e)
        {
            FrmDoktorPanel frm = new FrmDoktorPanel();
            frm.Show();
        }

        private void BtnBranşPanel_Click(object sender, EventArgs e)
        {
            FrmBransPanel frm = new FrmBransPanel();
            frm.Show();
        }

        private void BtnRandevuListe_Click(object sender, EventArgs e)
        {
            FrmSekreterRandevu frm = new FrmSekreterRandevu();
            frm.Show();
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
