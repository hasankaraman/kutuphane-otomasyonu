using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kulturhane
{
    public partial class FrmTanimlaUye : Form
    {
        public FrmTanimlaUye()
        {
            InitializeComponent();
            GetUyeler();
        }

        private void GetUyeler()
        {
            DataTable dt = Islemler.GetUyeler();
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                dataGridView1.Rows.Add(item[0], item[1], item[2], null, item[4], null, item[6], null);

                DataGridViewComboBoxCell colUyeTipi = (DataGridViewComboBoxCell)dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[3];
                colUyeTipi.Value = item[3];

                DataGridViewCheckBoxCell colAktifMi = (DataGridViewCheckBoxCell)dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[5];
                colAktifMi.Value = item[5];

                string resim = item[7].ToString();
                if (resim == "") continue;

                Bitmap bitmap = new Bitmap(resim);

                DataGridViewImageCell colResim = (DataGridViewImageCell)dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[7];
                colResim.Value = bitmap;
                colResim.Tag = resim;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string adi = txtAdi.Text.Trim();

            if (adi == "")
            {
                MessageBox.Show("Üyenin Adını Girin!");
                return;
            }

            if (cmbUyeTipi.SelectedIndex == -1)
            {
                MessageBox.Show("Üye Tipini Seçin");
                return;
            }

            string uyeTipi = cmbUyeTipi.Text;

            if (Islemler.VarMiUye(adi))
            {
                MessageBox.Show("Üye Zaten Kayıtlıdır!");
                return;
            }

            string resimYolu = pictureBox1.ImageLocation == null ? "" : pictureBox1.ImageLocation;

            if (Islemler.EkleUye(adi, txtTel.Text, uyeTipi, txtAdres.Text.Trim(), resimYolu))
            {
                int id = Islemler.GetUyeID(adi);
                string dizin = Application.StartupPath + "\\Uyeler\\";
                string yol = dizin + id.ToString() + ".jpg";
                if (!Directory.Exists(dizin)) Directory.CreateDirectory(dizin);
                pictureBox1.Image.Save(yol);
                Islemler.GuncelleUyeResim(id, yol);

                MessageBox.Show("Üye Başarıyla Tanımlandı.");
                GetUyeler();
                txtAdi.SelectAll();
                txtAdi.Focus();
            }
            else MessageBox.Show("Üye Eklenirken Hata Oluştu!");
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            int uyeID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            string adi = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            DialogResult result = MessageBox.Show(adi + " İsimli Üyeyi Silmek İstediğinize Emin Misiniz?", "Üye Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;
            if (Islemler.SilUye(uyeID))
            {
                MessageBox.Show("Üye Başarıyla Silindi!");
                GetUyeler();
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int uyeID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            string adi = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string tel = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string uyeTipi = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string adres = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            bool uyeAktifMi = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[5].Value);
            Islemler.GuncelleUye(uyeID, adi, tel, uyeTipi, adres, uyeAktifMi);
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != 7) return;

            DataGridViewImageCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewImageCell;
            int uyeID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            if (cell.Value == null) new FrmResimSec(FormAdi.Uye, uyeID, "").ShowDialog();
            else new FrmResimSec(FormAdi.Uye, uyeID, cell.Tag.ToString()).ShowDialog();
            GetUyeler();
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Resim Dosyası (*.jpg)|*.jpg;";
            if (ofd.ShowDialog() == DialogResult.OK) pictureBox1.ImageLocation = ofd.FileName;
        }

        private void resmiSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            int uyeID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Islemler.GuncelleUyeResim(uyeID, "");
            GetUyeler();
        }
    }
}
