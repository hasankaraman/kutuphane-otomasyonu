using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace Kulturhane
{
    class OleDbHelper
    {
        OleDbConnection conn;
        OleDbCommand cmd;

        public OleDbCommand Komut
        {
            get { return cmd; }
            set { cmd = value; }
        }
        OleDbDataAdapter da;

        public OleDbHelper()
        {
            conn = new OleDbConnection();
            cmd = new OleDbCommand();
            da = new OleDbDataAdapter();

            cmd.Connection = conn;
            da.SelectCommand = cmd;
        }

        public bool Baglan(string connectionString)
        {
            conn.ConnectionString = connectionString;
            try
            {
                conn.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void BaglantiyiKes()
        {
            conn.Close();
        }

        public int KomutCalistir(string sql)
        {
            cmd.CommandText = sql;
            return cmd.ExecuteNonQuery();
        }

        public DataTable TabloAl(string sql)
        {
            DataTable tblVeri = new DataTable();
            cmd.CommandText = sql;
            da.Fill(tblVeri);
            return tblVeri;
        }

        public bool KayitVarMi(string sql)
        {
            return TabloAl(sql).Rows.Count > 0;
        }
        public OleDbDataReader ReaderAl(string sql)
        {
            OleDbConnection conn2 = new OleDbConnection(conn.ConnectionString);
            OleDbCommand cmd2 = conn2.CreateCommand();
            conn2.Open();

            OleDbParameter parametre;
            while (cmd.Parameters.Count > 0)
            {
                parametre = cmd.Parameters[0];
                cmd.Parameters.Remove(parametre);
                cmd2.Parameters.Add(parametre);
            }
            cmd2.CommandText = sql;
            OleDbDataReader dr2 = cmd2.ExecuteReader();
            return dr2;
        }

    }
}
