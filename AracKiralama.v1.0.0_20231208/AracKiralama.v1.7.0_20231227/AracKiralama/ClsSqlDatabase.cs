using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
        public SqlConnection con = new SqlConnection("Data Source=fdestj15;Initial Catalog=AracKiralama;User ID=keremkoroglu;Password=User1234user...;Integrated Security=SSPI;Integrated Security=False");
        public SqlCommand cmd;
        private SqlDataReader dr;
        readonly DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        private SqlDataAdapter da;
        public readonly string tbLogin = "Login", tbCars = "Cars", tbCustomers = "Customers", dbAracKiralama = "AracKiralama";

        public void ConOpen()
        {
            if (con.State == ConnectionState.Closed) con.Open();          
        }
        public void ConClose()
        {
            if (con.State == ConnectionState.Open) con.Close();
        }
        public void DrClose()
        {
            if (dr.Equals(1)) dr.Close();
        }

        #endregion

        // METODS -- METODLAR
        #region METODS

        // PROCCES
        #region PROCCES

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

        #endregion

        // FUNCTION
        #region FUNCTION

        // Get Column Count -- Satır Sayısını Getir
        public int GetColumnCount(string Db, string Tb, string Type = "=", byte ConditionCount = 0, string Condition = "", string Value = "")
        {
            try
            {
                int Count;
                ConOpen();
                switch (Type)
                {
                    case "=":
                        switch (ConditionCount)
                        {
                            case 0:
                                cmd = new SqlCommand("USE " + Db + " SELECT COUNT (*) AS ColumnCount FROM " + Tb, con);
                                dr = cmd.ExecuteReader();

                                if (dr.Read())
                                {
                                    Count = Convert.ToInt32(dr["ColumnCount"]);

                                    ConClose();
                                    DrClose();
                                    return Count;
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

                                Count = Convert.ToInt32(dr["Count"]);

                                ConClose();
                                DrClose();
                                return Count;

                            default:
                                MessageBox.Show("Koşul sayısı geçersiz. \nAçıklama : Gelen koşul parametresi hatalı. \n0 Döndürüldü." +
                                        "\nHatalı Class : ClsSqlDatabase \nHatalı Metod : GetColumnCount \nHatalı Satır : 82", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                ConClose();
                                return 0;
                        }
                        
                    case "/%":
                        cmd = new SqlCommand("USE " + Db + " SELECT COUNT (*) AS Count FROM " + Tb + " WHERE " + Condition + " LIKE '%" + Value + "'", con);
                        dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            Count = Convert.ToInt32(dr["Count"]);
                            ConClose();
                            DrClose();
                            return Count;
                        }
                        else
                        {
                            MessageBox.Show("DataReader veri okumuyor. \nAçıklama : Girilen veriler doğru değil. \n0 Döndürüldü." +
                                "\nHatalı Class : ClsSqlDatabase \nHatalı Metod : GetColumnCount \nHatalı Satır : 82", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ConClose();
                            DrClose();
                            return 0;
                        }

                    case "%/":
                        cmd = new SqlCommand("USE " + Db + " SELECT COUNT (*) AS Count FROM " + Tb + " WHERE " + Condition + " LIKE '" + Value + "%'", con);
                        dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            Count = Convert.ToInt32(dr["Count"]);
                            ConClose();
                            DrClose();
                            return Count;
                        }
                        else
                        {
                            MessageBox.Show("DataReader veri okumuyor. \nAçıklama : Girilen veriler doğru değil. \n0 Döndürüldü." +
                                "\nHatalı Class : ClsSqlDatabase \nHatalı Metod : GetColumnCount \nHatalı Satır : 82", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ConClose();
                            DrClose();
                            return 0;
                        }

                    case "%%":
                        cmd = new SqlCommand("USE " + Db + " SELECT COUNT (*) AS Count FROM " + Tb + " WHERE " + Condition + " LIKE '%" + Value + "%'", con);
                        dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            Count = Convert.ToInt32(dr["Count"]);
                            ConClose();
                            DrClose();
                            return Count;
                        }
                        else
                        {
                            MessageBox.Show("DataReader veri okumuyor. \nAçıklama : Girilen veriler doğru değil. \n0 Döndürüldü." +
                                "\nHatalı Class : ClsSqlDatabase \nHatalı Metod : GetColumnCount \nHatalı Satır : 82", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ConClose();
                            DrClose();
                            return 0;
                        }

                    default:
                        MessageBox.Show("Tip geçersiz. \nAçıklama : Gelen tip parametresi hatalı. \n0 Döndürüldü." +
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

        // Get Column -- Kolonu Getir
        public string[] GetColumn(string Db, string Tb, string Column, byte ConditionCount = 0, string Condition = "", string Value = "")
        {
            try
            {
                int i = 0;
                int columnCount = GetColumnCount(Db, Tb, "=", ConditionCount, Condition, Value);

                // If The Condition Is Not Met -- Koşul Sağlanmıyorsa
                if (columnCount == 0)
                {
                    string[] Error = { null };
                    return Error;
                }

                string[] Columns = new string[columnCount];
                ConOpen();
                switch (ConditionCount)
                {
                    case 0:
                        cmd = new SqlCommand("USE " + Db + " SELECT " + Column + " FROM " + Tb, con);
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

                    default:
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

        // GÖZDEN GEÇİR // Update Cell -- Hücreyi Güncelle 
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

        // Search -- Ara 
        public string[] Search(string Db, string Tb, string Column, string Type, string Condition = "", string Value = "")
        {
            int i = 0;
            switch (Type)
            {
                case "/%":
                    int Count = GetColumnCount(Db, Tb, Type, 0, Condition, Value);

                    ConOpen();
                    cmd = new SqlCommand("USE " + Db + " SELECT " + Column + " FROM " + Tb + " WHERE " + Condition + " like '%" + Value + "'", con);
                    dr = cmd.ExecuteReader();

                    // If The Condition Is Not Met -- Koşul Sağlanmıyorsa
                    if (Count == 0)
                    {
                        string[] Error = { null };
                        return Error;
                    }

                    string[] result = new string[Count];
                    while (dr.Read())
                    {
                        if (i < Count)
                        {
                            result[i] = dr[Column].ToString();
                            i++;
                        }
                    }
                    ConClose();
                    DrClose();
                    return result;

                case "%/":
                    Count = GetColumnCount(Db, Tb, Type, 0, Condition, Value);

                    ConOpen();
                    cmd = new SqlCommand("USE " + Db + " SELECT " + Column + " FROM " + Tb + " WHERE " + Condition + " like '" + Value + "%'", con);
                    dr = cmd.ExecuteReader();

                    // If The Condition Is Not Met -- Koşul Sağlanmıyorsa
                    if (Count == 0)
                    {
                        string[] Error = { null };
                        return Error;
                    }

                    result = new string[Count];
                    while (dr.Read())
                    {
                        if (i < Count)
                        {
                            result[i] = dr[Column].ToString();
                            i++;
                        }
                    }
                    ConClose();
                    DrClose();
                    return result;

                case "%%":
                    Count = GetColumnCount(Db, Tb, Type, 0, Condition, Value);

                    ConOpen();
                    cmd = new SqlCommand("USE " + Db + " SELECT " + Column + " FROM " + Tb + " WHERE " + Condition + " LIKE '%" + Value + "%'", con);
                    dr = cmd.ExecuteReader();

                    // If The Condition Is Not Met -- Koşul Sağlanmıyorsa
                    if (Count == 0)
                    {
                        string[] Error = { null };
                        return Error;
                    }

                    result = new string[Count];
                    while (dr.Read())
                    {
                        if (i < Count)
                        {
                            result[i] = dr[Column].ToString();
                            i++;
                        }
                    }
                    ConClose();
                    DrClose();
                    return result;

                default:
                    MessageBox.Show("Koşul geçersiz. \nAçıklama : Parametreler hatalı. \nnull Döndürüldü." +
                            "\nHatalı Class : ClsSqlDatabase \nHatalı Metod : GetColumn \nHatalı Satır : 402", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ConClose();
                    DrClose();
                    return null;
            }
        }

        // Is There -- Var mı? -- Yarım bırakıldı
        public bool IsThere(string Db, string Tb, string Column, string Type = "=", byte ConditionCount = 0, string Condition = "", string Value = "", string Condition2 = "", string Value2 = "")
        {
            bool result;
            switch (Type)
            {
                case "=" :
                    switch (ConditionCount)
                    {
                        case 0:
                            ConOpen();
                            cmd = new SqlCommand("USE " + Db + " SELECT COUNT (@Column) AS Count FROM " + Tb, con);
                            cmd.Parameters.AddWithValue("@Column", Column);
                            dr = cmd.ExecuteReader();
                            dr.Read();
                            result = Convert.ToInt32(dr["Count"]) != 0;
                            ConClose();
                            DrClose();
                            return result;

                        case 1:
                            ConOpen();
                            cmd = new SqlCommand("USE " + Db + " SELECT COUNT (@Column) AS Count FROM " + Tb + " WHERE " + Condition + " = @Value", con);
                            cmd.Parameters.AddWithValue("@Column", Column);
                            cmd.Parameters.AddWithValue("@Value", Value);
                            dr = cmd.ExecuteReader();
                            dr.Read();
                            result = Convert.ToInt32(dr["Count"]) != 0;
                            ConClose();
                            DrClose();
                            return result;

                        case 2:
                            ConOpen();
                            cmd = new SqlCommand("USE " + Db + " SELECT COUNT (@Column) AS Count FROM " + Tb + " WHERE " + Condition + " = @Value AND " + Condition2 + " = @Value2", con);
                            cmd.Parameters.AddWithValue("@Column", Column);
                            cmd.Parameters.AddWithValue("@Value", Value);
                            cmd.Parameters.AddWithValue("@Value2", Value);
                            dr = cmd.ExecuteReader();
                            dr.Read();
                            result = Convert.ToInt32(dr["Count"]) != 0;
                            ConClose();
                            DrClose();
                            return result;

                        default:
                            MessageBox.Show("hata 469");
                            return false;
                    }

                default : MessageBox.Show("hata 469"); return false;
            }
        }
        
        #endregion

        // FREE
        #region FREE

        // Run Command -- Komutu Çalıştır
        public void RunCommand(string Command)
        {
            try
            {
                ConOpen();
                cmd = new SqlCommand(Command, con);
                cmd.ExecuteNonQuery();
                ConClose();
            }
            catch (Exception Error)
            {
                MessageBox.Show("Komut çalıştırılamadı. \n" + Error.Message + "\nHatalı Class : ClsSqlDatabase \nHatalı Metod : RunCommand \nHatalı Satır : 186", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #endregion

        // METODLARI DÜZENLE : PARAMETRELERİ EKLE ÖRNEĞİN Model = @Model VE ALDIĞIN DEĞERLERDEN "'" + ... + "'" OLANLARI TEMİZLE
        // CLASLARDA MESSAGEBOX PARAMETRESİ EKLE
        // METOD İSİMLERİNİ KISALT
        // TRY CATCH DÜZENLEMESİ
        // HATA AÇIKLAMALARI DÜZENLEMESİ
        // DEĞİŞKEN ADLARINI DÜZENLE
        // SQL CON DAVASI
    }
}
