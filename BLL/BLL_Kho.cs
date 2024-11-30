using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class BLL_Kho
    {
        DAL_Kho dl = new DAL_Kho();
        public BLL_Kho() { }
        public IQueryable getAllKho()
        {
            return dl.getAllKho();
        }

        public string GenerateMaKho()
        {
            return dl.GenerateMaKho();
        }

        public bool insertKho(kho lsp)
        {
            return dl.insertKho(lsp);
        }
        public bool deleteKho(kho lsp)
        {
            return dl.deleteKho(lsp);
        }

        public bool updateKho(string ten,  kho lsp)
        {
            return dl.updateKho(ten, lsp);
        }

        public kho findKho(string s)
        {
            return dl.findKho(s);
        }

    }
}
