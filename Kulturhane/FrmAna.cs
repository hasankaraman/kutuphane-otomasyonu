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
    public partial class FrmAna : Form
    {
        public FrmAna()
        {
            InitializeComponent();
        }

        private void FrmAna_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void kitapTanımlaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FrmTanimlaKitap { MdiParent = this, StartPosition = FormStartPosition.Manual, Location = new Point(0, 0) }.Show();
        }

        private void yazarTanımlaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FrmTanimlaYazar { MdiParent = this, StartPosition = FormStartPosition.Manual, Location = new Point(0, 0) }.Show();
        }

        private void kitapTürüTanımlaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FrmTanimlaKitapTuru { MdiParent = this, StartPosition = FormStartPosition.Manual, Location = new Point(0, 0) }.Show();
        }

        private void rafTanımlaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FrmTanimlaRaf { MdiParent = this, StartPosition = FormStartPosition.Manual, Location = new Point(0, 0) }.Show();
        }

        private void yayıneviTanımlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmTanimlaYayinevi { MdiParent = this, StartPosition = FormStartPosition.Manual, Location = new Point(0, 0) }.Show();
        }

        private void üyeTanımlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmTanimlaUye { MdiParent = this, StartPosition = FormStartPosition.Manual, Location = new Point(0, 0) }.Show();
        }

        private void emanetKitapVerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmEmanetKitapVer { MdiParent = this, StartPosition = FormStartPosition.Manual, Location = new Point(0, 0) }.Show();
        }

        #region Rapor
        private void kitapListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmRapor(RaporTuru.TumKitaplarinListesi) { MdiParent = this, StartPosition = FormStartPosition.Manual, Location = new Point(0, 0) }.Show();
        }

        private void alınanKitaplarınListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmRapor(RaporTuru.AlinanKitaplarinListesi) { MdiParent = this, StartPosition = FormStartPosition.Manual, Location = new Point(0, 0) }.Show();
        }

        private void hibeliKitaplarınListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmRapor(RaporTuru.HibeliKitaplarinListesi) { MdiParent = this, StartPosition = FormStartPosition.Manual, Location = new Point(0, 0) }.Show();
        }

        private void emanetteOlanKitaplarınListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmRapor(RaporTuru.EmanetteOlanKitaplarinListesi) { MdiParent = this, StartPosition = FormStartPosition.Manual, Location = new Point(0, 0) }.Show();
        }

        private void uyeListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmRapor(RaporTuru.UyeListesi) { MdiParent = this, StartPosition = FormStartPosition.Manual, Location = new Point(0, 0) }.Show();
        }

        private void yazarListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmRapor(RaporTuru.YazarListesi) { MdiParent = this, StartPosition = FormStartPosition.Manual, Location = new Point(0, 0) }.Show();
        }

        private void rafListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmRapor(RaporTuru.RafListesi) { MdiParent = this, StartPosition = FormStartPosition.Manual, Location = new Point(0, 0) }.Show();
        }

        private void emanetHareketListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmRapor(RaporTuru.EmanetHareketListesi) { MdiParent = this, StartPosition = FormStartPosition.Manual, Location = new Point(0, 0) }.Show();
        }

        private void emanetteOlmayanKitaplarınListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmRapor(RaporTuru.EmanetteOlmayanKitaplarinListesi) { MdiParent = this, StartPosition = FormStartPosition.Manual, Location = new Point(0, 0) }.Show();
        }
        #endregion
    }
} 