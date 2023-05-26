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



    public override string ToString()
    {
      return $"Id:{WydarzenieId}, Nazwa: {Nazwa}, Opis: {Opis}, Początek: {Poczatek}, Koniec: {Koniec}";
    }

    public TimeSpan IlePozostalo
    {
            get
            {
                return Poczatek - DateTime.Now;
            }
    }

        public double IleMinutPozostalo
        {
            get
            {
                return (Poczatek - DateTime.Now).TotalMinutes;
            }
        }

        public TimeSpan CzasTrwania
        {
            get
            {
                return Koniec - Poczatek;
            }
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
