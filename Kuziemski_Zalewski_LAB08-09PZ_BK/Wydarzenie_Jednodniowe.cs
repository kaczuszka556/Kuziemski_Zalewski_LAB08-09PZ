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

        public override string ToString()
        {
            return $"{base.ToString()}, Data: {Data}";
        }

    }
}
