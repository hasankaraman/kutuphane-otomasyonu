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
    public partial class FrmTanimlaYazar : Form
    {
        public FrmTanimlaYazar()
        {
            InitializeComponent();
            GetYazarlar();
            dataGridView1.Columns[0].Visible = false;
        }

        private void GetYazarlar()
        {
            DataTable dt = Islemler.GetYazarlar();
            dataGridView1.DataSource = dt;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string adi = txtYazar.Text.Trim();

            if (adi == "")
            {
                MessageBox.Show("Kitap Türünü Girin!");
                return;
            }

            if (Islemler.VarMiYazar(adi))
            {
                MessageBox.Show("Yazar Zaten Kayıtlıdır!");
                return;
            }

            if (Islemler.EkleYazar(adi))
            {
                MessageBox.Show("Yazar Başarıyla Tanımlandı.");
                GetYazarlar();
                txtYazar.SelectAll();
                txtYazar.Focus();
            }
            else MessageBox.Show("Yazar Eklenirken Hata Oluştu!");
        } 

        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            int yazarID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            string adi = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Islemler.GuncelleYazar(yazarID, adi);
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            int yazarID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            string adi = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            DialogResult result = MessageBox.Show(adi + " İsimli Yazarı Silmek İstediğinize Emin Misiniz?", "Yazar Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (Islemler.SilYazar(yazarID))
                {
                    MessageBox.Show("Yazar Başarıyla Silindi!");
                    GetYazarlar();
                }
            } 
        }
    }
}
