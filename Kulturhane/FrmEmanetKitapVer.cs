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
    public partial class FrmEmanetKitapVer : Form
    {
        public FrmEmanetKitapVer()
        {
            InitializeComponent();
            GetUyeler();
            GetKitaplar();
            GetEmanetKitaplar();
        }

        private void GetUyeler()
        {
            cmbUye.DataSource = Islemler.GetUyeler();
            cmbUye.DisplayMember = "Adı Soyadı";
            cmbUye.ValueMember = "UyeID";
        }

        private void GetKitaplar()
        {
            cmbKitap.DataSource = Islemler.GetEmanetOlmayanKitaplar();
            cmbKitap.DisplayMember = "KitapAdi";
            cmbKitap.ValueMember = "KitapID";
        }

        private void GetEmanetKitaplar()
        {
            dataGridView1.DataSource = Islemler.GetEmanetKitaplar();
            dataGridView1.Columns[0].Visible = false;
        }

        private void btnTanimlaUye_Click(object sender, EventArgs e)
        {
            new FrmTanimlaUye().ShowDialog();
            GetUyeler();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cmbUye.SelectedIndex == -1)
            {
                MessageBox.Show("Üye Seçin");
                return;
            }

            if (cmbKitap.SelectedIndex == -1)
            {
                MessageBox.Show("Üye Seçin");
                return;
            }

            int uyeID = Convert.ToInt32(cmbUye.SelectedValue);
            int kitapID = Convert.ToInt32(cmbKitap.SelectedValue);

            string kitapDurum = Islemler.GetKitapDurum(kitapID);
            if (kitapDurum != "Müsait")
            {
                MessageBox.Show("Kitap Müsait Değildir! Listeyi Yenileyiniz!");
                return;
            }

            DateTime almaTar = dateAlmaTar.Value;
            DateTime verecegiTar = dateVermeTar.Value;

            if (Islemler.EkleEmanetKitap(uyeID, kitapID, almaTar, verecegiTar))
            {
                MessageBox.Show("Kitap Emanet Olarak Verildi!");
                GetEmanetKitaplar();
                GetKitaplar();
            }
            else MessageBox.Show("Kitap Emanet Olarak Verilirken Hata Oluştu!");
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            int emanetID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            string adi = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            DialogResult result = MessageBox.Show(adi + " İsimli Emanet Kitabı Emanetlerden Silmek İstediğinize Emin Misiniz?", "Üye Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;
            if (Islemler.SilEmanet(emanetID))
            {
                MessageBox.Show("Emanet Kitap Başarıyla Silindi!");
                GetUyeler();
            }
        }

        private void teslimEdildiOlarakİşaretleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            int emanetID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            string adi = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            if (Islemler.EmanetTeslimAlindiOlarakIsaretle(emanetID))
            {
                MessageBox.Show("Emanet Kitap Başarıyla Teslim Alındı!");
                GetEmanetKitaplar();
                GetKitaplar();
            }
        }
    }
}
