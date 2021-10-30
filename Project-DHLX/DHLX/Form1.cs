using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using DAO;
using System.Data.SqlClient;

namespace DHLX
{
    public partial class FrmNhapcanloxo : Form
    {
        public FrmNhapcanloxo()
        {
            InitializeComponent();
        }
        private void load_thongso()
        {
            txtTenPTD.Text = "Cân đồng hồ lò xo";
            txtKieu.Text = "CĐH15";
            txtSoCan.Text = Can_BUS.SoCan();
            txtCapCX.Text = "III";
            txtNamSX.Text = "2019";
            txtNuocSX.Text = "Nhơn Hòa-Việt Nam";
            txtChedoKD.Text = "Định kỳ";
            txtMuccanMAX.Text = "15.00";
            txtMuccanMIN.Text = "0.5";
            txtGiatridochia.Text = "50";
            txtGiatridochiakiem.Text = "50";
            txtPhuongphap.Text = "ĐLVN 30 : 2021";
            txtDonviSD.Text = "Chợ Vườn Chuối";
            cbbKiemdinhvien.Text = "ĐÀO DUY TƯỜNG";
            txtDiachiSD.Text = "Nguyễn Đình Chiểu, Quận 3, Tp. Hồ Chí Minh";

            txtMini1.Text = "0.5";
            txtMax1i1.Text = "7.475";
            txtMax2i1.Text = "14.95";
            txtMing.Text = "25.00";
            txtMax1g.Text = "50.00";
            txtMax2g.Text = "75.00";
            txtMini2.Text = "0.525";
            txtMax1i2.Text = "7.525";
            txtMax2i2.Text = "15.025";

            txtMindd.Text = "25/25";
            txtMax1dd.Text = "50/50";
            txtMax2dd.Text = "75/75";

            txtMindli1.Text = "0.5";
            txtMax1dli1.Text = "7.475";
            txtMax2dli1.Text = "14.95";///////////////////

            txtMindli2.Text = "0.5";
            txtMax1dli2.Text = "7.475";
            txtMax2dli2.Text = "14.95";
            txtMindli3.Text = "0.5";
            txtMax1dli3.Text = "7.5";
            txtMax2dli3.Text = "14.975";

            txtMinclln.Text = ".00";
            txtMax1clln.Text = "25.00";
            txtMax2clln.Text = "25.00";

            txtMinclcp.Text = "25.00";
            txtMax1clcp.Text = "50.00";
            txtMax2clcp.Text = "75.00";

            txtLlt.Text = "5";
            txtGlt.Text = "5";
            txtI1lt.Text = "5";
            txtI2lt.Text = "5";
            txtI3lt.Text = "5";
            txtI4lt.Text = "5";
            txtCLLN.Text = "0";
            txtCLCP.Text = "50.00";

            txtL1ss.Text = "0.5";
            txtL2ss.Text = "2.5";
            txtL3ss.Text = "7.5";
            txtL4ss.Text = "10";
            txtL5ss.Text = "15";

            txtCTT1.Text = "0.5";
            txtCTT2.Text = "2.5";
            txtCTT3.Text = "7.475";
            txtCTT4.Text = "9.975";
            txtCTT5.Text = "14.95";

            txtCTG1.Text = "0.5";
            txtCTG2.Text = "2.5";
            txtCTG3.Text = "7.5";
            txtCTG4.Text = "9.975";

            txtSST1.Text = ".00";
            txtSST2.Text = ".00";
            txtSST3.Text = "-25.00";
            txtSST4.Text = "-25.00";
            txtSST5.Text = "-50.00";

            txtSSG1.Text = ".00";
            txtSSG2.Text = ".00";
            txtSSG3.Text = ".00";
            txtSSG4.Text = "-25.00";

            txtHS1.Text = ".00";
            txtHS2.Text = ".00";
            txtHS3.Text = "25.00";
            txtHS4.Text = ".00";

            txtSSCP1.Text = ".025";
            txtSSCP2.Text = ".025";
            txtSSCP3.Text = ".05";
            txtSSCP4.Text = ".05";
            txtSSCP5.Text = ".075";
        }
        private void load_trang()
        {
            txtTenPTD.Text = "";
            txtKieu.Text = "";
            txtSoCan.Text = "";
            txtCapCX.Text = "";
            txtNamSX.Text = "";
            txtNuocSX.Text = "";
            txtChedoKD.Text = "";
            txtMuccanMAX.Text = "";
            txtMuccanMIN.Text = "";
            txtGiatridochia.Text = "";
            txtGiatridochiakiem.Text = "";
            txtPhuongphap.Text = "";
            txtDonviSD.Text = "";
            cbbKiemdinhvien.Text = "";
            txtDiachiSD.Text = "";

            txtMini1.Text = "";
            txtMax1i1.Text = "";
            txtMax2i1.Text = "";
            txtMing.Text = "";
            txtMax1g.Text = "";
            txtMax2g.Text = "";
            txtMini2.Text = "";
            txtMax2i2.Text = "";
            txtMax1i2.Text = "";
            txtMindd.Text = "";
            txtMax1dd.Text = "";
            txtMax2dd.Text = "";

            txtMindli1.Text = "";
            txtMax1dli1.Text = "";
            txtMax2dli1.Text = "";

            txtMindli2.Text = "";
            txtMax1dli2.Text = "";
            txtMax2dli2.Text = "";
            txtMindli3.Text = "";
            txtMax1dli3.Text = "";
            txtMax2dli3.Text = "";

            txtMinclln.Text = "";
            txtMax1clln.Text = "";
            txtMax2clln.Text = "";

            txtMinclcp.Text = "";
            txtMax1clcp.Text = "";
            txtMax2clcp.Text = "";

            txtLlt.Text = "";
            txtGlt.Text = "";
            txtI1lt.Text = "";
            txtI2lt.Text = "";
            txtI3lt.Text = "";
            txtI4lt.Text = "";
            txtCLLN.Text = "";
            txtCLCP.Text = "";

            txtL1ss.Text = "";
            txtL2ss.Text = "";
            txtL3ss.Text = "";
            txtL4ss.Text = "";
            txtL5ss.Text = "";

            txtCTT1.Text = "";
            txtCTT2.Text = "";
            txtCTT3.Text = "";
            txtCTT4.Text = "";
            txtCTT5.Text = "";

            txtCTG1.Text = "";
            txtCTG2.Text = "";
            txtCTG3.Text = "";
            txtCTG4.Text = "";

            txtSST1.Text = "";
            txtSST2.Text = "";
            txtSST3.Text = "";
            txtSST4.Text = "";
            txtSST5.Text = "";

            txtSSG1.Text = "";
            txtSSG2.Text = "";
            txtSSG3.Text = "";
            txtSSG4.Text = "";

            txtHS1.Text = "";
            txtHS2.Text = "";
            txtHS3.Text = "";
            txtHS4.Text = "";

            txtSSCP1.Text = "";
            txtSSCP2.Text = "";
            txtSSCP3.Text = "";
            txtSSCP4.Text = "";
            txtSSCP5.Text = "";
            txtNgayKD.Text = "";

        }
        private void loadtimenow()
        {
            string datenow;
            datenow = DateTime.Now.ToString("dd/MM/yyyy");
            txtNgayKD.Text = datenow;
        }


