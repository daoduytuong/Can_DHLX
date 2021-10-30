using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class KDV_DAO
    {
        static SqlConnection conn;
        public static List<KDV_DTO> LayKDV()
        {
            string query = "select * from KiemDinhVien";
            conn = DataProvider.cn;
            DataTable table = DataProvider.TruyVanLayDuLieu(query);
            if (table.Rows.Count == 0)
            {
                return null;
            }
            List<KDV_DTO> lstKDV = new List<KDV_DTO>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                KDV_DTO kdv = new KDV_DTO();
                kdv.SKiemDinhVien = table.Rows[i]["KiemDinhVien"].ToString();
                lstKDV.Add(kdv);
            }
            DataProvider.DongKetNoi();
            return lstKDV;
        }
    }
}
