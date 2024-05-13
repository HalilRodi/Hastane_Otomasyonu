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
    public partial class FrmDoktorRandevu : Form
    {
        public FrmDoktorRandevu()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();
        public string doktoradi;

        private void FrmDoktorRandevu_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Randevular WHERE RandevuDoktor = @p1", bgl.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@p1", doktoradi);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            // Bağlantı kapatılıyor
            bgl.baglanti().Close();
        }
    }
}
