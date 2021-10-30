using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using DTO;

namespace DAO
{
    public class Can_DAO
    {
        public static SqlConnection cn;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
        public static string s = @"Data Source=DESKTOP-RLHU1VD\SQLEXPRESS;Initial Catalog=DHLX1;Integrated Security=True";

        /*Tao Ma So Bien Ban*/
        public static string CreateSoBB()
        {
            string SoBB = "";
            string sql = "select count(*) from canloxo";
            DataProvider.MoKetNoi();
            SqlCommand cmd = new SqlCommand(sql,DataProvider.cn);
            int sl = (int)cmd.ExecuteScalar();
            SoBB = "21" + (sl + 1) + "/LX";
            return SoBB;
        }
        public static string CreateSoGCN()
        {
            string SoBB = "";
            string sql = "select count(GCN) from canloxo where GCN != ''";
            DataProvider.MoKetNoi();
            SqlCommand cmd = new SqlCommand(sql, DataProvider.cn);
            int sl = (int)cmd.ExecuteScalar();
            SoBB = "21" + (sl + 1) + "/GCNCLX";
            return SoBB;
        }
        /*Tao Tem*/
        public static string CreateTem()
        {
            string tem = "";
            string sql = "select count(*) from canloxo";
            DataProvider.MoKetNoi();
            cmd = new SqlCommand(sql, DataProvider.cn);
            int sl = (int)cmd.ExecuteScalar();
            tem = "17A-" + (sl + 1);
            return tem;
        }

