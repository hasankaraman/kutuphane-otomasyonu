using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kulturhane
{
    class Islemler
    {
        public static bool GirisYap(string kadi, string sifre)
        {
            string sql = "select * from tblKullanici where kadi=@kadi and sifre=@sifre";
            OrtakNokta.DbHelper.Komut.Parameters.Clear();
            OrtakNokta.DbHelper.Komut.Parameters.Add("@kadi", OleDbType.VarChar).Value = kadi;
            OrtakNokta.DbHelper.Komut.Parameters.Add("@sifre", OleDbType.VarChar).Value = sifre;
            return OrtakNokta.DbHelper.KayitVarMi(sql);
        }

        #region KitapTurleri
        public static DataTable GetKitapTurleri()
        {
            string sql = "select * from tblKitapTuru order by adi";
            OrtakNokta.DbHelper.Komut.Parameters.Clear();
            return OrtakNokta.DbHelper.TabloAl(sql);
        }

        public static bool VarMiKitapTuru(string adi)
        {
            string sql = "select * from tblKitapTuru where Adi=@Adi";
            OrtakNokta.DbHelper.Komut.Parameters.Clear();
            OrtakNokta.DbHelper.Komut.Parameters.Add("@Adi", OleDbType.VarChar).Value = adi;
            return OrtakNokta.DbHelper.KayitVarMi(sql);
        }

        public static bool EkleKitapTuru(string adi)
        {
            string sql = "Insert Into tblKitapTuru(adi) Values(@Adi)";
            OrtakNokta.DbHelper.Komut.Parameters.Clear();
            OrtakNokta.DbHelper.Komut.Parameters.Add("@Adi", OleDbType.VarChar).Value = adi;
            return OrtakNokta.DbHelper.KomutCalistir(sql) > 0;
        }

        public static bool GuncelleKitapTuru(int kitapTurID, string adi)
        {
            string sql = "Update tblKitapTuru set adi=@Adi Where KitapTurID=@kitapTurID";
            OrtakNokta.DbHelper.Komut.Parameters.Clear();
            OrtakNokta.DbHelper.Komut.Parameters.Add("@Adi", OleDbType.VarChar).Value = adi;
            OrtakNokta.DbHelper.Komut.Parameters.Add("@kitapTurID", OleDbType.Integer).Value = kitapTurID;
            return OrtakNokta.DbHelper.KomutCalistir(sql) > 0;
        }

        public static bool SilKitapTuru(int kitapTurID)
        {
            string sql = "Delete From tblKitapTuru Where KitapTurID=@kitapTurID";
            OrtakNokta.DbHelper.Komut.Parameters.Clear();
            OrtakNokta.DbHelper.Komut.Parameters.Add("@kitapTurID", OleDbType.Integer).Value = kitapTurID;
            return OrtakNokta.DbHelper.KomutCalistir(sql) > 0;
        }
        #endregion

        #region Yazar 
        public static DataTable GetYazarlar()
        {
            string sql = "select * from tblYazar order by adi";
            OrtakNokta.DbHelper.Komut.Parameters.Clear();
            return OrtakNokta.DbHelper.TabloAl(sql);
        }

        public static bool VarMiYazar(string adi)
        {
            string sql = "select * from tblYazar where Adi=@Adi";
            OrtakNokta.DbHelper.Komut.Parameters.Clear();
            OrtakNokta.DbHelper.Komut.Parameters.Add("@Adi", OleDbType.VarChar).Value = adi;
            return OrtakNokta.DbHelper.KayitVarMi(sql);
        }

        public static bool EkleYazar(string adi)
        {
            string sql = "Insert Into tblYazar(adi) Values(@Adi)";
            OrtakNokta.DbHelper.Komut.Parameters.Clear();
            OrtakNokta.DbHelper.Komut.Parameters.Add("@Adi", OleDbType.VarChar).Value = adi;
            return OrtakNokta.DbHelper.KomutCalistir(sql) > 0;
        }

        public static bool GuncelleYazar(int yazarID, string adi)
        {
            string sql = "Update tblYazar set adi=@Adi Where YazarID=@yazarID";
            OrtakNokta.DbHelper.Komut.Parameters.Clear();
            OrtakNokta.DbHelper.Komut.Parameters.Add("@Adi", OleDbType.VarChar).Value = adi;
            OrtakNokta.DbHelper.Komut.Parameters.Add("@yazarID", OleDbType.Integer).Value = yazarID;
            return OrtakNokta.DbHelper.KomutCalistir(sql) > 0;
        }

        public static bool SilYazar(int yazarID)
        {
            string sql = "Delete From tblYazar Where YazarID=@yazarID";
            OrtakNokta.DbHelper.Komut.Parameters.Clear();
            OrtakNokta.DbHelper.Komut.Parameters.Add("@yazarID", OleDbType.Integer).Value = yazarID;
            return OrtakNokta.DbHelper.KomutCalistir(sql) > 0;
        }
        #endregion

        #region Raf 
        public static DataTable GetRaflar()
        {
            string sql = "select * from tblRaf order by adi";
            OrtakNokta.DbHelper.Komut.Parameters.Clear();
            return OrtakNokta.DbHelper.TabloAl(sql);
        }

        public static bool VarMiRaf(string adi)
        {
            string sql = "select * from tblRaf where Adi=@Adi";
            OrtakNokta.DbHelper.Komut.Parameters.Clear();
            OrtakNokta.DbHelper.Komut.Parameters.Add("@Adi", OleDbType.VarChar).Value = adi;
            return OrtakNokta.DbHelper.KayitVarMi(sql);
        }

        public static bool EkleRaf(string adi)
        {
            string sql = "Insert Into tblRaf(adi) Values(@Adi)";
            OrtakNokta.DbHelper.Komut.Parameters.Clear();
            OrtakNokta.DbHelper.Komut.Parameters.Add("@Adi", OleDbType.VarChar).Value = adi;
            return OrtakNokta.DbHelper.KomutCalistir(sql) > 0;
        }

        public static bool GuncelleRaf(int rafID, string adi)
        {
            string sql = "Update tblRaf set adi=@Adi Where RafID=@rafID";
            OrtakNokta.DbHelper.Komut.Parameters.Clear();
            OrtakNokta.DbHelper.Komut.Parameters.Add("@Adi", OleDbType.VarChar).Value = adi;
            OrtakNokta.DbHelper.Komut.Parameters.Add("@rafID", OleDbType.Integer).Value = rafID;
            return OrtakNokta.DbHelper.KomutCalistir(sql) > 0;
        }

        public static bool SilRaf(int rafID)
        {
            string sql = "Delete From tblRaf Where RafID=@rafID";
            OrtakNokta.DbHelper.Komut.Parameters.Clear();
            OrtakNokta.DbHelper.Komut.Parameters.Add("@rafID", OleDbType.Integer).Value = rafID;
            return OrtakNokta.DbHelper.KomutCalistir(sql) > 0;
        }
        #endregion

        #region Yayinevleri 
        public static DataTable GetYayinevleri()
        {
            string sql = "select * from tblYayinevi order by adi";
            OrtakNokta.DbHelper.Komut.Parameters.Clear();
            return OrtakNokta.DbHelper.TabloAl(sql);
        }

        public static bool VarMiYayinevi(string adi)
        {
            string sql = "select * from tblYayinevi where Adi=@Adi";
            OrtakNokta.DbHelper.Komut.Parameters.Clear();
            OrtakNokta.DbHelper.Komut.Parameters.Add("@Adi", OleDbType.VarChar).Value = adi;
            return OrtakNokta.DbHelper.KayitVarMi(sql);
        }

        public static bool EkleYayinevi(string adi)
        {
            string sql = "Insert Into tblYayinevi(adi) Values(@Adi)";
            OrtakNokta.DbHelper.Komut.Parameters.Clear();
            OrtakNokta.DbHelper.Komut.Parameters.Add("@Adi", OleDbType.VarChar).Value = adi;
            return OrtakNokta.DbHelper.KomutCalistir(sql) > 0;
        }

        public static bool GuncelleYayinevi(int yayineviID, string adi)
        {
            string sql = "Update tblYayinevi set adi=@Adi Where YayineviID=@yayineviID";
            OrtakNokta.DbHelper.Komut.Parameters.Clear();
            OrtakNokta.DbHelper.Komut.Parameters.Add("@Adi", OleDbType.VarChar).Value = adi;
            OrtakNokta.DbHelper.Komut.Parameters.Add("@yayineviID", OleDbType.Integer).Value = yayineviID;
            return OrtakNokta.DbHelper.KomutCalistir(sql) > 0;
        }

        public static bool SilYayinevi(int yayineviID)
        {
            string sql = "Delete From tblYayinevi Where YayineviID=@yayineviID";
            OrtakNokta.DbHelper.Komut.Parameters.Clear();
            OrtakNokta.DbHelper.Komut.Parameters.Add("@yayineviID", OleDbType.Integer).Value = yayineviID;
            return OrtakNokta.DbHelper.KomutCalistir(sql) > 0;
        }
        #endregion

        #region Uye 
        public static DataTable GetUyeler()
        {
            string sql = "SELECT tblUye.UyeID, tblUye.AdiSoyadi as [Adı Soyadı], tblUye.Telefon, tblUye.UyeTipi as [Üye Tipi], tblUye.Adres, tblUye.UyeAktifMi as [Üye Aktif Mi], tblUye.UyeTar as [Üye Tarihi], tblUye.ResimYolu as [Resim Yolu] FROM tblUye;";
            OrtakNokta.DbHelper.Komut.Parameters.Clear();
            return OrtakNokta.DbHelper.TabloAl(sql);
        }

        public static int GetUyeID(string adi)
        {
            string sql = "select * from tblUye where AdiSoyadi=@adi";
            OrtakNokta.DbHelper.Komut.Parameters.Clear();
            OrtakNokta.DbHelper.Komut.Parameters.Add("@Adi", OleDbType.VarChar).Value = adi;
            return Convert.ToInt32(OrtakNokta.DbHelper.TabloAl(sql).Rows[0][0]);
        }


        public static bool VarMiUye(string adiSoyadi)
        {
            string sql = "select * from tblUye where AdiSoyadi=@Adi";
            OrtakNokta.DbHelper.Komut.Parameters.Clear();
            OrtakNokta.DbHelper.Komut.Parameters.Add("@Adi", OleDbType.VarChar).Value = adiSoyadi;
            return OrtakNokta.DbHelper.KayitVarMi(sql);
        }

        public static bool EkleUye(string adi, string tel, string uyeTipi, string adres, string resimYolu)
        {
            string sql = "Insert Into tblUye(adiSoyadi, telefon, uyeTipi, adres, resimyolu) Values(@adi, @tel, @uyeTipi, @adres, @resimyolu)";
            OrtakNokta.DbHelper.Komut.Parameters.Clear();
            OrtakNokta.DbHelper.Komut.Parameters.Add("@Adi", OleDbType.VarChar).Value = adi;
            OrtakNokta.DbHelper.Komut.Parameters.Add("@tel", OleDbType.VarChar).Value = tel;
            OrtakNokta.DbHelper.Komut.Parameters.Add("@uyeTipi", OleDbType.VarChar).Value = uyeTipi;
            OrtakNokta.DbHelper.Komut.Parameters.Add("@adres", OleDbType.VarChar).Value = adres;
            OrtakNokta.DbHelper.Komut.Parameters.Add("@resimyolu", OleDbType.VarChar).Value = resimYolu;
            return OrtakNokta.DbHelper.KomutCalistir(sql) > 0;
        }

        public static bool GuncelleUyeResim(int uyeID, string yol)
        {
            string sql = "update tblUye set resimYolu=@yol where uyeID=@uyeID";
            OrtakNokta.DbHelper.Komut.Parameters.Clear();
            OrtakNokta.DbHelper.Komut.Parameters.Add("@yol", OleDbType.VarChar).Value = yol;
            OrtakNokta.DbHelper.Komut.Parameters.Add("@uyeID", OleDbType.Integer).Value = uyeID;
            return OrtakNokta.DbHelper.KayitVarMi(sql);
        }

        public static bool GuncelleUye(int uyeID, string adi, string tel, string uyeTipi, string adres, bool uyeAktifMi)
        {
            string sql = "Update tblUye set adiSoyadi=@Adi, telefon=@tel, uyeTipi=@uyeTipi, adres=@adres, uyeAktifMi=@uyeAktifMi Where UyeID=@uyeID";
            OrtakNokta.DbHelper.Komut.Parameters.Clear();
            OrtakNokta.DbHelper.Komut.Parameters.Add("@Adi", OleDbType.VarChar).Value = adi;
            OrtakNokta.DbHelper.Komut.Parameters.Add("@tel", OleDbType.VarChar).Value = tel;
            OrtakNokta.DbHelper.Komut.Parameters.Add("@uyeTipi", OleDbType.VarChar).Value = uyeTipi;
            OrtakNokta.DbHelper.Komut.Parameters.Add("@adres", OleDbType.VarChar).Value = adres;
            OrtakNokta.DbHelper.Komut.Parameters.Add("@uyeAktifMi", OleDbType.Boolean).Value = uyeAktifMi;
            OrtakNokta.DbHelper.Komut.Parameters.Add("@uyeID", OleDbType.Integer).Value = uyeID;
            return OrtakNokta.DbHelper.KomutCalistir(sql) > 0;
        }

        public static bool SilUye(int uyeID)
        {
            string sql = "Delete From tblUye Where UyeID=@uyeID";
            OrtakNokta.DbHelper.Komut.Parameters.Clear();
            OrtakNokta.DbHelper.Komut.Parameters.Add("@uyeID", OleDbType.Integer).Value = uyeID;
            return OrtakNokta.DbHelper.KomutCalistir(sql) > 0;
        }
        #endregion

        #region Kitap 
        public static DataTable GetKitaplar()
        {
            string sql = "select * from tblKitap order by kitapAdi";
            OrtakNokta.DbHelper.Komut.Parameters.Clear();
            return OrtakNokta.DbHelper.TabloAl(sql);
        }

        public static DataTable GetLikeKitaplar(string aranacakIfade)
        {
            string sql = "select * from tblKitap Where KitapAdi like '%" + aranacakIfade + "%' order by kitapAdi";
            OrtakNokta.DbHelper.Komut.Parameters.Clear();
            return OrtakNokta.DbHelper.TabloAl(sql);
        }

        public static DataTable GetTumKitaplarinListesi()
        {
            string sql = @"SELECT tblKitap.DemirbasNo as [Demirbaş No], tblKitap.KitapAdi as [Kitap Adı], tblYazar.Adi as Yazar, tblKitapTuru.Adi as [Kitap Türü], tblRaf.Adi as [Raf Adı], tblKitap.GelisSekli as [Gelis Sekli], tblKitap.Aciklama
                           FROM((tblKitap INNER JOIN tblRaf ON tblKitap.RafID = tblRaf.RafID) INNER JOIN tblYazar ON tblKitap.YazarID = tblYazar.YazarID) INNER JOIN tblKitapTuru ON tblKitap.TurID = tblKitapTuru.KitapTurID;";
            OrtakNokta.DbHelper.Komut.Parameters.Clear();
            return OrtakNokta.DbHelper.TabloAl(sql);
        }

        public static DataTable GetAlinanKitaplarinListesi()
        {
            string sql = @"SELECT tblKitap.DemirbasNo as [Demirbaş No], tblKitap.KitapAdi as [Kitap Adı], tblYazar.Adi as Yazar, tblKitapTuru.Adi as [Kitap Türü], tblRaf.Adi as [Raf Adı], tblKitap.GelisSekli as [Gelis Sekli], tblKitap.Aciklama
                           FROM((tblKitap INNER JOIN tblRaf ON tblKitap.RafID = tblRaf.RafID) INNER JOIN tblYazar ON tblKitap.YazarID = tblYazar.YazarID) INNER JOIN tblKitapTuru ON tblKitap.TurID = tblKitapTuru.KitapTurID
                           Where GelisSekli='Satın Alınan' order by kitapAdi";
            OrtakNokta.DbHelper.Komut.Parameters.Clear();
            return OrtakNokta.DbHelper.TabloAl(sql);
        }

        public static DataTable GetHibeliKitaplarinListesi()
        {
            string sql = @"SELECT tblKitap.DemirbasNo as [Demirbaş No], tblKitap.KitapAdi as [Kitap Adı], tblYazar.Adi as Yazar, tblKitapTuru.Adi as [Kitap Türü], tblRaf.Adi as [Raf Adı], tblKitap.GelisSekli as [Gelis Sekli], tblKitap.Aciklama
                           FROM((tblKitap INNER JOIN tblRaf ON tblKitap.RafID = tblRaf.RafID) INNER JOIN tblYazar ON tblKitap.YazarID = tblYazar.YazarID) INNER JOIN tblKitapTuru ON tblKitap.TurID = tblKitapTuru.KitapTurID
                           Where GelisSekli='Hibe' order by kitapAdi";
            OrtakNokta.DbHelper.Komut.Parameters.Clear();
            return OrtakNokta.DbHelper.TabloAl(sql);
        }

        public static string GetKitapDurum(int kitapID)
        {
            string sql = "select * from tblEmanet where KitapID=@KitapID And TeslimEdildiMi=1";
            OrtakNokta.DbHelper.Komut.Parameters.Clear();
            OrtakNokta.DbHelper.Komut.Parameters.Add("@KitapID", OleDbType.Integer).Value = kitapID;
            return OrtakNokta.DbHelper.TabloAl(sql).Rows.Count > 0 ? "Emanette" : "Müsait";
        }

        public static int GetKitapID(string adi)
        {
            string sql = "select * from tblKitap where KitapAdi=@adi";
            OrtakNokta.DbHelper.Komut.Parameters.Clear();
            OrtakNokta.DbHelper.Komut.Parameters.Add("@Adi", OleDbType.VarChar).Value = adi;
            return Convert.ToInt32(OrtakNokta.DbHelper.TabloAl(sql).Rows[0][0]);
        }

        public static bool VarMiKitap(string adi)
        {
            string sql = "select * from tblKitap where KitapAdi=@Adi";
            OrtakNokta.DbHelper.Komut.Parameters.Clear();
            OrtakNokta.DbHelper.Komut.Parameters.Add("@Adi", OleDbType.VarChar).Value = adi;
            return OrtakNokta.DbHelper.KayitVarMi(sql);
        }

        public static bool EkleKitap(int demirbasNo, string kitapAdi, int yazarID, int turID, int rafID, int yayineviID, string gelisSekli, string aciklama, DateTime gelisTar, int adet, int cilt, string resimYolu)
        {
            string sql = @"Insert Into tblKitap(demirbasNo, kitapAdi, yazarID, turID, rafID, yayineviID, gelisSekli, aciklama, gelisTar, adet, cilt, resimyolu) 
                           Values(@demirbasNo, @kitapAdi, @yazarID, @turID, @rafID, @yayineviID, @gelisSekli, @aciklama, @gelisTar, @adet, @cilt, @resimyolu)";
            OrtakNokta.DbHelper.Komut.Parameters.Clear();
            OrtakNokta.DbHelper.Komut.Parameters.Add("@demirbasNo", OleDbType.Integer).Value = demirbasNo;
            OrtakNokta.DbHelper.Komut.Parameters.Add("@kitapAdi", OleDbType.VarChar).Value = kitapAdi;
            OrtakNokta.DbHelper.Komut.Parameters.Add("@yazarID", OleDbType.Integer).Value = yazarID;
            OrtakNokta.DbHelper.Komut.Parameters.Add("@turID", OleDbType.Integer).Value = turID;
            OrtakNokta.DbHelper.Komut.Parameters.Add("@rafID", OleDbType.Integer).Value = rafID;
            OrtakNokta.DbHelper.Komut.Parameters.Add("@yayineviID", OleDbType.Integer).Value = yayineviID;
            OrtakNokta.DbHelper.Komut.Parameters.Add("@gelisSekli", OleDbType.VarChar).Value = gelisSekli;
            OrtakNokta.DbHelper.Komut.Parameters.Add("@aciklama", OleDbType.VarChar).Value = aciklama;
            OrtakNokta.DbHelper.Komut.Parameters.Add("@gelisTar", OleDbType.Date).Value = gelisTar;
            OrtakNokta.DbHelper.Komut.Parameters.Add("@adet", OleDbType.Integer).Value = adet;
            OrtakNokta.DbHelper.Komut.Parameters.Add("@cilt", OleDbType.Integer).Value = cilt;
            OrtakNokta.DbHelper.Komut.Parameters.Add("@resimyolu", OleDbType.VarChar).Value = resimYolu;
            return OrtakNokta.DbHelper.KomutCalistir(sql) > 0;
        }

        public static bool GuncelleKitapResim(int kitapID, string yol)
        {
            string sql = "update tblKitap set resimYolu=@yol where kitapID=@kitapID";
            OrtakNokta.DbHelper.Komut.Parameters.Clear();
            OrtakNokta.DbHelper.Komut.Parameters.Add("@yol", OleDbType.VarChar).Value = yol;
            OrtakNokta.DbHelper.Komut.Parameters.Add("@kitapID", OleDbType.Integer).Value = kitapID;
            return OrtakNokta.DbHelper.KayitVarMi(sql);
        }

        public static bool GuncelleKitap(int kitapID, int demirbasNo, string kitapAdi, int yazarID, int turID, int rafID, int yayineviID, string gelisSekli, string aciklama, int adet, int cilt)
        {
            string sql = "Update tblKitap set demirbasNo=@demirbasNo, kitapAdi=@kitapAdi, yazarID=@yazarID, turID=@turID, rafID=@rafID, yayineviID=@yayineviID, gelisSekli=@gelisSekli, aciklama=@aciklama, gelisTar=@gelisTar, adet=@adet, cilt=@cilt Where KitapID=@kitapID";
            OrtakNokta.DbHelper.Komut.Parameters.Clear();
            OrtakNokta.DbHelper.Komut.Parameters.Clear();
            OrtakNokta.DbHelper.Komut.Parameters.Add("@demirbasNo", OleDbType.Integer).Value = demirbasNo;
            OrtakNokta.DbHelper.Komut.Parameters.Add("@kitapAdi", OleDbType.VarChar).Value = kitapAdi;
            OrtakNokta.DbHelper.Komut.Parameters.Add("@yazarID", OleDbType.Integer).Value = yazarID;
            OrtakNokta.DbHelper.Komut.Parameters.Add("@turID", OleDbType.Integer).Value = turID;
            OrtakNokta.DbHelper.Komut.Parameters.Add("@rafID", OleDbType.Integer).Value = rafID;
            OrtakNokta.DbHelper.Komut.Parameters.Add("@yayineviID", OleDbType.Integer).Value = yayineviID;
            OrtakNokta.DbHelper.Komut.Parameters.Add("@gelisSekli", OleDbType.VarChar).Value = gelisSekli;
            OrtakNokta.DbHelper.Komut.Parameters.Add("@aciklama", OleDbType.VarChar).Value = aciklama;
            OrtakNokta.DbHelper.Komut.Parameters.Add("@adet", OleDbType.Integer).Value = adet;
            OrtakNokta.DbHelper.Komut.Parameters.Add("@cilt", OleDbType.Integer).Value = cilt;
            OrtakNokta.DbHelper.Komut.Parameters.Add("@kitapID", OleDbType.VarChar).Value = kitapID;
            return OrtakNokta.DbHelper.KomutCalistir(sql) > 0;
        }

        public static bool SilKitap(int kitapID)
        {
            string sql = "Delete From tblKitap Where kitapID=@kitapID";
            OrtakNokta.DbHelper.Komut.Parameters.Clear();
            OrtakNokta.DbHelper.Komut.Parameters.Add("@kitapID", OleDbType.Integer).Value = kitapID;
            return OrtakNokta.DbHelper.KomutCalistir(sql) > 0;
        }
        #endregion

        #region EmanetKitaplar
        public static DataTable GetEmanetOlmayanKitaplar()
        {
            string sql = @"Select kitapID, kitapAdi from tblKitap Where KitapID Not in 
                           (Select kitapID From tblEmanet Where TeslimEdildiMi=0);";
            OrtakNokta.DbHelper.Komut.Parameters.Clear();
            return OrtakNokta.DbHelper.TabloAl(sql);
        }

        public static DataTable GetEmanetteOlmayanKitaplar()
        {
            string sql = @"SELECT tblKitap.kitapAdi AS [Kitap Adı], tblYazar.Adi AS Yazar, tblRaf.Adi AS Raf, tblKitapTuru.Adi AS [Kitap Türü]
                           FROM ((tblKitap INNER JOIN tblYazar ON tblKitap.YazarID = tblYazar.YazarID) INNER JOIN tblRaf ON tblKitap.RafID = tblRaf.RafID) INNER JOIN tblKitapTuru ON tblKitap.TurID = tblKitapTuru.KitapTurID
                           WHERE (((tblKitap.[KitapID]) 
                                    Not In (Select kitapID From tblEmanet Where TeslimEdildiMi=0)));";
            OrtakNokta.DbHelper.Komut.Parameters.Clear();
            return OrtakNokta.DbHelper.TabloAl(sql);
        }

        public static DataTable GetEmanetHareketListesi()
        {
            string sql = @"SELECT tblKitap.kitapAdi AS [Kitap Adı], tblYazar.Adi AS Yazar, tblUye.AdiSoyadi AS Üye, tblUye.Telefon, tblEmanet.AlmaTarihi AS [Alma Tarihi], tblEmanet.VerecegiTarih AS [Vereceği Tarih], tblEmanet.TeslimEdilmeTarihi AS [Teslim Edilme Tarihi]
                           FROM ((tblKitap INNER JOIN tblYazar ON tblKitap.YazarID = tblYazar.YazarID) INNER JOIN tblEmanet ON tblKitap.KitapID = tblEmanet.KitapID) INNER JOIN tblUye ON tblEmanet.UyeID = tblUye.UyeID
                           WHERE (((tblEmanet.TeslimEdildiMi)=True));";
            OrtakNokta.DbHelper.Komut.Parameters.Clear();
            return OrtakNokta.DbHelper.TabloAl(sql);
        }

        public static DataTable GetEmanetKitaplar()
        {
            string sql = @"SELECT tblKitap.KitapAdi as [Kitap Adı], tblYazar.Adi as [Yazar], tblUye.AdiSoyadi as [Üye], tblUye.Telefon, tblUye.UyeTipi as [Üye Tipi], tblEmanet.AlmaTarihi as [Alma Tarihi], tblEmanet.VerecegiTarih as [Vereceği Tarih]
                           FROM(
                                (tblEmanet INNER JOIN tblKitap ON tblEmanet.KitapID = tblKitap.KitapID) 
                                INNER JOIN tblYazar ON tblKitap.YazarID = tblYazar.YazarID) 
                                INNER JOIN tblUye ON tblEmanet.UyeID = tblUye.UyeID
                                Where TeslimEdildiMi=0;";
            OrtakNokta.DbHelper.Komut.Parameters.Clear();
            return OrtakNokta.DbHelper.TabloAl(sql);
        }

        public static bool EkleEmanetKitap(int uyeID, int kitapID, DateTime almaTarihi, DateTime verecegiTarih)
        {
            string sql = "Insert Into tblEmanet(uyeID, kitapID, almaTarihi, verecegiTarih) Values(@uyeID, @kitapID, @almaTarihi, @verecegiTarih)";
            OrtakNokta.DbHelper.Komut.Parameters.Clear();
            OrtakNokta.DbHelper.Komut.Parameters.Add("@uyeID", OleDbType.Integer).Value = uyeID;
            OrtakNokta.DbHelper.Komut.Parameters.Add("@kitapID", OleDbType.Integer).Value = kitapID;
            OrtakNokta.DbHelper.Komut.Parameters.Add("@almaTarihi", OleDbType.Date).Value = almaTarihi;
            OrtakNokta.DbHelper.Komut.Parameters.Add("@verecegiTarih", OleDbType.Date).Value = verecegiTarih;
            return OrtakNokta.DbHelper.KomutCalistir(sql) > 0;
        }

        public static bool EmanetTeslimAlindiOlarakIsaretle(int emanetID)
        {
            string sql = "Update tblEmanet set TeslimEdildiMi=1, TeslimEdilmeTarihi=@tar Where emanetID=@emanetID";
            OrtakNokta.DbHelper.Komut.Parameters.Clear();
            OrtakNokta.DbHelper.Komut.Parameters.Add("@tar", OleDbType.Date).Value = DateTime.Now;
            OrtakNokta.DbHelper.Komut.Parameters.Add("@emanetID", OleDbType.Integer).Value = emanetID;
            return OrtakNokta.DbHelper.KomutCalistir(sql) > 0;
        }

        public static bool SilEmanet(int emanetID)
        {
            string sql = "Delete From tblEmanet Where emanetID=@emanetID";
            OrtakNokta.DbHelper.Komut.Parameters.Clear();
            OrtakNokta.DbHelper.Komut.Parameters.Add("@emanetID", OleDbType.Integer).Value = emanetID;
            return OrtakNokta.DbHelper.KomutCalistir(sql) > 0;
        }
        #endregion
    }
}