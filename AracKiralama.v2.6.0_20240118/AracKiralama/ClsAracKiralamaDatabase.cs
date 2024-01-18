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
        readonly ClsSqlDatabase SqlDatabase = new();
        readonly ClsTextTools TextTools = new();
        #endregion

        // Form Connection -- Form Bağlantıları
        #region Form Connection
        public static FrmMain Main {  get; set; }
        #endregion

        // Values -- Değişkenler
        #region Values
        readonly string db = "AracKiralama", tbCars = "Cars", tbCustomers = "Customers";
        string Command;
        #endregion

        // METODS
        #region METODS

        public void WriteCarTable(string Price, string Model, string Km, string Seat, string AutoGear, string Damaged, string Description, string Rented, string Renter, string RentDate, string Delivered, string DeliveredDate, string DeliveryDate)
        {
            /*try
            {*/
                SqlDatabase.ConOpen();
                Command = $"USE {db} INSERT INTO {tbCars} (Price, Model, Km, Seat, AutoGear, Damaged, Description, Rented, Renter, RentDate, Delivered, DeliveredDate, DeliveryDate) " +
                    "VALUES (@Price, @Model, @Km, @Seat, @AutoGear, @Damaged, @Description, @Rented, @Renter, @RentDate, @Delivered, @DeliveredDate, @DeliveryDate)";
                SqlDatabase.cmd = new SqlCommand(Command, SqlDatabase.con);
                SqlDatabase.cmd.Parameters.AddWithValue("@Price", Price);
                SqlDatabase.cmd.Parameters.AddWithValue("@Model", Model);
                SqlDatabase.cmd.Parameters.AddWithValue("@Km", Km);
                SqlDatabase.cmd.Parameters.AddWithValue("@Seat", Seat);
                SqlDatabase.cmd.Parameters.AddWithValue("@AutoGear", AutoGear);
                SqlDatabase.cmd.Parameters.AddWithValue("@Damaged", Damaged);
                SqlDatabase.cmd.Parameters.AddWithValue("@Description", Description);
                SqlDatabase.cmd.Parameters.AddWithValue("@Rented", Rented);
                SqlDatabase.cmd.Parameters.AddWithValue("@Renter", Renter);
                SqlDatabase.cmd.Parameters.AddWithValue("@RentDate", string.IsNullOrEmpty(RentDate) ? DBNull.Value : (object)RentDate);
                SqlDatabase.cmd.Parameters.AddWithValue("@Delivered", Delivered);
                SqlDatabase.cmd.Parameters.AddWithValue("@DeliveredDate", string.IsNullOrEmpty(DeliveredDate) ? DBNull.Value : (object)DeliveredDate);
                SqlDatabase.cmd.Parameters.AddWithValue("@DeliveryDate", string.IsNullOrEmpty(DeliveryDate) ? DBNull.Value : (object)DeliveryDate);
                SqlDatabase.cmd.ExecuteNonQuery();
                SqlDatabase.ConClose();
                MessageBox.Show("Araç başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            /*}
            catch (Exception Error) 
            {
                MessageBox.Show(Error.Message + "\nHatalı Satır : 33 \nHatalı Class : ClsAracKiralamaDatabase \nHatalı Metod : WriteCarTable", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
        public void UpdateCar(string Model, string Renter, string Description, string RentDate, string DeliveryDate)
        {
            try
            {
                SqlDatabase.ConOpen();
                Command = "USE " + db + " UPDATE " + tbCars + " SET Rented = @Rented, Renter = @Renter, Description = @Description, RentDate = @RentDate, Delivered = @Delivered, DeliveryDate = @DeliveryDate WHERE Model = @Model";
                SqlDatabase.cmd = new SqlCommand(Command, SqlDatabase.con);
                SqlDatabase.cmd.Parameters.AddWithValue("@Rented", true);
                SqlDatabase.cmd.Parameters.AddWithValue("@Renter", Renter);
                SqlDatabase.cmd.Parameters.AddWithValue("@Description", Description);
                SqlDatabase.cmd.Parameters.AddWithValue("@RentDate", RentDate);
                SqlDatabase.cmd.Parameters.AddWithValue("@Delivered", false);
                SqlDatabase.cmd.Parameters.AddWithValue("@DeliveryDate", DeliveryDate);
                SqlDatabase.cmd.Parameters.AddWithValue("@Model", Model);
                SqlDatabase.cmd.ExecuteNonQuery();

                Command = "USE " + db + " UPDATE " + tbCustomers + " SET Renter = @Renter, RentedModel = @RentedModel, RentDate = @RentDate, Delivered = @Delivered, DeliveredDate = @DeliveredDate, DeliveryDate = @DeliveryDate WHERE Name = @Name AND Surname = @Surname";
                SqlDatabase.cmd = new SqlCommand(Command, SqlDatabase.con);
                SqlDatabase.cmd.Parameters.AddWithValue("@Renter", true);
                SqlDatabase.cmd.Parameters.AddWithValue("@RentedModel", Model);
                SqlDatabase.cmd.Parameters.AddWithValue("@RentDate", RentDate);
                SqlDatabase.cmd.Parameters.AddWithValue("@Delivered", false);
                SqlDatabase.cmd.Parameters.AddWithValue("@DeliveredDate", DBNull.Value);
                SqlDatabase.cmd.Parameters.AddWithValue("@DeliveryDate", DeliveryDate);
                string name = TextTools.GetBeforeSpace(Renter);
                string surname = TextTools.GetAfterSpace(Renter);
                SqlDatabase.cmd.Parameters.AddWithValue("@Name", name);
                SqlDatabase.cmd.Parameters.AddWithValue("@Surname", surname);
                SqlDatabase.cmd.ExecuteNonQuery();

                MessageBox.Show("Kiralama işlemi başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message + "\nHatalı Satır : 61-69 \nHatalı Class : ClsAracKiralamaDatabase \nHatalı Metod : UpdateCar", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void RecallCar(string Km, string Damaged, string Description, string DeliveredDate, string Model)
        {
            try
            {
                SqlDatabase.ConOpen();
                Command = "USE " + db + " UPDATE " + tbCustomers + " SET Renter = @Renter, RentedModel = @RentedModel, RentDate = @RentDate, Delivered = @Delivered, DeliveredDate = @DeliveredDate, DeliveryDate = @DeliveryDate, LastRentedModel = @LastRentedModel WHERE RentedModel = @RentedModel";
                SqlDatabase.cmd = new SqlCommand(Command, SqlDatabase.con);
                SqlDatabase.cmd.Parameters.AddWithValue("@Renter", false);
                SqlDatabase.cmd.Parameters.AddWithValue("@RentedModel", DBNull.Value);
                SqlDatabase.cmd.Parameters.AddWithValue("@RentDate", DBNull.Value);
                SqlDatabase.cmd.Parameters.AddWithValue("@Delivered", true);
                SqlDatabase.cmd.Parameters.AddWithValue("@DeliveredDate", DeliveredDate);
                SqlDatabase.cmd.Parameters.AddWithValue("@DeliveryDate", DBNull.Value);
                SqlDatabase.cmd.Parameters.AddWithValue("@LastRentedModel", Model);
                SqlDatabase.cmd.Parameters.AddWithValue("@RentedModel", Model);
                SqlDatabase.cmd.ExecuteNonQuery();

                Command = "USE " + db + " UPDATE " + tbCars + " SET Km = @Km, Damaged = @Damaged, Description = @Description, Rented = @Rented, Renter = @Renter, RentDate = @RentDate, Delivered = @Delivered, DeliveredDate = @DeliveredDate, LastRenter = @LastRenter WHERE Model = @Model";
                SqlDatabase.cmd = new SqlCommand(Command, SqlDatabase.con);
                SqlDatabase.cmd.Parameters.AddWithValue("@Km", Km);
                SqlDatabase.cmd.Parameters.AddWithValue("@Damaged", Damaged);
                SqlDatabase.cmd.Parameters.AddWithValue("@Description", Description);
                SqlDatabase.cmd.Parameters.AddWithValue("@Rented", false);
                SqlDatabase.cmd.Parameters.AddWithValue("@Renter", DBNull.Value);
                SqlDatabase.cmd.Parameters.AddWithValue("@RentDate", DBNull.Value);
                SqlDatabase.cmd.Parameters.AddWithValue("@Delivered", true);
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
        public void EditCar(string Id, string Price, string Model, string Km, string Seat, string AutoGear, string Damaged,string Description,
            string Rented, string Renter, string RentDate, string Delivered,string DeliveredDate, string DeliveryDate, string LastRenter)
        {
            try
            {
                // Customers Updates -- Müşteri Güncelleştirmeleri
                SqlDatabase.ConOpen();
                string name = TextTools.GetBeforeSpace(Renter);
                string surname = TextTools.GetAfterSpace(Renter);

                if (!string.IsNullOrEmpty(Renter))
                {
                    // New
                    Command = "USE " + db + " UPDATE " + tbCustomers + " SET Renter = @Renter, RentedModel = @RentedModel, RentDate = @RentDate, Delivered = @Delivered, DeliveredDate = @DeliveredDate, DeliveryDate = @DeliveryDate WHERE Name = @Name AND Surname = @Surname";
                    SqlDatabase.cmd = new SqlCommand(Command, SqlDatabase.con);
                    SqlDatabase.cmd.Parameters.AddWithValue("@Renter", true);
                    SqlDatabase.cmd.Parameters.AddWithValue("@RentedModel", Model);
                    SqlDatabase.cmd.Parameters.AddWithValue("@RentDate", string.IsNullOrEmpty(RentDate) ? DBNull.Value : (object)RentDate);
                    SqlDatabase.cmd.Parameters.AddWithValue("@Delivered", false);
                    SqlDatabase.cmd.Parameters.AddWithValue("@DeliveredDate", DBNull.Value);
                    SqlDatabase.cmd.Parameters.AddWithValue("@DeliveryDate", string.IsNullOrEmpty(DeliveryDate) ? DBNull.Value : (object)DeliveryDate);
                    SqlDatabase.cmd.Parameters.AddWithValue("@Name", name);
                    SqlDatabase.cmd.Parameters.AddWithValue("@Surname", surname);
                    SqlDatabase.cmd.ExecuteNonQuery();
                }
                if (!string.IsNullOrEmpty(LastRenter))
                {
                    // Old
                    string lastRenterName = TextTools.GetBeforeSpace(LastRenter);
                    string lastRenterSurname = TextTools.GetAfterSpace(LastRenter);

                    Command = "USE " + db + " UPDATE " + tbCustomers + " SET Renter = @Renter, RentedModel = @RentedModel, RentDate = @RentDate, Delivered = @Delivered, DeliveredDate = @DeliveredDate, DeliveryDate = @DeliveryDate, LastRentedModel = @LastRentedModel WHERE Name = @LastRenterName AND Surname = @LastRenterSurname";
                    SqlDatabase.cmd = new SqlCommand(Command, SqlDatabase.con);
                    SqlDatabase.cmd.Parameters.AddWithValue("@Renter", false);
                    SqlDatabase.cmd.Parameters.AddWithValue("@RentedModel", DBNull.Value);
                    SqlDatabase.cmd.Parameters.AddWithValue("@RentDate", DBNull.Value);
                    SqlDatabase.cmd.Parameters.AddWithValue("@Delivered", true);
                    SqlDatabase.cmd.Parameters.AddWithValue("@DeliveredDate", string.IsNullOrEmpty(DeliveredDate) ? DBNull.Value : (object)DeliveredDate);
                    SqlDatabase.cmd.Parameters.AddWithValue("@DeliveryDate", string.IsNullOrEmpty(DeliveryDate) ? DBNull.Value : (object)DeliveryDate);
                    SqlDatabase.cmd.Parameters.AddWithValue("@LastRentedModel", Model);
                    SqlDatabase.cmd.Parameters.AddWithValue("@LastRenterName", lastRenterName);
                    SqlDatabase.cmd.Parameters.AddWithValue("@LastRenterSurname", lastRenterSurname);
                    SqlDatabase.cmd.ExecuteNonQuery();
                }

                // Car Updates -- Araba Güncelleştirmeleri
                Command = "USE " + db + " UPDATE " + tbCars + " SET Price = @Price, Model = @Model, Km = @Km, Seat = @Seat, AutoGear = @AutoGear, Damaged = @Damaged, " +
                    "Description = @Description, Rented = @Rented, Renter = @Renter, RentDate = @RentDate, Delivered = @Delivered, DeliveredDate = @DeliveredDate, " +
                    "DeliveryDate = @DeliveryDate, LastRenter = @LastRenter WHERE Id = @Id";
                SqlDatabase.cmd = new SqlCommand(Command, SqlDatabase.con);
                SqlDatabase.cmd.Parameters.AddWithValue("@Id", Id);
                SqlDatabase.cmd.Parameters.AddWithValue("@Price", Price);
                SqlDatabase.cmd.Parameters.AddWithValue("@Model", Model);
                SqlDatabase.cmd.Parameters.AddWithValue("@Km", Km);
                SqlDatabase.cmd.Parameters.AddWithValue("@Seat", Seat);
                SqlDatabase.cmd.Parameters.AddWithValue("@AutoGear", AutoGear);
                SqlDatabase.cmd.Parameters.AddWithValue("@Damaged", Damaged);
                SqlDatabase.cmd.Parameters.AddWithValue("@Description", string.IsNullOrEmpty(Description) ? DBNull.Value : (object)Description);
                SqlDatabase.cmd.Parameters.AddWithValue("@Rented", Rented);
                SqlDatabase.cmd.Parameters.AddWithValue("@Renter", string.IsNullOrEmpty(Renter) ? DBNull.Value : (object)Renter);
                SqlDatabase.cmd.Parameters.AddWithValue("@RentDate", string.IsNullOrEmpty(RentDate) ? DBNull.Value : (object)RentDate);
                SqlDatabase.cmd.Parameters.AddWithValue("@Delivered", Delivered);
                SqlDatabase.cmd.Parameters.AddWithValue("@DeliveredDate", string.IsNullOrEmpty(DeliveredDate) ? DBNull.Value : (object)DeliveredDate);
                SqlDatabase.cmd.Parameters.AddWithValue("@DeliveryDate", string.IsNullOrEmpty(DeliveryDate) ? DBNull.Value : (object)DeliveryDate);
                SqlDatabase.cmd.Parameters.AddWithValue("@LastRenter", string.IsNullOrEmpty(LastRenter) ? DBNull.Value : (object)LastRenter);
                SqlDatabase.cmd.ExecuteNonQuery();
                SqlDatabase.ConClose();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message + "\nHatalı Class : ClsAracKiralamaDatabase \nHatalı Metod : EditCar", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void EditCustomer(string Id, string Name, string Surname, string DateOfBirth, string Tckn, string Number,string Mail, string Renter,
            string RentedModel, string RentDate, string Delivered, string DeliveredDate,string DeliveryDate, string LastRentedModel)
        {
            try
            {
                SqlDatabase.ConOpen();
                string model = RentedModel;

                // Car Updates -- Araba Güncelleştirmeleri

                if (!string.IsNullOrEmpty(model))
                {
                    // New
                    Command = "USE " + db + " UPDATE " + tbCars + " SET Rented = @Rented, Renter = @Renter, RentDate = @RentDate, " +
                        "Delivered = @Delivered, DeliveredDate = @DeliveredDate, DeliveryDate = @DeliveryDate WHERE Model = @Model";
                    SqlDatabase.cmd = new SqlCommand(Command, SqlDatabase.con);
                    SqlDatabase.cmd.Parameters.AddWithValue("@Rented", true);
                    SqlDatabase.cmd.Parameters.AddWithValue("@Renter", Name + " " + Surname);
                    SqlDatabase.cmd.Parameters.AddWithValue("@RentDate", string.IsNullOrEmpty(RentDate) ? DBNull.Value : (object)RentDate);
                    SqlDatabase.cmd.Parameters.AddWithValue("@Delivered", false);
                    SqlDatabase.cmd.Parameters.AddWithValue("@DeliveredDate", string.IsNullOrEmpty(DeliveredDate) ? DBNull.Value : (object)DeliveredDate);
                    SqlDatabase.cmd.Parameters.AddWithValue("@DeliveryDate", string.IsNullOrEmpty(DeliveryDate) ? DBNull.Value : (object)DeliveryDate);
                    SqlDatabase.cmd.Parameters.AddWithValue("@Model", model);
                    SqlDatabase.cmd.ExecuteNonQuery();
                }

                if (!string.IsNullOrEmpty(LastRentedModel))
                {
                    // Old
                    Command = "USE " + db + " UPDATE " + tbCars + " SET Rented = @Rented, Renter = @Renter, RentDate = @RentDate, " +
                        "Delivered = @Delivered, DeliveredDate = @DeliveredDate, DeliveryDate = @DeliveryDate, LastRenter = @LastRenter WHERE Model = @Model";
                    SqlDatabase.cmd = new SqlCommand(Command, SqlDatabase.con);
                    SqlDatabase.cmd.Parameters.AddWithValue("@Rented", false);
                    SqlDatabase.cmd.Parameters.AddWithValue("@Renter", DBNull.Value);
                    SqlDatabase.cmd.Parameters.AddWithValue("@RentDate", DBNull.Value);
                    SqlDatabase.cmd.Parameters.AddWithValue("@Delivered", true);
                    SqlDatabase.cmd.Parameters.AddWithValue("@DeliveredDate", string.IsNullOrEmpty(DeliveredDate) ? DBNull.Value : (object)DeliveredDate);
                    SqlDatabase.cmd.Parameters.AddWithValue("@DeliveryDate", DBNull.Value);
                    SqlDatabase.cmd.Parameters.AddWithValue("@LastRenter", string.IsNullOrEmpty(Renter) ? DBNull.Value : (object)Renter);
                    SqlDatabase.cmd.Parameters.AddWithValue("@Model", LastRentedModel);
                    SqlDatabase.cmd.ExecuteNonQuery();
                }

                // Customers Updates -- Müşteri Güncelleştirmeleri
                Command = "USE " + db + " UPDATE " + tbCustomers + " SET Name = @Name, Surname = @Surname, DateOfBirth = @DateOfBirth, Tckn = @Tckn, Number = @Number," +
                    " Mail = @Mail, Renter = @Renter, RentedModel = @RentedModel, RentDate = @RentDate, Delivered = @Delivered, DeliveredDate = @DeliveredDate," +
                    " DeliveryDate = @DeliveryDate, LastRentedModel = @LastRentedModel WHERE Id = @Id";
                SqlDatabase.cmd = new SqlCommand(Command, SqlDatabase.con);
                SqlDatabase.cmd.Parameters.AddWithValue("@Name", Name);
                SqlDatabase.cmd.Parameters.AddWithValue("@Surname", Surname);
                SqlDatabase.cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                SqlDatabase.cmd.Parameters.AddWithValue("@Tckn", Tckn);
                SqlDatabase.cmd.Parameters.AddWithValue("@Number", Number);
                SqlDatabase.cmd.Parameters.AddWithValue("@Mail", string.IsNullOrEmpty(Mail) ? DBNull.Value : (object)Mail);
                SqlDatabase.cmd.Parameters.AddWithValue("@Renter", Renter);
                SqlDatabase.cmd.Parameters.AddWithValue("@RentedModel", string.IsNullOrEmpty(RentedModel) ? DBNull.Value : (object)RentedModel);
                SqlDatabase.cmd.Parameters.AddWithValue("@RentDate", string.IsNullOrEmpty(RentDate) ? DBNull.Value : (object)RentDate);
                SqlDatabase.cmd.Parameters.AddWithValue("@Delivered", Delivered);
                SqlDatabase.cmd.Parameters.AddWithValue("@DeliveredDate", string.IsNullOrEmpty(DeliveredDate) ? DBNull.Value : (object)DeliveredDate);
                SqlDatabase.cmd.Parameters.AddWithValue("@DeliveryDate", string.IsNullOrEmpty(DeliveryDate) ? DBNull.Value : (object)DeliveryDate);
                SqlDatabase.cmd.Parameters.AddWithValue("@LastRentedModel", string.IsNullOrEmpty(LastRentedModel) ? DBNull.Value : (object)LastRentedModel);
                SqlDatabase.cmd.Parameters.AddWithValue("@Id", Id);
                SqlDatabase.cmd.ExecuteNonQuery();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message + "\nHatalı Class : ClsAracKiralamaDatabase \nHatalı Metod : EditCustomer", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void RefreshCarInfo()
        {
            // Bu değer toplam satır sayısından alındı
            Main.LblTotalCar.Text = "Toplam Araba : " + SqlDatabase.ColumnCount(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars);
            Main.LblIdleCar.Text = "Boşta Araba : " + SqlDatabase.ColumnCount(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "=", 1, "Rented", "0");
            Main.LblRentedCar.Text = "Kiralanan Araba : " + SqlDatabase.ColumnCount(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "=", 1, "Rented", "1");
        }

        #endregion
    }
}
