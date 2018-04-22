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
    public partial class FrmTanimlaKitap : Form
    {
        public FrmTanimlaKitap()
        {
            InitializeComponent();
            GetYazar();
            GetKitapTuru();
            GetRaf();
            GetYayinevi();
            GetKitap("");
        }

        private void GetKitap(string aranacakIfade)
        {
            DataTable dt = aranacakIfade == "" ? Islemler.GetKitaplar() : Islemler.GetLikeKitaplar(aranacakIfade);
            dataGridView1.Rows.Clear();
            lblToplamKitapSayisi.Text = "Toplam Kitap Sayısı: " + dt.Rows.Count.ToString();
            foreach (DataRow item in dt.Rows)
            {
                /*0 KitapID
                 *1 DemirbasNo
                 *2 KitapAdi
                 *3 YazarID
                 *4 TurID
                 *5 RafID
                 *6 YayineviID
                 *7 GelisSekli
                 *8 Aciklama
                 *9 GelisTar
                 *10 Adet
                 *11 Cilt
                 *12 ResimYolu
                 *13 Durum
                 */

                string kitapDurum = Islemler.GetKitapDurum(Convert.ToInt32(item[0]));

                dataGridView1.Rows.Add(item[0], item[1], item[2], null, null, null, null,
                    null, item[8], item[9], item[10], item[11], null, kitapDurum);

                DataGridViewComboBoxCell colYazar = (DataGridViewComboBoxCell)dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[3];
                colYazar.DataSource = cmbYazar.DataSource as DataTable;
                colYazar.DisplayMember = "Adi";
                colYazar.ValueMember = "YazarID";
                colYazar.Value = item[3];

                DataGridViewComboBoxCell colKitapTur = (DataGridViewComboBoxCell)dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[4];
                colKitapTur.DataSource = cmbKitapTuru.DataSource as DataTable;
                colKitapTur.DisplayMember = "Adi";
                colKitapTur.ValueMember = "KitapTurID";
                colKitapTur.Value = item[4];

                DataGridViewComboBoxCell colRaf = (DataGridViewComboBoxCell)dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[5];
                colRaf.DataSource = cmbRaf.DataSource as DataTable;
                colRaf.DisplayMember = "Adi";
                colRaf.ValueMember = "RafID";
                colRaf.Value = item[5];

                DataGridViewComboBoxCell colYayinevi = (DataGridViewComboBoxCell)dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[6];
                colYayinevi.DataSource = cmbYayinevi.DataSource as DataTable;
                colYayinevi.DisplayMember = "Adi";
                colYayinevi.ValueMember = "YayineviID";
                colYayinevi.Value = item[6];

                DataGridViewComboBoxCell colGelisSekli = (DataGridViewComboBoxCell)dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[7];
                colGelisSekli.Value = item[7];

                string resim = item[12].ToString();
                if (resim == "") continue;

                Bitmap bitmap = new Bitmap(resim);

                DataGridViewImageCell colResim = (DataGridViewImageCell)dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[12];
                colResim.Value = bitmap;
                colResim.Tag = resim;
            }
        }

        private void GetYazar()
        {
            cmbYazar.DataSource = Islemler.GetYazarlar();
            cmbYazar.DisplayMember = "Adi";
            cmbYazar.ValueMember = "YazarID";
        }

        private void GetKitapTuru()
        {
            cmbKitapTuru.DataSource = Islemler.GetKitapTurleri();
            cmbKitapTuru.DisplayMember = "Adi";
            cmbKitapTuru.ValueMember = "KitapTurID";
        }

        private void GetRaf()
        {
            cmbRaf.DataSource = Islemler.GetRaflar();
            cmbRaf.DisplayMember = "Adi";
            cmbRaf.ValueMember = "RafID";
        }

        private void GetYayinevi()
        {
            cmbYayinevi.DataSource = Islemler.GetYayinevleri();
            cmbYayinevi.DisplayMember = "Adi";
            cmbYayinevi.ValueMember = "YayineviID";
        }

        private void btnTanimlaYazar_Click(object sender, EventArgs e)
        {
            new FrmTanimlaYazar().ShowDialog();
            GetYazar();
        }

        private void btnTanimlaKitapTuru_Click(object sender, EventArgs e)
        {
            new FrmTanimlaKitapTuru().ShowDialog();
            GetKitapTuru();
        }

        private void btnTanimlaRaf_Click(object sender, EventArgs e)
        {
            new FrmTanimlaRaf().ShowDialog();
            GetRaf();
        }

        private void btnTanimlaYayinevi_Click(object sender, EventArgs e)
        {
            new FrmTanimlaYayinevi().ShowDialog();
            GetYayinevi();
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Resim Dosyası (*.jpg)|*.jpg;";
            if (ofd.ShowDialog() == DialogResult.OK) pictureBox1.ImageLocation = ofd.FileName;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string kitapAdi = txtKitapAdi.Text.Trim();

            if (kitapAdi == "")
            {
                MessageBox.Show("Kitap Adını Girin!");
                return;
            }

            if (Islemler.VarMiKitap(kitapAdi))
            {
                DialogResult result = MessageBox.Show("Kitap Zaten Kayıtlıdır!, Yine de Eklemek İstiyor Musunuz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No) return;
            }

            if (cmbYazar.SelectedIndex == -1)
            {
                MessageBox.Show("Yazar Seçin!");
                return;
            }

            if (cmbKitapTuru.SelectedIndex == -1)
            {
                MessageBox.Show("Kitap Türü Seçin!");
                return;
            }

            if (cmbRaf.SelectedIndex == -1)
            {
                MessageBox.Show("Raf Seçin!");
                return;
            }

            if (cmbYayinevi.SelectedIndex == -1)
            {
                MessageBox.Show("Yayınevi Seçin!");
                return;
            }

            if (cmbGelisSekli.SelectedIndex == -1)
            {
                MessageBox.Show("Geliş Şekli Seçin!");
                return;
            }

            int demirbasNo = Convert.ToInt32(numericDemirbasNo.Value.ToString());
            int yazarID = Convert.ToInt32(cmbYazar.SelectedValue);
            int rafID = Convert.ToInt32(cmbRaf.SelectedValue);
            int yayineviID = Convert.ToInt32(cmbYayinevi.SelectedValue);
            int kitapTurID = Convert.ToInt32(cmbKitapTuru.SelectedValue);
            int adet = (int)numericAdet.Value;
            int cilt = (int)numericCilt.Value;
            string aciklama = txtHibeAlinanYer.Text;
            DateTime gelisTar = dateGelmeTar.Value;
            string resimYolu = pictureBox1.ImageLocation == null ? "" : pictureBox1.ImageLocation;

            if (Islemler.EkleKitap(demirbasNo, kitapAdi, yazarID, kitapTurID, rafID, yayineviID, cmbGelisSekli.Text, aciklama, gelisTar, adet, cilt, resimYolu))
            {
                if (resimYolu != "")
                {
                    int id = Islemler.GetKitapID(kitapAdi);
                    string dizin = Application.StartupPath + "\\Kitaplar\\";
                    string yol = dizin + id.ToString() + ".jpg";
                    if (!Directory.Exists(dizin)) Directory.CreateDirectory(dizin);
                    pictureBox1.Image.Save(yol);
                    Islemler.GuncelleKitapResim(id, yol);
                }

                MessageBox.Show("Kitap Başarıyla Tanımlandı.");
                GetKitap("");
                txtKitapAdi.SelectAll();
                txtKitapAdi.Focus();
            }
            else MessageBox.Show("Kitap Eklenirken Hata Oluştu!");
        }

        private void cmbGelisSekli_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblHibeYer.Text = cmbGelisSekli.SelectedIndex == 0 ? "Hibe Eden" : "Alındığı Yer";
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            /*0 KitapID
             *1 DemirbasNo
             *2 KitapAdi
             *3 YazarID
             *4 TurID
             *5 RafID
             *6 YayineviID
             *7 GelisSekli
             *8 Aciklama
             *9 GelisTar
             *10 Adet
             *11 Cilt
             *12 ResimYolu
             *13 Durum
            */
            try
            {
                int kitapID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                int demirbasNo = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
                string kitapAdi = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                int yazarID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);
                int turID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value);
                int rafID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value);
                int yayineviID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value);
                string gelisSekli = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                string aciklama = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                DateTime gelisTar = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[9].Value);
                int adet = Convert.ToInt32(dataGridView1.CurrentRow.Cells[10].Value);
                int cilt = Convert.ToInt32(dataGridView1.CurrentRow.Cells[11].Value);
                Islemler.GuncelleKitap(kitapID, demirbasNo, kitapAdi, yazarID, turID, rafID, yayineviID, gelisSekli, aciklama, adet, cilt);
            }
            catch (Exception)
            {
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != 9) return;

            DataGridViewImageCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewImageCell;
            int kitapID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            if (cell.Value == null) new FrmResimSec(FormAdi.Kitap, kitapID, "").ShowDialog();
            else new FrmResimSec(FormAdi.Kitap, kitapID, cell.Tag.ToString()).ShowDialog();
            GetKitap("");
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            int uyeID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            string adi = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            DialogResult result = MessageBox.Show(adi + " İsimli Kitabı Silmek İstediğinize Emin Misiniz?", "Kitap Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;
            if (Islemler.SilKitap(uyeID))
            {
                MessageBox.Show("Kitap Başarıyla Silindi!");
                GetKitap("");
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string aranacakIfade = txtAranacakKelime.Text.TrimStart();
            GetKitap(aranacakIfade);
        }

        private void btnAramaIptal_Click(object sender, EventArgs e)
        {
            GetKitap("");
        }

        private void txtAranacakKelime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            btnAra.PerformClick();
        }
    }
}