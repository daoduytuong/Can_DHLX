using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class Can_BUS
    {
        public static void setTem(string makd, string tem)
        {
            Can_DAO.setTem(makd, tem);
        }

        public static void setGCN(string sogcn, string mabb)
        {
            Can_DAO.setGCN(sogcn, mabb);
        }
        public static void them(Can_DTO clx)
        {
            Can_DAO.them(clx);
        }
        public static void Sua(Can_DTO clx)
        {
            Can_DAO.Sua(clx);
        }
        public static string CreateSoBB()
        {
            return Can_DAO.CreateSoBB();
        }
        /*public static string CreateTem()
        {
            return Can_DAO.CreateTem();
        }*/
        public static string SoCan()
        {
            return Can_DAO.SoCan();
        }

        public static DataTable TimBB(string soBB)
        {
            return Can_DAO.TimBB(soBB);
        }
        public static int KTSoBB(string SoBB)
        {
            return Can_DAO.KTSoBB(SoBB);
        }
    }
}
