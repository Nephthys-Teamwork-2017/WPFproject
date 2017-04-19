using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Store
{
    public class BlankStore
    {
        public static IEnumerable<string> GetAllBlankNumbers()
        {
            using (var context = new BrokerDbContext())
            {
                return context.Blanks.Where(x => x.IsDeleted == false).Select(x => x.Number.ToString()).ToList();
            }

        }

        public static int GetBlankIdByNumber(string Number)
        {
            using (var context = new BrokerDbContext())
            {
                return context.Blanks.Where(x => x.IsDeleted == false && x.Number==Number).FirstOrDefault().Id;
            }

        }


    }
}
