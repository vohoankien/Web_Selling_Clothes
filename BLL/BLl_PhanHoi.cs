using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using BLL;
using DAL;
namespace BLL
{
    public class BLl_PhanHoi
    {
        DAL_PhanHoi dl =new DAL_PhanHoi();
        public BLl_PhanHoi() { }
        public string GenerateMaPhanHoi()
        {
            return dl.GenerateMaPhanHoi();
        }
        public phanhoi findPhanHoi(string s)
        {
            return dl.findPhanHoi(s);
        }

        public bool insertPhanHoi(phanhoi lsp)
        {
            return dl.insertPhanHoi(lsp);
        }
        public bool updatePhanHoi(string madg , phanhoi lsp)
        {
            return dl.updatePhanHoi(madg, lsp);
        }

    }
}
