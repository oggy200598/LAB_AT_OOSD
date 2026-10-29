using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using QuanLyBenhAn_GiaHuy.Services;
namespace QuanLyBenhAn_GiaHuy.Forms {
 public partial class FrmNhapLieu:Form {
  private readonly TableDef model;private readonly DataRow row;private readonly Dictionary<string,Control> controls=new Dictionary<string,Control>();
  public FrmNhapLieu(TableDef t,DataRow r){InitializeComponent();model=t;row=r;heading.Text=(r==null?"THÊM ":"CẬP NHẬT ")+t.Title.ToUpperInvariant();BuildFields();btnSave.Click+=(s,e)=>Save();}
  private void BuildFields(){foreach(var f in model.Fields){var label=new Label{Text=f.Title+":",AutoSize=true,Anchor=AnchorStyles.Left,ForeColor=Color.FromArgb(29,66,74)};Control c;
    if(f.Kind.StartsWith("ref:")){var cb=new ComboBox{DropDownStyle=ComboBoxStyle.DropDownList,Width=360,Anchor=AnchorStyles.Left|AnchorStyles.Right};try{var options=CrudService.Options(f.Kind.Substring(4));var blank=options.NewRow();blank["Id"]="";blank["Ten"]="-- Chọn --";options.Rows.InsertAt(blank,0);cb.DisplayMember="Ten";cb.ValueMember="Id";cb.DataSource=options;}catch(Exception ex){MessageBox.Show("Không tải được danh mục "+f.Title+": "+ex.Message);}c=cb;}
    else if(f.Kind=="bool")c=new CheckBox{Text="Đã xác nhận",AutoSize=true};
    else if(f.Kind=="date"||f.Kind=="datetime")c=new DateTimePicker{Format=f.Kind=="date"?DateTimePickerFormat.Short:DateTimePickerFormat.Custom,CustomFormat="dd/MM/yyyy HH:mm",Width=220};
    else if(f.Kind=="time")c=new DateTimePicker{Format=DateTimePickerFormat.Custom,CustomFormat="HH:mm",ShowUpDown=true,Width=130};
    else c=new TextBox{Width=360,Anchor=AnchorStyles.Left|AnchorStyles.Right};
    c.Font=new Font("Segoe UI",10F);c.Margin=new Padding(5,6,5,8);if(row!=null&&!row.IsNull(f.Name)){var val=row[f.Name];if(c is ComboBox) ((ComboBox)c).SelectedValue=val.ToString();else if(c is CheckBox)((CheckBox)c).Checked=Convert.ToBoolean(val);else if(c is DateTimePicker){DateTime dt; if(val is TimeSpan)dt=DateTime.Today.Add((TimeSpan)val);else dt=Convert.ToDateTime(val);((DateTimePicker)c).Value=dt;}else c.Text=Convert.ToString(val,CultureInfo.CurrentCulture);}
    if(row!=null&&f.Name==model.Key)c.Enabled=false;
    fieldsPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));int i=fieldsPanel.RowCount++;fieldsPanel.Controls.Add(label,0,i);fieldsPanel.Controls.Add(c,1,i);controls.Add(f.Name,c);
  }}
  private void Save(){try{var values=new Dictionary<string,object>();foreach(var f in model.Fields){var c=controls[f.Name];object value;
    if(c is ComboBox){value=((ComboBox)c).SelectedValue;value=value==null||value.ToString()==""?(object)DBNull.Value:value.ToString();}
    else if(c is CheckBox)value=((CheckBox)c).Checked;
    else if(c is DateTimePicker){var v=((DateTimePicker)c).Value;value=f.Kind=="time"?(object)v.TimeOfDay:v;}
    else {var text=c.Text.Trim();if(f.Kind=="int"){int n;if(!int.TryParse(text,out n)||n<=0)throw new ArgumentException(f.Title+" phải là số nguyên dương.");value=n;}else if(f.Kind=="decimal"){decimal d;if(!decimal.TryParse(text,NumberStyles.Number,CultureInfo.CurrentCulture,out d)||d<0)throw new ArgumentException(f.Title+" phải là số không âm.");value=d;}else value=text==""?(object)DBNull.Value:text;}
    values.Add(f.Name,value);
   }
   if(values[model.Key]==DBNull.Value)throw new ArgumentException("Mã không được để trống.");
   CrudService.Save(model,values,row!=null);MessageBox.Show("Đã lưu dữ liệu thành công.","Thông báo");this.DialogResult=DialogResult.OK;Close();
  }catch(Exception ex){MessageBox.Show("Không thể lưu: "+ex.Message,"Kiểm tra dữ liệu",MessageBoxButtons.OK,MessageBoxIcon.Warning);}}
 }
}
