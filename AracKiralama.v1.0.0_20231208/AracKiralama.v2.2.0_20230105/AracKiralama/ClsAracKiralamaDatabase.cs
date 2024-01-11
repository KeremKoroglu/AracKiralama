using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data;
using System.Xml.Linq;

namespace AracKiralama
{
    public class ClsAracKiralamaDatabase
    {
        // Class Connection -- Sınıf Bağlantıları
        #region Class Connection
        readonly ClsSqlDatabase SqlDatabase = new ClsSqlDatabase();
        readonly ClsTextTools TextTools = new ClsTextTools();
        #endregion

        // Values
        #region
        readonly string db = "AracKiralama", tbCars = "Cars", tbCustomers = "Customers";
        string Command;
        #endregion

        // METODS -- METODLAR
        #region METODS

        // Write Car Table -- Car Tablosuna Yaz
        public void WriteCarTable(string Price, string Model, string Km, string Seat, string AutoGear, string Damaged, string Description, string Rented, string Renter, string RentDate, string Delivered, string DeliveredDate, string DeliveryDate)
        {
            try
            {
                SqlDatabase.ConOpen();
                SqlDatabase.cmd = new SqlCommand("USE " + db + " INSERT INTO " + tbCars + " (Price, Model, Km, Seat, AutoGear, Damaged, Description, Rented, Renter, RentDate, Delivered, DeliveredDate, DeliveryDate) " +
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
                MessageBox.Show(Error.Message + "\nHatalı Satır : 33 \nHatalı Class : ClsAracKiralamaDatabase \nHatalı Metod : WriteCarTable", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Update Car -- Arabayı Güncelle
        public void UpdateCar(string Model, string Renter, string Description, string RentDate, string DeliveryDate)
        {
            try
            {
                SqlDatabase.ConOpen();
                SqlDatabase.cmd = new SqlCommand("USE " + db + " UPDATE " + tbCars + " SET Rented = 1, Renter = @Renter, Description = @Description, RentDate = @RentDate, Delivered = 0, DeliveryDate = @DeliveryDate WHERE Model = @Model", SqlDatabase.con);
                SqlDatabase.cmd.Parameters.AddWithValue("@Renter", Renter);
                SqlDatabase.cmd.Parameters.AddWithValue("@Description", Description);
                SqlDatabase.cmd.Parameters.AddWithValue("@RentDate", RentDate);
                SqlDatabase.cmd.Parameters.AddWithValue("@DeliveryDate", DeliveryDate);
                SqlDatabase.cmd.Parameters.AddWithValue("@Model", Model);
                SqlDatabase.cmd.ExecuteNonQuery();

                SqlDatabase.cmd = new SqlCommand("USE " + db + " UPDATE " + tbCustomers + " SET Renter = 1, RentedModel = @RentedModel, RentDate = @RentDateC, Delivered = 0, DeliveredDate = NULL, DeliveryDate = @DeliveryDateC WHERE Name = @Name", SqlDatabase.con);
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
                MessageBox.Show(Error.Message + "\nHatalı Satır : 61-69 \nHatalı Class : ClsAracKiralamaDatabase \nHatalı Metod : UpdateCar", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        // Recall Car -- Arabayı Çağır
        public void RecallCar(string Km, string Damaged, string Description, string DeliveredDate, string Model)
        {
            try
            {
                SqlDatabase.ConOpen();
                SqlDatabase.cmd = new SqlCommand("USE " + db + " UPDATE " + tbCustomers + " SET Renter = 0, RentedModel = NULL, RentDate = NULL, Delivered = 1, DeliveredDate = @DeliveredDate, DeliveryDate = NULL, LastRentedModel = @Model WHERE RentedModel = @RentedModel", SqlDatabase.con);
                SqlDatabase.cmd.Parameters.AddWithValue("@DeliveredDate", DeliveredDate);
                SqlDatabase.cmd.Parameters.AddWithValue("@Model", Model);
                SqlDatabase.cmd.Parameters.AddWithValue("@RentedModel", Model);
                SqlDatabase.cmd.ExecuteNonQuery();

                SqlDatabase.cmd = new SqlCommand("USE " + db + " UPDATE " + tbCars + " SET Km = @Km, Damaged = @Damaged, Description = @Description, Rented = 0, Renter = NULL, RentDate = NULL, Delivered = 1, DeliveredDate = @DeliveredDate, LastRenter = @LastRenter WHERE Model = @Model", SqlDatabase.con);
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
                MessageBox.Show(Error.Message + "\nHatalı Satır : 94-100 \nHatalı Class : ClsAracKiralamaDatabase \nHatalı Metod : RecallCar", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }               
        }

        // Edit Car -- Araba Düzenle
        public void EditCar(string Id, string Price, string Model, string Km, string Seat, string AutoGear, string Damaged,
            string Description, string Rented, string Renter, string RentDate, string Delivered,
            string DeliveredDate, string DeliveryDate, string LastRenter)
        {
            try
            {
                // Customers Updates -- Müşteri Güncelleştirmeleri
                SqlDatabase.ConOpen();
                string name = TextTools.GetBeforeSpace(Renter);
                string surname = TextTools.GetAfterSpace(Renter);

                if (Renter != "NULL")
                {
                    SqlDatabase.cmd = new SqlCommand("USE " + db + " UPDATE " + tbCustomers + " SET Renter = @Renter, RentedModel = @RentedModel, RentDate = @RentDate, Delivered = @Delivered, DeliveredDate = @DeliveredDate, DeliveryDate = @DeliveryDate WHERE Name = @Name AND Surname = @Surname", SqlDatabase.con);
                    SqlDatabase.cmd.Parameters.AddWithValue("@Renter", SqlDbType.Bit).Value = true;
                    SqlDatabase.cmd.Parameters.AddWithValue("@RentedModel", Model);
                    SqlDatabase.cmd.Parameters.AddWithValue("@RentDate", SqlDbType.Date).Value = RentDate == "NULL" ? DBNull.Value : (object)RentDate;
                    SqlDatabase.cmd.Parameters.AddWithValue("@Delivered", SqlDbType.Bit).Value = false;
                    SqlDatabase.cmd.Parameters.AddWithValue("@DeliveredDate", DBNull.Value);
                    SqlDatabase.cmd.Parameters.AddWithValue("@DeliveryDate", SqlDbType.Date).Value = DeliveryDate == "NULL" ? DBNull.Value : (object)DeliveryDate;
                    SqlDatabase.cmd.Parameters.AddWithValue("@Name", name);
                    SqlDatabase.cmd.Parameters.AddWithValue("@Surname", surname);
                    SqlDatabase.cmd.ExecuteNonQuery();
                }
                if (LastRenter != "NULL")
                {
                    string lastRenterName = TextTools.GetBeforeSpace(LastRenter);
                    string lastRenterSurname = TextTools.GetAfterSpace(LastRenter);

                    SqlDatabase.cmd = new SqlCommand("USE " + db + " UPDATE " + tbCustomers + " SET Renter = @Renter, RentedModel = @RentedModel, RentDate = @RentDate, Delivered = @Delivered, DeliveredDate = @DeliveredDate, DeliveryDate = @DeliveryDate, LastRentedModel = @LastRentedModel WHERE Name = @LastRenterName AND Surname = @LastRenterSurname", SqlDatabase.con);
                    SqlDatabase.cmd.Parameters.AddWithValue("@Renter", SqlDbType.Bit).Value = false;
                    SqlDatabase.cmd.Parameters.AddWithValue("@RentedModel", DBNull.Value);
                    SqlDatabase.cmd.Parameters.AddWithValue("@RentDate", DBNull.Value);
                    SqlDatabase.cmd.Parameters.AddWithValue("@Delivered", SqlDbType.Bit).Value = true;
                    SqlDatabase.cmd.Parameters.AddWithValue("@DeliveredDate", SqlDbType.Date).Value = DeliveredDate == "NULL" ? DBNull.Value : (object)DeliveredDate;
                    SqlDatabase.cmd.Parameters.AddWithValue("@DeliveryDate", SqlDbType.Date).Value = DeliveryDate == "NULL" ? DBNull.Value : (object)DeliveryDate;
                    SqlDatabase.cmd.Parameters.AddWithValue("@LastRentedModel", Model);
                    SqlDatabase.cmd.Parameters.AddWithValue("@LastRenterName", lastRenterName);
                    SqlDatabase.cmd.Parameters.AddWithValue("@LastRenterSurname", lastRenterSurname);
                    SqlDatabase.cmd.ExecuteNonQuery();
                }

                // Car Updates -- Araba Güncelleştirmeleri
                SqlDatabase.cmd = new SqlCommand(@"USE " + db + " UPDATE " + tbCars + " SET Price = @Price, Model = @Model," +
                "Km = @Km, Seat = @Seat, AutoGear = @AutoGear, Damaged = @Damaged, Description = @Description, Rented = @Rented," +
                "Renter = @Renter, RentDate = @RentDate, Delivered = @Delivered, DeliveredDate = @DeliveredDate, DeliveryDate = @DeliveryDate," +
                "LastRenter = @LastRenter WHERE Id = @Id", SqlDatabase.con);
                SqlDatabase.cmd.Parameters.AddWithValue("@Id", Id);
                SqlDatabase.cmd.Parameters.AddWithValue("@Price", SqlDbType.Int).Value = Price;
                SqlDatabase.cmd.Parameters.AddWithValue("@Model", Model);
                SqlDatabase.cmd.Parameters.AddWithValue("@Km", SqlDbType.Int).Value = Km;
                SqlDatabase.cmd.Parameters.AddWithValue("@Seat", SqlDbType.Int).Value = Seat;
                SqlDatabase.cmd.Parameters.AddWithValue("@AutoGear", SqlDbType.Bit).Value = AutoGear;
                SqlDatabase.cmd.Parameters.AddWithValue("@Damaged", SqlDbType.Bit).Value = Damaged;
                SqlDatabase.cmd.Parameters.AddWithValue("@Description", Description).Value = Description == "NULL" ? DBNull.Value : (object)Description;
                SqlDatabase.cmd.Parameters.AddWithValue("@Rented", SqlDbType.Bit).Value = Rented;
                SqlDatabase.cmd.Parameters.AddWithValue("@Renter", Renter).Value = Renter == "NULL" ? DBNull.Value : (object)Renter;
                SqlDatabase.cmd.Parameters.AddWithValue("@RentDate", SqlDbType.Date).Value = RentDate == "NULL" ? DBNull.Value : (object)RentDate;
                SqlDatabase.cmd.Parameters.AddWithValue("@Delivered", SqlDbType.Bit).Value = Delivered;
                SqlDatabase.cmd.Parameters.AddWithValue("@DeliveredDate", SqlDbType.Date).Value = DeliveredDate == "NULL" ? DBNull.Value : (object)DeliveredDate;
                SqlDatabase.cmd.Parameters.AddWithValue("@DeliveryDate", SqlDbType.Date).Value = DeliveryDate == "NULL" ? DBNull.Value : (object)DeliveryDate;
                SqlDatabase.cmd.Parameters.AddWithValue("@LastRenter", SqlDbType.NVarChar).Value = LastRenter == "NULL" ? DBNull.Value : (object)LastRenter;
                SqlDatabase.cmd.ExecuteNonQuery();
                SqlDatabase.ConClose();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message + "\nHatalı Class : ClsAracKiralamaDatabase \nHatalı Metod : EditCar", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Edit Customers -- Müşteri Düzenle
        public void EditCustomer(string Id, string Name, string Surname, string DateOfBirth, string Tckn, string Number,
            string Mail, string Renter, string RentedModel, string RentDate, string Delivered, string DeliveredDate,
            string DeliveryDate, string LastRentedModel)
        {
            try
            {
                SqlDatabase.ConOpen();
                string model = RentedModel;

                // Car Updates -- Araba Güncelleştirmeleri
                
                // New
                Command = "USE " + db + " UPDATE " + tbCars + " SET Rented = @Rented, Renter = @Renter, RentDate = @RentDate," +
                    "Delivered = @Delivered, DeliveredDate = @DeliveredDate, DeliveryDate = @DeliveryDate WHERE Model = @Model";
                SqlDatabase.cmd = new SqlCommand(Command, SqlDatabase.con);
                SqlDatabase.cmd.Parameters.AddWithValue("@Rented", SqlDbType.Bit).Value = true;
                SqlDatabase.cmd.Parameters.AddWithValue("@Renter", Renter);
                SqlDatabase.cmd.Parameters.AddWithValue("@RentDate", SqlDbType.Date).Value = RentDate == "NULL" ? DBNull.Value : (object)RentDate;
                SqlDatabase.cmd.Parameters.AddWithValue("@Delivered", SqlDbType.Bit).Value = false;
                SqlDatabase.cmd.Parameters.AddWithValue("@DeliveredDate", SqlDbType.Date).Value = DeliveredDate == "NULL" ? DBNull.Value : (object)DeliveredDate;
                SqlDatabase.cmd.Parameters.AddWithValue("@DeliveryDate", SqlDbType.Date).Value = DeliveryDate == "NULl" ? DBNull.Value : (object)DeliveryDate;
                SqlDatabase.cmd.ExecuteNonQuery();
                // Old
                Command = "USE " + db + " UPDATE " + tbCars + " SET Rented = @Rented, Renter = @Renter, RentDate = @RentDate," +
                    "Delivered = @Delivered, DeliveredDate = @DeliveredDate, DeliveryDate = @DeliveryDate, LastRenter = @LastRenter WHERE Model = @Model";
                SqlDatabase.cmd = new SqlCommand(Command, SqlDatabase.con);
                SqlDatabase.cmd.Parameters.AddWithValue("@Rented", SqlDbType.Bit).Value = false;
                SqlDatabase.cmd.Parameters.AddWithValue("@Renter", DBNull.Value);
                SqlDatabase.cmd.Parameters.AddWithValue("@RentDate", DBNull.Value);
                SqlDatabase.cmd.Parameters.AddWithValue("@Delivered", SqlDbType.Bit).Value = true;
                SqlDatabase.cmd.Parameters.AddWithValue("@DeliveredDate", SqlDbType.Date).Value = DeliveredDate == "NULL" ? DBNull.Value : (object)DeliveredDate;
                SqlDatabase.cmd.Parameters.AddWithValue("@DeliveryDate", DBNull.Value);
                SqlDatabase.cmd.Parameters.AddWithValue("@LastRenter", SqlDbType.NVarChar).Value = Renter == "NULl" ? DBNull.Value : (object)Renter;
                SqlDatabase.cmd.ExecuteNonQuery();

                // Customers Updates -- Müşteri Güncelleştirmeleri
                Command = "USE " + db + " UPDATE " + tbCustomers + " SET Name = @Name, Surname = @Surname, DateOfBirth = @DateOfBirth," +
                    "Tckn = @Tckn, Number = @Number, Mail = @Mail, Renter = @Renter, RentedModel = @RentedModel, RentDate = @RentDate," +
                    "Delivered = @Delivered, DeliveredDate = @DeliveredDate, DeliveryDate = @DeliveryDate, LastRentedModel = @LastRentedModel " +
                    "WHERE Id = @Id";
                SqlDatabase.cmd = new SqlCommand(Command, SqlDatabase.con);
                SqlDatabase.cmd.Parameters.AddWithValue("@Name", Name);
                SqlDatabase.cmd.Parameters.AddWithValue("@DateOfBirth", SqlDbType.Date).Value = DateOfBirth;
                SqlDatabase.cmd.Parameters.AddWithValue("@Tckn", Tckn);
                SqlDatabase.cmd.Parameters.AddWithValue("@Number", Number);
                SqlDatabase.cmd.Parameters.AddWithValue("@Mail", SqlDbType.NVarChar).Value = Mail == "NULL" ? DBNull.Value : (object)Mail;
                SqlDatabase.cmd.Parameters.AddWithValue("@Renter", SqlDbType.Bit).Value = Renter;
                SqlDatabase.cmd.Parameters.AddWithValue("@RentedModel", SqlDbType.NVarChar).Value = RentedModel == "NULL" ? DBNull.Value : (object)RentedModel;
                SqlDatabase.cmd.Parameters.AddWithValue("@RentDate", SqlDbType.Date).Value = RentDate == "NULL" ? DBNull.Value : (object)RentDate;
                SqlDatabase.cmd.Parameters.AddWithValue("@Delivered", SqlDbType.Bit).Value = Delivered;
                SqlDatabase.cmd.Parameters.AddWithValue("@Delivered", SqlDbType.Date).Value = DeliveredDate == "NULL" ? DBNull.Value : (object)DeliveredDate;
                SqlDatabase.cmd.Parameters.AddWithValue("@Delivery", SqlDbType.Date).Value = DeliveryDate == "NULL" ? DBNull.Value : (object)DeliveryDate;
                SqlDatabase.cmd.Parameters.AddWithValue("@LastRentedModel", SqlDbType.NVarChar).Value = LastRentedModel == "NULL" ? DBNull.Value : (object)LastRentedModel;
                SqlDatabase.cmd.Parameters.AddWithValue("@Id", Id);
                SqlDatabase.cmd.ExecuteNonQuery();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message + "\nHatalı Class : ClsAracKiralamaDatabase \nHatalı Metod : EditCustomer", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
