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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
            string connStr = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=VeriDeposu.accdb";
            OleDbHelper dbHelper = new OleDbHelper();
            dbHelper.Baglan(connStr);
            OrtakNokta.DbHelper = dbHelper;
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kadi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text.Trim();
            if (Islemler.GirisYap(kadi, sifre))
            {
                new FrmAna().Show();
                Hide();
            }
            else MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre Girdiniz!");
        }
    }
}
