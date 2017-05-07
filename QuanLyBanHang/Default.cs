using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang
{
    class Default
    {
        public static void SetDefaultDataGridView(System.Windows.Forms.DataGridView dgv)
        {
            dgv.BackgroundColor = System.Drawing.Color.Gray;
            dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgv.EnableHeadersVisualStyles = false;
            dgv.GridColor = System.Drawing.Color.Gray;
            //dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgv.ShowCellErrors = false;
            dgv.ShowCellToolTips = false;
            dgv.ShowEditingIcon = false;
            dgv.ShowRowErrors = false;
            dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToResizeRows = false;
        }
    }
}
