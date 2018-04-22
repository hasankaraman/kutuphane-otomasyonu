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
    public partial class FrmTanimlaKitapTuru : Form
    {
        public FrmTanimlaKitapTuru()
        {
            InitializeComponent();
            GetKitapTurleri();
            dataGridView1.Columns[0].Visible = false;
        }

        private void GetKitapTurleri()
        {
            dataGridView1.DataSource = Islemler.GetKitapTurleri();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string adi = txtKitapTuru.Text.Trim();

            if (adi == "")
            {
                MessageBox.Show("Kitap Türünü Girin!");
                return;
            }

            if (Islemler.VarMiKitapTuru(adi))
            {
                MessageBox.Show("Kitap Türü Zaten Kayıtlıdır!");
                return;
            }

            if (Islemler.EkleKitapTuru(adi))
            {
                MessageBox.Show("Kitap Türü Başarıyla Tanımlandı.");
                GetKitapTurleri();
                txtKitapTuru.SelectAll();
                txtKitapTuru.Focus();
            }
            else MessageBox.Show("Kitap Türü Eklenirken Hata Oluştu!");
        }

        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            int turID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            string adi = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Islemler.GuncelleKitapTuru(turID, adi);
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            int turID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            string adi = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            DialogResult result = MessageBox.Show(adi + " İsimli Kitap Türünü Silmek İstediğinize Emin Misiniz?", "Kitap Türü Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;
            if (Islemler.SilKitapTuru(turID))
            {
                MessageBox.Show("Kitap Türü Başarıyla Silindi!");
                GetKitapTurleri();
            }
        }
    }
}
