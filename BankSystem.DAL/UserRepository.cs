using Npgsql;
using BankSystem.Models;
using System.Data;
using System.Collections.Generic;
using BCrypt.Net;
using System;

namespace BankSystem.DAL
{
    public class UserRepository
    {
        public User Login(int userId, string pin)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string sql = "SELECT u.UserID, u.FullName, u.Phone, u.Role, u.PIN, u.TelegramChatID " +
                             "FROM Users u " +
                             "WHERE u.UserID = @id";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("id", userId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedHash = reader["PIN"].ToString();

                            if (BCrypt.Net.BCrypt.Verify(pin, storedHash))
                            {
                                return new User
                                {
                                    UserID = (int)reader["UserID"],
                                    FullName = reader["FullName"].ToString(),
                                    Role = reader["Role"].ToString(),
                                    Phone = reader["Phone"]?.ToString(),
                                    TelegramChatID = reader["TelegramChatID"]?.ToString()
                                };
                            }
                        }
                    }
                }
            }
            return null; 
        }

        public bool RegisterStaff(User user)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(user.PIN);

                string sqlUser = "INSERT INTO Users (FullName, PIN, Role, Phone) VALUES (@name, @pin, 'Staff', @phone)";
                using (var cmd = new NpgsqlCommand(sqlUser, conn))
                {
                    cmd.Parameters.AddWithValue("name", user.FullName ?? string.Empty);
                    cmd.Parameters.AddWithValue("pin", hashedPassword);
                    cmd.Parameters.AddWithValue("phone", user.Phone ?? string.Empty);
                    return cmd.ExecuteNonQuery() > 0;
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
                        // Hash
                        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(user.PIN);

                        string sqlUser = "INSERT INTO Users (FullName, PIN, Role, Phone, TelegramChatID) " +
                                         "VALUES (@name, @pin, 'Customer', @phone, @tgid) RETURNING UserID";

                        int newUserId;
                        using (var cmd = new NpgsqlCommand(sqlUser, conn))
                        {
                            cmd.Parameters.AddWithValue("name", user.FullName);
                            cmd.Parameters.AddWithValue("pin", hashedPassword);
                            cmd.Parameters.AddWithValue("phone", user.Phone);
                            cmd.Parameters.AddWithValue("tgid", user.TelegramChatID ?? (object)DBNull.Value);
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

        public bool DeleteCustomer(int userId)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sqlDelete = "DELETE FROM Users WHERE UserID = @id";
                using (var cmd = new NpgsqlCommand(sqlDelete, conn))
                {
                    cmd.Parameters.AddWithValue("id", userId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public DataTable GetAllCustomers()
        {
            DataTable dt = new DataTable();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "SELECT u.UserID, u.FullName, u.Phone, u.TelegramChatID, a.AccountID, a.Balance, a.Currency " +
                             "FROM Users u JOIN Accounts a ON u.UserID = a.UserID WHERE u.Role = 'Customer'";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    using (var reader = cmd.ExecuteReader()) { dt.Load(reader); }
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
                string sql = "SELECT UserID, FullName, Phone, Role FROM Users WHERE Role = 'Staff'";
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
    }
}