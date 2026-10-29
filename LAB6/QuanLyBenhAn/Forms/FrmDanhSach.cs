using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using QuanLyBenhAn_GiaHuy.Services;
namespace QuanLyBenhAn_GiaHuy.Forms {
 public partial class FrmDanhSach:Form {
  private readonly TableDef model;private DataTable data;
  public FrmDanhSach(TableDef t){InitializeComponent();model=t;heading.Text="DANH SÁCH "+t.Title.ToUpperInvariant();txtSearch.TextChanged+=(s,e)=>Filter();btnReload.Click+=(s,e)=>LoadData();btnAdd.Click+=(s,e)=>Edit(false);btnEdit.Click+=(s,e)=>Edit(true);btnDelete.Click+=(s,e)=>DeleteSelected();grid.CellDoubleClick+=(s,e)=>{if(e.RowIndex>=0)Edit(true);};LoadData();}
  private void LoadData(){try{data=CrudService.All(model);grid.DataSource=data;foreach(var f in model.Fields)if(grid.Columns.Contains(f.Name))grid.Columns[f.Name].HeaderText=f.Title;Filter();}catch(Exception ex){MessageBox.Show("Không thể tải dữ liệu: "+ex.Message,"SQL Server",MessageBoxButtons.OK,MessageBoxIcon.Error);}}
  private void Filter(){if(data==null)return;var text=txtSearch.Text.Replace("'","''").Replace("[","[[]").Replace("%","[%]").Replace("*","[*]");try{data.DefaultView.RowFilter=string.IsNullOrWhiteSpace(text)?"":string.Join(" OR ",data.Columns.Cast<DataColumn>().Where(c=>c.DataType==typeof(string)).Select(c=>"CONVERT(["+c.ColumnName+"], 'System.String') LIKE '%"+text+"%'"));}catch(Exception){data.DefaultView.RowFilter="";}}
  private DataRow Current(){if(grid.CurrentRow==null)return null;var r=grid.CurrentRow.DataBoundItem as DataRowView;return r==null?null:r.Row;}
  private void Edit(bool existing){var row=existing?Current():null;if(existing&&row==null){MessageBox.Show("Hãy chọn một dòng.");return;}using(var f=new FrmNhapLieu(model,row)){if(f.ShowDialog(this)==DialogResult.OK)LoadData();}}
  private void DeleteSelected(){var row=Current();if(row==null){MessageBox.Show("Hãy chọn bản ghi cần xóa.");return;}if(MessageBox.Show("Xóa mã "+row[model.Key]+"?","Xác nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Question)!=DialogResult.Yes)return;try{CrudService.Delete(model,row[model.Key].ToString());LoadData();}catch(Exception ex){MessageBox.Show("Không thể xóa (có thể đang được bảng khác tham chiếu): "+ex.Message);}}
 }
}
