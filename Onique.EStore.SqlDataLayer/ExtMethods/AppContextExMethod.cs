using Onique.EStore.SqlDataLayer.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onique.EStore.SqlDataLayer.ExtMethods
{
    public static class AppContextExMethod
    {
        public static int GetId<T>(this AppDbContext db,Func<T,bool> where ,Func<T,int> selector) 
            where T : class
        {
            var query = db.Set<T>().Where(where).Select(selector);

            return query.FirstOrDefault();
        }

    }
}
