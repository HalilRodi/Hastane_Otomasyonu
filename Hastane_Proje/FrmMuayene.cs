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
    public partial class FrmMuayene : Form
    {
        public FrmMuayene()
        {
            InitializeComponent();
        }

        private void LblSonuc_Click(object sender, EventArgs e)
        {

        }

        sqlbaglanti bgl = new sqlbaglanti();
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnReceteYaz_Click(object sender, EventArgs e)
        {
            DateTime muayeneTarihi;
            if (!DateTime.TryParse(MskTarih.Text, out muayeneTarihi))
            {
                MessageBox.Show("Geçersiz tarih formatı! Lütfen geçerli bir tarih giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            
            if (muayeneTarihi.Year < 1900)
            {
                MessageBox.Show("Geçersiz bir tarih girdiniz! Lütfen geçerli bir tarih giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            
            if (muayeneTarihi < DateTime.Today)
            {
                MessageBox.Show("Geçmiş bir tarih giremezsiniz! Lütfen ileri bir tarih giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            SqlCommand kaydet = new SqlCommand("INSERT INTO Tbl_Muayene (HastaAdSoyad, HastaTC, Teşhis, İlaçAdı, MuayeneTarihi) VALUES (@p1, @p2, @p3, @p4, @p5)", bgl.baglanti());
            kaydet.Parameters.AddWithValue("@p1", TxtAdSoyad.Text);
            kaydet.Parameters.AddWithValue("@p2", MskTC.Text);
            kaydet.Parameters.AddWithValue("@p3", RchSonuc.Text);
            kaydet.Parameters.AddWithValue("@p4", Cmbİlac.Text);
            kaydet.Parameters.AddWithValue("@p5", MskTarih.Text);
            kaydet.ExecuteNonQuery();
            bgl.baglanti().Close();

            FrmRecete frmRecete = new FrmRecete();

            frmRecete.hastaAdSoyad = TxtAdSoyad.Text;
            frmRecete.hastaTC = MskTC.Text;
            frmRecete.ilacAdi = Cmbİlac.SelectedItem.ToString();

            frmRecete.MuayeneTarihi = DateTime.Parse(MskTarih.Text);

            frmRecete.Show();
        }

        private void FrmMuayene_Load(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Select İlaçAdı From Tbl_İlaçlar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                Cmbİlac.Items.Add(dr2[0].ToString());
            }
            bgl.baglanti().Close();

            
            
        }

       
    }
}
