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
                if (jezyk != "pl" && jezyk != "en")
                {
                    throw new NieprawidlowyJezykException();
                }


                if (db.Preferencjes.Count(x => true) == 0)
                {
                    Preferencje dp = new Preferencje { PreferencjeId = 1, Jezyk = "pl" };
                    db.Preferencjes.Add(dp);
                    db.SaveChanges();
                }

                else
                {
                    Preferencje pom = db.Preferencjes.Where(p => true).First();
                    pom.Jezyk = jezyk;
                    db.SaveChanges();
                }

            }
        }

        public String PobierzJezyk()
        {
            using (var db = new DatabaseContext())
            {
                db.Database.EnsureCreated();

                if (db.Preferencjes.Count(x => true) == 0)
                {
                    Preferencje dp = new Preferencje { PreferencjeId = 1, Jezyk = "pl" };
                    db.Preferencjes.Add(dp);
                    db.SaveChanges();
                }
                Preferencje p = db.Preferencjes.Take(1).First();
                return p.Jezyk;
            }
        }
    }
}