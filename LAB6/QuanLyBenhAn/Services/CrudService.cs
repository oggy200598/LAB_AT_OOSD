using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using QuanLyBenhAn_GiaHuy.Data;
namespace QuanLyBenhAn_GiaHuy.Services {
 public static class CrudService {
  // Tên bảng và tên cột chỉ lấy từ Catalog, không lấy trực tiếp từ ô người dùng.
  public static DataTable All(TableDef t){return Db.Query("SELECT * FROM ["+t.Name+"] ORDER BY ["+t.Key+"] DESC");}
  public static DataTable Options(string table){var t=Catalog.Find(table); var display=t.Fields.FirstOrDefault(x=>x.Name=="hoTen"||x.Name=="tenThuoc"||x.Name=="tenKhoa"); var col=display==null?t.Key:display.Name; return Db.Query("SELECT ["+t.Key+"] AS Id, CAST(["+t.Key+"] AS NVARCHAR(100)) + N' - ' + CAST(["+col+"] AS NVARCHAR(200)) AS Ten FROM ["+t.Name+"] ORDER BY ["+t.Key+"]"); }
  public static void Save(TableDef t, Dictionary<string,object> values,bool editing){
    if(values[t.Key]==null||string.IsNullOrWhiteSpace(values[t.Key].ToString())) throw new ArgumentException("Mã không được để trống.");
    var p=t.Fields.Select((f,i)=>new SqlParameter("@p"+i,values[f.Name]??DBNull.Value)).ToArray();
    string sql;
    if(editing) sql="UPDATE ["+t.Name+"] SET "+string.Join(",",t.Fields.Skip(1).Select((f,i)=>"["+f.Name+"]=@p"+(i+1)))+" WHERE ["+t.Key+"]=@p0";
    else sql="INSERT INTO ["+t.Name+"] ("+string.Join(",",t.Fields.Select(f=>"["+f.Name+"]"))+") VALUES ("+string.Join(",",t.Fields.Select((f,i)=>"@p"+i))+")";
    var affected=Db.Execute(sql,p); if(affected==0)throw new InvalidOperationException("Không tìm thấy bản ghi để cập nhật.");
  }
  public static void Delete(TableDef t,string id){var count=Db.Execute("DELETE FROM ["+t.Name+"] WHERE ["+t.Key+"]=@id",new SqlParameter("@id",id));if(count==0)throw new InvalidOperationException("Không có dữ liệu cần xóa.");}
 }
}
