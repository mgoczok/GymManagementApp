using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using GymManagementApp.Models;

namespace GymManagementApp.Database
{
    public static class DatabaseHelper
    {
        private static readonly string connectionString = "server=localhost;user=root;password=;database=gymdb;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        // metody użytkownika
        public static List<User> GetUsers()
        {
            var users = new List<User>();
            using var conn = GetConnection();
            conn.Open();
            const string query = "SELECT id, name, email, password FROM users";
            using var cmd = new MySqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                users.Add(new User
                {
                    Id = reader.GetInt32("id"),
                    Name = reader.GetString("name"),
                    Email = reader.GetString("email"),
                    Password = reader.GetString("password")
                });
            }
            return users;
        }

        public static void AddUser(User user)
        {
            using var conn = GetConnection();
            conn.Open();
            const string query = "INSERT INTO users (name, email, password) VALUES (@name, @email, @password)";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", user.Name);
            cmd.Parameters.AddWithValue("@email", user.Email);
            cmd.Parameters.AddWithValue("@password", user.Password);
            cmd.ExecuteNonQuery();
            user.Id = (int)cmd.LastInsertedId;
        }

        public static void UpdateUser(User user)
        {
            using var conn = GetConnection();
            conn.Open();
            const string query = "UPDATE users SET name=@name, email=@email, password=@password WHERE id=@id";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", user.Name);
            cmd.Parameters.AddWithValue("@email", user.Email);
            cmd.Parameters.AddWithValue("@password", user.Password);
            cmd.Parameters.AddWithValue("@id", user.Id);
            var rows = cmd.ExecuteNonQuery();
            if (rows == 0)
                throw new InvalidOperationException("User not found for update.");
        }

        public static void DeleteUser(int userId)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // usuwanie powiązania
                var deletePaymentsCmd = new MySqlCommand("DELETE FROM payments WHERE client_id = @userId", connection);
                deletePaymentsCmd.Parameters.AddWithValue("@userId", userId);
                deletePaymentsCmd.ExecuteNonQuery();

