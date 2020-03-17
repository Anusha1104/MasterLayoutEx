using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasterLayoutEx.Models
{
    public class ODOps
    {
        static DemoEntities D = new DemoEntities();

        public static List<EMPDATA> GetAll()
        {
            var E = from E1 in D.EMPDATAs
                    select E1;
            return E.ToList();
        
        }
        public static EMPDATA GetEmp(int id)
        {
            var E = from E1 in D.EMPDATAs
                    where E1.EMPNO==id
                    select E1;
            return E.First();

        }

    }
}