using OfficeOpenXml.Style;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Web.UI.WebControls;

namespace HoLoQuan
{
    public partial class FormHoaDon : Form
    {
        Ketnoi kn = new Ketnoi();
        public FormHoaDon()
        {
            InitializeComponent();
        }
        public void loadcthd()
        {
            string query = "select TenDV,SOLUONG,THANHTIEN from CTHOADON where IDBAN = '" + txtidb.Text + "' ";
            DataSet ds = kn.LayDuLieu(query, "CTHOADON");
            dataGridViewhd.DataSource = ds.Tables["CTHOADON"];
        }
        public void tinhtien()
        {
            int tiendv = 0;
            string query = "select IDHOADON,TenDV,SOLUONG,THANHTIEN from CTHOADON where IDBAN = '" + txtidb.Text + "' ";
            DataSet ds = kn.LayDuLieu(query, "CTHOADON");
            txtMhd.Text = ds.Tables["CTHOADON"].Rows[0][0].ToString();
            for (int i = 0; i < ds.Tables["CTHOADON"].Rows.Count; i++)
            {
                int tt = int.Parse(ds.Tables["CTHOADON"].Rows[i].ItemArray[3].ToString());
                tiendv += tt;
            }
            txttdv.Text = tiendv.ToString();
            txttgg.Text = "-" + tiendv * FormQkyOrder.mgg.mg / 100;
            txttongt.Text = (tiendv - tiendv * FormQkyOrder.mgg.mg / 100).ToString();
        }
        private void buttonquaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            txtidb.Text = FormQkyOrder.idbtt.mb;
            loadcthd();
            tinhtien();
        }
        public class UserInfo
        {
            public string TENDV { get; set; }
            public int SOLUONG { get; set; }
            public int THANHTIEN { get; set; }
            public DateTime THOIGIAN { get; set; }
        }

        private void buttonXuatexel_Click(object sender, EventArgs e)
        {
            string query = "select TenDV,SOLUONG,THANHTIEN from CTHOADON where IDBAN = '" + txtidb.Text + "' ";
            DataSet ds = kn.LayDuLieu(query, "CTHOADON");

            string filePath = "";
            // tạo SaveFileDialog để lưu file excel
            SaveFileDialog dialog = new SaveFileDialog();

            // chỉ lọc ra các file có định dạng Excel
            dialog.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";

            // Nếu mở file và chọn nơi lưu file thành công sẽ lưu đường dẫn lại dùng
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
            }

