using Npgsql;
using BankSystem.Models;
using System.Data;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace BankSystem.DAL
{
    public class UserRepository
    {
        public User Login(int userId, string pin)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string sql = "SELECT u.UserID, u.FullName, u.Phone, u.Role, a.AccountID, a.Balance, a.Currency " +
                             "FROM Users u " +
                             "LEFT JOIN Accounts a ON u.UserID = a.UserID " +
                             "WHERE u.UserID = @id AND u.PIN = @pin";   

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("id", userId);
                    cmd.Parameters.AddWithValue("pin", pin);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                UserID = (int)reader["UserID"],
                                FullName = reader["FullName"].ToString(),
                                Role = reader["Role"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }

        //Update
        public bool UpdateCustomer(User user)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
             
                string sqlUpdate = "UPDATE Users SET FullName = @name, Phone = @phone WHERE UserID = @id";
                using (var cmd = new NpgsqlCommand(sqlUpdate, conn))
                {
                    cmd.Parameters.AddWithValue("name", user.FullName);
                    cmd.Parameters.AddWithValue("phone", user.Phone);
                    cmd.Parameters.AddWithValue("id", user.UserID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        //Delete
        public bool DeleteCustomer(int userId)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                String sqlDelete = "DELETE FROM Users WHERE UserID = @id";
                using (var cmd = new NpgsqlCommand(sqlDelete, conn))
                {
                    cmd.Parameters.AddWithValue("id", userId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public string GetNameByAccountId(int accountId)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "SELECT u.FullName FROM Users u JOIN Accounts a ON u.UserID = a.UserID WHERE a.AccountID = @aid";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("aid", accountId);
                    object result = cmd.ExecuteScalar();
                    return result?.ToString() ?? "Unknown";
                }
            }
        }   

        public bool RegisterCustomer(User user, decimal initialDeposit, string currency)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var trans = conn.BeginTransaction())
                {
                    try
                    {
                        string sqlUser = "INSERT INTO Users (FullName, PIN, Role, Phone) VALUES (@name, @pin, 'Customer', @phone) RETURNING UserID";
                        int newUserId;
                        using (var cmd = new NpgsqlCommand(sqlUser, conn))
                        {
                            cmd.Parameters.AddWithValue("name", user.FullName);
                            cmd.Parameters.AddWithValue("pin", user.PIN);
                            cmd.Parameters.AddWithValue("phone", user.Phone);
                            newUserId = (int)cmd.ExecuteScalar();
                        }
                        string sqlAcc = "INSERT INTO Accounts (UserID, Balance, Currency, AccountType) VALUES (@uid, @bal, @cur, 'Savings')";
                        using (var cmd = new NpgsqlCommand(sqlAcc, conn))
                        {
                            cmd.Parameters.AddWithValue("uid", newUserId);
                            cmd.Parameters.AddWithValue("bal", initialDeposit);
                            cmd.Parameters.AddWithValue("cur", currency);
                            cmd.ExecuteNonQuery();
                        }

                        trans.Commit();
                        return true;
                    }
                    catch
                    {
                        trans.Rollback();
                        return false;
                    }
                }
            }
        }

        public bool RegisterStaff(User user)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var trans = conn.BeginTransaction())
                {
                    try
                    {
                        string sqlUser = "INSERT INTO Users (FullName, PIN, Role, Phone) VALUES (@name, @pin, 'Staff', @phone) RETURNING UserID";
                        int newUserId;
                        using (var cmd = new NpgsqlCommand(sqlUser, conn))
                        {
                            cmd.Parameters.AddWithValue("name", user.FullName);
                            cmd.Parameters.AddWithValue("pin", user.PIN);
                            cmd.Parameters.AddWithValue("phone", user.Phone);
                            newUserId = (int)cmd.ExecuteScalar();
                        }
                        trans.Commit();
                        return true;
                    }
                    catch
                    {
                        trans.Rollback();
                        return false;
                    }
                }
            }
        }


        public DataTable GetAllCustomers()
        {
            DataTable dt = new DataTable();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "SELECT u.UserID, u.FullName, u.Phone, a.AccountID, a.Balance, a.Currency " +
                             "FROM Users u JOIN Accounts a ON u.UserID = a.UserID WHERE u.Role = 'Customer'";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            return dt;
        }

        public DataTable GetAllStaff()
        {
            DataTable dt = new DataTable();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "SELECT userid, fullname, pin, role, phone, status " +
                             "FROM Users WHERE Role = 'Staff'";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            return dt;
        }

    }
}