        public static string SoCan()
        {
            string socan = "";
            string sql = "select count(*) from canloxo";
            DataProvider.MoKetNoi();
            cmd = new SqlCommand(sql, DataProvider.cn);
            int sl = (int)cmd.ExecuteScalar();
            socan = (sl + 1)+"";
            return socan;
        }
        /*Them du lieu*/
        public static void them(Can_DTO clx)
        {
            string sql = @"insert into canloxo values(
@sobienban,@socan,@tencan,@kieu,@capchinhxac,
@nuocsx,@namsx,@chedokd,@ngaykd,@max,
@min,@dochia,@dochiakiem,@ppth,@donvisd,
@kiemdinhvien,@sotem,@nhanmac,@tem,@daydu,
@donghothangdo,@bophan,@kiemtrangoai,@ddct1min,@ddct105max,
@ddct1max,@ddgtmin,@ddgt05max,@ddgtmax,@ddct2min,
@ddct205max,@ddct2max,@ddmin,@dd05max,@ddmax,
@kiemtradodong,@llct1min,@llct105max,@llct1max,@llct2min,
@llct205max,@llct2max,@llct3min,@llct305max,@llct3max,
@llcllonmin,@llcllon05max,@llcllonmax,@llclcpmin,@llclcp05max,
@llclcpmax,@kiemtralaplai,@ltmuctai,@ltchithig,@ltchithii1,
@ltchithii2,@ltchithii3,@ltchithii4,@ltclln,@ltclcp,
@kiemtralechtam,@mtl1,@mtl2,@mtl3,@mtl4
,@mtl5,@ctct1,@ctct2,@ctct3,@ctct4,
@ctct5,@ctcg1,@ctcg2,@ctcg3,@ctcg4,
@sst1,@sst2,@sst3,@sst4,@sst5,
@ssg1,@ssg2,@ssg3,@ssg4,@dhs1,
@dhs2,@dhs3,@dhs4,@sscp1,@sscp2,
@sscp3,@sscp4,@sscp5,@kiemtrasaiso, @ketluan, @diachi, @gcn)";
            DataProvider.MoKetNoi();
            cmd = new SqlCommand(sql, DataProvider.cn);
            cmd.Parameters.AddWithValue("sobienban", clx.SSoBienBan);
            cmd.Parameters.AddWithValue("socan", clx.SSoCan);
            cmd.Parameters.AddWithValue("tencan", clx.STenCan);
            cmd.Parameters.AddWithValue("kieu", clx.SKieu);
            cmd.Parameters.AddWithValue("capchinhxac", clx.SCapChinhXac);
            cmd.Parameters.AddWithValue("nuocsx", clx.SNuocSX);
            cmd.Parameters.AddWithValue("namsx", clx.SNamSX);
            cmd.Parameters.AddWithValue("chedokd", clx.SCheDoKD);
            cmd.Parameters.AddWithValue("ngaykd", clx.SNgayKD);
            cmd.Parameters.AddWithValue("max", clx.SMax);
            cmd.Parameters.AddWithValue("min", clx.SMin);
            cmd.Parameters.AddWithValue("dochia", clx.SDoChia);
            cmd.Parameters.AddWithValue("dochiakiem", clx.SDoChiaKiem);
            cmd.Parameters.AddWithValue("ppth", clx.SPPTH);
            cmd.Parameters.AddWithValue("donvisd", clx.SDonViSD);
            cmd.Parameters.AddWithValue("kiemdinhvien", clx.SKiemDinhVien);
            cmd.Parameters.AddWithValue("sotem", clx.SSoTem);
            //cmd.Parameters.AddWithValue("nguoisoatlai", clx.SNguoiSoatLai);
            cmd.Parameters.AddWithValue("nhanmac", clx.SNhanMac);
            cmd.Parameters.AddWithValue("tem", clx.STem);
            cmd.Parameters.AddWithValue("daydu", clx.SDayDu);
            cmd.Parameters.AddWithValue("donghothangdo", clx.SDongHoThangDo);
            cmd.Parameters.AddWithValue("bophan", clx.SBoPhan);
            cmd.Parameters.AddWithValue("kiemtrangoai", clx.SKiemTraNgoai);
            //cmd.Parameters.AddWithValue("ddmtmin", clx.SDDMTmin);
            //cmd.Parameters.AddWithValue("ddmt05max", clx.SDDMT05max);
            //cmd.Parameters.AddWithValue("ddmtmax", clx.SDDMTmax);
            cmd.Parameters.AddWithValue("ddct1min", clx.SDDCT1min);
            cmd.Parameters.AddWithValue("ddct105max", clx.SDDCT105max);
            cmd.Parameters.AddWithValue("ddct1max", clx.SDDCT1max);
            cmd.Parameters.AddWithValue("ddgtmin", clx.SDDGTmin);
            cmd.Parameters.AddWithValue("ddgt05max", clx.SDDGT05max);
            cmd.Parameters.AddWithValue("ddgtmax", clx.SDDGTmax);
            cmd.Parameters.AddWithValue("ddct2min", clx.SDDCT2min);
            cmd.Parameters.AddWithValue("ddct205max", clx.SDDCT205max);
            cmd.Parameters.AddWithValue("ddct2max", clx.SDDCT2max);
            cmd.Parameters.AddWithValue("ddmin", clx.SDDmin);
            cmd.Parameters.AddWithValue("dd05max", clx.SDD05max);
            cmd.Parameters.AddWithValue("ddmax", clx.SDDmax);
            cmd.Parameters.AddWithValue("kiemtradodong", clx.SKiemTraDoDong);
            //cmd.Parameters.AddWithValue("llmtmin", clx.SLLMTmin);
            //cmd.Parameters.AddWithValue("llmt05max", clx.SLLMT05max);
            //cmd.Parameters.AddWithValue("llmtmax", clx.SLLMTmax);
            cmd.Parameters.AddWithValue("llct1min", clx.SLLCT1min);
            cmd.Parameters.AddWithValue("llct105max", clx.SLLCT105max);
            cmd.Parameters.AddWithValue("llct1max", clx.SLLCT1max);
            cmd.Parameters.AddWithValue("llct2min", clx.SLLCT2min);
            cmd.Parameters.AddWithValue("llct205max", clx.SLLCT205max);
            cmd.Parameters.AddWithValue("llct2max", clx.SLLCT2max);
            cmd.Parameters.AddWithValue("llct3min", clx.SLLCT3min);
            cmd.Parameters.AddWithValue("llct305max", clx.SLLCT305max);
            cmd.Parameters.AddWithValue("llct3max", clx.SLLCT3max);
            cmd.Parameters.AddWithValue("llcllonmin", clx.SLLCLLonmin);
            cmd.Parameters.AddWithValue("llcllon05max", clx.SLLCLLon05max);
            cmd.Parameters.AddWithValue("llcllonmax", clx.SLLCLLmax);
            cmd.Parameters.AddWithValue("llclcpmin", clx.SLLCLCPmin);
            cmd.Parameters.AddWithValue("llclcp05max", clx.SLLCLCP05max);
            cmd.Parameters.AddWithValue("llclcpmax", clx.SLLCLCPmax);
            cmd.Parameters.AddWithValue("kiemtralaplai", clx.SKiemtraLapLai);
            cmd.Parameters.AddWithValue("ltmuctai", clx.SLTMucTai);
            cmd.Parameters.AddWithValue("ltchithig", clx.SLTChiThiG);
            cmd.Parameters.AddWithValue("ltchithii1", clx.SLTChiThiI1);
            cmd.Parameters.AddWithValue("ltchithii2", clx.SLTChiThiI2);
            cmd.Parameters.AddWithValue("ltchithii3", clx.SLTChiThiI3);
            cmd.Parameters.AddWithValue("ltchithii4", clx.SLTChiThiI4);
            cmd.Parameters.AddWithValue("ltclln", clx.SLTCLLN);
            cmd.Parameters.AddWithValue("ltclcp", clx.SLTCLCP);
            cmd.Parameters.AddWithValue("kiemtralechtam", clx.SKiemtraLechTam);
            cmd.Parameters.AddWithValue("mtl1", clx.SMTL1);
            cmd.Parameters.AddWithValue("mtl2", clx.SMTL2);
            cmd.Parameters.AddWithValue("mtl3", clx.SMTL3);
            cmd.Parameters.AddWithValue("mtl4", clx.SMTL4);
            cmd.Parameters.AddWithValue("mtl5", clx.SMTL5);
            cmd.Parameters.AddWithValue("ctct1", clx.SCTCT1);
            cmd.Parameters.AddWithValue("ctct2", clx.SCTCT2);
            cmd.Parameters.AddWithValue("ctct3", clx.SCTCT3);
            cmd.Parameters.AddWithValue("ctct4", clx.SCTCT4);
            cmd.Parameters.AddWithValue("ctct5", clx.SCTCT5);
            cmd.Parameters.AddWithValue("ctcg1", clx.SCTCG1);
            cmd.Parameters.AddWithValue("ctcg2", clx.SCTCG2);
            cmd.Parameters.AddWithValue("ctcg3", clx.SCTCG3);
            cmd.Parameters.AddWithValue("ctcg4", clx.SCTCG4);
            cmd.Parameters.AddWithValue("sst1", clx.SSST1);
            cmd.Parameters.AddWithValue("sst2", clx.SSST2);
            cmd.Parameters.AddWithValue("sst3", clx.SSST3);
            cmd.Parameters.AddWithValue("sst4", clx.SSST4);
            cmd.Parameters.AddWithValue("sst5", clx.SSST5);
            cmd.Parameters.AddWithValue("ssg1", clx.SSSG1);
            cmd.Parameters.AddWithValue("ssg2", clx.SSSG2);
            cmd.Parameters.AddWithValue("ssg3", clx.SSSG3);
            cmd.Parameters.AddWithValue("ssg4", clx.SSSG4);
            cmd.Parameters.AddWithValue("dhs1", clx.SDHS1);
            cmd.Parameters.AddWithValue("dhs2", clx.SDHS2);
            cmd.Parameters.AddWithValue("dhs3", clx.SDHS3);
            cmd.Parameters.AddWithValue("dhs4", clx.SDHS4);
            cmd.Parameters.AddWithValue("sscp1", clx.SSSCP1);
            cmd.Parameters.AddWithValue("sscp2", clx.SSSCP2);
            cmd.Parameters.AddWithValue("sscp3", clx.SSSCP3);
            cmd.Parameters.AddWithValue("sscp4", clx.SSSCP4);
            cmd.Parameters.AddWithValue("sscp5", clx.SSSCP5);
            cmd.Parameters.AddWithValue("kiemtrasaiso", clx.SKiemtraSaiSo);
            cmd.Parameters.AddWithValue("ketluan", clx.SKetLuan);
            cmd.Parameters.AddWithValue("diachi", clx.SDiaChiSD);
            cmd.Parameters.AddWithValue("gcn", clx.Sgcn);
            cmd.ExecuteNonQuery();
            DataProvider.DongKetNoi();
        }
        public static void Sua(Can_DTO clx)
        {
            string sql = @"update canloxo set
sobienban=@sobienban,socan=@socan,tencan=@tencan,kieu=@kieu,capchinhxac=@capchinhxac,
nuocsx=@nuocsx,namsx=@namsx,chedokd=@chedokd,ngaykd=@ngaykd,max=@max,
min=@min,dochia=@dochia,dochiakiem=@dochiakiem,ppth=@ppth,donvisd=@donvisd,
kiemdinhvien=@kiemdinhvien,nhanmac=@nhanmac,tem=@tem,daydu=@daydu,
donghothangdo=@donghothangdo,bophan=@bophan,kiemtrangoai=@kiemtrangoai,ddct1min=@ddct1min,ddct105max=@ddct105max,
ddct1max=@ddct1max,ddgtmin=@ddgtmin,ddgt05max=@ddgt05max,ddgtmax=@ddgtmax,ddct2min=@ddct2min,
ddct205max=@ddct205max,ddct2max=@ddct2max,ddmin=@ddmin,dd05max=@dd05max,ddmax=@ddmax,
kiemtradodong=@kiemtradodong,llct1min=@llct1min,llct105max=@llct105max,llct1max=@llct1max,llct2min=@llct2min,
llct205max=@llct205max,llct2max=@llct2max,llct3min=@llct3min,llct305max=@llct305max,llct3max=@llct3max,
llcllonmin=@llcllonmin,llcllon05max=@llcllon05max,llcllonmax=@llcllonmax,llclcpmin=@llclcpmin,llclcp05max=@llclcp05max,
llclcpmax=@llclcpmax,kiemtralaplai=@kiemtralaplai,ltmuctai=@ltmuctai,ltchithig=@ltchithig,ltchithii1=@ltchithii1,
ltchithii2=@ltchithii2,ltchithii3=@ltchithii3,ltchithii4=@ltchithii4,ltclln=@ltclln,ltclcp=@ltclcp,
kiemtralechtam=@kiemtralechtam,mtl1=@mtl1,mtl2=@mtl2,mtl3=@mtl3,mtl4=@mtl4
,mtl5=@mtl5,ctct1=@ctct1,ctct2=@ctct2,ctct3=@ctct3,ctct4=@ctct4,
ctct5=@ctct5,ctcg1=@ctcg1,ctcg2=@ctcg2,ctcg3=@ctcg3,ctcg4=@ctcg4,
sst1=@sst1,sst2=@sst2,sst3=@sst3,sst4=@sst4,sst5=@sst5,
ssg1=@ssg1,ssg2=@ssg2,ssg3=@ssg3,ssg4=@ssg4,dhs1=@dhs1,
dhs2=@dhs2,dhs3=@dhs3,dhs4=@dhs4,sscp1=@sscp1,sscp2=@sscp2,
sscp3=@sscp3,sscp4=@sscp4,sscp5=@sscp5,kiemtrasaiso=@kiemtrasaiso,ketluan=@ketluan,diachisd =@diachisd where sobienban = @sobienban";
            DataProvider.MoKetNoi();
            cmd = new SqlCommand(sql, DataProvider.cn);
            cmd.Parameters.AddWithValue("sobienban", clx.SSoBienBan);
            cmd.Parameters.AddWithValue("socan", clx.SSoCan);
            cmd.Parameters.AddWithValue("tencan", clx.STenCan);
            cmd.Parameters.AddWithValue("kieu", clx.SKieu);
            cmd.Parameters.AddWithValue("capchinhxac", clx.SCapChinhXac);
            cmd.Parameters.AddWithValue("nuocsx", clx.SNuocSX);
            cmd.Parameters.AddWithValue("namsx", clx.SNamSX);
            cmd.Parameters.AddWithValue("chedokd", clx.SCheDoKD);
            cmd.Parameters.AddWithValue("ngaykd", clx.SNgayKD);
            cmd.Parameters.AddWithValue("max", clx.SMax);
            cmd.Parameters.AddWithValue("min", clx.SMin);
            cmd.Parameters.AddWithValue("dochia", clx.SDoChia);
            cmd.Parameters.AddWithValue("dochiakiem", clx.SDoChiaKiem);
            cmd.Parameters.AddWithValue("ppth", clx.SPPTH);
            cmd.Parameters.AddWithValue("donvisd", clx.SDonViSD);
            cmd.Parameters.AddWithValue("kiemdinhvien", clx.SKiemDinhVien);
            //cmd.Parameters.AddWithValue("sotem", clx.SSoTem);
            cmd.Parameters.AddWithValue("nhanmac", clx.SNhanMac);
            cmd.Parameters.AddWithValue("tem", clx.STem);
            cmd.Parameters.AddWithValue("daydu", clx.SDayDu);
            cmd.Parameters.AddWithValue("donghothangdo", clx.SDongHoThangDo);
            cmd.Parameters.AddWithValue("bophan", clx.SBoPhan);
            cmd.Parameters.AddWithValue("kiemtrangoai", clx.SKiemTraNgoai);
            cmd.Parameters.AddWithValue("ddct1min", clx.SDDCT1min);
            cmd.Parameters.AddWithValue("ddct105max", clx.SDDCT105max);
            cmd.Parameters.AddWithValue("ddct1max", clx.SDDCT1max);
            cmd.Parameters.AddWithValue("ddgtmin", clx.SDDGTmin);
            cmd.Parameters.AddWithValue("ddgt05max", clx.SDDGT05max);
            cmd.Parameters.AddWithValue("ddgtmax", clx.SDDGTmax);
            cmd.Parameters.AddWithValue("ddct2min", clx.SDDCT2min);
            cmd.Parameters.AddWithValue("ddct205max", clx.SDDCT205max);
            cmd.Parameters.AddWithValue("ddct2max", clx.SDDCT2max);
            cmd.Parameters.AddWithValue("ddmin", clx.SDDmin);
            cmd.Parameters.AddWithValue("dd05max", clx.SDD05max);
            cmd.Parameters.AddWithValue("ddmax", clx.SDDmax);
            cmd.Parameters.AddWithValue("kiemtradodong", clx.SKiemTraDoDong);
            cmd.Parameters.AddWithValue("llct1min", clx.SLLCT1min);
            cmd.Parameters.AddWithValue("llct105max", clx.SLLCT105max);
            cmd.Parameters.AddWithValue("llct1max", clx.SLLCT1max);
            cmd.Parameters.AddWithValue("llct2min", clx.SLLCT2min);
            cmd.Parameters.AddWithValue("llct205max", clx.SLLCT205max);
            cmd.Parameters.AddWithValue("llct2max", clx.SLLCT2max);
            cmd.Parameters.AddWithValue("llct3min", clx.SLLCT3min);
            cmd.Parameters.AddWithValue("llct305max", clx.SLLCT305max);
            cmd.Parameters.AddWithValue("llct3max", clx.SLLCT3max);
            cmd.Parameters.AddWithValue("llcllonmin", clx.SLLCLLonmin);
            cmd.Parameters.AddWithValue("llcllon05max", clx.SLLCLLon05max);
            cmd.Parameters.AddWithValue("llcllonmax", clx.SLLCLLmax);
            cmd.Parameters.AddWithValue("llclcpmin", clx.SLLCLCPmin);
            cmd.Parameters.AddWithValue("llclcp05max", clx.SLLCLCP05max);
            cmd.Parameters.AddWithValue("llclcpmax", clx.SLLCLCPmax);
            cmd.Parameters.AddWithValue("kiemtralaplai", clx.SKiemtraLapLai);
            cmd.Parameters.AddWithValue("ltmuctai", clx.SLTMucTai);
            cmd.Parameters.AddWithValue("ltchithig", clx.SLTChiThiG);
            cmd.Parameters.AddWithValue("ltchithii1", clx.SLTChiThiI1);
            cmd.Parameters.AddWithValue("ltchithii2", clx.SLTChiThiI2);
            cmd.Parameters.AddWithValue("ltchithii3", clx.SLTChiThiI3);
            cmd.Parameters.AddWithValue("ltchithii4", clx.SLTChiThiI4);
            cmd.Parameters.AddWithValue("ltclln", clx.SLTCLLN);
            cmd.Parameters.AddWithValue("ltclcp", clx.SLTCLCP);
            cmd.Parameters.AddWithValue("kiemtralechtam", clx.SKiemtraLechTam);
            cmd.Parameters.AddWithValue("mtl1", clx.SMTL1);
            cmd.Parameters.AddWithValue("mtl2", clx.SMTL2);
            cmd.Parameters.AddWithValue("mtl3", clx.SMTL3);
            cmd.Parameters.AddWithValue("mtl4", clx.SMTL4);
            cmd.Parameters.AddWithValue("mtl5", clx.SMTL5);
            cmd.Parameters.AddWithValue("ctct1", clx.SCTCT1);
            cmd.Parameters.AddWithValue("ctct2", clx.SCTCT2);
            cmd.Parameters.AddWithValue("ctct3", clx.SCTCT3);
            cmd.Parameters.AddWithValue("ctct4", clx.SCTCT4);
            cmd.Parameters.AddWithValue("ctct5", clx.SCTCT5);
            cmd.Parameters.AddWithValue("ctcg1", clx.SCTCG1);
            cmd.Parameters.AddWithValue("ctcg2", clx.SCTCG2);
            cmd.Parameters.AddWithValue("ctcg3", clx.SCTCG3);
            cmd.Parameters.AddWithValue("ctcg4", clx.SCTCG4);
            cmd.Parameters.AddWithValue("sst1", clx.SSST1);
            cmd.Parameters.AddWithValue("sst2", clx.SSST2);
            cmd.Parameters.AddWithValue("sst3", clx.SSST3);
            cmd.Parameters.AddWithValue("sst4", clx.SSST4);
            cmd.Parameters.AddWithValue("sst5", clx.SSST5);
            cmd.Parameters.AddWithValue("ssg1", clx.SSSG1);
            cmd.Parameters.AddWithValue("ssg2", clx.SSSG2);
            cmd.Parameters.AddWithValue("ssg3", clx.SSSG3);
            cmd.Parameters.AddWithValue("ssg4", clx.SSSG4);
            cmd.Parameters.AddWithValue("dhs1", clx.SDHS1);
            cmd.Parameters.AddWithValue("dhs2", clx.SDHS2);
            cmd.Parameters.AddWithValue("dhs3", clx.SDHS3);
            cmd.Parameters.AddWithValue("dhs4", clx.SDHS4);
            cmd.Parameters.AddWithValue("sscp1", clx.SSSCP1);
            cmd.Parameters.AddWithValue("sscp2", clx.SSSCP2);
            cmd.Parameters.AddWithValue("sscp3", clx.SSSCP3);
            cmd.Parameters.AddWithValue("sscp4", clx.SSSCP4);
            cmd.Parameters.AddWithValue("sscp5", clx.SSSCP5);
            cmd.Parameters.AddWithValue("kiemtrasaiso", clx.SKiemtraSaiSo);
            cmd.Parameters.AddWithValue("KetLuan", clx.SKetLuan);
            cmd.Parameters.AddWithValue("diachisd", clx.SDiaChiSD);
            cmd.ExecuteNonQuery();
            DataProvider.DongKetNoi();
        }

