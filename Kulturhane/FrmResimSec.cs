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
    public enum FormAdi
    {
        Kitap,
        Uye
    }
    public partial class FrmResimSec : Form
    {
        int _UyeVeKitapID;
        FormAdi _FormAdi;
        public FrmResimSec(FormAdi formAdi, int uyeVeKitapID, string yol)
        {
            InitializeComponent();
            _UyeVeKitapID = uyeVeKitapID;
            _FormAdi = formAdi;

            if (yol != "") pictureBox1.ImageLocation = yol;
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Resim Dosyası (*.jpg)|*.jpg;";
            if (ofd.ShowDialog() == DialogResult.OK) pictureBox1.ImageLocation = ofd.FileName;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (_FormAdi == FormAdi.Uye)
            {
                string dizin = Application.StartupPath + "\\Uyeler\\";
                string yol = dizin + _UyeVeKitapID.ToString() + ".jpg";
                if (!Directory.Exists(dizin)) Directory.CreateDirectory(dizin);
                pictureBox1.Image.Save(yol);
                Islemler.GuncelleUyeResim(_UyeVeKitapID, yol);
            }
            else
            {
                string dizin = Application.StartupPath + "\\Kitaplar\\";
                string yol = dizin + _UyeVeKitapID.ToString() + ".jpg";
                if (!Directory.Exists(dizin)) Directory.CreateDirectory(dizin);
                pictureBox1.Image.Save(yol);
                Islemler.GuncelleKitapResim(_UyeVeKitapID, yol);
            }
        }
    }
}
