using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuziemski_Zalewski_LAB08_09PZ_BK
{
    public abstract class Wydarzenie
    {
    public String Nazwa{get;set;}
    public String Opis { get; set; }
    public abstract Boolean CzywDniu(DateOnly dzień);
    public abstract TimeSpan IlePozostało(DateTime Teraz);
        public override string ToString()
        {
            return $"Nazwa: {Nazwa}, Opis: {Opis}";
        }

        protected Wydarzenie(string nazwa, string opis)
        {
            Nazwa = nazwa;
            Opis = opis;
        }
    }
}
