using Npgsql;
using System;
using System.Collections.Generic;
using BankSystem.Models; 

namespace BankSystem.DAL
{
    public class TransactionRepository
    {
        public List<TransactionView> GetHistory(int accountId)
        {
            List<TransactionView> list = new List<TransactionView>();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "SELECT TransactionID, Type, Amount, ToAccountID, TransactionDate " +
                             "FROM Transactions WHERE AccountID = @id ORDER BY TransactionDate DESC";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("id", accountId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new TransactionView
                            {
                                ID = (int)reader["TransactionID"],
                                Type = reader["Type"]?.ToString() ?? "",
                                Amount = (decimal)reader["Amount"],
                                ToAccount = reader["ToAccountID"] as int?,
                                Date = (DateTime)reader["TransactionDate"]
                            });
                        }
                    }
                }
            }
            return list;
        }
    }
}