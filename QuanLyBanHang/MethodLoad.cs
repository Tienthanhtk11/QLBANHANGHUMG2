using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Data;

namespace QuanLyBanHang
{
    public class MethodLoad
    {
        public static void LoadCombobox(ComboBox cbName, System.Data.DataTable db, string value, string display)
        {
            try
            {
                cbName.DataSource = db;
                cbName.DisplayMember = display;
                cbName.ValueMember = value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
            cbName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbName.AutoCompleteSource = AutoCompleteSource.ListItems;

        }
        public static void Datagridview(DataGridView dgv)
        {
            dgv.BackgroundColor = System.Drawing.Color.White;
            dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgv.EnableHeadersVisualStyles = false;
            dgv.GridColor = System.Drawing.Color.WhiteSmoke;
            dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgv.ShowCellErrors = false;
            dgv.ShowCellToolTips = false;
            dgv.ShowEditingIcon = false;
            dgv.ShowRowErrors = false;
            dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToResizeRows = false;
        }
        public static void LoadDatagridview(DataGridView dgvName, System.Data.DataTable datatable)
        {
            dgvName.DataSource = datatable;
        }
        public static DataGridView dtg;
        public static void InDt(DataGridView dt)
        {
            dtg = dt;
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            System.Drawing.Printing.PrintDocument pd = new System.Drawing.Printing.PrintDocument();
            ppd.Document = pd;
            pd.PrintPage += Pd_PrintPage;
            ppd.ShowDialog();
        }

        private static void Pd_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try { e.Graphics.DrawImage(GetBmp(dtg), 0, 0); }
            catch { }
        }
        public static Bitmap GetBmp(DataGridView dgv)
        {
            try
            {
                dgv.BackgroundColor = Color.White;
                dgv.BorderStyle = BorderStyle.None;

                int height = dgv.Height;
                dgv.Height = dgv.RowCount * dgv.RowTemplate.Height * 2;
                Bitmap bmp = new Bitmap(dgv.Width, dgv.Height);
                dgv.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, dgv.Width, dgv.Height));
                dgv.Height = height;

