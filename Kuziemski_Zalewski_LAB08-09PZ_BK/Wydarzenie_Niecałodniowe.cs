using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuziemski_Zalewski_LAB08_09PZ_BK
{
    public class Wydarzenie_Niecałodniowe : Wydarzenie
    {
        public DateTime Początek { get; set; }
        public DateTime Koniec { get; set; }


        public override bool CzywDniu(DateOnly dzień)
        {
            return (Początek.Date.Equals(dzień));
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Początek: {Początek}, Koniec: {Koniec}";
        }

        public override TimeSpan IlePozostało(DateTime Teraz)
        {
            return Początek - Teraz;
        }

        public Wydarzenie_Niecałodniowe(String nazwa, String opis, DateTime początek, DateTime koniec) : base(nazwa, opis)
        {
            Początek = początek;
            Koniec = koniec;
        }

    }
}
