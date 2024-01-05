using System;
using System.CodeDom;
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

        #endregion

        // FUNCTION
        #region FUNCTION

        // Get Column Count -- Satır Sayısını Getir
        public int ColumnCount(string Db, string Tb, string Type = "=", byte ConditionCount = 0, string Condition = "", string Value = "", string Condition2 = "", string Value2 = "")
        {
            /*try
            {*/
                int Count;
                ConOpen();

                // Get Column Count Without Condition
                if (ConditionCount == 0)
                {
                    cmd = new SqlCommand("USE " + Db + " SELECT COUNT (*) AS Count FROM " + Tb, con);
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
                        throw new Exception("Sql DataReader veri okumuyor. \nHatalı Satır : 134");
                    }
                }

                switch (Type)
                {
                    case "=":
                        switch (ConditionCount)
                        {                         
                            case 1:
                                cmd = new SqlCommand("USE " + Db + " SELECT COUNT (*) AS Count FROM " + Tb + " WHERE " + Condition + " = @Value", con);
                                cmd.Parameters.AddWithValue("@Value", SqlDbType.NVarChar).Value = Value == null ? DBNull.Value : (object)Value;
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
                                    throw new Exception("Sql DataReader veri okumuyor. \nHatalı Satır : 154");
                                }

                        case 2:
                            cmd = new SqlCommand("USE " + Db + " SELECT COUNT (*) AS Count FROM " + Tb + " WHERE " + Condition + " = @Value AND " + Condition2 + " = @Value2", con);
                            cmd.Parameters.AddWithValue("@Value", SqlDbType.NVarChar).Value = Value == null ? DBNull.Value : (object)Value;
                            cmd.Parameters.AddWithValue("@Value2", SqlDbType.NVarChar).Value = Value2 == null ? DBNull.Value : (object)Value2;
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
                                throw new Exception("Sql DataReader veri okumuyor. \nHatalı Satır : 154");
                            }

                        default: throw new Exception("ConditionCount(" + ConditionCount +") değeri geçersiz. \nHatalı Satır : 131");
                        }
                        
                    case "/%":
                        switch (ConditionCount)
                        {
                            case 1:
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
                                    throw new Exception("Sql DataReader veri okumuyor. \nHatalı Satır : 180");
                                }

                            default: throw new Exception("ConditionCount(" + ConditionCount + ") değeri geçersiz. \nHatalı Satır : 173");
                        }

                    case "%/":
                        switch (ConditionCount)
                        {
                            case 1:
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
                                    throw new Exception("Sql DataReader veri okumuyor. \nHatalı Satır : 201");
                                }

                            default: throw new Exception("ConditionCount(" + ConditionCount + ") değeri geçersiz. \nHatalı Satır : 195");
                        }
                        
                    case "%%":
                        switch (ConditionCount)
                        {
                            case 1:
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
                                    throw new Exception("Sql DataReader veri okumuyor. \nHatalı Satır : 223");
                                }

                            case 2:
                                cmd = new SqlCommand("USE " + Db + " SELECT COUNT (*) AS Count FROM " + Tb + " WHERE " + Condition + " LIKE '%" + Value + "%' AND " + Condition2 + " LIKE '%" + Value2 + "%'", con);
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
                                    throw new Exception("Sql DataReader veri okumuyor. \nHatalı Satır : 223");
                                }

                            default: throw new Exception("ConditionCount(" + ConditionCount + ") değeri geçersiz. \nHatalı Satır : 217");
                        }

                    default: throw new Exception("Type(" + Type + ") değeri geçersiz. \nHatalı Satır : 148");
                }


            /*}
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message + "\nHatalı Satır : 124 \nHatalı Class : ClsSqlDatabase \nHatalı Metod : ColumnCount", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }*/
        }

        // Get Column -- Kolonu Getir
        public string[] GetColumn(string Db, string Tb, string Column, byte ConditionCount = 0, string Condition = "", string Value = "", string Condition2 = "", string Value2 = "")
        {
            /*try
            {*/
                int i = 0;
                int columnCount = ColumnCount(Db, Tb, "=", ConditionCount, Condition, Value, Condition2, Value2);
                string[] Columns = new string[columnCount];

                // If The Condition Is Not Met -- Koşul Sağlanmıyorsa
                if (columnCount == 0)
                {
                    string[] Error = { null };
                    return Error;
                }

                ConOpen();
                switch (ConditionCount)
                {
                    case 0:
                        cmd = new SqlCommand("USE " + Db + " SELECT " + Column + " FROM " + Tb, con);
                        dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            if (i < columnCount)
                            {
                                Columns[i] = dr[Column].ToString();
                                i++;
                            }
                        }
                        ConClose();
                        DrClose();
                        return Columns;

                    case 1:
                        cmd = new SqlCommand("USE " + Db + " SELECT " + Column + " FROM " + Tb + " WHERE " + Condition + " = @Value", con);
                        cmd.Parameters.AddWithValue("@Value", Value);
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

                    case 2:
                        cmd = new SqlCommand("USE " + Db + " SELECT " + Column + " FROM " + Tb + " WHERE " + Condition + " = @Value AND " + Condition2 + " = @Value2", con);
                        cmd.Parameters.AddWithValue("@Value", Value);
                        cmd.Parameters.AddWithValue("@Value2", Value2);
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

                    default: throw new Exception("ConditionCount(" + ConditionCount + ") değeri geçersiz. \nHatalı Satır : 267");
                }
            /*}
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message + "\nHatalı Class : ClsSqlDatabase \nHatalı Metod : GetColumn", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ConClose();
                DrClose();
                return null;
            }*/
        }

        // Delete Column -- Kolonu Temizle
        public void DeleteColumn(string Db, string Tb, string Condition, string Value)
        {
            try
            {
                ConOpen();
                cmd = new SqlCommand("USE " + Db + " DELETE FROM " + Tb + " WHERE " + Condition + " = '" + Value + "'", con);
                cmd.ExecuteNonQuery();
                ConClose();
                MessageBox.Show("Kolon başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message + "\nHatalı Satır : 331 \nHatalı Class : ClsSqlDatabase \nHatalı Metod : DeleteColumn", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Update Cell -- Hücreyi Güncelle 
        public void Update(string Db, string Tb, string Column, string Value, byte ConditionCount = 0, string Condition = "", string ConditionValue = "", string Condition2 = "", string ConditionValue2 = "")
        {
            try
            {
                ConOpen();

                // Update Without Condition
                if (ConditionCount == 0)
                {
                    cmd = new SqlCommand("USE " + Db + " UPDATE " + Tb + " SET " + Column + " = @Value", con);
                    cmd.Parameters.AddWithValue("@Value", Value);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    switch (ConditionCount)
                    {
                        case 1:
                            cmd = new SqlCommand("USE " + Db + " UPDATE " + Tb + " SET " + Column + " = @Value  WHERE " + Condition + " = @ConditionValue", con);
                            cmd.Parameters.AddWithValue("@Value", Value);
                            cmd.Parameters.AddWithValue("@ConditionValue", ConditionValue);
                            cmd.ExecuteNonQuery();
                            break;

                        case 2:
                            cmd = new SqlCommand("USE " + Db + " UPDATE " + Tb + " SET " + Column + " = @Value WHERE " + Condition + " = @ConditionValue AND " + Condition2 + " = @ConditionValue2", con);
                            cmd.Parameters.AddWithValue("@Value", Value);
                            cmd.Parameters.AddWithValue("@ConditionValue", ConditionValue);
                            cmd.Parameters.AddWithValue("@ConditionValue2", ConditionValue2);
                            cmd.ExecuteNonQuery();
                            break;

                        default: throw new Exception("ConditionCount(" + ConditionCount + ") değeri geçersiz. \nHatalı Satır : 358");
                    }
                }            
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message + "\nHatalı Class : ClsSqlDatabase \nHatalı Metod : Update", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Search -- Ara 
        public string[] Search(string Db, string Tb, string Column, string Type, byte ConditionCount = 0, string Condition = "", string Value = "", string Condition2 = "", string Value2 = "")
        {
            int i = 0;
            switch (Type)
            {
                case "/%":
                    int Count = ColumnCount(Db, Tb, Type, 0, Condition, Value);

                    ConOpen(); // Hata Olabilir
                    cmd = new SqlCommand("USE " + Db + " SELECT " + Column + " FROM " + Tb + " WHERE " + Condition + " LIKE '%@Value", con);
                    cmd.Parameters.AddWithValue("@Value", Value);
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
                    Count = ColumnCount(Db, Tb, Type, 0, Condition, Value);

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
                    switch (ConditionCount)
                    {
                        case 1:
                            Count = ColumnCount(Db, Tb, Type, ConditionCount, Condition, Value);

                            ConOpen();
                            cmd = new SqlCommand("USE " + Db + " SELECT " + Column + " FROM " + Tb + " WHERE " + Condition + " LIKE '%" + Value + "%'", con);
                            dr = cmd.ExecuteReader();

                            // If The Condition Is Not Met -- Koşul Sağlanmıyorsa
                            if (Count == 0)
                            {
                                string[] Error = { null };
                                ConClose();
                                DrClose();
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

                        case 2:
                            Count = ColumnCount(Db, Tb, Type, ConditionCount, Condition, Value, Condition2, Value2);

                            ConOpen();
                            cmd = new SqlCommand("USE " + Db + " SELECT " + Column + " FROM " + Tb + " WHERE " + Condition + " LIKE '%" + Value + "%' AND " + Condition2 + " LIKE '%" + Value2 + "%'", con);
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
                            "\nHatalı Class : ClsSqlDatabase \nHatalı Metod : GetColumn \nHatalı Satır : 467", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ConClose();
                            DrClose();
                            return null;
                    }

                default:
                    MessageBox.Show("Koşul geçersiz. \nAçıklama : Parametreler hatalı. \nnull Döndürüldü." +
                            "\nHatalı Class : ClsSqlDatabase \nHatalı Metod : GetColumn \nHatalı Satır : 402", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ConClose();
                    DrClose();
                    return null;
            }
        }

        // Is There -- Var mı?
        public bool IsThere(string Db, string Tb, string Column, string Type = "=", byte ConditionCount = 0, string Condition = "", string Value = "", string Condition2 = "", string Value2 = "", string Condition3 = "", string Value3 = "")
        {
            try
            {
                bool result;
                switch (Type)
                {
                    case "=":
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
                                cmd.Parameters.AddWithValue("@Value2", Value2);
                                dr = cmd.ExecuteReader();
                                dr.Read();
                                result = Convert.ToInt32(dr["Count"]) != 0;
                                ConClose();
                                DrClose();
                                return result;

                            case 3:
                                ConOpen();
                                cmd = new SqlCommand("USE " + Db + " SELECT COUNT (@Column) AS Count FROM " + Tb + " WHERE " + Condition + " = @Value AND " + Condition2 + " = @Value2 AND " + Condition3 + " = @Value3", con);
                                cmd.Parameters.AddWithValue("@Column", Column);
                                cmd.Parameters.AddWithValue("@Value", Value);
                                cmd.Parameters.AddWithValue("@Value2", Value2);
                                cmd.Parameters.AddWithValue("@Value3", Value3);
                                dr = cmd.ExecuteReader();
                                dr.Read();
                                result = Convert.ToInt32(dr["Count"]) != 0;
                                ConClose();
                                DrClose();
                                return result;

                            default: throw new Exception("ConditionCount(" + ConditionCount + ") değeri geçersiz. \nHatalı Satır : 480");
                        }

                    default: throw new Exception("Type(" + Type + ") değeri geçersiz. \nHatalı Satır : 477");
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message + "\nHatalı Class : ClsSqlDatabase \nHatalı Metod : IsThere", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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
                MessageBox.Show(Error.Message + "\nHatalı Satır : 542 \nHatalı Class : ClsSqlDatabase \nHatalı Metod : RunCommand", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        // TYPE DEĞİŞKENİ EKLE (/%)
    }
}
