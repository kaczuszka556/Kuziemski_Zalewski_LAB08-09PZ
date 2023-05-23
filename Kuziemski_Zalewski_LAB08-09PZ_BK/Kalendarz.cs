using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuziemski_Zalewski_LAB08_09PZ_BK
{
    public class Kalendarz
    {

        public void AddWydarznie(Wydarzenie w)
        {
            using (var db = new DatabaseContext())
            {
                db.Database.EnsureCreated();
                if (db.Wydarzenia.All(p => p.Nazwa != w.Nazwa))
                {
                    db.Wydarzenia.Add(w);
                    db.SaveChanges();

                    foreach (var p in db.Wydarzenia)
                    {
                        Console.WriteLine(p.ToString());
                    }
                }
                else
                {
                    throw new NazwaZajętaException();
                }
            }
        }

        public Boolean CzyDzieńZajęty(DateOnly dzień)
        {
            using (var db = new DatabaseContext())
            {
              return db.Wydarzenia.Any(p => p.CzywDniu(dzień));
            }
        }

        public int LiczbaWydarzeńDnia(DateOnly dzień)
        {
            using (var db = new DatabaseContext())
            {
                return db.Wydarzenia.Count(p => p.CzywDniu(dzień));
            }
        }

        public void DeleteWydarzenie(Wydarzenie w) 
        {
            using (var db = new DatabaseContext())
            {
                db.Wydarzenia.Remove(w);
            }
        }

        public void DeleteWydarzeniePoNazwie(String nazwa)
        {
            using (var db = new DatabaseContext())
            {
                db.Wydarzenia.RemoveRange(db.Wydarzenia.Where(p => p.Nazwa==nazwa));
                db.SaveChanges();
            }
        }

        public void DeleteWydarzeniaPoDniu(DateOnly dzień)
        {
            using (var db = new DatabaseContext())
            {
                db.Wydarzenia.RemoveRange(db.Wydarzenia.Where(p=>p.CzywDniu(dzień)));
                db.SaveChanges();
            }
        }

        public int LiczbaWydarzeń()
        {
            using (var db = new DatabaseContext())
            {
               return db.Wydarzenia.Count();
            }
        }

        public Wydarzenie ZnajdżWydarzeniePoNazwie(String nazwa)
        {
            using (var db = new DatabaseContext())
            {
                return db.Wydarzenia.Where(w => w.Nazwa.Equals(nazwa)).First();
            }
        }

        public Wydarzenie NajblizszeWydarzenie(DateTime teraz)
        {
            using (var db = new DatabaseContext())
            {
                return db.Wydarzenia.OrderBy(w => w.IlePozostało(teraz)).First();
            }
        }

        public List<Wydarzenie> ZnajdżWydarzeniaDnia(DateOnly dzień)
        { 
            using (var db = new DatabaseContext())
            {
                return db.Wydarzenia.Where(w => w.CzywDniu(dzień)).ToList();
            }
        }
    }
}