        private void loadTem() //lấy các tem chưa đc dùng 
        {
            List<Tem_DTO> lstTem = Tem_DAO.LayTem();
            cbxTem.DataSource = lstTem;
            cbxTem.DisplayMember = "STem";
            cbxTem.ValueMember = "STem";
        }
        private void btnInKD_Click(object sender, EventArgs e) //in bien ban kiem dinh
        {
            frmBBKiemDinh fr = new frmBBKiemDinh(txtMakd.Text); //truyền tham số vào gọi phương thức
            fr.ShowDialog();
        }

        private void btnInBB_Click(object sender, EventArgs e) //in giay chung nhan
        {


            string gcn = Can_DAO.CreateSoGCN(); //tạo mã gcn mới
            DataTable dt = Can_DAO.KTGCN(txtMakd.Text);  //ktra gcn
            string soGCN = "";
            foreach (DataRow dr in dt.Rows)
            {
                soGCN = dr.ItemArray[0].ToString();

            }
            if (soGCN.Equals("")) //ktra chưa có mã gcn
            {
                Can_BUS.setGCN(gcn, txtMakd.Text); //gán cho bb mã gcn
            }          
            frmChungNhan fr = new frmChungNhan(txtMakd.Text); //truyền tham số vào gọi phương thức
            fr.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "LT Quản Lý", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thêm không?", "LT Quản Lý", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                string mabb = Can_BUS.CreateSoBB();
                string matem = "";
                string ketluan="";
                string gcn ="";
                int a;
                float b;

                /*radiobutton nhan mac*/
                string nhanmac = "";
                if (rddat1.Checked == true)
                {
                    nhanmac = "Đạt";
                }
                else if (rdkhongdat1.Checked == true)
                {
                    nhanmac = "Không đạt";
                }
                string rdtem = "";
                if (rddat1.Checked == true)
                {
                    rdtem = "Đạt";
                }
                else if(rdkhongdat1.Checked == true)
                {
                    rdtem = "Không đạt";
                }
                /*radiobutton day du cac bo phan*/
                string daydu = "";
                if (rddat2.Checked == true)
                {
                    daydu = "Đạt";
                }
                else if (rdkhongdat2.Checked == true)
                {
                    daydu = "Không đạt";
                }
                /**/
                string donghothangdo = "";
                if (rddat3.Checked == true)
                {
                    donghothangdo = "Đạt";
                }
                else if (rdkhongdat3.Checked == true)
                {
                    donghothangdo = "Không đạt";
                }
                /**/
                string bophan = "";
                if (rddat4.Checked == true)
                {
                    bophan = "Đạt";
                }
                else if (rdkhongdat4.Checked == true)
                {
                    bophan = "Không đạt";
                }
                
                string ktngoai = "";
                if(rddat1.Checked==true && rddat2.Checked==true && rddat3.Checked==true && rddat4.Checked == true)
                {
                    ktngoai = "Đạt";
                    
                }
                else
                {
                    ktngoai = "Không đạt";
                }
                string ktdd = "Đạt";
                string ktll = "Đạt";
                string ktlt = "Đạt";
                string ktss = "Đạt";
                if( ktngoai.Equals("Đạt") && ktdd.Equals("Đạt") && ktll.Equals("Đạt") && ktlt.Equals("Đạt") && ktss.Equals("Đạt"))
                {
                    ketluan = "Đạt yêu cầu kỹ thuật đo lường";
                }
                else
                { ketluan = "Không đạt yêu cầu đo lường";}    
                    

                try
                {
                    if (txtTenPTD.Text != "" && txtKieu.Text != "" && txtSoCan.Text != "" && txtCapCX.Text != "" && txtNamSX.Text != "" && txtNuocSX.Text != "" && txtChedoKD.Text != "" && txtPhuongphap.Text != "" &&  txtDonviSD.Text != "" &&  cbbKiemdinhvien.Text != "" && txtDiachiSD.Text != "" && txtMing.Text != "" && txtMax1g.Text != "" && txtMax2g.Text != "" && txtMini2.Text != "" && txtMax1i2.Text != "" && txtMax2i2.Text != "" && txtMindd.Text != "" && txtMax1dd.Text != "" && txtMax2dd.Text != "" && txtMinclln.Text != "" && txtMax1clln.Text != "" && txtMax2clln.Text != "" && txtMinclcp.Text != "" && txtMax1clcp.Text != "" && txtMax2clcp.Text != "" && txtCLLN.Text != "" && txtCLCP.Text != "" && txtSST1.Text != "" && txtSST2.Text != "" && txtSST3.Text != "" && txtSST4.Text != "" && txtSST5.Text != "" && txtSSCP1.Text != "" && txtSSCP2.Text != "" && txtSSCP3.Text != "" && txtSSCP4.Text != "" && txtSSCP5.Text != "")
                    {
                        if (!int.TryParse(txtSoCan.Text.Trim(), out a) || !int.TryParse(txtNamSX.Text.Trim(), out a) || !float.TryParse(txtMuccanMAX.Text.Trim(), out b) || !float.TryParse(txtMuccanMIN.Text.Trim(), out b) || !float.TryParse(txtGiatridochia.Text.Trim(), out b) || !float.TryParse(txtGiatridochiakiem.Text.Trim(), out b) || !float.TryParse(txtMini1.Text.Trim(), out b) || !float.TryParse(txtMax1i1.Text.Trim(), out b) ||
            !float.TryParse(txtMax2i1.Text.Trim(), out b) ||
            !float.TryParse(txtMing.Text.Trim(), out b) ||
            !float.TryParse(txtMax1g.Text.Trim(), out b) ||
            !float.TryParse(txtMax2g.Text.Trim(), out b) ||
            !float.TryParse(txtMini2.Text.Trim(), out b) ||
            !float.TryParse(txtMax1i1.Text.Trim(), out b) ||
            !float.TryParse(txtMax1i2.Text.Trim(), out b) ||
            /*!float.TryParse(txtMindd.Text.Trim(), out b) ||
            !float.TryParse(txtMax1dd.Text.Trim(), out b) ||
            !float.TryParse(txtMax2dd.Text.Trim(), out b) ||*/

            !float.TryParse(txtMindli1.Text.Trim(), out b) ||
            !float.TryParse(txtMax1dli1.Text.Trim(), out b) ||
            !float.TryParse(txtMax2dli1.Text.Trim(), out b) ||

            !float.TryParse(txtMindli2.Text.Trim(), out b) ||
            !float.TryParse(txtMax1dli2.Text.Trim(), out b) ||
            !float.TryParse(txtMax2dli2.Text.Trim(), out b) ||
            !float.TryParse(txtMindli3.Text.Trim(), out b) ||
            !float.TryParse(txtMax1dli3.Text.Trim(), out b) ||
            !float.TryParse(txtMax2dli3.Text.Trim(), out b) ||

            !float.TryParse(txtMinclln.Text.Trim(), out b) ||
            !float.TryParse(txtMax1clln.Text.Trim(), out b) ||
            !float.TryParse(txtMax2clln.Text.Trim(), out b) ||

            !float.TryParse(txtMinclcp.Text.Trim(), out b) ||
            !float.TryParse(txtMax1clcp.Text.Trim(), out b) ||
            !float.TryParse(txtMax2clcp.Text.Trim(), out b) ||

            !float.TryParse(txtLlt.Text.Trim(), out b) ||
            !float.TryParse(txtGlt.Text.Trim(), out b) ||
            !float.TryParse(txtI1lt.Text.Trim(), out b) ||
            !float.TryParse(txtI2lt.Text.Trim(), out b) ||
            !float.TryParse(txtI3lt.Text.Trim(), out b) ||
            !float.TryParse(txtI4lt.Text.Trim(), out b) ||
            !float.TryParse(txtCLLN.Text.Trim(), out b) ||
            !float.TryParse(txtCLCP.Text.Trim(), out b) ||

            !float.TryParse(txtL1ss.Text.Trim(), out b) ||
            !float.TryParse(txtL2ss.Text.Trim(), out b) ||
            !float.TryParse(txtL3ss.Text.Trim(), out b) ||
            !float.TryParse(txtL4ss.Text.Trim(), out b) ||
            !float.TryParse(txtL5ss.Text.Trim(), out b) ||

            !float.TryParse(txtCTT1.Text.Trim(), out b) ||
            !float.TryParse(txtCTT2.Text.Trim(), out b) ||
            !float.TryParse(txtCTT3.Text.Trim(), out b) ||
            !float.TryParse(txtCTT4.Text.Trim(), out b) ||
            !float.TryParse(txtCTT5.Text.Trim(), out b) ||

            !float.TryParse(txtCTG1.Text.Trim(), out b) ||
            !float.TryParse(txtCTG2.Text.Trim(), out b) ||
            !float.TryParse(txtCTG3.Text.Trim(), out b) ||
            !float.TryParse(txtCTG4.Text.Trim(), out b) ||

            !float.TryParse(txtSST1.Text.Trim(), out b) ||
            !float.TryParse(txtSST2.Text.Trim(), out b) ||
            !float.TryParse(txtSST3.Text.Trim(), out b) ||
            !float.TryParse(txtSST4.Text.Trim(), out b) ||
            !float.TryParse(txtSST5.Text.Trim(), out b) ||

            !float.TryParse(txtSSG1.Text.Trim(), out b) ||
            !float.TryParse(txtSSG2.Text.Trim(), out b) ||
            !float.TryParse(txtSSG3.Text.Trim(), out b) ||
            !float.TryParse(txtSSG4.Text.Trim(), out b) ||

                        !float.TryParse(txtHS1.Text.Trim(), out b) ||
                        !float.TryParse(txtHS2.Text.Trim(), out b) ||
                        !float.TryParse(txtHS3.Text.Trim(), out b) ||
                        !float.TryParse(txtHS4.Text.Trim(), out b) ||

                        !float.TryParse(txtSSCP1.Text.Trim(), out b) ||
                        !float.TryParse(txtSSCP2.Text.Trim(), out b) ||
                        !float.TryParse(txtSSCP3.Text.Trim(), out b) ||
                        !float.TryParse(txtSSCP4.Text.Trim(), out b) ||
                        !float.TryParse(txtSSCP5.Text.Trim(), out b))
                        {
                            MessageBox.Show("Định dạng của một số ô nhập không khớp xin kiểm tra lại!", "Thông báo");
                        }
                        else
                        {
                            Can_DTO nv = new Can_DTO(mabb, txtSoCan.Text, txtTenPTD.Text, txtKieu.Text, txtCapCX.Text,
                                                txtNuocSX.Text, txtNamSX.Text, txtChedoKD.Text, txtNgayKD.Text,
                                                float.Parse(txtMuccanMAX.Text.Trim()),
                                                float.Parse(txtMuccanMIN.Text.Trim()),
                                                txtGiatridochia.Text, txtGiatridochiakiem.Text, txtPhuongphap.Text, txtDonviSD.Text,
                                                cbbKiemdinhvien.Text, matem, nhanmac, rdtem, daydu,
                                                donghothangdo, bophan, ktngoai, txtMini1.Text, txtMax1i1.Text,
                                                txtMax2i1.Text, txtMing.Text, txtMax1g.Text, txtMax2g.Text, txtMini2.Text,
                                                txtMax1i2.Text, txtMax2i2.Text, txtMindd.Text, txtMax1dd.Text, txtMax2dd.Text,
                                                ktdd, txtMindli1.Text, txtMax1dli1.Text, txtMax2dli1.Text, txtMindli2.Text,
                                                txtMax1dli2.Text, txtMax2dli2.Text, txtMindli3.Text, txtMax1dli3.Text, txtMax2dli3.Text,
                                                txtMinclln.Text, txtMax1clln.Text, txtMax2clln.Text, txtMinclcp.Text, txtMax1clcp.Text,
                                                txtMax2clcp.Text, ktll, txtLlt.Text, txtGlt.Text, txtI1lt.Text,
                                                txtI2lt.Text, txtI3lt.Text, txtI4lt.Text, txtCLLN.Text, txtCLCP.Text,
                                                ktlt, txtL1ss.Text, txtL2ss.Text, txtL3ss.Text, txtL4ss.Text,
                                                txtL5ss.Text, txtCTT1.Text, txtCTT2.Text, txtCTT3.Text, txtCTT4.Text,
                                                txtCTT5.Text, txtCTG1.Text, txtCTG2.Text, txtCTG3.Text, txtCTG4.Text,
                                                txtSST1.Text, txtSST2.Text, txtSST3.Text, txtSST4.Text, txtSST5.Text,
                                                txtSSG1.Text, txtSSG2.Text, txtSSG3.Text, txtSSG4.Text, txtHS1.Text,
                                                txtHS2.Text, txtHS3.Text, txtHS4.Text, txtSSCP1.Text, txtSSCP2.Text,
                                                txtSSCP3.Text, txtSSCP4.Text, txtSSCP5.Text, ktss, ketluan, txtDiachiSD.Text,gcn );
                            Can_BUS.them(nv);
                            txtMakd.Text = mabb;
                            btnLuu.Enabled = true;
                            MessageBox.Show("Hoàn tất kiểm định với số mã biên bản : '" + mabb + "'\nKết luận: " + ketluan + "", "Thông báo");
                        }
                    }
                    else MessageBox.Show("Hãy nhập đầy đủ dữ liệu !");
                }
                catch
                {
                    MessageBox.Show("Lỗi! Hãy kiểm tra lại.", "Thông báo");
                }
            }
        }

