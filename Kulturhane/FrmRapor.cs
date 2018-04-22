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
using Excel = Microsoft.Office.Interop.Excel;

namespace Kulturhane
{
    public enum RaporTuru
    {
        TumKitaplarinListesi,
        AlinanKitaplarinListesi,
        HibeliKitaplarinListesi,
        EmanetHareketListesi,
        EmanetteOlanKitaplarinListesi,
        EmanetteOlmayanKitaplarinListesi,
        UyeListesi,
        YazarListesi,
        RafListesi
    }

    public partial class FrmRapor : Form
    {
        public FrmRapor(RaporTuru raporTuru)
        {
            InitializeComponent();
            if (raporTuru == RaporTuru.TumKitaplarinListesi)
            {
                dataGridView1.DataSource = Islemler.GetTumKitaplarinListesi();
                Text = "Raporlar - [Tüm Kitapların Listesi]";
            }
            else if (raporTuru == RaporTuru.AlinanKitaplarinListesi)
            {
                dataGridView1.DataSource = Islemler.GetAlinanKitaplarinListesi();
                Text = "Raporlar - [Alınan Kitapların Listesi]";
            }
            else if (raporTuru == RaporTuru.HibeliKitaplarinListesi)
            {
                dataGridView1.DataSource = Islemler.GetHibeliKitaplarinListesi();
                Text = "Raporlar - [Hibeli Kitapların Listesi]";
            }
            else if (raporTuru == RaporTuru.EmanetteOlanKitaplarinListesi)
            {
                dataGridView1.DataSource = Islemler.GetEmanetKitaplar();
                Text = "Raporlar - [Emanette Olan Kitapların Listesi]";
            }
            else if (raporTuru == RaporTuru.EmanetteOlmayanKitaplarinListesi)
            {
                dataGridView1.DataSource = Islemler.GetEmanetteOlmayanKitaplar();
                Text = "Raporlar - [Emanette Olmayanan Kitapların Listesi]";
            }
            else if (raporTuru == RaporTuru.EmanetHareketListesi)
            {
                dataGridView1.DataSource = Islemler.GetEmanetHareketListesi();
                Text = "Raporlar - [Emanet Hareket Listesi]";
            }
            else if (raporTuru == RaporTuru.UyeListesi)
            {
                dataGridView1.DataSource = Islemler.GetUyeler();
                Text = "Raporlar - [Üye Listesi]";
            }
            else if (raporTuru == RaporTuru.YazarListesi)
            {
                dataGridView1.DataSource = Islemler.GetYazarlar();
                Text = "Raporlar - [Yazar Listesi]";
            }
            else if (raporTuru == RaporTuru.RafListesi)
            {
                dataGridView1.DataSource = Islemler.GetRaflar();
                Text = "Raporlar - [Raf Listesi]";
            }
            this.Text += " | Kayıt Sayısı: " + dataGridView1.Rows.Count;
        }

        private void exceleAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = Text;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ToCsV(dataGridView1, sfd.FileName);
            }
        }
        // save the application 

        private void ToCsV(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dGV.RowCount; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }
    }
}