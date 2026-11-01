using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;

namespace QuanLyChoThueVanPhong.Data
{
    public static class Database
    {
        public static string ConnectionString
        {
            get { return ConfigurationManager.ConnectionStrings["QuanLyChoThueVanPhong"].ConnectionString; }
        }

        public static SqlConnection Open()
        {
            var connection = new SqlConnection(ConnectionString);
            connection.Open();
            return connection;
        }

        public static DataTable Query(string sql, params SqlParameter[] parameters)
        {
            using (var connection = Open())
            using (var command = new SqlCommand(sql, connection))
            using (var adapter = new SqlDataAdapter(command))
            {
                command.CommandTimeout = 30;
                if (parameters != null) command.Parameters.AddRange(parameters);
                var result = new DataTable();
                adapter.Fill(result);
                return result;
            }
        }

        public static int Execute(string sql, params SqlParameter[] parameters)
        {
            using (var connection = Open())
            using (var command = new SqlCommand(sql, connection))
            {
                if (parameters != null) command.Parameters.AddRange(parameters);
                return command.ExecuteNonQuery();
            }
        }

        public static object Scalar(string sql, params SqlParameter[] parameters)
        {
            using (var connection = Open())
            using (var command = new SqlCommand(sql, connection))
            {
                if (parameters != null) command.Parameters.AddRange(parameters);
                return command.ExecuteScalar();
            }
        }

        public static SqlCommand Command(SqlConnection connection, SqlTransaction transaction, string sql, params SqlParameter[] parameters)
        {
            var command = new SqlCommand(sql, connection, transaction);
            if (parameters != null) command.Parameters.AddRange(parameters);
            return command;
        }

        public static object Scalar(SqlConnection connection, SqlTransaction transaction, string sql, params SqlParameter[] parameters)
        {
            using (var command = Command(connection, transaction, sql, parameters)) return command.ExecuteScalar();
        }

        public static int Execute(SqlConnection connection, SqlTransaction transaction, string sql, params SqlParameter[] parameters)
        {
            using (var command = Command(connection, transaction, sql, parameters)) return command.ExecuteNonQuery();
        }

        public static SqlParameter P(string name, object value)
        {
            return new SqlParameter(name, value ?? (object)DBNull.Value);
        }

        public static void Initialize(string proposedConnection)
        {
            var builder = new SqlConnectionStringBuilder(proposedConnection);
            builder.InitialCatalog = "master";
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database", "QuanLyChoThueVanPhong.sql");
            if (!File.Exists(path)) throw new FileNotFoundException("Không tìm thấy script CSDL: " + path);
            using (var connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                var batches = Regex.Split(File.ReadAllText(path), @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);
                foreach (var batch in batches)
                {
                    if (string.IsNullOrWhiteSpace(batch)) continue;
                    using (var command = new SqlCommand(batch, connection))
                    {
                        command.CommandTimeout = 90;
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        public static void SaveConnectionString(string value)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var item = config.ConnectionStrings.ConnectionStrings["QuanLyChoThueVanPhong"];
            item.ConnectionString = value;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("connectionStrings");
        }
    }
}
