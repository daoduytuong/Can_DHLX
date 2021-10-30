using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Tem_DTO
    {
        private string sTem;
        private string sTrangThai;
        public string STem
        {
           get { return sTem;  }
           set { sTem = value;  }
        }

        public string STrangThai
        {
            get { return sTrangThai; }
            set { sTrangThai = value; }
        }
    }
}
