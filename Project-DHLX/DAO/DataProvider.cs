using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class DataProvider
    {
        public static SqlConnection cn;
        public static string s = @"Data Source=DESKTOP-RLHU1VD\SQLEXPRESS;Initial Catalog=DHLX1;Integrated Security=True";

        public static SqlConnection Kn()
        {
            cn = new SqlConnection(s);
            return cn;
        }
        public static SqlConnection MoKetNoi()
        {
            //string s = @"Data Source=.\SQLEXPRESS;Initial Catalog=DHLX1;Integrated Security=True";
            cn = new SqlConnection(s);
            cn.Open();
            return cn;
        }
        public static SqlConnection DongKetNoi()
        {
            cn = new SqlConnection(s);
            cn.Close();
            return cn;
        }
        // Thực hiện truy vấn trả về bảng dữ liệu
        public static DataTable TruyVanLayDuLieu(string sTruyVan)
        {
            cn = new SqlConnection(s);
            SqlDataAdapter da = new SqlDataAdapter(sTruyVan, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // Thực hiện truy vấn không trả về dữ liệu
        public static bool TruyVanKhongLayDuLieu(string sTruyVan)
        {
            cn = new SqlConnection(s);
            cn.Open();
            try
            {
                SqlCommand cm = new SqlCommand(sTruyVan, cn);
                cm.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
