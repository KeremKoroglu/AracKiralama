using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AracKiralama
{
    public class ClsAracKiralamaDatabase
    {
        // Class Connection -- Sınıf Bağlantıları
        #region Class Connection
        readonly ClsSqlDatabase SqlDatabase = new ClsSqlDatabase();
        #endregion

        // METODS -- METODLAR
        #region METODS

        // Write Car Table -- Car Tablosuna Yaz
        public void WriteCarTable(string Price, string Model, string Km, string Seat, string AutoGear, string Damaged, string Description, string Rented, string Renter, string RentDate, string Delivered, string DeliveredDate, string DeliveryDate)
        {
            try
            {
                SqlDatabase.ConOpen();
                SqlDatabase.cmd = new SqlCommand("USE AracKiralama INSERT INTO Cars (Price, Model, Km, Seat, AutoGear, Damaged, Description, Rented, Renter, RentDate, Delivered, DeliveredDate, DeliveryDate) " +
                    "VALUES (@Price, @Model, @Km, @Seat, @AutoGear, @Damaged, @Description, @Rented, @Renter, @RentDate, @Delivered, @DeliveredDate, @DeliveryDate)", SqlDatabase.con);
                SqlDatabase.cmd.Parameters.AddWithValue("@Price", Price);
                SqlDatabase.cmd.Parameters.AddWithValue("@Model", Model);
                SqlDatabase.cmd.Parameters.AddWithValue("@Km", Km);
                SqlDatabase.cmd.Parameters.AddWithValue("@Seat", Seat);
                SqlDatabase.cmd.Parameters.AddWithValue("@AutoGear", AutoGear);
                SqlDatabase.cmd.Parameters.AddWithValue("@Damaged", Damaged);
                SqlDatabase.cmd.Parameters.AddWithValue("@Description", Description);
                SqlDatabase.cmd.Parameters.AddWithValue("@Rented", Rented);
                SqlDatabase.cmd.Parameters.AddWithValue("@Renter", Renter);
                SqlDatabase.cmd.Parameters.AddWithValue("@RentDate", RentDate);
                SqlDatabase.cmd.Parameters.AddWithValue("@Delivered", Delivered);
                SqlDatabase.cmd.Parameters.AddWithValue("@DeliveredDate", DeliveredDate);
                SqlDatabase.cmd.Parameters.AddWithValue("@DeliveryDate", DeliveryDate);
                SqlDatabase.cmd.ExecuteNonQuery();
                SqlDatabase.ConClose();
                MessageBox.Show("Araç başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception Error) 
            {
                MessageBox.Show("Araç kaydı başarısız. \n" + Error.Message + "\nHatalı Class : ClsAracKiralamaDatabase \nHatalı Metod : WriteCarTable \nHatalı Satır : 22", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
