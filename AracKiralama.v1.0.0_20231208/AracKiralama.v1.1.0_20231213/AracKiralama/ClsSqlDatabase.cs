using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralama
{
    public class ClsSqlDatabase
    {
        // Sql Connection -- Sql Bağlantıları
        #region Sql Connection
        public readonly SqlConnection con = new SqlConnection("Data Source=fdestj15;Initial Catalog=AracKiralama;User ID=keremkoroglu;Password=K671876eren</>;Integrated Security=SSPI;Integrated Security=False");
        public SqlCommand cmd;
        SqlDataReader dr;
        readonly DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        SqlDataAdapter da;
        public readonly string tbLogin = "Login", tbCars = "Cars", tbCustomers = "Customers", dbAracKiralama = "AracKiralama";

        public void ConOpen()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void ConClose()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        public void DrClose()
        {
            if (dr.Equals(1))
            {
                dr.Close();
            }
        }

        #endregion

        // METODS -- METODLAR
        #region METODS
        // Login -- Giriş Yap
        public bool Login(string Db, string Tb, string U, string P)
        {
            ConOpen();
            cmd = new SqlCommand("USE " + Db + " SELECT * FROM " + Tb, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (U == dr["username"].ToString() && P == dr["password"].ToString())
                {
                    ConClose();
                    DrClose();                   
                    return true;
                }
            }
            
            ConClose();
            DrClose();
            return false;
        }

        // Get Column Count -- Satır Sayısını Getir
        public int GetColumnCount(string Db, string Tb, byte ConditionCount = 0, string Condition = "", string Value = "")
        {
            ConOpen();           

            switch (ConditionCount)
            {
                case 0:

                    cmd = new SqlCommand("USE " + Db + " SELECT COUNT (*) AS ColumnCount FROM " + Tb, con);
                    dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        int tableCount = Convert.ToInt32(dr["ColumnCount"]);

                        ConClose();
                        DrClose();
                        return tableCount;
                    }
                    else
                    {
                        MessageBox.Show("Koşul sayısı geçersiz. \nAçıklama : Gelen koşul parametresi hatalı. \n0 Döndürüldü." +
                            "Hatalı Metod : GetColumnCount \nHatalı Satır : 80", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ConClose();
                        DrClose();
                        return 0;
                    }

                case 1:

                    cmd = new SqlCommand("USE " + Db + " SELECT COUNT (*) AS Count FROM " + Tb + " WHERE " + Condition + " = " + Value, con);
                    dr = cmd.ExecuteReader();
                    dr.Read();

                    int Count = Convert.ToInt32(dr["Count"]);

                    ConClose();
                    DrClose();
                    return Count;

                default:

                    MessageBox.Show("Koşul sayısı geçersiz. \nAçıklama : Gelen koşul parametresi hatalı. \n0 Döndürüldü." +
                            "Hatalı Metod : GetColumnCount \nHatalı Satır : 80", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ConClose();
                    return 0;
            }
        }

        // Write Data Grid View -- Data Grid Viewe Yaz
        public DataTable WriteDGV(string Db, string Tb, byte ConditionCount = 0, string Condition = "", string Value = "")
        {
            da = new SqlDataAdapter("USE " + Db + " SELECT * FROM " + Tb, con);
            switch (ConditionCount)
            {
                case 0:

                    ConOpen();
                    da.Fill(ds, Tb);

                    if (dt == ds.Tables[0])
                    {
                        dt.Clear();
                        da = new SqlDataAdapter("USE " + Db + " SELECT * FROM " + Tb, con);
                        ConOpen();
                        da.Fill(ds, Tb);
                    }

                    dt = ds.Tables[0];
                    ConClose();
                    return dt;

                case 1:

                    da = new SqlDataAdapter("USE " + Db + " SELECT * FROM " + Tb + " WHERE " + Condition + " = " + Value, con);
                    ConOpen();
                    da.Fill(ds, Tb);

                    if (dt == ds.Tables[0])
                    {
                        dt.Clear();
                        da = new SqlDataAdapter("USE " + Db + " SELECT * FROM " + Tb + " WHERE " + Condition + " = " + Value, con);
                        ConOpen();
                        da.Fill(ds, Tb);
                    }

                    dt = ds.Tables[0];
                    ConClose();
                    return dt;

                default:
                    MessageBox.Show("Koşul sayısı geçersiz. \nAçıklama : Gelen koşul parametresi hatalı. \nnull Döndürüldü." +
                            "Hatalı Metod : WriteDGV \nHatalı Satır : 125", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
            }
        }

        // Run Command -- Komutu Çalıştır
        public void RunCommand(string Command)
        {
            ConOpen();
            cmd = new SqlCommand(Command);
            cmd.ExecuteNonQuery();
            ConClose();
        }

        // Delete Column -- Kolonu Temizle
        public void DeleteColumn(string Db, string Tb, string Condition, string Value)
        {
            ConOpen();
            cmd = new SqlCommand("USE " + Db + " DELETE FROM " + Tb + " WHERE " + Condition + " = " + Value, con);
            cmd.ExecuteNonQuery();
            ConClose();
        }
        #endregion

    }
}
