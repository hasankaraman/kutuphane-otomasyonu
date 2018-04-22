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
    public partial class FrmTanimlaRaf : Form
    {
        public FrmTanimlaRaf()
        {
            InitializeComponent();
            GetRaflar();
            dataGridView1.Columns[0].Visible = false;
        }

        private void GetRaflar()
        {
            dataGridView1.DataSource = Islemler.GetRaflar();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string adi = txtRaf.Text.Trim();

            if (adi == "")
            {
                MessageBox.Show("Raf Adını Girin!");
                return;
            }

            if (Islemler.VarMiRaf(adi))
            {
                MessageBox.Show("Raf Adı Zaten Kayıtlıdır!");
                return;
            }

            if (Islemler.EkleRaf(adi))
            {
                MessageBox.Show("Raf Başarıyla Tanımlandı.");
                GetRaflar();
                txtRaf.SelectAll();
                txtRaf.Focus();
            }
            else MessageBox.Show("Raf Eklenirken Hata Oluştu!");
        }

        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            int rafID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            string adi = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Islemler.GuncelleRaf(rafID, adi);
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            int rafID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            string adi = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            DialogResult result = MessageBox.Show(adi + " İsimli Rafı Silmek İstediğinize Emin Misiniz?", "Raf Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;
            if (Islemler.SilRaf(rafID))
            {
                MessageBox.Show("Raf Başarıyla Silindi!");
                GetRaflar();
            }
        }
    }
}
