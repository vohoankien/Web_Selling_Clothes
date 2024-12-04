using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLL_ThongTinAdmin
    {
        DAL_ThongTinAdmin dl = new DAL_ThongTinAdmin();
        public BLL_ThongTinAdmin() { }  
        public bool insertAdmin(thongtinadmin tt)
        {
            return dl.insertAdmin(tt);
        }

        public IQueryable getAllAdmin()
        {
            return dl.getAllAdmin();
        }

        public thongtinadmin findThongTinAdmin(string s)
        {
            return dl.findAdmin(s);
        }
        public bool updateThongTinAdmin(thongtinadmin tt,thongtinadmin ad)
        {
            return dl.updateTTAdmin(tt,ad);
        }

        public bool deleteThongTinAdmin(thongtinadmin tt)
        {
            return dl.deleteThongTinAdmin(tt);
        }

        
    }
}
