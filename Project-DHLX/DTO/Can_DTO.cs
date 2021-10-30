using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Can_DTO
    {
        /* constructor sua*/
        public Can_DTO(string sSoBienBan, string sSoCan, string sTenCan, string sKieu, string sCapChinhXac,
            string sNuocSX, string sNamSX, string sCheDoKD, string sNgayKD, float sMax, float sMin,
            string sDoChia, string sDoChiaKiem, string sPPTH, string sDonViSD, string sKiemDinhVien,
            /*string sSoTem,*/    /*string sNguoiSoatLai,*/    string sNhanMac, string sTem, string sDayDu, string sDongHoThangDo, string sBoPhan, string sKiemTraNgoai,
            /*string sDDMTmin,    string sDDMT05max,    string sDDMTmax,*/    string sDDCT1min, string sDDCT105max,
            string sDDCT1max, string sDDGTmin, string sDDGT05max, string sDDGTmax, string sDDCT2min,
            string sDDCT205max, string sDDCT2max, string sDDmin, string sDD05max, string sDDmax,
            string sKiemTraDoDong,    /*string sLLMTmin,    string sLLMT05max,    string sLLMTmax,*/    string sLLCT1min,
            string sLLCT105max, string sLLCT1max, string sLLCT2min, string sLLCT205max, string sLLCT2max,
            string sLLCT3min, string sLLCT305max, string sLLCT3max, string sLLCLLonmin, string sLLCLLon05max,
            string sLLCLLmax, string sLLCLCPmin, string sLLCLCP05max, string sLLCLCPmax, string sKiemtraLapLai,
            string sLTMucTai, string sLTChiThiG, string sLTChiThiI1, string sLTChiThiI2, string sLTChiThiI3,
            string sLTChiThiI4, string sLTCLLN, string sLTCLCP, string sKiemtraLechTam, string sMTL1,
            string sMTL2, string sMTL3, string sMTL4, string sMTL5, string sCTCT1, string sCTCT2,
            string sCTCT3, string sCTCT4, string sCTCT5, string sCTCG1, string sCTCG2, string sCTCG3,
            string sCTCG4, string sSST1, string sSST2, string sSST3, string sSST4, string sSST5,
            string sSSG1, string sSSG2, string sSSG3, string sSSG4, string sDHS1, string sDHS2,
            string sDHS3, string sDHS4, string sSSCP1, string sSSCP2, string sSSCP3, string sSSCP4,
            string sSSCP5, string sKiemtraSaiSo, string sKetLuan, string sDiaChiSD) {
            this.sSoBienBan = sSoBienBan;
            this.sSoCan = sSoCan;
            this.sTenCan = sTenCan;
            this.sKieu = sKieu;
            this.sCapChinhXac = sCapChinhXac;
            this.sNuocSX = sNuocSX;
            this.sNamSX = sNamSX;
            this.sCheDoKD = sCheDoKD;
            this.sNgayKD = sNgayKD;
            this.sMax = sMax;
            this.sMin = sMin;
            this.sDoChia = sDoChia;
            this.sDoChiaKiem = sDoChiaKiem;
            this.sPPTH = sPPTH;
            this.sDonViSD = sDonViSD;
            //this.sDiaChiSD = sDiaChiSD;
            this.sKiemDinhVien = sKiemDinhVien;
            //this.sSoTem = sSoTem;
            //this.sNguoiSoatLai = sNguoiSoatLai;
            this.sNhanMac = sNhanMac;
            this.sTem = sTem;
            this.sDayDu = sDayDu;
            this.sDongHoThangDo = sDongHoThangDo;
            this.sBoPhan = sBoPhan;
            this.sKiemTraNgoai = sKiemTraNgoai;
            //this.sDDMTmin = sDDMTmin;
            //this.sDDMT05max = sDDMT05max;
            //this.sDDMTmax = sDDMTmax;
            this.sDDCT1min = sDDCT1min;
            this.sDDCT105max = sDDCT105max;
            this.sDDCT1max = sDDCT1max;
            this.sDDGTmin = sDDGTmin;
            this.sDDGT05max = sDDGT05max;
            this.sDDGTmax = sDDGTmax;
            this.sDDCT2min = sDDCT2min;
            this.sDDCT205max = sDDCT205max;
            this.sDDCT2max = sDDCT2max;
            this.sDDmin = sDDmin;
            this.sDD05max = sDD05max;
            this.sDDmax = sDDmax;
            this.sKiemTraDoDong = sKiemTraDoDong;
            //this.sLLMTmin = sLLMTmin;
            //this.sLLMT05max = sLLMT05max;
            //this.sLLMTmax = sLLMTmax;
            this.sLLCT1min = sLLCT1min;
            this.sLLCT105max = sLLCT105max;
            this.sLLCT1max = sLLCT1max;
            this.sLLCT2min = sLLCT2min;
            this.sLLCT205max = sLLCT205max;
            this.sLLCT2max = sLLCT2max;
            this.sLLCT3min = sLLCT3min;
            this.sLLCT305max = sLLCT305max;
            this.sLLCT3max = sLLCT3max;
            this.sLLCLLonmin = sLLCLLonmin;
            this.sLLCLLon05max = sLLCLLon05max;
            this.sLLCLLmax = sLLCLLmax;
            this.sLLCLCPmin = sLLCLCPmin;
            this.sLLCLCP05max = sLLCLCP05max;
            this.sLLCLCPmax = sLLCLCPmax;
            this.sKiemtraLapLai = sKiemtraLapLai;
            this.sLTMucTai = sLTMucTai;
            this.sLTChiThiG = sLTChiThiG;
            this.sLTChiThiI1 = sLTChiThiI1;
            this.sLTChiThiI2 = sLTChiThiI2;
            this.sLTChiThiI3 = sLTChiThiI3;
            this.sLTChiThiI4 = sLTChiThiI4;
            this.sLTCLLN = sLTCLLN;
            this.sLTCLCP = sLTCLCP;
            this.sKiemtraLechTam = sKiemtraLechTam;
            this.sMTL1 = sMTL1;
            this.sMTL2 = sMTL2;
            this.sMTL3 = sMTL3;
            this.sMTL4 = sMTL4;
            this.sMTL5 = sMTL5;
            this.sCTCT1 = sCTCT1;
            this.sCTCT2 = sCTCT2;
            this.sCTCT3 = sCTCT3;
            this.sCTCT4 = sCTCT4;
            this.sCTCT5 = sCTCT5;
            this.sCTCG1 = sCTCG1;
            this.sCTCG2 = sCTCG2;
            this.sCTCG3 = sCTCG3;
            this.sCTCG4 = sCTCG4;
            this.sSST1 = sSST1;
            this.sSST2 = sSST2;
            this.sSST3 = sSST3;
            this.sSST4 = sSST4;
            this.sSST5 = sSST5;
            this.sSSG1 = sSSG1;
            this.sSSG2 = sSSG2;
            this.sSSG3 = sSSG3;
            this.sSSG4 = sSSG4;
            this.sDHS1 = sDHS1;
            this.sDHS2 = sDHS2;
            this.sDHS3 = sDHS3;
            this.sDHS4 = sDHS4;
            this.sSSCP1 = sSSCP1;
            this.sSSCP2 = sSSCP2;
            this.sSSCP3 = sSSCP3;
            this.sSSCP4 = sSSCP4;
            this.sSSCP5 = sSSCP5;
            this.sKiemtraSaiSo = sKiemtraSaiSo;
            this.sKetLuan = sKetLuan;
            this.sDiaChiSD = sDiaChiSD;
        }
        /* constructor them*/
        public Can_DTO(string sSoBienBan,    string sSoCan,    string sTenCan,    string sKieu,    string sCapChinhXac,
            string sNuocSX,    string sNamSX,    string sCheDoKD,    string sNgayKD,    float sMax,    float sMin,    
            string sDoChia,    string sDoChiaKiem,    string sPPTH,    string sDonViSD,    string sKiemDinhVien,
            string sSoTem,    /*string sNguoiSoatLai,*/    string sNhanMac,    string sTem,    string sDayDu,    string sDongHoThangDo,string sBoPhan    ,string sKiemTraNgoai,
            /*string sDDMTmin,    string sDDMT05max,    string sDDMTmax,*/    string sDDCT1min,    string sDDCT105max,
            string sDDCT1max,    string sDDGTmin,    string sDDGT05max,    string sDDGTmax,    string sDDCT2min,
            string sDDCT205max,    string sDDCT2max,    string sDDmin,    string sDD05max,    string sDDmax,
            string sKiemTraDoDong,    /*string sLLMTmin,    string sLLMT05max,    string sLLMTmax,*/    string sLLCT1min,
            string sLLCT105max,    string sLLCT1max,    string sLLCT2min,    string sLLCT205max,    string sLLCT2max,
            string sLLCT3min,    string sLLCT305max,    string sLLCT3max,    string sLLCLLonmin,    string sLLCLLon05max,
            string sLLCLLmax,    string sLLCLCPmin,    string sLLCLCP05max,    string sLLCLCPmax,    string sKiemtraLapLai,
            string sLTMucTai,    string sLTChiThiG,    string sLTChiThiI1,    string sLTChiThiI2,    string sLTChiThiI3,
            string sLTChiThiI4,    string sLTCLLN,    string sLTCLCP,    string sKiemtraLechTam,    string sMTL1,
            string sMTL2,    string sMTL3,        string sMTL4,    string sMTL5,    string sCTCT1,    string sCTCT2,
            string sCTCT3,    string sCTCT4,    string sCTCT5,    string sCTCG1,    string sCTCG2,    string sCTCG3,
            string sCTCG4,    string sSST1,    string sSST2,    string sSST3,    string sSST4,    string sSST5,
            string sSSG1,    string sSSG2,    string sSSG3,    string sSSG4,    string sDHS1,    string sDHS2,
            string sDHS3,    string sDHS4,    string sSSCP1,    string sSSCP2,    string sSSCP3,    string sSSCP4,
            string sSSCP5,    string sKiemtraSaiSo, string sKetLuan, string sDiaChiSD, string sgcn) {
            this.sSoBienBan = sSoBienBan;
            this.sSoCan = sSoCan;
            this.sTenCan = sTenCan;
            this.sKieu = sKieu;
            this.sCapChinhXac = sCapChinhXac;
            this.sNuocSX = sNuocSX;
            this.sNamSX = sNamSX;
            this.sCheDoKD = sCheDoKD;
            this.sNgayKD = sNgayKD;
            this.sMax = sMax;
            this.sMin = sMin;
            this.sDoChia = sDoChia;
            this.sDoChiaKiem = sDoChiaKiem;
            this.sPPTH = sPPTH;
            this.sDonViSD = sDonViSD;
            //this.sDiaChiSD = sDiaChiSD;
            this.sKiemDinhVien = sKiemDinhVien;
            this.sSoTem = sSoTem;
            //this.sNguoiSoatLai = sNguoiSoatLai;
            this.sNhanMac = sNhanMac;
            this.sTem = sTem;
            this.sDayDu = sDayDu;
            this.sDongHoThangDo = sDongHoThangDo;
            this.sBoPhan = sBoPhan;
            this.sKiemTraNgoai = sKiemTraNgoai;
            //this.sDDMTmin = sDDMTmin;
            //this.sDDMT05max = sDDMT05max;
            //this.sDDMTmax = sDDMTmax;
            this.sDDCT1min = sDDCT1min;
            this.sDDCT105max = sDDCT105max;
            this.sDDCT1max = sDDCT1max;
            this.sDDGTmin = sDDGTmin;
            this.sDDGT05max = sDDGT05max;
            this.sDDGTmax = sDDGTmax;
            this.sDDCT2min = sDDCT2min;
            this.sDDCT205max = sDDCT205max;
            this.sDDCT2max = sDDCT2max;
            this.sDDmin = sDDmin;
            this.sDD05max = sDD05max;
            this.sDDmax = sDDmax;
            this.sKiemTraDoDong = sKiemTraDoDong;
            //this.sLLMTmin = sLLMTmin;
            //this.sLLMT05max = sLLMT05max;
            //this.sLLMTmax = sLLMTmax;
            this.sLLCT1min = sLLCT1min;
            this.sLLCT105max = sLLCT105max;
            this.sLLCT1max = sLLCT1max;
            this.sLLCT2min = sLLCT2min;
            this.sLLCT205max = sLLCT205max;
            this.sLLCT2max = sLLCT2max;
            this.sLLCT3min = sLLCT3min;
            this.sLLCT305max = sLLCT305max;
            this.sLLCT3max = sLLCT3max;
            this.sLLCLLonmin = sLLCLLonmin;
            this.sLLCLLon05max = sLLCLLon05max;
            this.sLLCLLmax = sLLCLLmax;
            this.sLLCLCPmin = sLLCLCPmin;
            this.sLLCLCP05max = sLLCLCP05max;
            this.sLLCLCPmax = sLLCLCPmax;
            this.sKiemtraLapLai = sKiemtraLapLai;
            this.sLTMucTai = sLTMucTai;
            this.sLTChiThiG = sLTChiThiG;
            this.sLTChiThiI1 = sLTChiThiI1;
            this.sLTChiThiI2 = sLTChiThiI2;
            this.sLTChiThiI3 = sLTChiThiI3;
            this.sLTChiThiI4 = sLTChiThiI4;
            this.sLTCLLN = sLTCLLN;
            this.sLTCLCP = sLTCLCP;
            this.sKiemtraLechTam = sKiemtraLechTam;
            this.sMTL1 = sMTL1;
            this.sMTL2 = sMTL2;
            this.sMTL3 = sMTL3;
            this.sMTL4 = sMTL4;
            this.sMTL5 = sMTL5;
            this.sCTCT1 = sCTCT1;
            this.sCTCT2 = sCTCT2;
            this.sCTCT3 = sCTCT3;
            this.sCTCT4 = sCTCT4;
            this.sCTCT5 = sCTCT5;
            this.sCTCG1 = sCTCG1;
            this.sCTCG2 = sCTCG2;
            this.sCTCG3 = sCTCG3;
            this.sCTCG4 = sCTCG4;
            this.sSST1 = sSST1;
            this.sSST2 = sSST2;
            this.sSST3 = sSST3;
            this.sSST4 = sSST4;
            this.sSST5 = sSST5;
            this.sSSG1 = sSSG1;
            this.sSSG2 = sSSG2;
            this.sSSG3 = sSSG3;
            this.sSSG4 = sSSG4;
            this.sDHS1 = sDHS1;
            this.sDHS2 = sDHS2;
            this.sDHS3 = sDHS3;
            this.sDHS4 = sDHS4;
            this.sSSCP1 = sSSCP1;
            this.sSSCP2 = sSSCP2;
            this.sSSCP3 = sSSCP3;
            this.sSSCP4 = sSSCP4;
            this.sSSCP5 = sSSCP5;
            this.sKiemtraSaiSo = sKiemtraSaiSo;
            this.sKetLuan = sKetLuan;
            this.sDiaChiSD = sDiaChiSD;
            this.Sgcn = sgcn;
        }

        private string sgcn;
        private string sSoBienBan;
        private string sSoCan;
        private string sTenCan;
        private string sKieu;
        private string sCapChinhXac;
        private string sNuocSX;
        private string sNamSX;
        private string sCheDoKD;
        private string sNgayKD;
        private float sMax;
        private float sMin;
        private string sDoChia;
        private string sDoChiaKiem;
        private string sPPTH;
        private string sDonViSD;
        private string sKiemDinhVien;
        private string sSoTem;
        //private string sNguoiSoatLai;
        private string sNhanMac;
        private string sTem;
        private string sDayDu;
        private string sDongHoThangDo;
        private string sBoPhan;
        private string sKiemTraNgoai;
        //private string sDDMTmin;
        //private string sDDMT05max;
        //private string sDDMTmax;
        private string sDDCT1min;
        private string sDDCT105max;
        private string sDDCT1max;
        private string sDDGTmin;
        private string sDDGT05max;
        private string sDDGTmax;
        private string sDDCT2min;
        private string sDDCT205max;
        private string sDDCT2max;
        private string sDDmin;
        private string sDD05max;
        private string sDDmax;
        private string sKiemTraDoDong;

        //private string sLLMTmin;
        //private string sLLMT05max;
        //private string sLLMTmax;
        private string sLLCT1min;
        private string sLLCT105max;
        private string sLLCT1max;
        private string sLLCT2min;
        private string sLLCT205max;
        private string sLLCT2max;
        private string sLLCT3min;
        private string sLLCT305max;
        private string sLLCT3max;
        private string sLLCLLonmin;
        private string sLLCLLon05max;
        private string sLLCLLmax;
        private string sLLCLCPmin;
        private string sLLCLCP05max;
        private string sLLCLCPmax;
        private string sKiemtraLapLai;

        private string sLTMucTai;
        private string sLTChiThiG;
        private string sLTChiThiI1;
        private string sLTChiThiI2;
        private string sLTChiThiI3;
        private string sLTChiThiI4;
        private string sLTCLLN;
        private string sLTCLCP;
        private string sKiemtraLechTam;

        private string sMTL1;
        private string sMTL2;
        private string sMTL3;
        private string sMTL4;
        private string sMTL5;
        private string sCTCT1;
        private string sCTCT2;
        private string sCTCT3;
        private string sCTCT4;
        private string sCTCT5;
        private string sCTCG1;
        private string sCTCG2;
        private string sCTCG3;
        private string sCTCG4;
        private string sSST1;
        private string sSST2;
        private string sSST3;
        private string sSST4;
        private string sSST5;
        private string sSSG1;
        private string sSSG2;
        private string sSSG3;
        private string sSSG4;
        private string sDHS1;
        private string sDHS2;
        private string sDHS3;
        private string sDHS4;
        private string sSSCP1;
        private string sSSCP2;
        private string sSSCP3;
        private string sSSCP4;
        private string sSSCP5;
        private string sKiemtraSaiSo;
        private string sKetLuan;
        private string sDiaChiSD;
        //su dung phim tat ta boi den roi (CTR+R+E)
        public string SSoBienBan { get => sSoBienBan; set => sSoBienBan = value; }
        public string SSoCan { get => sSoCan; set => sSoCan = value; }
        public string STenCan { get => sTenCan; set => sTenCan = value; }
        public string SKieu { get => sKieu; set => sKieu = value; }
        public string SCapChinhXac { get => sCapChinhXac; set => sCapChinhXac = value; }
        public string SNuocSX { get => sNuocSX; set => sNuocSX = value; }
        public string SNamSX { get => sNamSX; set => sNamSX = value; }
        public string SCheDoKD { get => sCheDoKD; set => sCheDoKD = value; }
        public string SNgayKD { get => sNgayKD; set => sNgayKD = value; }
        public float SMax { get => sMax; set => sMax = value; }
        public float SMin { get => sMin; set => sMin = value; }
        public string SDoChia { get => sDoChia; set => sDoChia = value; }
        public string SDoChiaKiem { get => sDoChiaKiem; set => sDoChiaKiem = value; }
        public string SPPTH { get => sPPTH; set => sPPTH = value; }
        public string SDonViSD { get => sDonViSD; set => sDonViSD = value; }
        //public string SDiaChiSD { get => sDiaChiSD; set => sDiaChiSD = value; }
        public string SKiemDinhVien { get => sKiemDinhVien; set => sKiemDinhVien = value; }
        public string SSoTem { get => sSoTem; set => sSoTem = value; }
        //public string SNguoiSoatLai { get => sNguoiSoatLai; set => sNguoiSoatLai = value; }
        public string SNhanMac { get => sNhanMac; set => sNhanMac = value; }
        public string STem { get => sTem; set => sTem = value; }
        public string SDayDu { get => sDayDu; set => sDayDu = value; }
        public string SDongHoThangDo { get => sDongHoThangDo; set => sDongHoThangDo = value; }
        public string SBoPhan { get => sBoPhan; set => sBoPhan = value; }
        public string SKiemTraNgoai { get => sKiemTraNgoai; set => sKiemTraNgoai = value; }
        //public string SDDMTmin { get => sDDMTmin; set => sDDMTmin = value; }
        //public string SDDMT05max { get => sDDMT05max; set => sDDMT05max = value; }
        //public string SDDMTmax { get => sDDMTmax; set => sDDMTmax = value; }
        public string SDDCT1min { get => sDDCT1min; set => sDDCT1min = value; }
        public string SDDCT105max { get => sDDCT105max; set => sDDCT105max = value; }
        public string SDDCT1max { get => sDDCT1max; set => sDDCT1max = value; }
        public string SDDGTmin { get => sDDGTmin; set => sDDGTmin = value; }
        public string SDDGT05max { get => sDDGT05max; set => sDDGT05max = value; }
        public string SDDGTmax { get => sDDGTmax; set => sDDGTmax = value; }
        public string SDDCT2min { get => sDDCT2min; set => sDDCT2min = value; }
        public string SDDCT205max { get => sDDCT205max; set => sDDCT205max = value; }
        public string SDDCT2max { get => sDDCT2max; set => sDDCT2max = value; }
        public string SDDmin { get => sDDmin; set => sDDmin = value; }
        public string SDD05max { get => sDD05max; set => sDD05max = value; }
        public string SDDmax { get => sDDmax; set => sDDmax = value; }
        public string SKiemTraDoDong { get => sKiemTraDoDong; set => sKiemTraDoDong = value; }
        //public string SLLMTmin { get => sLLMTmin; set => sLLMTmin = value; }
        //public string SLLMT05max { get => sLLMT05max; set => sLLMT05max = value; }
        //public string SLLMTmax { get => sLLMTmax; set => sLLMTmax = value; }
        public string SLLCT1min { get => sLLCT1min; set => sLLCT1min = value; }
        public string SLLCT105max { get => sLLCT105max; set => sLLCT105max = value; }
        public string SLLCT1max { get => sLLCT1max; set => sLLCT1max = value; }
        public string SLLCT2min { get => sLLCT2min; set => sLLCT2min = value; }
        public string SLLCT205max { get => sLLCT205max; set => sLLCT205max = value; }
        public string SLLCT2max { get => sLLCT2max; set => sLLCT2max = value; }
        public string SLLCT3min { get => sLLCT3min; set => sLLCT3min = value; }
        public string SLLCT305max { get => sLLCT305max; set => sLLCT305max = value; }
        public string SLLCT3max { get => sLLCT3max; set => sLLCT3max = value; }
        public string SLLCLLonmin { get => sLLCLLonmin; set => sLLCLLonmin = value; }
        public string SLLCLLon05max { get => sLLCLLon05max; set => sLLCLLon05max = value; }
        public string SLLCLLmax { get => sLLCLLmax; set => sLLCLLmax = value; }
        public string SLLCLCPmin { get => sLLCLCPmin; set => sLLCLCPmin = value; }
        public string SLLCLCP05max { get => sLLCLCP05max; set => sLLCLCP05max = value; }
        public string SLLCLCPmax { get => sLLCLCPmax; set => sLLCLCPmax = value; }
        public string SKiemtraLapLai { get => sKiemtraLapLai; set => sKiemtraLapLai = value; }
        public string SLTMucTai { get => sLTMucTai; set => sLTMucTai = value; }
        public string SLTChiThiG { get => sLTChiThiG; set => sLTChiThiG = value; }
        public string SLTChiThiI1 { get => sLTChiThiI1; set => sLTChiThiI1 = value; }
        public string SLTChiThiI2 { get => sLTChiThiI2; set => sLTChiThiI2 = value; }
        public string SLTChiThiI3 { get => sLTChiThiI3; set => sLTChiThiI3 = value; }
        public string SLTChiThiI4 { get => sLTChiThiI4; set => sLTChiThiI4 = value; }
        public string SLTCLLN { get => sLTCLLN; set => sLTCLLN = value; }
        public string SLTCLCP { get => sLTCLCP; set => sLTCLCP = value; }
        public string SKiemtraLechTam { get => sKiemtraLechTam; set => sKiemtraLechTam = value; }
        public string SMTL1 { get => sMTL1; set => sMTL1 = value; }
        public string SMTL2 { get => sMTL2; set => sMTL2 = value; }
        public string SMTL3 { get => sMTL3; set => sMTL3 = value; }
        public string SMTL4 { get => sMTL4; set => sMTL4 = value; }
        public string SMTL5 { get => sMTL5; set => sMTL5 = value; }
        public string SCTCT1 { get => sCTCT1; set => sCTCT1 = value; }
        public string SCTCT2 { get => sCTCT2; set => sCTCT2 = value; }
        public string SCTCT3 { get => sCTCT3; set => sCTCT3 = value; }
        public string SCTCT4 { get => sCTCT4; set => sCTCT4 = value; }
        public string SCTCT5 { get => sCTCT5; set => sCTCT5 = value; }
        public string SCTCG1 { get => sCTCG1; set => sCTCG1 = value; }
        public string SCTCG2 { get => sCTCG2; set => sCTCG2 = value; }
        public string SCTCG3 { get => sCTCG3; set => sCTCG3 = value; }
        public string SCTCG4 { get => sCTCG4; set => sCTCG4 = value; }
        public string SSST1 { get => sSST1; set => sSST1 = value; }
        public string SSST2 { get => sSST2; set => sSST2 = value; }
        public string SSST3 { get => sSST3; set => sSST3 = value; }
        public string SSST4 { get => sSST4; set => sSST4 = value; }
        public string SSST5 { get => sSST5; set => sSST5 = value; }
        public string SSSG1 { get => sSSG1; set => sSSG1 = value; }
        public string SSSG2 { get => sSSG2; set => sSSG2 = value; }
        public string SSSG3 { get => sSSG3; set => sSSG3 = value; }
        public string SSSG4 { get => sSSG4; set => sSSG4 = value; }
        public string SDHS1 { get => sDHS1; set => sDHS1 = value; }
        public string SDHS2 { get => sDHS2; set => sDHS2 = value; }
        public string SDHS3 { get => sDHS3; set => sDHS3 = value; }
        public string SDHS4 { get => sDHS4; set => sDHS4 = value; }
        public string SSSCP1 { get => sSSCP1; set => sSSCP1 = value; }
        public string SSSCP2 { get => sSSCP2; set => sSSCP2 = value; }
        public string SSSCP3 { get => sSSCP3; set => sSSCP3 = value; }
        public string SSSCP4 { get => sSSCP4; set => sSSCP4 = value; }
        public string SSSCP5 { get => sSSCP5; set => sSSCP5 = value; }
        public string SKiemtraSaiSo { get => sKiemtraSaiSo; set => sKiemtraSaiSo = value; }
        public string SKetLuan { get => sKetLuan; set => sKetLuan = value; }
        public string SDiaChiSD { get => sDiaChiSD; set => sDiaChiSD = value; }
        public string Sgcn { get => sgcn; set => sgcn = value; }
    }
}
