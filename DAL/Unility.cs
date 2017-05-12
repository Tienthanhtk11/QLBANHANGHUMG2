using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Unility
    {

        public static string conStr = "Data Source='DESKTOP-IEOTL5P\\SQLEXPRESS';Initial Catalog=QuanLyBanHangHUMG;Integrated Security=True";
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
        private static SqlConnection cnn = new SqlConnection(conStr);
        public Unility()
        {
            openCon();
        }
        public static void DisConnection()
        {
            cnn.Close();
        }
        public static void openCon()
        {
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
        }
        public static DataTable GetDataTable(string sql)
        {

            openCon();
            cmd = new SqlCommand(sql, cnn);
            da = new SqlDataAdapter(cmd);
            DataTable db = new DataTable();
            try
            {
                da.Fill(db);

            }
            catch { }
            return db;
        }
        public static void ExcuteSQL(string sql)
        {
            openCon();
            cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
        }
        public static int AExcuteSQL(string sql)
        {
            openCon();
            cmd = new SqlCommand(sql, cnn);
            return (int)cmd.ExecuteScalar();
        }
    }
}
