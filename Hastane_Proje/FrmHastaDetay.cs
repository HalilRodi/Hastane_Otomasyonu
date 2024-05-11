using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

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

            // Subscribe to the SelectedIndexChanged event of CmbBrans
            CmbBrans.SelectedIndexChanged += CmbBrans_SelectedIndexChanged;
        }

        // Event handler for CmbBrans SelectedIndexChanged event
        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Call the method to populate the doctors ComboBox (CmbDoktor)
            PopulateDoctorsComboBox();
        }

        // Method to populate the doctors ComboBox (CmbDoktor)
        private void PopulateDoctorsComboBox()
        {
            CmbDoktor.Items.Clear();

            SqlCommand komut3 = new SqlCommand("Select Doktorad, Doktorsoyad From Tbl_Doktorlar where Doktorbrans=@b1", bgldetay.baglanti());
            komut3.Parameters.AddWithValue("@b1", CmbBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                CmbDoktor.Items.Add(dr3[0].ToString() + " " + dr3[1].ToString());
            }
            bgldetay.baglanti().Close();
        }

        // Aktif randevular
        private void CmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Randevular WHERE HastaTC = @p1 AND Randevubrans = @p2 AND Randevudoktor = @p3 AND Randevudurum = 0", bgldetay.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@p1", hastatc); // Sadece bu hastaya ait randevuları göstermek için hastanın TC'sini kullanıyoruz.
            da.SelectCommand.Parameters.AddWithValue("@p2", CmbBrans.Text);
            da.SelectCommand.Parameters.AddWithValue("@p3", CmbDoktor.Text);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void BtnRandevu_Click_1(object sender, EventArgs e)
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

            // Convert the date to the format expected by SQL Server
            string formattedDate = randevuTarih.ToString("yyyy-MM-dd");

            // Check if the appointment already exists
            SqlCommand kontrolKomut = new SqlCommand("SELECT COUNT(*) FROM Tbl_Randevular WHERE RandevuTarih = @p1 AND RandevuSaat = @p2", bgldetay.baglanti());
            kontrolKomut.Parameters.AddWithValue("@p1", formattedDate); // Use the formatted date
            kontrolKomut.Parameters.AddWithValue("@p2", randevuSaat); // HH:MM formatında saat
            int existingAppointmentsCount = (int)kontrolKomut.ExecuteScalar();
            bgldetay.baglanti().Close();

            // If any appointment exists, show an error message
            if (existingAppointmentsCount > 0)
            {
                MessageBox.Show("Bu tarihte ve saatte bir randevu zaten mevcut.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Insert the new appointment
            SqlCommand kaydet = new SqlCommand("INSERT INTO Tbl_Randevular (HastaTC, RandevuTarih, RandevuSaat, RandevuBrans, RandevuDoktor) VALUES (@p1, @p2, @p3, @p4, @p5)", bgldetay.baglanti());
            kaydet.Parameters.AddWithValue("@p1", LblTc.Text);
            kaydet.Parameters.AddWithValue("@p2", formattedDate); // Use the formatted date
            kaydet.Parameters.AddWithValue("@p3", randevuSaat);
            kaydet.Parameters.AddWithValue("@p4", CmbBrans.Text);
            kaydet.Parameters.AddWithValue("@p5", CmbDoktor.Text);
            kaydet.ExecuteNonQuery();
            bgldetay.baglanti().Close();

            MessageBox.Show("Randevu Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
