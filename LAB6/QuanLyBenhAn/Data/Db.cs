using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyBenhAn_GiaHuy.Data {
 public static class Db {
  public static SqlConnection Open() { var c=new SqlConnection(ConfigurationManager.ConnectionStrings["QLBA"].ConnectionString); c.Open(); return c; }
  public static DataTable Query(string sql, params SqlParameter[] parameters) { using(var c=Open()) using(var cmd=new SqlCommand(sql,c)) {cmd.Parameters.AddRange(parameters); using(var da=new SqlDataAdapter(cmd)){var t=new DataTable(); da.Fill(t); return t;} } }
  public static int Execute(string sql, params SqlParameter[] parameters) { using(var c=Open()) using(var cmd=new SqlCommand(sql,c)) {cmd.Parameters.AddRange(parameters); return cmd.ExecuteNonQuery();} }
 }
}