                dgv.BorderStyle = BorderStyle.FixedSingle;
                return bmp;
            }
            catch { return null; }

        }

        public static void Excell(DataGridView dt,int a,string[] temp)
        {
            if(a == 0)
            {
                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("Chưa có dữ liệu");
                }
                else
                {
                    // khởi tạo 1 chương trình excell mới
                    Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();

                    //add thêm 1 sheet mới vào
                    Workbook wb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);

                    //
                    Worksheet ws = (Worksheet)Excel.ActiveSheet;
                    Excel.Visible = true;
                    int cl = dt.ColumnCount;
                    // thêm vào cột
                    ws.Cells[2, 2] = "Danh Sách hóa đơn xuất hàng";
                    ws.Cells[4, 1] = "STT";
                    ws.Cells[4, 2] = "Số hóa đơn";
                    ws.Cells[4, 3] = "Nhân viên";
                    ws.Cells[4, 4] = "Khách hàng";
                    ws.Cells[4, 5] = "Mặt hàng";
                    ws.Cells[4, 6] = "Số lượng";
                    ws.Cells[4, 7] = "Tổng tiền";
                    ws.Cells[4, 8] = "Ngày xuất hóa đơn";
                    int dem = 1;
                    for (int j = 5; j <= (dt.Rows.Count + 4); j++)
                    {
                        ws.Cells[j, 1] = dem;
                        for (int i = 2; i <= cl+1; i++)
                        {
                            ws.Cells[j, i] = dt.Rows[j - 5].Cells[i - 2].Value;
                        }
                        dem++;
                    }
                }
            }else if (a==1)
            {
                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("Chưa có dữ liệu");
                }
                else
                {
                    // khởi tạo 1 chương trình excell mới
                    Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();

                    //add thêm 1 sheet mới vào
                    Workbook wb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);

                    //
                    Worksheet ws = (Worksheet)Excel.ActiveSheet;
                    Excel.Visible = true;
                    int cl = dt.ColumnCount;
                    // thêm vào cột
                    ws.Cells[2, 2] = "Danh Sách hóa đơn nhập hàng";
                    ws.Cells[4, 1] = "STT";
                    ws.Cells[4, 2] = "Mã hóa đơn";
                    ws.Cells[4, 3] = "Tên mặt hàng";
                    ws.Cells[4, 4] = "Người nhập";
                    ws.Cells[4, 5] = "Ngày nhập";
                    ws.Cells[4, 6] = "Số lượng";
                    ws.Cells[4, 7] = "Đơn giá";
                    ws.Cells[4, 8] = "Phí vận chuyển";
                    ws.Cells[4, 9] = "Tổng tiền";
                    ws.Cells[4, 10] = "Mô tả";
                    int dem = 1;
                    for (int j = 5; j <= (dt.Rows.Count + 4); j++)
                    {
                        ws.Cells[j, 1] = dem;
                        for (int i = 2; i <= cl + 1; i++)
                        {
                            ws.Cells[j, i] = dt.Rows[j - 5].Cells[i - 2].Value;
                        }
                        dem++;
                    }
                }
            }
            else if (a == 2)
            {
                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("Chưa có dữ liệu");
                }
                else
                {
                    // khởi tạo 1 chương trình excell mới
                    Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();

                    //add thêm 1 sheet mới vào
                    Workbook wb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);

                    //
                    Worksheet ws = (Worksheet)Excel.ActiveSheet;
                    Excel.Visible = true;
                    int cl = dt.ColumnCount;
                    // thêm vào cột
                    ws.Cells[2, 2] = "BÁO CÁO SỐ HÀNG BÁN ĐƯỢC NHIỀU NHẤT TỪ NGÀY "+ temp[0] +" ĐẾN NGÀY "+temp[1];
                    ws.Cells[4, 1] = "STT";
                    ws.Cells[4, 2] = "Mã hàng";
                    ws.Cells[4, 3] = "Tên hàng";
                    ws.Cells[4, 4] = "Số lượng bán";
                    int dem = 1;
                    for (int j = 5; j <= (dt.Rows.Count + 4); j++)
                    {
                        ws.Cells[j, 1] = dem;
                        for (int i = 2; i <= cl + 1; i++)
                        {
                            ws.Cells[j, i] = dt.Rows[j - 5].Cells[i - 2].Value;
                        }
                        dem++;
                    }
                }
            }
            else if (a == 3)
            {
                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("Chưa có dữ liệu");
                }
                else
                {
                    // khởi tạo 1 chương trình excell mới
                    Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();

                    //add thêm 1 sheet mới vào
                    Workbook wb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);

                    //
                    Worksheet ws = (Worksheet)Excel.ActiveSheet;
                    Excel.Visible = true;
                    int cl = dt.ColumnCount;
                    // thêm vào cột
                    ws.Cells[2, 2] = "BÁO CÁO SỐ HÀNG TỒN KHO ĐẾN NGÀY " + DateTime.Now.ToShortDateString();
                    ws.Cells[4, 1] = "STT";
                    ws.Cells[4, 2] = "Mã hàng";
                    ws.Cells[4, 3] = "Tên hàng";
                    ws.Cells[4, 4] = "Tên nhà cung cấp";
                    ws.Cells[4, 5] = "Tên loại hàng";
                    ws.Cells[4, 6] = "Đơn vị tính";
                    ws.Cells[4, 7] = "Số lượng còn";
                    int dem = 1;
                    for (int j = 5; j <= (dt.Rows.Count + 4); j++)
                    {
                        ws.Cells[j, 1] = dem;
                        for (int i = 2; i <= cl + 1; i++)
                        {
                            ws.Cells[j, i] = dt.Rows[j - 5].Cells[i - 2].Value;
                        }
                        dem++;
                    }
                }
            }
        }

       public enum form
        {
            XuatKho,
            NhapKho,
            SoHangbanDuoc,
            SoHangTonKho
        }
    }
}