        private void FrmNhapcanloxo_Load(object sender, EventArgs e)
        {
            loadtimenow();
            loadTem();
            txtSoCan.Text = Can_BUS.SoCan();
            List<KDV_DTO> lstKDV = KDV_BUS.LayKDV();
            cbbKiemdinhvien.DataSource = lstKDV;
            cbbKiemdinhvien.DisplayMember = "SKiemDinhVien";
            cbbKiemdinhvien.ValueMember = "SKiemDinhVien";
            btnInBB.Enabled = false;
            btnInKD.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {            
            string sobb="";
            if (txtMakd.Text.Equals(""))
            {
                MessageBox.Show("Chưa có số biên bản !", "Thông báo");
            }
            else
            {
                DataTable dt = new DataTable();
                int a = Can_BUS.KTSoBB(txtMakd.Text); // ktra sự tồn tại của bb
                if (a > 0)
                {
                    btnSua.Enabled = true;
                    btnLuu.Enabled = true;
                    dt = Can_BUS.TimBB(txtMakd.Text.Trim());                    
                    foreach (DataRow dr in dt.Rows)
                    {
                    sobb = dr.ItemArray[0].ToString();
                    txtSoCan.Text = dr.ItemArray[1].ToString();
                    txtTenPTD.Text = dr.ItemArray[2].ToString();
                    txtKieu.Text = dr.ItemArray[3].ToString();
                    txtCapCX.Text = dr.ItemArray[4].ToString();
                    txtNuocSX.Text = dr.ItemArray[5].ToString();
                    txtNamSX.Text = dr.ItemArray[6].ToString();
                    txtChedoKD.Text = dr.ItemArray[7].ToString();
                    txtNgayKD.Text = dr.ItemArray[8].ToString();
                    txtMuccanMAX.Text = dr.ItemArray[9].ToString();
                    txtMuccanMIN.Text = dr.ItemArray[10].ToString();
                    txtGiatridochia.Text = dr.ItemArray[11].ToString();
                    txtGiatridochiakiem.Text = dr.ItemArray[12].ToString();
                    txtPhuongphap.Text = dr.ItemArray[13].ToString();
                    txtDonviSD.Text = dr.ItemArray[14].ToString();
                    cbbKiemdinhvien.Text = dr.ItemArray[15].ToString();
                    if (dr.ItemArray[17].ToString().Equals("Đạt"))
                    {
                        rddat1.Checked = true;
                    }
                    else { rdkhongdat1.Checked = true; }

                    if (dr.ItemArray[19].ToString().Equals("Đạt"))
                    {
                        rddat2.Checked = true;
                    }
                    else rdkhongdat2.Checked = true;

                    if (dr.ItemArray[20].ToString().Equals("Đạt"))
                    {
                        rddat3.Checked = true;
                    }
                    else rdkhongdat3.Checked = true;

                    if (dr.ItemArray[21].ToString().Equals("Đạt"))
                    {
                        rddat4.Checked = true;
                    }
                    else rdkhongdat4.Checked = true;

                    txtMini1.Text = dr.ItemArray[23].ToString();
                    txtMax1i1.Text = dr.ItemArray[24].ToString();
                    txtMax2i1.Text = dr.ItemArray[25].ToString();

                    txtMing.Text = dr.ItemArray[26].ToString();
                    txtMax1g.Text = dr.ItemArray[27].ToString();
                    txtMax2g.Text = dr.ItemArray[28].ToString();

                    txtMini2.Text = dr.ItemArray[29].ToString();
                    txtMax1i2.Text = dr.ItemArray[30].ToString();
                    txtMax2i2.Text = dr.ItemArray[31].ToString();

                    txtMindd.Text = dr.ItemArray[32].ToString();
                    txtMax1dd.Text = dr.ItemArray[33].ToString();
                    txtMax2dd.Text = dr.ItemArray[34].ToString();


                    txtMindli1.Text = dr.ItemArray[36].ToString();
                    txtMax1dli1.Text = dr.ItemArray[37].ToString();
                    txtMax2dli1.Text = dr.ItemArray[38].ToString();

                    txtMindli2.Text = dr.ItemArray[39].ToString();
                    txtMax1dli2.Text = dr.ItemArray[40].ToString();
                    txtMax2dli2.Text = dr.ItemArray[41].ToString();

                    txtMindli3.Text = dr.ItemArray[42].ToString();
                    txtMax1dli3.Text = dr.ItemArray[43].ToString();
                    txtMax2dli3.Text = dr.ItemArray[44].ToString();

                    txtMinclln.Text = dr.ItemArray[45].ToString();
                    txtMax1clln.Text = dr.ItemArray[46].ToString();
                    txtMax2clln.Text = dr.ItemArray[47].ToString();

                    txtMinclcp.Text = dr.ItemArray[48].ToString();
                    txtMax1clcp.Text = dr.ItemArray[49].ToString();
                    txtMax2clcp.Text = dr.ItemArray[50].ToString();


                    txtLlt.Text = dr.ItemArray[52].ToString();
                    txtGlt.Text = dr.ItemArray[53].ToString();
                    txtI1lt.Text = dr.ItemArray[54].ToString();
                    txtI2lt.Text = dr.ItemArray[55].ToString();
                    txtI3lt.Text = dr.ItemArray[56].ToString();
                    txtI4lt.Text = dr.ItemArray[57].ToString();
                    txtCLLN.Text = dr.ItemArray[58].ToString();
                    txtCLCP.Text = dr.ItemArray[59].ToString();


                    txtL1ss.Text = dr.ItemArray[61].ToString();
                    txtL2ss.Text = dr.ItemArray[62].ToString();
                    txtL3ss.Text = dr.ItemArray[63].ToString();
                    txtL4ss.Text = dr.ItemArray[64].ToString();
                    txtL5ss.Text = dr.ItemArray[65].ToString();

                    txtCTT1.Text = dr.ItemArray[66].ToString();
                    txtCTT2.Text = dr.ItemArray[67].ToString();
                    txtCTT3.Text = dr.ItemArray[68].ToString();
                    txtCTT4.Text = dr.ItemArray[69].ToString();
                    txtCTT5.Text = dr.ItemArray[70].ToString();

                    txtCTG1.Text = dr.ItemArray[71].ToString();
                    txtCTG2.Text = dr.ItemArray[72].ToString();
                    txtCTG3.Text = dr.ItemArray[73].ToString();
                    txtCTG4.Text = dr.ItemArray[74].ToString();

                    txtSST1.Text = dr.ItemArray[75].ToString();
                    txtSST2.Text = dr.ItemArray[76].ToString();
                    txtSST3.Text = dr.ItemArray[77].ToString();
                    txtSST4.Text = dr.ItemArray[78].ToString();
                    txtSST5.Text = dr.ItemArray[79].ToString();

                    txtSSG1.Text = dr.ItemArray[80].ToString();
                    txtSSG2.Text = dr.ItemArray[81].ToString();
                    txtSSG3.Text = dr.ItemArray[82].ToString();
                    txtSSG4.Text = dr.ItemArray[83].ToString();

                    txtHS1.Text = dr.ItemArray[84].ToString();
                    txtHS2.Text = dr.ItemArray[85].ToString();
                    txtHS3.Text = dr.ItemArray[86].ToString();
                    txtHS4.Text = dr.ItemArray[87].ToString();

                    txtSSCP1.Text = dr.ItemArray[88].ToString();
                    txtSSCP2.Text = dr.ItemArray[89].ToString();
                    txtSSCP3.Text = dr.ItemArray[90].ToString();
                    txtSSCP4.Text = dr.ItemArray[91].ToString();
                    txtSSCP5.Text = dr.ItemArray[92].ToString();
                    txtDiachiSD.Text = dr.ItemArray[95].ToString();
                    }
                }
                else 
                    MessageBox.Show("Không có số biên bản này!");


                //kiểm tra xem có đạt kết luận hay không
                DataTable dt2 = Can_DAO.KTTem2(txtMakd.Text);
                string kl = "";
                foreach (DataRow dr in dt2.Rows)
                {
                    kl = dr.ItemArray[0].ToString();
                }

                if (!string.IsNullOrEmpty(sobb)) //nếu có
                {
                    btnThem.Enabled = false;
                    button1.Enabled = false;
                    btnInKD.Enabled = true;
                    if (rddat1.Checked == true && rddat2.Checked == true && rddat3.Checked == true && rddat4.Checked == true && kl.Equals("Đạt yêu cầu kỹ thuật đo lường") == true) //ktra các điều kiện đạt
                    {
                        btnInBB.Enabled = true;
                        
                    }
                    else 
                    {
                        btnInBB.Enabled = false;
                    } 
                }
                else
                {
                    button1.Enabled = true;
                    btnInKD.Enabled = false;
                    btnInBB.Enabled = false;
                    btnThem.Enabled = true;
                    sobb = "";
                }
            }
            
        }

        /*END_Kiem tra dieu kien in giay chung nhan*/

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //kiểm tra xem có tem hay chưa
            DataTable dt = Can_DAO.KTTem(txtMakd.Text);
            string soTem = "";
            foreach (DataRow dr in dt.Rows)
            {
                soTem = dr.ItemArray[0].ToString();

            }

            //kiểm tra xem có đạt kết luận hay không
            DataTable dt2 = Can_DAO.KTTem2(txtMakd.Text);
            string kl = "";
            foreach (DataRow dr in dt2.Rows)
            {
                kl = dr.ItemArray[0].ToString();
            }


            if (cbxTem.Equals(""))
            {
                MessageBox.Show("Chưa có Tem");
            }
            else
            {
                if (soTem.Equals("")) //chưa có tem
                {
                    try
                     {
                        if (rddat1.Checked == true && rddat2.Checked == true && rddat3.Checked == true && rddat4.Checked == true && kl.Equals("Đạt yêu cầu kỹ thuật đo lường") == true) //ktra các điều kiện đạt
                        {
                           Can_BUS.setTem(txtMakd.Text, cbxTem.Text);
                           MessageBox.Show("Hoàn tất gán tem : '" + cbxTem.Text + "'", "Thông báo");
                           loadTem();
                           btnInBB.Enabled = true;
                           btnInKD.Enabled = true;
                        }
                         else MessageBox.Show("Biên bản không đủ điều kiện cấp tem");
                     }
                     catch
                     {
                        MessageBox.Show("Chưa thể gán tem", "Thông báo");
                     }
                }
                else
                {
                    MessageBox.Show("Biên bản này đã có tem", "Thông báo");
                }                  
            }            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn sửa" +
                "" +
                "" +
                " không?", "LT Quản Lý", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                string mabb = txtMakd.Text;
                //string matem = "";
                string ketluan = "";

                /*radiobutton nhan mac*/
                string nhanmac = "";
                if (rddat1.Checked == true)
                {
                    nhanmac = "Đạt";
                }
                else if (rdkhongdat1.Checked == true)
                {
                    nhanmac = "Không đạt";
                }
                string rdtem = "";
                if (rddat1.Checked == true)
                {
                    rdtem = "Đạt";
                }
                else if (rdkhongdat1.Checked == true)
                {
                    rdtem = "Không đạt";
                }
                /*radiobutton day du cac bo phan*/
                string daydu = "";
                if (rddat2.Checked == true)
                {
                    daydu = "Đạt";
                }
                else if (rdkhongdat2.Checked == true)
                {
                    daydu = "Không đạt";
                }
                /**/
                string donghothangdo = "";
                if (rddat3.Checked == true)
                {
                    donghothangdo = "Đạt";
                }
                else if (rdkhongdat3.Checked == true)
                {
                    donghothangdo = "Không đạt";
                }
                /**/
                string bophan = "";
                if (rddat4.Checked == true)
                {
                    bophan = "Đạt";
                }
                else if (rdkhongdat4.Checked == true)
                {
                    bophan = "Không đạt";
                }
                string ktngoai = "";
                if (rddat1.Checked == true && rddat2.Checked == true && rddat3.Checked == true && rddat4.Checked == true)
                {
                    ktngoai = "Đạt";
                }
                else
                {
                    ktngoai = "Không đạt";
                }
                string ktdd = "Đạt";
                string ktll = "Đạt";
                string ktlt = "Đạt";
                string ktss = "Đạt";
                if (ktngoai.Equals("Đạt") && ktdd.Equals("Đạt") && ktll.Equals("Đạt") && ktlt.Equals("Đạt") && ktss.Equals("Đạt"))
                {
                    ketluan = "Đạt yêu cầu kỹ thuật đo lường";
                }
                else
                    ketluan = "Không đạt yêu cầu đo lường";

                //try
                //{
                //    if (txtMing.Text != "" && txtMax1g.Text != "" && txtMax2g.Text != "" && txtMini2.Text != "" && txtMax1i2.Text != "" && txtMax2i2.Text != "" && txtMindd.Text != "" && txtMax1dd.Text != "" && txtMax2dd.Text != "" && txtMinclln.Text != "" && txtMax1clln.Text != "" && txtMax2clln.Text != "" && txtMinclcp.Text != "" && txtMax1clcp.Text != "" && txtMax2clcp.Text != "" && txtCLLN.Text != "" && txtCLCP.Text != "" && txtSST1.Text != "" && txtSST2.Text != "" && txtSST3.Text != "" && txtSST4.Text != "" && txtSST5.Text != "" && txtSSCP1.Text != "" && txtSSCP2.Text != "" && txtSSCP3.Text != "" && txtSSCP4.Text != "" && txtSSCP5.Text != "")
                //    {
                Can_DTO cxl = new Can_DTO(mabb, txtSoCan.Text, txtTenPTD.Text, txtKieu.Text, txtCapCX.Text,
                                            txtNuocSX.Text, txtNamSX.Text, txtChedoKD.Text, txtNgayKD.Text, float.Parse(txtMuccanMAX.Text.Trim()),
                                            float.Parse(txtMuccanMIN.Text.Trim()), txtGiatridochia.Text, txtGiatridochiakiem.Text, txtPhuongphap.Text, txtDonviSD.Text,
                                            cbbKiemdinhvien.Text, nhanmac, rdtem, daydu,
                                            donghothangdo, bophan, ktngoai, txtMini1.Text, txtMax1i1.Text,
                                            txtMax2i1.Text, txtMing.Text, txtMax1g.Text, txtMax2g.Text, txtMini2.Text,
                                            txtMax1i2.Text, txtMax2i2.Text, txtMindd.Text, txtMax1dd.Text, txtMax2dd.Text,
                                            ktdd, txtMindli1.Text, txtMax1dli1.Text, txtMax2dli1.Text, txtMindli2.Text,
                                            txtMax1dli2.Text, txtMax2dli2.Text, txtMindli3.Text, txtMax1dli3.Text, txtMax2dli3.Text,
                                            txtMinclln.Text, txtMax1clln.Text, txtMax2clln.Text, txtMinclcp.Text, txtMax1clcp.Text,
                                            txtMax2clcp.Text, ktll, txtLlt.Text, txtGlt.Text, txtI1lt.Text,
                                            txtI2lt.Text, txtI3lt.Text, txtI4lt.Text, txtCLLN.Text, txtCLCP.Text,
                                            ktlt, txtL1ss.Text, txtL2ss.Text, txtL3ss.Text, txtL4ss.Text,
                                            txtL5ss.Text, txtCTT1.Text, txtCTT2.Text, txtCTT3.Text, txtCTT4.Text,
                                            txtCTT5.Text, txtCTG1.Text, txtCTG2.Text, txtCTG3.Text, txtCTG4.Text,
                                            txtSST1.Text, txtSST2.Text, txtSST3.Text, txtSST4.Text, txtSST5.Text,
                                            txtSSG1.Text, txtSSG2.Text, txtSSG3.Text, txtSSG4.Text, txtHS1.Text,
                                            txtHS2.Text, txtHS3.Text, txtHS4.Text, txtSSCP1.Text, txtSSCP2.Text,
                                            txtSSCP3.Text, txtSSCP4.Text, txtSSCP5.Text, ktss, ketluan,txtDiachiSD.Text);

                    Can_BUS.Sua(cxl);
                    txtMakd.Text = mabb;
                    MessageBox.Show("Cập nhật thành công : '" + mabb + "'\nKết luận: "+ketluan+"", "Thông báo");
                    //}
                    //else MessageBox.Show("Hãy nhập đầy đủ dữ liệu !");
                //}
                //catch
                //{
                //    MessageBox.Show("Lỗi! Hãy kiểm tra lại.", "Thông báo");
                //}
            }
        }

        private void cbbKiemdinhvien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            load_thongso();
            loadtimenow();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            load_trang();
            button1.Enabled = true;
            btnThem.Enabled = true;
            btnInBB.Enabled = false;
            btnInKD.Enabled = false;
            lbtb.Text = "";
        }
    }
}
