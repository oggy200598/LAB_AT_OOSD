using System;
using System.Configuration;
using System.Data.SqlClient;

namespace eSHOPPING.Data
{
    public static class Db
    {
        public static SqlConnection CreateConnection()
        {
            var setting = ConfigurationManager.ConnectionStrings["eShoppingDb"];

            if (setting == null)
            {
                throw new Exception("Không tìm thấy connection string 'eShoppingDb' trong App.config.");
            }

            if (string.IsNullOrWhiteSpace(setting.ConnectionString))
            {
                throw new Exception("Connection string 'eShoppingDb' đang bị trống.");
            }

            return new SqlConnection(setting.ConnectionString);
        }
    }
}