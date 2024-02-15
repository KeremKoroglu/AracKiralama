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
using System.Configuration;
using SqlLibrary;

namespace AracKiralama
{
    public class SqlDatabase
    {
        // Class Connection -- Sınıf Bağlantıları
        #region Class Connection
        readonly ClsTextTools TextTools = new();
        readonly DatabaseManager DatabaseManage = new(ConfigurationManager.ConnectionStrings["AracKiralamaConnectionString"].ConnectionString);
        #endregion

        // Form Connection -- Form Bağlantıları
        #region Form Connection
        public static FrmMain Main {  get; set; }
        #endregion

        // Values -- Değişkenler
        #region Values
        private readonly string _ConnectionString = ConfigurationManager.ConnectionStrings["AracKiralamaConnectionString"].ConnectionString;
        public readonly string db = "AracKiralama", tbLogin = "Login", tbCars = "Cars", tbCustomers = "Customers", tbBank = "Bank";
        #endregion

        // METODS
        #region METODS

        public void AddCar(string Price, string Model, string Km, string Seat, string AutoGear, string Damaged, string Description, string Rented,
            string Renter, string RentDate, string Delivered, string DeliveredDate, string DeliveryDate)
        {
            try
            {
                using (SqlConnection con = new(_ConnectionString))
                {
                    con.Open();

                    string command = $"INSERT INTO {tbCars} (Price, Model, Km, Seat, AutoGear, Damaged, Description, Rented, Renter, RentDate, Delivered, DeliveredDate, DeliveryDate) " +
                        "VALUES (@Price, @Model, @Km, @Seat, @AutoGear, @Damaged, @Description, @Rented, @Renter, @RentDate, @Delivered, @DeliveredDate, @DeliveryDate)";

                    using SqlCommand cmd = new(command, con);
                    cmd.Parameters.AddWithValue("@Price", Price);
                    cmd.Parameters.AddWithValue("@Model", Model);
                    cmd.Parameters.AddWithValue("@Km", Km);
                    cmd.Parameters.AddWithValue("@Seat", Seat);
                    cmd.Parameters.AddWithValue("@AutoGear", AutoGear);
                    cmd.Parameters.AddWithValue("@Damaged", Damaged);
                    cmd.Parameters.AddWithValue("@Description", Description);
                    cmd.Parameters.AddWithValue("@Rented", Rented);
                    cmd.Parameters.AddWithValue("@Renter", Renter);
                    cmd.Parameters.AddWithValue("@RentDate", string.IsNullOrEmpty(RentDate) ? DBNull.Value : (object)RentDate);
                    cmd.Parameters.AddWithValue("@Delivered", Delivered);
                    cmd.Parameters.AddWithValue("@DeliveredDate", string.IsNullOrEmpty(DeliveredDate) ? DBNull.Value : (object)DeliveredDate);
                    cmd.Parameters.AddWithValue("@DeliveryDate", string.IsNullOrEmpty(DeliveryDate) ? DBNull.Value : (object)DeliveryDate);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Araç başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Araç kaydedilirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void UpdateCar(string Model, string Renter, string Description, string RentDate, string DeliveryDate)
        {
            try
            {
                using (SqlConnection con = new(_ConnectionString))
                {
                    con.Open();

                    // Update Cars Table -- Araç Tablosunu Güncelle
                    string command = $"UPDATE {tbCars} SET Rented = @Rented, Renter = @Renter, Description = @Description, RentDate = @RentDate, Delivered = @Delivered, DeliveryDate = @DeliveryDate WHERE Model = @Model";
                    using (SqlCommand cmd = new(command, con))
                    {
                        cmd.Parameters.AddWithValue("@Rented", true);
                        cmd.Parameters.AddWithValue("@Renter", Renter);
                        cmd.Parameters.AddWithValue("@Description", Description);
                        cmd.Parameters.AddWithValue("@RentDate", RentDate);
                        cmd.Parameters.AddWithValue("@Delivered", false);
                        cmd.Parameters.AddWithValue("@DeliveryDate", DeliveryDate);
                        cmd.Parameters.AddWithValue("@Model", Model);

                        cmd.ExecuteNonQuery();
                    }

                    // Update Customers Table -- Müşteri Tablosunu Güncelle
                    command = $"UPDATE {tbCustomers} SET Renter = @Renter, RentedModel = @RentedModel, RentDate = @RentDate, Delivered = @Delivered, DeliveredDate = @DeliveredDate, DeliveryDate = @DeliveryDate WHERE Name = @Name AND Surname = @Surname";
                    using (SqlCommand cmd = new(command, con))
                    {
                        cmd.Parameters.AddWithValue("@Renter", true);
                        cmd.Parameters.AddWithValue("@RentedModel", Model);
                        cmd.Parameters.AddWithValue("@RentDate", RentDate);
                        cmd.Parameters.AddWithValue("@Delivered", false);
                        cmd.Parameters.AddWithValue("@DeliveredDate", DBNull.Value);
                        cmd.Parameters.AddWithValue("@DeliveryDate", DeliveryDate);

                        string name = TextTools.GetBeforeSpace(Renter);
                        string surname = TextTools.GetAfterSpace(Renter);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Surname", surname);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Kiralama işlemi başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kiralama işlemi sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void RecallCar(string Km, string Damaged, string Description, string DeliveredDate, string Model)
        {
            try
            {
                using (SqlConnection con = new(_ConnectionString))
                {
                    con.Open();

                    // Update Customers Table -- Müşteri Tablosunu Güncelle
                    string renterName = DatabaseManage.GetColumn(tbCustomers, "Name", ("RentedModel", Model))[0];
                    string renterSurname = DatabaseManage.GetColumn(tbCustomers, "Surname", ("RentedModel", Model))[0];
                    string commandText = $"UPDATE {tbCustomers} SET Renter = @Renter, RentedModel = @RentedModel, RentDate = @RentDate, Delivered = @Delivered, DeliveredDate = @DeliveredDate, DeliveryDate = @DeliveryDate, LastRentedModel = @LastRentedModel WHERE RentedModel = @LastRentedModel";
                    using (SqlCommand cmd = new(commandText, con))
                    {
                        cmd.Parameters.AddWithValue("@Renter", false);
                        cmd.Parameters.AddWithValue("@RentedModel", DBNull.Value);
                        cmd.Parameters.AddWithValue("@RentDate", DBNull.Value);
                        cmd.Parameters.AddWithValue("@Delivered", true);
                        cmd.Parameters.AddWithValue("@DeliveredDate", DeliveredDate);
                        cmd.Parameters.AddWithValue("@DeliveryDate", DBNull.Value);
                        cmd.Parameters.AddWithValue("@LastRentedModel", Model);

                        cmd.ExecuteNonQuery();
                    }

                    // Update Cars Table -- Araç Tablosunu Güncelle
                    commandText = $"UPDATE {tbCars} SET Km = @Km, Damaged = @Damaged, Description = @Description, Rented = @Rented, Renter = @Renter, RentDate = @RentDate, Delivered = @Delivered, DeliveredDate = @DeliveredDate, LastRenter = @LastRenter WHERE Model = @Model";
                    using (SqlCommand cmd = new(commandText, con))
                    {
                        cmd.Parameters.AddWithValue("@Km", Km);
                        cmd.Parameters.AddWithValue("@Damaged", Damaged);
                        cmd.Parameters.AddWithValue("@Description", Description);
                        cmd.Parameters.AddWithValue("@Rented", false);
                        cmd.Parameters.AddWithValue("@Renter", DBNull.Value);
                        cmd.Parameters.AddWithValue("@RentDate", DBNull.Value);
                        cmd.Parameters.AddWithValue("@Delivered", true);
                        cmd.Parameters.AddWithValue("@DeliveredDate", DeliveredDate);
                        cmd.Parameters.AddWithValue("@LastRenter", renterName + " " + renterSurname);
                        cmd.Parameters.AddWithValue("@Model", Model);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Çağırma işlemi başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Çağırma işlemi sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void EditCar(string Id, string Price, string Model, string Km, string Seat, string AutoGear, string Damaged,string Description,
            string Rented, string Renter, string RentDate, string Delivered,string DeliveredDate, string DeliveryDate, string LastRenter)
        {
            try
            {
                using SqlConnection con = new(_ConnectionString);
                con.Open();

                // Update New Renter Customers -- Yeni Kiralayan Müşterinin Güncellenmesi
                if (!string.IsNullOrEmpty(Renter))
                {
                    string name = TextTools.GetBeforeSpace(Renter);
                    string surname = TextTools.GetAfterSpace(Renter);

                    string commandText = $"USE {db} UPDATE {tbCustomers} SET Renter = @Renter, RentedModel = @RentedModel, RentDate = @RentDate, Delivered = @Delivered, DeliveredDate = @DeliveredDate, DeliveryDate = @DeliveryDate WHERE Name = @Name AND Surname = @Surname";
                    using SqlCommand cmd = new(commandText, con);
                    cmd.Parameters.AddWithValue("@Renter", true);
                    cmd.Parameters.AddWithValue("@RentedModel", Model);
                    cmd.Parameters.AddWithValue("@RentDate", string.IsNullOrEmpty(RentDate) ? DBNull.Value : (object)RentDate);
                    cmd.Parameters.AddWithValue("@Delivered", false);
                    cmd.Parameters.AddWithValue("@DeliveredDate", DBNull.Value);
                    cmd.Parameters.AddWithValue("@DeliveryDate", string.IsNullOrEmpty(DeliveryDate) ? DBNull.Value : (object)DeliveryDate);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Surname", surname);
                    cmd.ExecuteNonQuery();
                }

                // Update Older Renter Customers -- Eski Kiralayan Müşterinin Güncellenmesi
                if (!string.IsNullOrEmpty(LastRenter))
                {
                    string lastRenterName = TextTools.GetBeforeSpace(LastRenter);
                    string lastRenterSurname = TextTools.GetAfterSpace(LastRenter);

                    string commandText = $"USE {db} UPDATE {tbCustomers} SET Renter = @Renter, RentedModel = @RentedModel, RentDate = @RentDate, Delivered = @Delivered, DeliveredDate = @DeliveredDate, DeliveryDate = @DeliveryDate, LastRentedModel = @LastRentedModel WHERE Name = @LastRenterName AND Surname = @LastRenterSurname";
                    using SqlCommand cmd = new(commandText, con);
                    cmd.Parameters.AddWithValue("@Renter", false);
                    cmd.Parameters.AddWithValue("@RentedModel", DBNull.Value);
                    cmd.Parameters.AddWithValue("@RentDate", DBNull.Value);
                    cmd.Parameters.AddWithValue("@Delivered", true);
                    cmd.Parameters.AddWithValue("@DeliveredDate", string.IsNullOrEmpty(DeliveredDate) ? DBNull.Value : (object)DeliveredDate);
                    cmd.Parameters.AddWithValue("@DeliveryDate", string.IsNullOrEmpty(DeliveryDate) ? DBNull.Value : (object)DeliveryDate);
                    cmd.Parameters.AddWithValue("@LastRentedModel", Model);
                    cmd.Parameters.AddWithValue("@LastRenterName", lastRenterName);
                    cmd.Parameters.AddWithValue("@LastRenterSurname", lastRenterSurname);
                    cmd.ExecuteNonQuery();
                }

                // Update Cars -- Araba Güncelleştirmeleri
                string updateCarCommand = $"USE {db} UPDATE {tbCars} SET Price = @Price, Model = @Model, Km = @Km, Seat = @Seat, AutoGear = @AutoGear, Damaged = @Damaged, Description = @Description, Rented = @Rented, Renter = @Renter, RentDate = @RentDate, Delivered = @Delivered, DeliveredDate = @DeliveredDate, DeliveryDate = @DeliveryDate, LastRenter = @LastRenter WHERE Id = @Id";
                using (SqlCommand cmd = new(updateCarCommand, con))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.Parameters.AddWithValue("@Price", Price);
                    cmd.Parameters.AddWithValue("@Model", Model);
                    cmd.Parameters.AddWithValue("@Km", Km);
                    cmd.Parameters.AddWithValue("@Seat", Seat);
                    cmd.Parameters.AddWithValue("@AutoGear", AutoGear);
                    cmd.Parameters.AddWithValue("@Damaged", Damaged);
                    cmd.Parameters.AddWithValue("@Description", string.IsNullOrEmpty(Description) ? DBNull.Value : (object)Description);
                    cmd.Parameters.AddWithValue("@Rented", Rented);
                    cmd.Parameters.AddWithValue("@Renter", string.IsNullOrEmpty(Renter) ? DBNull.Value : (object)Renter);
                    cmd.Parameters.AddWithValue("@RentDate", string.IsNullOrEmpty(RentDate) ? DBNull.Value : (object)RentDate);
                    cmd.Parameters.AddWithValue("@Delivered", Delivered);
                    cmd.Parameters.AddWithValue("@DeliveredDate", string.IsNullOrEmpty(DeliveredDate) ? DBNull.Value : (object)DeliveredDate);
                    cmd.Parameters.AddWithValue("@DeliveryDate", string.IsNullOrEmpty(DeliveryDate) ? DBNull.Value : (object)DeliveryDate);
                    cmd.Parameters.AddWithValue("@LastRenter", string.IsNullOrEmpty(LastRenter) ? DBNull.Value : (object)LastRenter);
                    cmd.ExecuteNonQuery();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nHatalı Class : ClsAracKiralamaDatabase \nHatalı Metod : EditCar", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void AddCustomer(string Name, string Surname, string DateOfBirth, string Tckn, string Number, string Mail, string Renter,
            string RentedModel, string RentDate, string Delivered, string DeliveredDate, string DeliveryDate)
        {
            try
            {
                using (SqlConnection con = new(_ConnectionString))
                {
                    con.Open();

                    string command = $"INSERT INTO {tbCustomers} (Name, Surname, DateOfBirth, Tckn, Number, Mail, Renter, RentedModel, RentDate, Delivered, DeliveredDate, DeliveryDate) " +
                        "VALUES (@Name, @Surname, @DateOfBirth, @Tckn, @Number, @Mail, @Renter, @RentedModel, @RentDate, @Delivered, @DeliveredDate, @DeliveryDate)";

                    using SqlCommand cmd = new(command, con);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Surname", Surname);
                    cmd.Parameters.AddWithValue("@DateOfBirth", string.IsNullOrEmpty(DateOfBirth) ? DBNull.Value : (object)DateOfBirth);
                    cmd.Parameters.AddWithValue("@Tckn", Tckn);
                    cmd.Parameters.AddWithValue("@Number", Number);
                    cmd.Parameters.AddWithValue("@Mail", Mail);
                    cmd.Parameters.AddWithValue("@Renter", Renter);
                    cmd.Parameters.AddWithValue("@RentedModel", string.IsNullOrEmpty(RentedModel) ? DBNull.Value : (object)RentedModel);
                    cmd.Parameters.AddWithValue("@RentDate", string.IsNullOrEmpty(RentDate) ? DBNull.Value : (object)RentDate);
                    cmd.Parameters.AddWithValue("@Delivered", Delivered);
                    cmd.Parameters.AddWithValue("@DeliveredDate", string.IsNullOrEmpty(DeliveredDate) ? DBNull.Value : (object)DeliveredDate);
                    cmd.Parameters.AddWithValue("@DeliveryDate", string.IsNullOrEmpty(DeliveryDate) ? DBNull.Value : (object)DeliveryDate);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Müşteri başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteri kaydedilirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void EditCustomer(string Id, string Name, string Surname, string DateOfBirth, string Tckn, string Number,string Mail, string Renter,
            string RentedModel, string RentDate, string Delivered, string DeliveredDate,string DeliveryDate, string LastRentedModel)
        {
            try
            {
                using (SqlConnection con = new(_ConnectionString))
                {
                con.Open();

                    // Update New Rented Car -- Yeni Kiralanan Aracın Güncellenmesi
                    if (!string.IsNullOrEmpty(RentedModel))
                    {
                        string commandText = $"USE {db} UPDATE {tbCars} SET Rented = @Rented, Renter = @Renter, RentDate = @RentDate, Delivered = @Delivered, DeliveredDate = @DeliveredDate, DeliveryDate = @DeliveryDate WHERE Model = @Model";
                        using SqlCommand cmd = new(commandText, con);
                        cmd.Parameters.AddWithValue("@Rented", true);
                        cmd.Parameters.AddWithValue("@Renter", Name + " " + Surname);
                        cmd.Parameters.AddWithValue("@RentDate", string.IsNullOrEmpty(RentDate) ? DBNull.Value : (object)RentDate);
                        cmd.Parameters.AddWithValue("@Delivered", false);
                        cmd.Parameters.AddWithValue("@DeliveredDate", string.IsNullOrEmpty(DeliveredDate) ? DBNull.Value : (object)DeliveredDate);
                        cmd.Parameters.AddWithValue("@DeliveryDate", string.IsNullOrEmpty(DeliveryDate) ? DBNull.Value : (object)DeliveryDate);
                        cmd.Parameters.AddWithValue("@Model", RentedModel);
                        cmd.ExecuteNonQuery();
                    }

                    // Update Last Rented Car -- Son Kiralanan Aracın Güncellenmesi
                    if (!string.IsNullOrEmpty(LastRentedModel))
                    {
                        string commandText = $"USE {db} UPDATE {tbCars} SET Rented = @Rented, Renter = @Renter, RentDate = @RentDate, Delivered = @Delivered, DeliveredDate = @DeliveredDate, DeliveryDate = @DeliveryDate, LastRenter = @LastRenter WHERE Model = @Model";
                        using SqlCommand cmd = new(commandText, con);
                        cmd.Parameters.AddWithValue("@Rented", false);
                        cmd.Parameters.AddWithValue("@Renter", DBNull.Value);
                        cmd.Parameters.AddWithValue("@RentDate", DBNull.Value);
                        cmd.Parameters.AddWithValue("@Delivered", true);
                        cmd.Parameters.AddWithValue("@DeliveredDate", string.IsNullOrEmpty(DeliveredDate) ? DBNull.Value : (object)DeliveredDate);
                        cmd.Parameters.AddWithValue("@DeliveryDate", DBNull.Value);
                        cmd.Parameters.AddWithValue("@LastRenter", string.IsNullOrEmpty(Renter) ? DBNull.Value : (object)Renter);
                        cmd.Parameters.AddWithValue("@Model", LastRentedModel);
                        cmd.ExecuteNonQuery();
                    }

                    // Update Customer Information -- Müşteri Bilgilerinin Güncellenmesi
                    string updateCustomerCommand = $"USE {db} UPDATE {tbCustomers} SET Name = @Name, Surname = @Surname, DateOfBirth = @DateOfBirth, Tckn = @Tckn, Number = @Number, Mail = @Mail, Renter = @Renter, RentedModel = @RentedModel, RentDate = @RentDate, Delivered = @Delivered, DeliveredDate = @DeliveredDate, DeliveryDate = @DeliveryDate, LastRentedModel = @LastRentedModel WHERE Id = @Id";
                    using (SqlCommand cmd = new(updateCustomerCommand, con))
                    {
                        cmd.Parameters.AddWithValue("@Name", Name);
                        cmd.Parameters.AddWithValue("@Surname", Surname);
                        cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                        cmd.Parameters.AddWithValue("@Tckn", Tckn);
                        cmd.Parameters.AddWithValue("@Number", Number);
                        cmd.Parameters.AddWithValue("@Mail", string.IsNullOrEmpty(Mail) ? DBNull.Value : (object)Mail);
                        cmd.Parameters.AddWithValue("@Renter", Renter);
                        cmd.Parameters.AddWithValue("@RentedModel", string.IsNullOrEmpty(RentedModel) ? DBNull.Value : (object)RentedModel);
                        cmd.Parameters.AddWithValue("@RentDate", string.IsNullOrEmpty(RentDate) ? DBNull.Value : (object)RentDate);
                        cmd.Parameters.AddWithValue("@Delivered", Delivered);
                        cmd.Parameters.AddWithValue("@DeliveredDate", string.IsNullOrEmpty(DeliveredDate) ? DBNull.Value : (object)DeliveredDate);
                        cmd.Parameters.AddWithValue("@DeliveryDate", string.IsNullOrEmpty(DeliveryDate) ? DBNull.Value : (object)DeliveryDate);
                        cmd.Parameters.AddWithValue("@LastRentedModel", string.IsNullOrEmpty(LastRentedModel) ? DBNull.Value : (object)LastRentedModel);
                        cmd.Parameters.AddWithValue("@Id", Id);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Müşteri bilgileri başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message + "\nHatalı Class : ClsAracKiralamaDatabase \nHatalı Metod : EditCustomer", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void RefreshCarInfo()
        {
            Main.LblTotalCar.Text = "Toplam Araba : " + DatabaseManage.ColumnCount(tbCars);
            Main.LblIdleCar.Text = "Boşta Araba : " + DatabaseManage.ColumnCount(tbCars, "=", ("Rented", "0"));
            Main.LblRentedCar.Text = "Kiralanan Araba : " + DatabaseManage.ColumnCount(tbCars, "=", ("Rented", "1"));
        }

        #endregion
    }
}
