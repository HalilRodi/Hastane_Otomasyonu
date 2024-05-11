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
            FrmRecete frmRecete = new FrmRecete();
            frmRecete.Show();
        }

        private void FrmMuayene_Load(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Select İlaçAd From Tbl_İlaçlar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                Cmbİlac.Items.Add(dr2[0].ToString());
            }
            bgl.baglanti().Close();

            
            
        }
    }
}
