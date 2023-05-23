using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuziemski_Zalewski_LAB08_09PZ_BK
{
    public class Wydarzenie
    {

    public int WydarzenieId { get; set; }
    public String Nazwa{get;set;}
    public String Opis { get; set; }

    public DateTime Poczatek { get; set; }
    public DateTime Koniec { get; set; }


    public bool CzywDniu(DateOnly dzień)
    {
      return (Poczatek.Date.Equals(dzień));
    }

    public override string ToString()
    {
      return $"Nazwa: {Nazwa}, Opis: {Opis}, Początek: {Poczatek}, Koniec: {Koniec}";
    }

    public TimeSpan IlePozostało(DateTime Teraz)
    {
       return Poczatek - Teraz;
    }


        public Wydarzenie(String nazwa,String opis,DateTime poczatek, DateTime koniec) 
        { 
            this.Nazwa = nazwa ;
            this.Opis=opis ;
            this.Poczatek = poczatek;
            this.Koniec = koniec;
        }

    }
}
