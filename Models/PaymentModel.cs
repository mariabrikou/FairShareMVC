using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Text;

namespace FairShare.Models
{
    public class PaymentModel 
    {

        private  string dbServer = "";
        private  string dbServerPort = "";
        private  string dbName = "";
        private  string dbUsername = "";
        private  string dbPassword = "";
        public MySqlConnection Connection { get; private set; }
        public List<Payment> GetPayments(int userID)
        {
            List<Payment> payments = new List<Payment>();
            string connectionString = $"Server={dbServer};Port={dbServerPort};Database={dbName};User ID={dbUsername};Password={dbPassword};";

            try
            {
                Connection = new MySqlConnection(connectionString);
                Connection.Open();
                String query = "SELECT PAYER, STATISTICS.PAYMENT_ID AS ID, STATISTICS.SPLIT_AMOUNTS AS AMOUNT, PAYMENT_DATE FROM STATISTICS,PAYMENT WHERE STATISTICS.PAYMENT_ID = PAYMENT.PAYMENT_ID AND STATISTICS.USER_ID = @userID;";

                using (MySqlCommand command = new MySqlCommand(query, Connection))
                {
                    command.Parameters.AddWithValue("@userID", userID);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            double Amount = reader.GetDouble("AMOUNT");
                            DateTime Date = reader.GetDateTime("PAYMENT_DATE");
                            string UsernamePayer = reader.GetString("PAYER");
                            int PaymentID = reader.GetInt32("ID");
                            Payment payment = new Payment(UsernamePayer, Amount, Date, PaymentID);
                            payments.Add(payment);
                        }
                    }
                }
                return payments;
            }
            catch (Exception e)
            {
                throw new Exception("Database error while retrieving payments", e);   
            }
            finally
            {
                Connection.Close();
            }
            
        }
    }
}
