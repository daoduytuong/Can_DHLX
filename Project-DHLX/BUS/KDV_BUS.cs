using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class KDV_BUS
    {
        public static List<KDV_DTO> LayKDV()
        {
            return KDV_DAO.LayKDV();
        }

    }
}
