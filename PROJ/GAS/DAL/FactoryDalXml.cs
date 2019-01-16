using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
     public class FactoryDalXml
    {
         static Idal dal = null;
         public static Idal getdal()
        {
            if (dal == null)
                dal = new DAL_IMP();
            return dal;
        }
    }
}