            // nếu đường dẫn null hoặc rỗng thì báo không hợp lệ và return hàm
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Đường dẫn báo cáo không hợp lệ");
                return;
            }

            try
            {
                using (ExcelPackage p = new ExcelPackage())
                {
                    // đặt tên người tạo file
                    p.Workbook.Properties.Author = "QHN";

                    // đặt tiêu đề cho file
                    p.Workbook.Properties.Title = "Chi tiet hoa don";

                    //Tạo một sheet để làm việc trên đó
                    p.Workbook.Worksheets.Add("Hoa don sheet");

                    // lấy sheet vừa add ra để thao tác
                    ExcelWorksheet ws = p.Workbook.Worksheets[1];


                    // đặt tên cho sheet
                    ws.Name = "Chi tiết hóa đơn";
                    // fontsize mặc định cho cả sheet
                    ws.Cells.Style.Font.Size = 11;
                    // font family mặc định cho cả sheet
                    ws.Cells.Style.Font.Name = "Calibri";
                    ws.Column(1).Width = 20;
                    ws.Column(3).Width = 10;
                    // Tạo danh sách các column header
                    string[] arrColumnHeader = {
                                                "Tên dịch vụ",
                                                "Số lượng",
                                                "Thành tiền"
                    };

                    // lấy ra số lượng cột cần dùng dựa vào số lượng header
                    var countColHeader = arrColumnHeader.Count();

                    // merge các column lại từ column 1 đến số column header
                    // gán giá trị cho cell vừa merge là Thống kê thông tni User Kteam
                    ws.Cells[1, 1].Value = "Chi tiết hóa đơn ID bàn " + FormOrder.idbtt.mb;
                    ws.Cells[1, 1, 1, countColHeader].Merge = true;

                    // in đậm
                    ws.Cells[1, 1, 1, countColHeader].Style.Font.Bold = true;
                    // căn giữa
                    ws.Cells[1, 1, 1, countColHeader].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    ws.Cells[2, 1].Value = "Mã hóa đơn: " + txtMhd.Text;
                    ws.Cells[2, 1].Style.Font.Bold = true;
                    ws.Cells[2, 1, 2, countColHeader].Merge = true;
                    int colIndex = 1;
                    int rowIndex = 3;
                    //tạo các header từ column header đã tạo từ bên trên
                    foreach (var item in arrColumnHeader)
                    {
                        var cell = ws.Cells[rowIndex, colIndex];
                        cell.Style.Font.Bold = true;
                        //set màu thành gray
                        var fill = cell.Style.Fill;
                        fill.PatternType = ExcelFillStyle.Solid;
                        fill.BackgroundColor.SetColor(System.Drawing.Color.LightBlue);

                        //căn chỉnh các border
                        var border = cell.Style.Border;
                        border.Bottom.Style =
                            border.Top.Style =
                            border.Left.Style =
                            border.Right.Style = ExcelBorderStyle.Thin;

                        //gán giá trị
                        cell.Value = item;

                        colIndex++;
                    }


                    for (int i = 0; i < ds.Tables["CTHOADON"].Rows.Count; i++)
                    // với mỗi item trong danh sách sẽ ghi trên 1 dòng
                    {
                        // bắt đầu ghi từ cột 1. Excel bắt đầu từ 1 không phải từ 0
                        colIndex = 1;
                        // rowIndex tương ứng từng dòng dữ liệu
                        rowIndex++;

                        //gán giá trị cho từng cell
                        ws.Cells[rowIndex, colIndex].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                        ws.Cells[rowIndex, colIndex++].Value = ds.Tables["CTHOADON"].Rows[i].ItemArray[0].ToString();
                        ws.Cells[rowIndex, colIndex++].Value = int.Parse(ds.Tables["CTHOADON"].Rows[i].ItemArray[1].ToString());
                        ws.Cells[rowIndex, colIndex].Value = int.Parse(ds.Tables["CTHOADON"].Rows[i].ItemArray[2].ToString());
                        ws.Cells[rowIndex, colIndex++].Style.Border.Right.Style = ExcelBorderStyle.Thin;

                    }
                    for (int i = 1; i < 4; i++)
                    {
                        ws.Cells[rowIndex, i].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                    }
                    rowIndex++;

                    ws.Cells[rowIndex, 1].Value = "Tổng tiền";
                    ws.Cells[rowIndex, 1, rowIndex, 2].Merge = true;    //ghep cot
                    ws.Cells[rowIndex, 1, rowIndex, 2].Style.Font.Bold = true;         //in dam
                    ws.Cells[rowIndex, 1, rowIndex, 2].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;    //can giua
                    ws.Cells[rowIndex++, 3].Value = txttdv.Text;

                    ws.Cells[rowIndex, 1].Value = "Giảm giá";
                    ws.Cells[rowIndex, 1, rowIndex, 2].Merge = true;    //ghep cot
                    ws.Cells[rowIndex, 1, rowIndex, 2].Style.Font.Bold = true;         //in dam
                    ws.Cells[rowIndex, 1, rowIndex, 2].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;    //can giua
                    ws.Cells[rowIndex++, 3].Value = txttgg.Text;

                    ws.Cells[rowIndex, 1].Value = "Thành tiền";
                    ws.Cells[rowIndex, 1, rowIndex, 2].Merge = true;    //ghep cot
                    ws.Cells[rowIndex, 1, rowIndex, 2].Style.Font.Bold = true;         //in dam
                    ws.Cells[rowIndex, 1, rowIndex, 2].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;    //can giua
                    ws.Cells[rowIndex++, 3].Value = txttongt.Text;

                    //Lưu file lại 
                    Byte[] bin = p.GetAsByteArray();
                    File.WriteAllBytes(filePath, bin);
                }
                MessageBox.Show("Xuất excel thành công!");
            }
            catch (Exception EE)
            {
                MessageBox.Show("Có lỗi khi lưu file!");
            }
        }

        private void buttonThanhtoan_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thanh toán bàn này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                string query0 = "update HOADON set TIENDV='" + txttongt.Text + "' where IDBAN = '" + txtidb.Text + "'";
                DataSet ds0 = kn.LayDuLieu(query0, "HOADON");

                string query2 = "insert into LSGD(IDHD,IDBAN,TIENDV,NGAY) select * from HOADON where IDBAN = '" + txtidb.Text + "'";
                DataSet ds2 = kn.LayDuLieu(query2, "LSGD");
                string query22 = "update LSGD set GIAMGIA = '" + FormOrder.mgg.mg + "' where IDBAN = '" + txtidb.Text + "' and IDHD = '" + txtMhd.Text + "' ";
                DataSet ds22 = kn.LayDuLieu(query22, "BAN");

                string query3 = "insert into CTLSGD select * from CTHOADON where IDBAN = '" + txtidb.Text + "'";
                DataSet ds3 = kn.LayDuLieu(query3, "CTLSGD");

                string query1 = "update BAN set TRANGTHAI=N'Trống' where ID = '" + txtidb.Text + "'";
                DataSet ds = kn.LayDuLieu(query1, "BAN");

                string query5 = "delete from CTHOADON where IDBAN='" + txtidb.Text + "'";
                DataSet ds5 = kn.LayDuLieu(query5, "CTHOADON");

                string query6 = "delete from HOADON where IDBAN='" + txtidb.Text + "'";
                DataSet ds6 = kn.LayDuLieu(query6, "HOADON");
                MessageBox.Show("Thanh toán thành công");
                this.Close();
            }
        }
    }
}
