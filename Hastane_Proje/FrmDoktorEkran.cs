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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Hastane_Proje
{
    public partial class FrmDoktorEkran : Form
    {
        public FrmDoktorEkran(string tc, string adSoyad)
        {
            InitializeComponent();
            doktortc = tc;
            doktoradsoyad = adSoyad;
        }

        public string doktortc;
        public string doktoradsoyad;

        sqlbaglanti bgl = new sqlbaglanti();

        private void FrmDoktorEkran_Load(object sender, EventArgs e)
        {
            LblTc.Text = doktortc;
            LblAdsoyad.Text = doktoradsoyad;

            SqlCommand command = new SqlCommand("Select DoktorAd, DoktorSoyad from Tbl_Doktorlar where DoktorTC=@p1", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", doktortc);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                LblAdsoyad.Text = reader[0] + " " + reader[1];
            }
            bgl.baglanti().Close();
        }
        private void BtnMuayene_Click(object sender, EventArgs e)
        {
            FrmMuayene frmMuayene = new FrmMuayene();
            frmMuayene.Show();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris frmDoktorGiris = new FrmDoktorGiris();
            frmDoktorGiris.Show();
            this.Hide();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            FrmDoktorGuncelle frmDoktorGuncelle = new FrmDoktorGuncelle();
            frmDoktorGuncelle.doktortc = LblTc.Text;
            frmDoktorGuncelle.Show();
        }

        private void BtnDetay_Click(object sender, EventArgs e)
        {
            FrmDoktorDetay frmDoktorDetay = new FrmDoktorDetay();
            frmDoktorDetay.doktortc = LblTc.Text;
            frmDoktorDetay.Show();
        }

        private void BtnRandevular_Click(object sender, EventArgs e)
        {
            FrmDoktorRandevu frmDoktorRandevu= new FrmDoktorRandevu();
            frmDoktorRandevu.doktoradi = LblAdsoyad.Text;
            frmDoktorRandevu.Show();
        }
    }
}
