
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanSu.Data
{
    public static class Db
    {
        public static string ConnectionString
        {
            get
            {
                return System.Configuration.ConfigurationManager
                    .ConnectionStrings["QuanLyNhanSuDB"]
                    .ConnectionString;
            }
        }

        public static SqlConnection OpenConnection()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            return conn;
        }

        public static DataTable Query(
            string sql,
            params SqlParameter[] parameters)
        {
            using (SqlConnection conn = OpenConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                if (parameters != null && parameters.Length > 0)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public static int Execute(
            string sql,
            params SqlParameter[] parameters)
        {
            using (SqlConnection conn = OpenConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                if (parameters != null && parameters.Length > 0)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                return cmd.ExecuteNonQuery();
            }
        }

        public static object Scalar(
            string sql,
            params SqlParameter[] parameters)
        {
            using (SqlConnection conn = OpenConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                if (parameters != null && parameters.Length > 0)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                return cmd.ExecuteScalar();
            }
        }

        public static SqlParameter P(string name, object value)
        {
            if (value == null ||
                (value is string &&
                string.IsNullOrWhiteSpace((string)value)))
            {
                value = DBNull.Value;
            }

            return new SqlParameter(name, value);
        }

        public static bool TestConnection()
        {
            try
            {
                using (SqlConnection conn = OpenConnection())
                {
                    return conn.State == ConnectionState.Open;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
