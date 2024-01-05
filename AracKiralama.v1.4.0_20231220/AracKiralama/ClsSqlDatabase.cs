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
            try
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
            catch (Exception Error)
            {
                MessageBox.Show("Giriş Yapılamadı. \nFalse Döndürüldü \n" + Error.Message + "\nHatalı Class : ClsSqlDatabase \nHatalı Metod : Login \nHatalı Satır : 52", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Get Column Count -- Satır Sayısını Getir
        public int GetColumnCount(string Db, string Tb, byte ConditionCount = 0, string Condition = "", string Value = "")
        {
            try
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
                            MessageBox.Show("DataReader veri okumuyor. \nAçıklama : Database ve Table parametreleri hatalı. \n0 Döndürüldü." +
                                "\nHatalı Class : ClsSqlDatabase \nHatalı Metod : GetColumnCount \nHatalı Satır : 82", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                                "\nHatalı Class : ClsSqlDatabase \nHatalı Metod : GetColumnCount \nHatalı Satır : 82", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ConClose();
                        return 0;
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show("GetColumnCount metodu çalıştırılırken hata.\n0 Döndürüldü. \n" + Error.Message + "\nHatalı Class : ClsSqlDatabase \nHatalı Metod : GetColumnCount \nHatalı Satır : 82 ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            
            
        }

        // Write Data Grid View -- Data Grid Viewe Yaz
        public DataTable WriteDGV(string Db, string Tb, byte ConditionCount = 0, string Condition = "", string Value = "")
        {
            try
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
                            "\nHatalı Class : ClsSqlDatabase \nHatalı Metod : WriteDGV \nHatalı Satır : 125", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show("WriteDGV metodu çalıştırılırken hata.\nnull Döndürüldü. \n" + Error.Message + "\nHatalı Class : ClsSqlDatabase \n Hatalı Metod : WriteDGV \nHatalı Satır : 125 ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // Run Command -- Komutu Çalıştır
        public void RunCommand(string Command)
        {
            try
            {
                ConOpen();
                cmd = new SqlCommand(Command);
                cmd.ExecuteNonQuery();
                ConClose();
            } 
            catch (Exception Error)
            {
                MessageBox.Show("Komut çalıştırılamadı. \n" + Error.Message + "\nHatalı Class : ClsSqlDatabase \nHatalı Metod : RunCommand \nHatalı Satır : 186", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Delete Column -- Kolonu Temizle
        public void DeleteColumn(string Db, string Tb, string Condition, string Value)
        {
            try
            {
                ConOpen();
                cmd = new SqlCommand("USE " + Db + " DELETE FROM " + Tb + " WHERE " + Condition + " = " + Value, con);
                cmd.ExecuteNonQuery();
                ConClose();
                MessageBox.Show("Kolon başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception Error) 
            {
                MessageBox.Show("Kolon Silinemedi. \n" + Error.Message + "\nHatalı Class : ClsSqlDatabase \nHatalı Metod : DeleteColumn \nHatalı Satır : 202", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Get Column -- Kolonu Getir
        public string[] GetColumn(string Db, string Tb, string Column, byte ConditionCount = 0, string Condition = "", string Value = "")
        {
            try
            {
                int i = 0;
                int columnCount = GetColumnCount(Db, Tb, ConditionCount, Condition, Value);
                string[] Columns = new string[columnCount];
                ConOpen();
                switch (ConditionCount)
                {
                    case 0:
                        cmd = new SqlCommand("USE " + Db + " SELECT " + Column +  " FROM " + Tb, con);
                        dr = cmd.ExecuteReader();
            
                        while (dr.Read())
                        {
                            if (i < (columnCount))
                            {
                                Columns[i] = dr[Column].ToString();
                                i++;
                            }                     
                        }
                        ConClose();
                        DrClose();
                        return Columns;

                    case 1:
                        cmd = new SqlCommand("USE " + Db + " SELECT " + Column + " FROM " + Tb + " WHERE " + Condition + " = " + Value, con);
                        dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            if (i < (columnCount))
                            {
                                Columns[i] = dr[Column].ToString();
                                i++;
                            }
                        }
                        ConClose();
                        DrClose();
                        return Columns;

                    default :
                        MessageBox.Show("Koşul sayısı geçersiz. \nAçıklama : Gelen koşul parametresi hatalı. \nnull Döndürüldü." +
                            "\nHatalı Class : ClsSqlDatabase \nHatalı Metod : GetColumn \nHatalı Satır : 227", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show("GetColumn metodu çalıştırılırken hata.\nnull Döndürüldü. \n" + Error.Message + "\nHatalı Class : ClsSqlDatabase \nHatalı Metod : GetColumn \nHatalı Satır : 227 ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        
        // Update Cell -- Hücreyi Güncelle
        public void UpdateCell(string Db, string Tb, string Column, string Value, byte ConditionCount = 0, string Condition = "", string ConditionValue = "", string Condition2 = "", string ConditionValue2 = "")
        {
            try
            {
                ConOpen();
                switch (ConditionCount)
                {
                    case 0:
                        cmd = new SqlCommand("USE " + Db + " UPDATE " + Tb + " SET " + Column + " = " + Value, con);
                        cmd.ExecuteNonQuery();
                        break;

                    case 1:
                        cmd = new SqlCommand("USE " + Db + " UPDATE " + Tb + " SET " + Column + " = " + Value + " WHERE " + Condition + " = " + ConditionValue + "", con);
                        cmd.ExecuteNonQuery();
                        break;

                    case 2:
                        cmd = new SqlCommand("USE " + Db + " UPDATE " + Tb + " SET " + Column + " = " + Value + " WHERE " + Condition + " = " + ConditionValue + " AND " + Condition2 + " = " + ConditionValue2, con);
                        cmd.ExecuteNonQuery();
                        break;

                    default:
                        MessageBox.Show("Belirtilen koşul sayısı kodlanmadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show("UpdateCell metodu çalıştırılırken hata. \n" + Error.Message + "\nHatalı Class : ClsSqlDatabase \nHatalı Metod : UpdateCell \nHatalı Satır : 283 ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

    }
}
