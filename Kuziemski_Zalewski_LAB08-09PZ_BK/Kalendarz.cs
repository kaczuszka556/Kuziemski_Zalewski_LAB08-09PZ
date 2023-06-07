using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuziemski_Zalewski_LAB08_09PZ_BK
{
    public class KalendarzService
    {

        public void AddWydarznie(Wydarzenie w) //OK
        {
            if (w.Poczatek > w.Koniec)
            {
                throw new KoniecPrzedPoczatkiemException();
            }
            else
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
        }

        public Boolean CzyDzieńZajęty(DateOnly dzień) //OK
        {
            using (var db = new DatabaseContext())
            {
                db.Database.EnsureCreated();
                return db.Wydarzenia.Any(w => w.Poczatek >= dzień.ToDateTime(new TimeOnly(0, 0))
                 && w.Koniec <= dzień.ToDateTime(new TimeOnly(23, 59)));
            }
        }

        public int LiczbaWydarzeńDnia(DateOnly dzień) //OK
        {
            using (var db = new DatabaseContext())
            {
                db.Database.EnsureCreated();
                return db.Wydarzenia.Count(
                    (w => (w.Poczatek >= dzień.ToDateTime(new TimeOnly(0, 0))
                && w.Koniec <= dzień.ToDateTime(new TimeOnly(23, 59,59))) 
                || (dzień.ToDateTime(new TimeOnly(0, 0)) >= w.Poczatek && dzień.ToDateTime(new TimeOnly(0, 0)) <= w.Koniec)
                ||(dzień.ToDateTime(new TimeOnly(23, 59,59)) >= w.Poczatek && dzień.ToDateTime(new TimeOnly(23,59,59))<=w.Koniec)
                ));
            }
        }

        public void DeleteAll() //OK
        {
            using (var db = new DatabaseContext())
            {
                db.Database.EnsureCreated();
                db.RemoveRange(db.Wydarzenia.Where(p => true));
                db.SaveChanges();
            }
        }

        public void DeleteWydarzeniePoId(int id) //OK
        {
            using (var db = new DatabaseContext())
            {
                db.Database.EnsureCreated();
                db.Wydarzenia.RemoveRange(db.Wydarzenia.Where(p => p.WydarzenieId==id));
                db.SaveChanges();
            }
        }

        public void DeleteWydarzeniePoNazwie(String nazwa) //OK
        {
            using (var db = new DatabaseContext())
            {
                db.Database.EnsureCreated();
                db.Wydarzenia.RemoveRange(db.Wydarzenia.Where(p => p.Nazwa.Equals(nazwa)));
                db.SaveChanges();
            }
        }

        public void DeleteWydarzeniaPoDniu(DateOnly dzień) //OK
        {
            using (var db = new DatabaseContext())
            {
                db.Database.EnsureCreated();
                db.Wydarzenia.RemoveRange(db.Wydarzenia.Where((w => (w.Poczatek >= dzień.ToDateTime(new TimeOnly(0, 0))
                && w.Koniec <= dzień.ToDateTime(new TimeOnly(23, 59, 59)))
                || (dzień.ToDateTime(new TimeOnly(0, 0)) >= w.Poczatek && dzień.ToDateTime(new TimeOnly(0, 0)) <= w.Koniec)
                || (dzień.ToDateTime(new TimeOnly(23, 59, 59)) >= w.Poczatek && dzień.ToDateTime(new TimeOnly(23, 59, 59)) <= w.Koniec)
                )));
                db.SaveChanges();
            }
        }

        public int LiczbaWydarzeń //OK
        {
            get
            {
                using (var db = new DatabaseContext())
                {
                    db.Database.EnsureCreated();
                    return db.Wydarzenia.Count();
                }
            }
        }

        public Wydarzenie ZnajdżWydarzeniePoNazwie(String nazwa) //OK
        {
            using (var db = new DatabaseContext())
            {
                db.Database.EnsureCreated();
                return db.Wydarzenia.Where(w => w.Nazwa.Equals(nazwa)).First();
            }
        }

        public Wydarzenie NajblizszeWydarzenie //OK
        {
            get
            {
                using (var db = new DatabaseContext())
                {
                    db.Database.EnsureCreated();
                    DateTime teraz = DateTime.Now;
                    return db.Wydarzenia.Where(w=>w.Koniec.CompareTo(teraz)>0).OrderBy(w => w.Poczatek).First();
                }
            }
        }

        public List<Wydarzenie> ZnajdżWydarzeniaDnia(DateOnly dzień) //OK
        { 
            using (var db = new DatabaseContext())
            {
                db.Database.EnsureCreated();
                return db.Wydarzenia.Where(
                      (w => (w.Poczatek >= dzień.ToDateTime(new TimeOnly(0, 0))
                && w.Koniec <= dzień.ToDateTime(new TimeOnly(23, 59, 59)))
                || (dzień.ToDateTime(new TimeOnly(0, 0)) >= w.Poczatek && dzień.ToDateTime(new TimeOnly(0, 0)) <= w.Koniec)
                || (dzień.ToDateTime(new TimeOnly(23, 59, 59)) >= w.Poczatek && dzień.ToDateTime(new TimeOnly(23, 59, 59)) <= w.Koniec)
                ))
                .ToList();
            }
        }
    }
}
