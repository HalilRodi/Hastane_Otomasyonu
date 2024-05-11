using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
