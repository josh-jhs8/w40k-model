using DbModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Db
{
    public class QuickTest
    {
        public static void TestDb()
        {
            using (var db = new W40kDbContext())
            {
                var unitType = new UnitType { Name = "Elite" };

                db.UnitTypes.Add(unitType);
                db.SaveChanges();

                var query = db.UnitTypes.OrderBy(ut => ut.Name);

                foreach (var item in query)
                {
                    Debug.WriteLine(item.Name);
                }

            }
        }
    }
}
