using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using DAO;
using DTO;

namespace DHLX
{
    public partial class frmChungNhan : Form
    {
        string MaKD;
        public frmChungNhan(string mkd) //phương thức khởi tạo nhận giá trị
        {
            InitializeComponent();
            this.MaKD = mkd;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = DataProvider.MoKetNoi();
            DataTable dt = new DataTable();
            string sql = "select * from canloxo where SoBienBan = '" + MaKD + "'";
            dt = DataProvider.TruyVanLayDuLieu(sql);
            /*string a = Convert.ToString(dt.Rows[0]["NgayKD"]);
            DateTime dateTime = DateTime.Parse(a);*/
            DateTime date = DateTime.Now;
            DateTime newtime = date.AddYears(1);
            ChungNhan cn = new ChungNhan();

            cn.SetParameterValue("NgayHH", newtime.ToString("dd/MM/yyy"));
            foreach (DataRow dr in dt.Rows)
            {
                //đổ dữ liệu từ datarow đọc từ datatable vào các parameter đc tạo ở report 
                cn.SetParameterValue("SoGCN", dr.ItemArray[96].ToString());
                cn.SetParameterValue("SoCan", dr.ItemArray[1].ToString());
                cn.SetParameterValue("TenPT", dr.ItemArray[2].ToString());
                cn.SetParameterValue("Kieu", dr.ItemArray[3].ToString());
                cn.SetParameterValue("CapCX", dr.ItemArray[4].ToString());
                cn.SetParameterValue("NoiSX", dr.ItemArray[5].ToString());
                cn.SetParameterValue("NamSX", dr.ItemArray[6].ToString());
                cn.SetParameterValue("Max", dr.ItemArray[9].ToString());
                cn.SetParameterValue("Min", dr.ItemArray[10].ToString());
                cn.SetParameterValue("DoChia", dr.ItemArray[11].ToString());
                cn.SetParameterValue("DoChiaKiem", dr.ItemArray[12].ToString());
                cn.SetParameterValue("PPTH", dr.ItemArray[13].ToString());
                cn.SetParameterValue("DonViSD", dr.ItemArray[14].ToString());
                cn.SetParameterValue("KiemDinhVien", dr.ItemArray[15].ToString());
                cn.SetParameterValue("NoiSD", dr.ItemArray[95].ToString());
                cn.SetParameterValue("KetLuan", dr.ItemArray[94].ToString());
                cn.SetParameterValue("SoTem", dr.ItemArray[16].ToString());
                cn.SetParameterValue("PPTH", dr.ItemArray[13].ToString());
                crystalReportViewer1.ReportSource = cn;
                DataProvider.DongKetNoi();
            }
        }
    }
}
