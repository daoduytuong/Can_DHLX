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
    public partial class frmBBKiemDinh : Form
    {
        string MaKD;
        public frmBBKiemDinh()
        {
            InitializeComponent();
        }

        public frmBBKiemDinh(string maKD) //phương thức khởi tạo nhận giá trị
        {
            InitializeComponent();
            this.MaKD = maKD;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = DataProvider.MoKetNoi();
            DataTable dt = new DataTable();
            string sql = "select * from canloxo where SoBienBan = '" + MaKD + "'";
            dt = DataProvider.TruyVanLayDuLieu(sql);

            BIENBANKIEMDINH bb = new BIENBANKIEMDINH();

            foreach (DataRow dr in dt.Rows)
            {
                //đổ dữ liệu từ datarow đọc từ datatable vào các parameter đc tạo ở report 
                bb.SetParameterValue("SoBB", dr.ItemArray[0].ToString());
                bb.SetParameterValue("SoCan", dr.ItemArray[1].ToString());
                bb.SetParameterValue("TenPT", dr.ItemArray[2].ToString());
                bb.SetParameterValue("Kieu", dr.ItemArray[3].ToString());
                bb.SetParameterValue("CapCX", dr.ItemArray[4].ToString());
                bb.SetParameterValue("NuocSX", dr.ItemArray[5].ToString());
                bb.SetParameterValue("NamSX", dr.ItemArray[6].ToString());

                bb.SetParameterValue("CheDoKD", dr.ItemArray[7].ToString());
                bb.SetParameterValue("NgayKD", dr.ItemArray[8].ToString());
                bb.SetParameterValue("Max", dr.ItemArray[9].ToString());
                bb.SetParameterValue("Min", dr.ItemArray[10].ToString());
                bb.SetParameterValue("DoChia", dr.ItemArray[11].ToString());
                bb.SetParameterValue("DoChiaKiem", dr.ItemArray[12].ToString());
                bb.SetParameterValue("PPTH", dr.ItemArray[13].ToString());
                bb.SetParameterValue("DonViSD", dr.ItemArray[14].ToString());             
               
                bb.SetParameterValue("KiemDinhVien", dr.ItemArray[15].ToString());
                bb.SetParameterValue("SoTem", dr.ItemArray[16].ToString());

                //kiểm tra dữ liệu đạt hay k để đánh dấu "X" vào bảng, ô
                if (dr.ItemArray[17].ToString().Equals("Đạt"))
                {
                     bb.SetParameterValue("NhanMacD", "X");
                    bb.SetParameterValue("NhanMacK", "");
                }
                else
                {
                    bb.SetParameterValue("NhanMacD", "");
                    bb.SetParameterValue("NhanMacK", "X");
                }

                if (dr.ItemArray[18].ToString().Equals("Đạt"))
                {
                    bb.SetParameterValue("TemD", "X");
                    bb.SetParameterValue("TemK", "");
                }
                else
                {
                    bb.SetParameterValue("TemD", "");
                    bb.SetParameterValue("TemK", "X");
                }
                if (dr.ItemArray[19].ToString().Equals("Đạt"))
                {
                    bb.SetParameterValue("DayDuD", "X");
                    bb.SetParameterValue("DayDuK", "");
                }
                else
                {
                    bb.SetParameterValue("DayDuD", "");
                    bb.SetParameterValue("DayDuK", "X");
                }
                
                if (dr.ItemArray[20].ToString().Equals("Đạt"))
                {
                    bb.SetParameterValue("DongHoD", "X");
                    bb.SetParameterValue("DongHoK", "");
                }
                else
                {
                    bb.SetParameterValue("DongHoD", "");
                    bb.SetParameterValue("DongHoK", "X");
                }
                if (dr.ItemArray[21].ToString().Equals("Đạt"))
                {
                    bb.SetParameterValue("BoPhanD", "X");
                    bb.SetParameterValue("BoPhanK", "");
                }
                else
                {
                    bb.SetParameterValue("BoPhanD", "");
                    bb.SetParameterValue("BoPhanK", "X");
                }

                if (dr.ItemArray[22].ToString().Equals("Đạt"))
                {
                    bb.SetParameterValue("KTNgoaiD", "X");
                    bb.SetParameterValue("KTNgoaiK", "");
                }
                else
                {
                    bb.SetParameterValue("KTNgoaiD", "");
                    bb.SetParameterValue("KTNgoaiK", "X");
                }


                bb.SetParameterValue("DDCT1min", dr.ItemArray[23].ToString());
                bb.SetParameterValue("DDCT105max", dr.ItemArray[24].ToString());
                bb.SetParameterValue("DDCT1max", dr.ItemArray[25].ToString());
                bb.SetParameterValue("DDGTmin", dr.ItemArray[26].ToString());
                bb.SetParameterValue("DDGT05max", dr.ItemArray[27].ToString());
                bb.SetParameterValue("DDGTmax", dr.ItemArray[28].ToString());
                bb.SetParameterValue("DDCT2min", dr.ItemArray[29].ToString());
                bb.SetParameterValue("DDCT205max", dr.ItemArray[30].ToString());
                bb.SetParameterValue("DDCT2max", dr.ItemArray[31].ToString());
                bb.SetParameterValue("DDmin", dr.ItemArray[32].ToString());
                bb.SetParameterValue("DD05max", dr.ItemArray[33].ToString());
                bb.SetParameterValue("DDmax", dr.ItemArray[34].ToString());
                
                if (dr.ItemArray[35].ToString().Equals("Đạt"))
                {
                    bb.SetParameterValue("KiemtraDoDongD", "X");
                    bb.SetParameterValue("KiemtraDoDongK", "");
                }
                else
                {
                    bb.SetParameterValue("KiemtraDoDongD", "");
                    bb.SetParameterValue("KiemtraDoDongK", "X");
                }
                bb.SetParameterValue("LLCT1min", dr.ItemArray[36].ToString());
                bb.SetParameterValue("LLCT105max", dr.ItemArray[37].ToString());
                bb.SetParameterValue("LLCT1max", dr.ItemArray[38].ToString());
                bb.SetParameterValue("LLCT2min", dr.ItemArray[39].ToString());
                bb.SetParameterValue("LLCT205max", dr.ItemArray[40].ToString());
                bb.SetParameterValue("LLCT2max", dr.ItemArray[41].ToString());
                bb.SetParameterValue("LLCT3min", dr.ItemArray[42].ToString());
                bb.SetParameterValue("LLCT305max", dr.ItemArray[43].ToString());
                bb.SetParameterValue("LLCT3max", dr.ItemArray[44].ToString());
                bb.SetParameterValue("LLCLLonmin", dr.ItemArray[45].ToString());
                bb.SetParameterValue("LLCLLon05max", dr.ItemArray[46].ToString());
                bb.SetParameterValue("LLCLLonmax", dr.ItemArray[47].ToString());
                bb.SetParameterValue("LLCLCPmin", dr.ItemArray[48].ToString());
                bb.SetParameterValue("LLCLCP05max", dr.ItemArray[49].ToString());
                bb.SetParameterValue("LLCLCPmax", dr.ItemArray[50].ToString());

                if (dr.ItemArray[51].ToString().Equals("Đạt"))
                {
                    bb.SetParameterValue("KiemtraLapLaiD", "X");
                    bb.SetParameterValue("KiemtralapLaiK", "");
                }
                else
                {
                    bb.SetParameterValue("KiemtraLapLaiD", "");
                    bb.SetParameterValue("KiemtralapLaiK", "X");
                }


                bb.SetParameterValue("LLMucTaiL", dr.ItemArray[52].ToString());
                bb.SetParameterValue("LTChiThiG", dr.ItemArray[53].ToString());
                bb.SetParameterValue("LTChiThiI1", dr.ItemArray[54].ToString());
                bb.SetParameterValue("LTChiThiI2", dr.ItemArray[55].ToString());
                bb.SetParameterValue("LTChiThiI3", dr.ItemArray[56].ToString());
                bb.SetParameterValue("LTChiThiI4", dr.ItemArray[57].ToString());
                bb.SetParameterValue("LTCLLN", dr.ItemArray[58].ToString());
                bb.SetParameterValue("LTCLCP", dr.ItemArray[59].ToString());
                if (dr.ItemArray[60].ToString().Equals("Đạt"))
                {
                    bb.SetParameterValue("KiemtraLechTamD", "X");
                    bb.SetParameterValue("KiemtraLechTamK", "");
                }
                else
                {
                    bb.SetParameterValue("KiemtraLechTamD", "");
                    bb.SetParameterValue("KiemtraLechTamK", "X");
                }

                bb.SetParameterValue("MTL1", dr.ItemArray[61].ToString());
                bb.SetParameterValue("MTL2", dr.ItemArray[62].ToString());
                bb.SetParameterValue("MTL3", dr.ItemArray[63].ToString());
                bb.SetParameterValue("MTL4", dr.ItemArray[64].ToString());
                bb.SetParameterValue("MTL5", dr.ItemArray[65].ToString());
                bb.SetParameterValue("CTCT1", dr.ItemArray[66].ToString());
                bb.SetParameterValue("CTCT2", dr.ItemArray[67].ToString());
                bb.SetParameterValue("CTCT3", dr.ItemArray[68].ToString());
                bb.SetParameterValue("CTCT4", dr.ItemArray[69].ToString());
                bb.SetParameterValue("CTCT5", dr.ItemArray[70].ToString());
                bb.SetParameterValue("CTCG1", dr.ItemArray[71].ToString());
                bb.SetParameterValue("CTCG2", dr.ItemArray[72].ToString());
                bb.SetParameterValue("CTCG3", dr.ItemArray[73].ToString());
                bb.SetParameterValue("CTCG4", dr.ItemArray[74].ToString());

                bb.SetParameterValue("SST1", dr.ItemArray[75].ToString());
                bb.SetParameterValue("SST2", dr.ItemArray[76].ToString());
                bb.SetParameterValue("SST3", dr.ItemArray[77].ToString());
                bb.SetParameterValue("SST4", dr.ItemArray[78].ToString());
                bb.SetParameterValue("SST5", dr.ItemArray[79].ToString());
                bb.SetParameterValue("SSG1", dr.ItemArray[80].ToString());
                bb.SetParameterValue("SSG2", dr.ItemArray[81].ToString());
                bb.SetParameterValue("SSG3", dr.ItemArray[81].ToString());
                bb.SetParameterValue("SSG4", dr.ItemArray[83].ToString());

                bb.SetParameterValue("DHS1", dr.ItemArray[84].ToString());
                bb.SetParameterValue("DHS2", dr.ItemArray[86].ToString());
                bb.SetParameterValue("DHS3", dr.ItemArray[86].ToString());
                bb.SetParameterValue("DHS4", dr.ItemArray[87].ToString());

                bb.SetParameterValue("SSCP1", dr.ItemArray[88].ToString());
                bb.SetParameterValue("SSCP2", dr.ItemArray[89].ToString());
                bb.SetParameterValue("SSCP3", dr.ItemArray[90].ToString());
                bb.SetParameterValue("SSCP4", dr.ItemArray[91].ToString());
                bb.SetParameterValue("SSCP5", dr.ItemArray[92].ToString());
                if (dr.ItemArray[93].ToString().Equals("Đạt"))
                {
                    bb.SetParameterValue("KiemtraSaiSoD", "X");
                    bb.SetParameterValue("KiemtraSaiSoK", "");
                }
                else
                {
                    bb.SetParameterValue("KiemtraSaiSoD", "");
                    bb.SetParameterValue("KiemtraSaiSoK", "X");
                }
                bb.SetParameterValue("KetLuan", dr.ItemArray[94].ToString());
            }
            crystalReportViewer1.ReportSource = bb; //Source
            DataProvider.DongKetNoi();

        }

        private void frmBBKiemDinh_Load(object sender, EventArgs e)
        {

        }
    }
}
