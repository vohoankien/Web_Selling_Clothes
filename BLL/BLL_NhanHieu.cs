using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLL_NhanHieu
    {
        DAL_NhanHieu dl = new DAL_NhanHieu();
        public BLL_NhanHieu() { }
        public IQueryable getAllNhanHieu()
        {
            return dl.getAllNhanHieu();
        }

        public string GenerateMaNhanHieu()
        {
            return dl.GenerateMaNhanHieu();
        }

        public bool insertNhanHieu(nhanhieu lsp)
        {
            return dl.insertNhanHieu(lsp);
        }
        public bool deleteNhanHieu(nhanhieu lsp)
        {
            return dl.deleteNhanHieu(lsp);
        }

        public bool updateNhanHieu(string ten,string qg, nhanhieu lsp)
        {
            return dl.updateNhanHieu(ten,qg, lsp);
        }

        public nhanhieu findNhanHieu(string s)
        {
            return dl.findNhanHieu(s);
        }
    }
}