        public static DataTable TimBB( string soBB)
        {
          
            SqlConnection connection = DataProvider.MoKetNoi();
            string sql = "select * from canloxo where SoBienBan = N'" + soBB + "' ";            
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable KTTem2(string mabb) //ktra ket Luan dat hay k
        {

            SqlConnection connection = DataProvider.MoKetNoi();
            string sql = "select KetLuan from canloxo where SoBienBan = '" + mabb + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static void setTem(string soBB, string tem)
        {
            
                cn = DataProvider.MoKetNoi();
                string sql = "update canloxo set SoTem = '" + tem + "' where SoBienBan = '" + soBB + "' "; //gán tem vào
                string sql2 = "update Tem set TrangThai = 1 where Tem = '" + tem + "'"; //đổi trạng thái của tem
                SqlCommand cm = new SqlCommand(sql, cn);
                SqlCommand cm2 = new SqlCommand(sql2, cn);
                cm.ExecuteNonQuery();
                cm2.ExecuteNonQuery();
                cn.Close();
            
        }

        public static DataTable KTGCN(string mabb) //ktra xem có mã gcn chưa
        {

            SqlConnection connection = DataProvider.MoKetNoi();
            string sql = "select GCN from canloxo where SoBienBan = '" + mabb + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable KTTem(string mabb) //ktra xem co tem hay chưa
        {

            SqlConnection connection = DataProvider.MoKetNoi();
            string sql = "select SoTem from canloxo where SoBienBan = '" + mabb + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void setGCN(string gcn, string mabb)
        {

            cn = DataProvider.MoKetNoi();
            string sql = "update canloxo set GCN = '" + gcn + "' where SoBienBan = '" + mabb + "' ";
            SqlCommand cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();     
            cn.Close();
        }
        public static int KTSoBB(string SoBB)
        {
            string sql = @"select count(*) from canloxo where sobienban like N'" + SoBB + "' ";
            DataProvider.MoKetNoi();
            cmd = new SqlCommand(sql, DataProvider.cn);
            int sl = (int)cmd.ExecuteScalar();
            return sl;
        }
    }





    
}
