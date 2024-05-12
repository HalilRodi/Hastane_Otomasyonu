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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public string doktortc;
        public string doktoradsoyad;

        private void FrmDoktorDetay_Load(object sender, EventArgs e)
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

            //Randevu çekme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Randevular WHERE RandevuDoktor='" + LblAdsoyad.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        

        // şikayetleri richtextboxa çekme
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            RchSikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnBilgiDuzenle_Click(object sender, EventArgs e)
        {
            FrmDoktorGuncelle frmDoktorGuncelle =new FrmDoktorGuncelle();
            frmDoktorGuncelle.doktortc = LblTc.Text;
            frmDoktorGuncelle.Show();
        }

        private void BtnMuayene_Click(object sender, EventArgs e)
        {
            FrmMuayene frmMuayene =new FrmMuayene();
            frmMuayene.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sikayet = dataGridView1.SelectedCells[0].RowIndex;
            RchSikayet.Text = dataGridView1.Rows[sikayet].Cells[7].Value.ToString();
        }
    }
}
