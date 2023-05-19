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

        public override string ToString()
        {
            return $"Nazwa: {Nazwa}, Opis: {Opis}";
        }

    }
}
