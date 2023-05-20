using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuziemski_Zalewski_LAB08_09PZ_BK
{
    public class Kalendarz: List<Wydarzenie>
    {
        //public String LoginBD { get;set;}
        //public String PasswordBD { get;set;}
        //public String UrlDB {get;set;}

        public void AddWydarznie(Wydarzenie w)
        {
            if (this.All(p => p.Nazwa != w.Nazwa))
            {
                this.Add(w);
            }

            else 
            {
                throw new NazwaZajętaException();
            }
        }

        public Boolean CzyDzieńZajęty(DateOnly dzień)
        {
            return this.Any(p => p.CzywDniu(dzień));
        }

        public int LiczbaWydarzeńDnia(DateOnly dzień)
        {
            return this.Count(p => p.CzywDniu(dzień));
        }

        public void DeleteWydarzenie(Wydarzenie w) 
        {
        this.Remove(w);
        }

        public void DeleteWydarzeniePoNazwie(String nazwa)
        {
            this.RemoveAll(w=>w.Nazwa==nazwa);
        }

        public void DeleteWydarzeniaPoDniu(DateOnly dzień)
        {
            this.RemoveAll(w => w.CzywDniu(dzień));
        }

        public int LiczbaWydarzeń()
        {
            return this.Count();
        }

        public Wydarzenie ZnajdżWydarzeniePoNazwie(String nazwa)
        {
            return this.Where(w => w.Nazwa.Equals(nazwa)).First();
        }

        public Wydarzenie NajblizszeWydarzenie(DateTime teraz)
        {
            return this.OrderBy(w => w.IlePozostało(teraz)).First();
        }

        public List<Wydarzenie> ZnajdżWydarzeniaDnia(DateOnly dzień)
        { 
        return this.Where(w=>w.CzywDniu(dzień)).ToList();
        }
    }
}
