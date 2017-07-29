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
                var currentUnitTypes = db.UnitTypes.ToList();

                db.UnitTypes.RemoveRange(currentUnitTypes);

                var newUnitTypes = UnitType.SeedUnitTypes();
                db.UnitTypes.AddRange(newUnitTypes);
                db.SaveChanges();

                var query = db.UnitTypes.OrderBy(ut => ut.Id);

                foreach (var item in query)
                {
                    Debug.WriteLine(item.Name);
                }

            }
        }
    }
}
