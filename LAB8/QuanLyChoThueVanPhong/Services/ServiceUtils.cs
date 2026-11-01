using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyChoThueVanPhong.Data;

namespace QuanLyChoThueVanPhong.Services
{
    internal static class ServiceUtils
    {
        public static DataTable Query(SqlConnection connection, SqlTransaction transaction, string sql, params SqlParameter[] parameters)
        {
            using (var command = Database.Command(connection, transaction, sql, parameters))
            using (var reader = command.ExecuteReader())
            {
                var result = new DataTable();
                result.Load(reader);
                return result;
            }
        }

        public static decimal Money(object value)
        {
            return Convert.ToDecimal(value);
        }

        public static void Require(bool condition, string message)
        {
            if (!condition) throw new InvalidOperationException(message);
        }

        public static DateTime AsDate(object value)
        {
            return Convert.ToDateTime(value).Date;
        }
    }
}
