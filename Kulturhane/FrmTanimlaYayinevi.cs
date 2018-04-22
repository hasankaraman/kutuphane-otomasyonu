using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kulturhane
{
    public partial class FrmTanimlaYayinevi : Form
    {
        public FrmTanimlaYayinevi()
        {
            InitializeComponent();
            GetYayinevleri();
            dataGridView1.Columns[0].Visible = false;
        }

        private void GetYayinevleri()
        {
            dataGridView1.DataSource = Islemler.GetYayinevleri();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string adi = txtYayinevi.Text.Trim();

            if (adi == "")
            {
                MessageBox.Show("Yayınevi Adını Girin!");
                return;
            }

            if (Islemler.VarMiYayinevi(adi))
            {
                MessageBox.Show("Yayınevi Adı Zaten Kayıtlıdır!");
                return;
            }

            if (Islemler.EkleYayinevi(adi))
            {
                MessageBox.Show("Yayınevi Başarıyla Tanımlandı.");
                GetYayinevleri();
                txtYayinevi.SelectAll();
                txtYayinevi.Focus();
            }
            else MessageBox.Show("Yayınevi Eklenirken Hata Oluştu!");
        }

        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            int yayineviID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            string adi = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Islemler.GuncelleYayinevi(yayineviID, adi);
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            int yayineviID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            string adi = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            DialogResult result = MessageBox.Show(adi + " İsimli Yayınevini Silmek İstediğinize Emin Misiniz?", "Yayınevi Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;
            if (Islemler.SilYayinevi(yayineviID))
            {
                MessageBox.Show("Yayınevi Başarıyla Silindi!");
                GetYayinevleri();
            }
        }
    }
}
