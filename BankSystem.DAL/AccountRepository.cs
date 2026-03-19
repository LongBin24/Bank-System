using BankSystem.Models;
using Npgsql;
using System.Security.Principal;

namespace BankSystem.DAL
{
    public class AccountRepository
    {
        public Account GetAccountByUserId(int userId)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "SELECT * FROM Accounts WHERE UserID = @uid";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("uid", userId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Account
                            {
                                AccountID = (int)reader["AccountID"],
                                Balance = (decimal)reader["Balance"],
                                Currency = reader["Currency"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }

        public bool UpdateBalance(int accountId, decimal newBalance)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "UPDATE Accounts SET Balance = @bal WHERE AccountID = @aid";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("bal", newBalance);
                    cmd.Parameters.AddWithValue("aid", accountId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public int ExecuteTransfer(int senderId, int receiverId, decimal amount)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var trans = conn.BeginTransaction())
                {
                    try
                    {

                        string sql1 = "UPDATE Accounts SET Balance = Balance - @amt WHERE AccountID = @sid";
                        new NpgsqlCommand(sql1, conn) { Parameters = { new("amt", amount), new("sid", senderId) } }.ExecuteNonQuery();

                        string sql2 = "UPDATE Accounts SET Balance = Balance + @amt WHERE AccountID = @rid";
                        new NpgsqlCommand(sql2, conn) { Parameters = { new("amt", amount), new("rid", receiverId) } }.ExecuteNonQuery();

                        string sql3 = "INSERT INTO Transactions (AccountID, ToAccountID, Type, Amount) " +
                                        "VALUES (@sid, @rid, 'Transfer', @amt) RETURNING TransactionID";
                        int refNo = 0;
                        using (var cmd = new NpgsqlCommand(sql3, conn))
                        {
                            cmd.Parameters.AddWithValue("sid", senderId);
                            cmd.Parameters.AddWithValue("rid", receiverId);
                            cmd.Parameters.AddWithValue("amt", amount);
                            refNo = (int)cmd.ExecuteScalar();
                        }

                        trans.Commit();
                        return refNo; 
                    }
                    catch
                    {
                        trans.Rollback();
                        return 0;
                    }
                }
            }
        }


        public decimal GetExchangeRate(string fromCur, string toCur)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "SELECT Rate FROM ExchangeRates WHERE FromCurrency = @from AND ToCurrency = @to";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("from", fromCur);
                    cmd.Parameters.AddWithValue("to", toCur);
                    object result = cmd.ExecuteScalar();
                    return result != null ? (decimal)result : 0;
                }
            }
        }

    }
}