                // usuwanie użyutkownika
                var deleteUserCmd = new MySqlCommand("DELETE FROM users WHERE id = @userId", connection);
                deleteUserCmd.Parameters.AddWithValue("@userId", userId);
                deleteUserCmd.ExecuteNonQuery();
            }
        }

        // Grupy metody
        public static List<TrainingGroup> GetTrainingGroups()
        {
            var groups = new List<TrainingGroup>();
            using var conn = GetConnection();
            conn.Open();
            const string query = "SELECT id, name, description FROM `groups`";
            using var cmd = new MySqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                groups.Add(new TrainingGroup
                {
                    Id = reader.GetInt32("id"),
                    Name = reader.GetString("name"),
                    Description = reader.IsDBNull(reader.GetOrdinal("description"))
                                  ? null
                                  : reader.GetString("description")
                });
            }
            return groups;
        }

        // dodawanie treningów

        public static void AddTrainingGroup(TrainingGroup group)
        {
            using var conn = GetConnection();
            conn.Open();
            const string query = "INSERT INTO `groups` (name, description) VALUES (@name, @description)";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", group.Name);
            cmd.Parameters.AddWithValue("@description", group.Description);
            cmd.ExecuteNonQuery();
            group.Id = (int)cmd.LastInsertedId;
        }

        public static void DeleteTrainingGroup(int groupId)
        {
            using var conn = GetConnection();
            conn.Open();

            // usuwanie przypisania
            var deleteTrainings = new MySqlCommand("DELETE FROM trainings WHERE group_id = @id", conn);
            deleteTrainings.Parameters.AddWithValue("@id", groupId);
            deleteTrainings.ExecuteNonQuery();

            // usuwanie grupy
            const string query = "DELETE FROM `groups` WHERE id = @id";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", groupId);
            cmd.ExecuteNonQuery();
        }


        // metody treningów
        public static List<Training> GetAllTrainings()
        {
            var trainings = new List<Training>();
            using var conn = GetConnection();
            conn.Open();
            const string query = "SELECT id, name, description, group_id, training_type FROM trainings";
            using var cmd = new MySqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var type = reader.GetString("training_type");
                Training training = type switch
                {
                    "Cardio" => new CardioTraining(),
                    "Strength" => new StrengthTraining(),
                    _ => new GeneralTraining()
                };
                training.Id = reader.GetInt32("id");
                training.Name = reader.GetString("name");
                training.Description = reader.IsDBNull(reader.GetOrdinal("description"))
                                      ? string.Empty
                                      : reader.GetString("description");
                training.GroupId = reader.GetInt32("group_id");
                trainings.Add(training);
            }
            return trainings;
        }

        // dodawanie treningów

        public static void AddTraining(Training training)
        {
            SaveTraining(training);
        }

        public static void SaveTraining(Training training)
        {
            using var conn = GetConnection();
            conn.Open();
            MySqlCommand cmd;
            if (training.Id == 0)
            {
                cmd = new MySqlCommand(
                    "INSERT INTO trainings (name, description, group_id, training_type) " +
                    "VALUES (@name,@description,@group_id,@training_type)", conn);
            }
            else
            {
                cmd = new MySqlCommand(
                    "UPDATE trainings SET name=@name, description=@description, group_id=@group_id, training_type=@training_type " +
                    "WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", training.Id);
            }
            cmd.Parameters.AddWithValue("@name", training.Name);
            cmd.Parameters.AddWithValue("@description", training.Description);
            cmd.Parameters.AddWithValue("@group_id", training.GroupId);
            cmd.Parameters.AddWithValue("@training_type", training.TrainingType);
            cmd.ExecuteNonQuery();
            if (training.Id == 0)
            {
                training.Id = (int)cmd.LastInsertedId;
            }
        }

        //usuwanie

        public static void DeleteTraining(int trainingId)
        {
            using var conn = GetConnection();
            conn.Open();
            const string query = "DELETE FROM trainings WHERE id=@id";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", trainingId);
            cmd.ExecuteNonQuery();
        }

        // metody płatności
        public static List<Payment> GetAllPayments()
        {
            var list = new List<Payment>();
            using var conn = GetConnection();
            conn.Open();
            const string sql = "SELECT id, client_id, amount, date, payment_type FROM payments";
            using var cmd = new MySqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Payment
                {
                    Id = reader.GetInt32("id"),
                    ClientId = reader.GetInt32("client_id"),
                    Amount = reader.GetDecimal("amount"),
                    Date = reader.GetDateTime("date"),
                    PaymentType = reader.GetString("payment_type")
                });
            }
            return list;
        }

        public static void AddPayment(Payment payment)
        {
            SavePayment(payment);
        }

        public static void SavePayment(Payment payment)
        {
            using var conn = GetConnection();
            conn.Open();
            MySqlCommand cmd;
            if (payment.Id == 0)
            {
                cmd = new MySqlCommand(
                    "INSERT INTO payments (client_id, amount, date, payment_type) " +
                    "VALUES (@cid,@amt,@dt,@type)", conn);
            }
            else
            {
                cmd = new MySqlCommand(
                    "UPDATE payments SET client_id=@cid, amount=@amt, date=@dt, payment_type=@type " +
                    "WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", payment.Id);
            }
            cmd.Parameters.AddWithValue("@cid", payment.ClientId);
            cmd.Parameters.AddWithValue("@amt", payment.Amount);
            cmd.Parameters.AddWithValue("@dt", payment.Date);
            cmd.Parameters.AddWithValue("@type", payment.PaymentType);
            cmd.ExecuteNonQuery();
            if (payment.Id == 0)
            {
                payment.Id = (int)cmd.LastInsertedId;
            }
        }

        public static void DeletePayment(int paymentId)
        {
            using var conn = GetConnection();
            conn.Open();
            using var cmd = new MySqlCommand("DELETE FROM payments WHERE id=@id", conn);
            cmd.Parameters.AddWithValue("@id", paymentId);
            cmd.ExecuteNonQuery();
        }
    }
}
