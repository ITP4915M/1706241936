using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class DISetBLL
    {
        DISetDAL dISetDAL = new DISetDAL();
        public List<DISet> GetDISets(string orderid) {
            return dISetDAL.SelectDIset(orderid);
        }



        public void addDISets(List<DISet> dISets) {
            foreach (DISet diset in dISets)
            {
                dISetDAL.InsertDISet(diset);
            }

        }
    }

   
}
