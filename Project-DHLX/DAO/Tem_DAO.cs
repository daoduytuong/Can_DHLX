using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class Tem_DAO
    {
        static SqlConnection conn;
        public static List<Tem_DTO> LayTem()
        {
            string query = "select * from Tem where TrangThai = '0'";
            conn = DataProvider.cn;
            DataTable table = DataProvider.TruyVanLayDuLieu(query);
            if (table.Rows.Count == 0)
            {
                return null;
            }
            List<Tem_DTO> lstTem = new List<Tem_DTO>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                Tem_DTO tem = new Tem_DTO();
                tem.STem = table.Rows[i]["Tem"].ToString();
                lstTem.Add(tem);
            }
            return lstTem;
        }
    }
}
