using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuziemski_Zalewski_LAB08_09PZ_BK
{
    public class PreferencjeService
    {
        public void UstawJezyk(String jezyk)
        {
            using (var db = new DatabaseContext())
            {
                db.Database.EnsureCreated();
                //db.SaveChanges();
                if (jezyk != "pl" && jezyk != "en")
                {
                    throw new NieprawidlowyJezykException();
                }

                db.Preferencjes.RemoveRange(db.Preferencjes.Where(p => true));
                db.SaveChanges();
                Preferencje p = new Preferencje { Jezyk = jezyk };
                db.Preferencjes.Add(p);
                db.SaveChanges();
            }
        }

        public String PobierzJezyk()
        {
            using (var db = new DatabaseContext())
            {
                db.Database.EnsureCreated();
                Preferencje p = db.Preferencjes.Take(1).First();
                return p.Jezyk;
            }
        }
    }
}
