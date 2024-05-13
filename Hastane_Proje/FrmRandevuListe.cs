﻿using System;
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
    public partial class FrmRandevuListe : Form
    {
        public FrmRandevuListe()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();

        public string hastatc;
        private void FrmRandevuListe_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Randevular WHERE HastaTC = @p1", bgl.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@p1", hastatc);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            // Bağlantı kapatılıyor
            bgl.baglanti().Close();
        }

        
    }
}
