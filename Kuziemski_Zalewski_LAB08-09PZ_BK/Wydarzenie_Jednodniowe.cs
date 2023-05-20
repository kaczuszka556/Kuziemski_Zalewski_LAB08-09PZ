using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuziemski_Zalewski_LAB08_09PZ_BK
{
    public class Wydarzenie_Jednodniowe: Wydarzenie
    {
        public DateOnly Data { get; set; }

        public override bool CzywDniu(DateOnly dzień)
        {
            return (Data == dzień);
        }

        public override TimeSpan IlePozostało(DateTime Teraz)
        {
            return Data.ToDateTime(TimeOnly.Parse("00:00 AM")) - Teraz;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Data: {Data}";
        }

        public Wydarzenie_Jednodniowe(String nazwa, String opis,DateOnly data): base(nazwa,opis)
        {
            Data = data;
        }
    }
}
