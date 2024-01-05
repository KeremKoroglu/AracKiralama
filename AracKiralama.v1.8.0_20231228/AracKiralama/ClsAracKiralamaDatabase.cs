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
                    "VALUES (@Price, @Model, @Km, @Seat, @AutoGear, @Damaged, @Description, @Rented, @Renter, " + RentDate + ", @Delivered, " + DeliveredDate + ", " + DeliveryDate + ")", SqlDatabase.con);
                SqlDatabase.cmd.Parameters.AddWithValue("@Price", Price);
                SqlDatabase.cmd.Parameters.AddWithValue("@Model", Model);
                SqlDatabase.cmd.Parameters.AddWithValue("@Km", Km);
                SqlDatabase.cmd.Parameters.AddWithValue("@Seat", Seat);
                SqlDatabase.cmd.Parameters.AddWithValue("@AutoGear", AutoGear);
                SqlDatabase.cmd.Parameters.AddWithValue("@Damaged", Damaged);
                SqlDatabase.cmd.Parameters.AddWithValue("@Description", Description);
                SqlDatabase.cmd.Parameters.AddWithValue("@Rented", Rented);
                SqlDatabase.cmd.Parameters.AddWithValue("@Renter", Renter);
                SqlDatabase.cmd.Parameters.AddWithValue("@Delivered", Delivered);
                SqlDatabase.cmd.ExecuteNonQuery();
                SqlDatabase.ConClose();
                MessageBox.Show("Araç başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception Error) 
            {
                MessageBox.Show("Araç kaydı başarısız. \n" + Error.Message + "\nHatalı Class : ClsAracKiralamaDatabase \nHatalı Metod : WriteCarTable \nHatalı Satır : 22", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Update Car -- Arabayı Güncelle
        public void UpdateCar(string Model, string Renter, string Description, string RentDate, string DeliveryDate)
        {
            try
            {
                SqlDatabase.ConOpen();
                SqlDatabase.cmd = new SqlCommand("USE AracKiralama UPDATE Cars SET Rented = 1, Renter = @Renter, Description = @Description, RentDate = @RentDate, Delivered = 0, DeliveryDate = @DeliveryDate WHERE Model = @Model", SqlDatabase.con);
                SqlDatabase.cmd.Parameters.AddWithValue("@Renter", Renter);
                SqlDatabase.cmd.Parameters.AddWithValue("@Description", Description);
                SqlDatabase.cmd.Parameters.AddWithValue("@RentDate", RentDate);
                SqlDatabase.cmd.Parameters.AddWithValue("@DeliveryDate", DeliveryDate);
                SqlDatabase.cmd.Parameters.AddWithValue("@Model", Model);
                SqlDatabase.cmd.ExecuteNonQuery();

                SqlDatabase.cmd = new SqlCommand("USE AracKiralama UPDATE Customers SET Renter = 1, RentedModel = @RentedModel, RentDate = @RentDateC, Delivered = 0, DeliveredDate = NULL, DeliveryDate = @DeliveryDateC WHERE Name = @Name", SqlDatabase.con);
                SqlDatabase.cmd.Parameters.AddWithValue("@RentedModel", Model);
                SqlDatabase.cmd.Parameters.AddWithValue("@RentDateC", RentDate);
                SqlDatabase.cmd.Parameters.AddWithValue("@DeliveryDateC", DeliveryDate);
                // Boşluğa kadar al
                int a = Renter.IndexOf(' ');
                SqlDatabase.cmd.Parameters.AddWithValue("@Name", Renter.Substring(0, a));
                SqlDatabase.cmd.ExecuteNonQuery();

                MessageBox.Show("Kiralama işlemi başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception Error)
            {
                MessageBox.Show("Kiralama işlemi başarısız. \n" + Error.Message + "\nHatalı Class : ClsAracKiralamaDatabase \nHatalı Metod : UpdateCar \nHatalı Satır : 53", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        // Recall Car -- Arabayı Çağır
        public void RecallCar(string Km, string Damaged, string Description, string DeliveredDate, string Model)
        {
            try
            {
                SqlDatabase.ConOpen();
                SqlDatabase.cmd = new SqlCommand("USE AracKiralama UPDATE Customers SET Renter = 0, RentedModel = NULL, RentDate = NULL, Delivered = 1, DeliveredDate = @DeliveredDate, DeliveryDate = NULL, LastRentedModel = @Model WHERE RentedModel = @RentedModel", SqlDatabase.con);
                SqlDatabase.cmd.Parameters.AddWithValue("@DeliveredDate", DeliveredDate);
                SqlDatabase.cmd.Parameters.AddWithValue("@Model", Model);
                SqlDatabase.cmd.Parameters.AddWithValue("@RentedModel", Model);
                SqlDatabase.cmd.ExecuteNonQuery();

                SqlDatabase.cmd = new SqlCommand("USE AracKiralama UPDATE Cars SET Km = @Km, Damaged = @Damaged, Description = @Description, Rented = 0, Renter = NULL, RentDate = NULL, Delivered = 1, DeliveredDate = @DeliveredDate, LastRenter = @LastRenter WHERE Model = @Model", SqlDatabase.con);
                SqlDatabase.cmd.Parameters.AddWithValue("@Km", Km);
                SqlDatabase.cmd.Parameters.AddWithValue("@Damaged", Damaged);
                SqlDatabase.cmd.Parameters.AddWithValue("@Description", Description);
                SqlDatabase.cmd.Parameters.AddWithValue("@DeliveredDate", DeliveredDate);
                SqlDatabase.cmd.Parameters.AddWithValue("@LastRenter", Model);
                SqlDatabase.cmd.Parameters.AddWithValue("@Model", Model);
                SqlDatabase.cmd.ExecuteNonQuery();

                MessageBox.Show("Çağırma işlemi başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception Error)
            {
                MessageBox.Show("Çağırma işlemi başarısız. \n" + Error.Message + "\nHatalı Class : ClsAracKiralamaDatabase \nHatalı Metod : RecallCar \nHatalı Satır : 86", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }               
        }

        // TEK SEFER KULLANILANLARI RUNCOMMAND METODUNA AYARLA

        #endregion
    }
}
