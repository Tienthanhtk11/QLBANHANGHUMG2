using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.BAOCAO
{
    public class ExportBaoCao
    {
        public static void ExportXLSX(DataGridView dgv, int[] x, int[] y, string[] vanban)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            //Khởi tạo WorkBook
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            //Khởi tạo WorkSheet
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            app.Visible = true;
            //Đổ dữ liệu vào Sheet

            for (int i = 0; i < vanban.Length; i++)
            {
                worksheet.Cells[x[i], y[i]] = vanban[i];
            }

            int dongbatdau = 7;
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                worksheet.Cells[dongbatdau, i + 1] = dgv.Columns[i].HeaderText;
            }


            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    worksheet.Cells[i + 1 + dongbatdau, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
                }
            }
            worksheet.Range["A" + dongbatdau, "G" + dongbatdau].Font.Bold = true; //đậm tiêu đề cột
            worksheet.Range["A1", "J100"].Font.Name = "Times New Roman";
            worksheet.Range["A1", "G2"].Font.Bold = true;
            worksheet.Range["A2", "G2"].Font.Italic = true;
            worksheet.Range["A2", "A2"].Font.Bold = false;
            worksheet.Range["C4"].Font.Bold = true;
            worksheet.Range["C4"].Font.Size = 18;
            //kẻ viền
            worksheet.Range["A" + (dongbatdau), Convert.ToChar(dgv.Columns.Count + 65 - 1).ToString() + (dongbatdau + dgv.Rows.Count)].Borders.LineStyle = 1;


            int ii = 20;
            worksheet.Range["A1"].ColumnWidth = ii;
            worksheet.Range["B1"].ColumnWidth = ii;
            worksheet.Range["C1"].ColumnWidth = ii;
            worksheet.Range["D1"].ColumnWidth = ii;
            worksheet.Range["E1"].ColumnWidth = ii;
            worksheet.Range["F1"].ColumnWidth = ii;
            worksheet.Range["G1"].ColumnWidth = ii;

            //tính ttoongr
            worksheet.Cells[dongbatdau + dgv.Rows.Count + 1, dgv.Columns.Count] =
                string.Format("=SUM({0}:{1})",
                Convert.ToChar(dgv.Columns.Count + 64).ToString() + (dongbatdau + 1),
                Convert.ToChar(dgv.Columns.Count + 64).ToString() + (dongbatdau + dgv.Rows.Count)
                );
            worksheet.Cells[dongbatdau + dgv.Rows.Count + 1, dgv.Columns.Count - 1] = "Tổng";
        }

        //public static void ExportXLSXDoanhThu(DataGridView dgv1,DataGridView dgv2, int[] x, int[] y, string[] vanban)
        //{
        //    Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
        //    //Khởi tạo WorkBook
        //    Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
        //    //Khởi tạo WorkSheet
        //    Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
        //    worksheet = workbook.Sheets["Sheet1"];
        //    worksheet = workbook.ActiveSheet;
        //    app.Visible = true;
        //    //Đổ dữ liệu vào Sheet

        //    for (int i = 0; i < vanban.Length; i++)
        //    {
        //        worksheet.Cells[x[i], y[i]] = vanban[i];
        //    }

        //    int dongbatdau = 7;
        //    worksheet.Cells[dongbatdau,0] = vanban[i];
        //    dongbatdau++;
        //    for (int i = 0; i < dgv1.Columns.Count; i++)
        //    {
        //        worksheet.Cells[dongbatdau, i + 1] = dgv1.Columns[i].HeaderText;
        //    }


        //    for (int i = 0; i < dgv1.Rows.Count; i++)
        //    {
        //        for (int j = 0; j < dgv.Columns.Count; j++)
        //        {
        //            worksheet.Cells[i + 1 + dongbatdau, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
        //        }
        //    }
        //    worksheet.Range["A" + dongbatdau, "G" + dongbatdau].Font.Bold = true; //đậm tiêu đề cột
        //    worksheet.Range["A1", "J100"].Font.Name = "Times New Roman";
        //    worksheet.Range["A1", "G2"].Font.Bold = true;
        //    worksheet.Range["A2", "G2"].Font.Italic = true;
        //    worksheet.Range["A2", "A2"].Font.Bold = false;
        //    worksheet.Range["C4"].Font.Bold = true;
        //    worksheet.Range["C4"].Font.Size = 18;
        //    //kẻ viền
        //    worksheet.Range["A" + (dongbatdau), Convert.ToChar(dgv.Columns.Count + 65 - 1).ToString() + (dongbatdau + dgv.Rows.Count)].Borders.LineStyle = 1;


        //    int ii = 20;
        //    worksheet.Range["A1"].ColumnWidth = ii;
        //    worksheet.Range["B1"].ColumnWidth = ii;
        //    worksheet.Range["C1"].ColumnWidth = ii;
        //    worksheet.Range["D1"].ColumnWidth = ii;
        //    worksheet.Range["E1"].ColumnWidth = ii;
        //    worksheet.Range["F1"].ColumnWidth = ii;
        //    worksheet.Range["G1"].ColumnWidth = ii;

        //    //tính ttoongr
        //    worksheet.Cells[dongbatdau + dgv.Rows.Count + 1, dgv.Columns.Count] =
        //        string.Format("=SUM({0}:{1})",
        //        Convert.ToChar(dgv.Columns.Count + 64).ToString() + (dongbatdau + 1),
        //        Convert.ToChar(dgv.Columns.Count + 64).ToString() + (dongbatdau + dgv.Rows.Count)
        //        );
        //    worksheet.Cells[dongbatdau + dgv.Rows.Count + 1, dgv.Columns.Count - 1] = "Tổng";
        //}
    }
}
