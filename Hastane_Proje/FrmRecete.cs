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
    public partial class FrmRecete : Form
    {
        public FrmRecete()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();
        public string hastaAdSoyad;
        public string hastaTC;
        public string ilacAdi;
        public DateTime MuayeneTarihi;
        private void FrmRecete_Load(object sender, EventArgs e)
        {
            TxtHastaAd.Text = hastaAdSoyad;
            MskHastaTC.Text = hastaTC;
            RchIlac.Text = ilacAdi;
            MskTarih.Text = MuayeneTarihi.ToString("dd.MM.yyyy");
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
