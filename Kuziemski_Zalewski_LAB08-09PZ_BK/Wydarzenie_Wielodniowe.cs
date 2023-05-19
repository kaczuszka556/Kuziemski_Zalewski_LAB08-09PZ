using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuziemski_Zalewski_LAB08_09PZ_BK
{
    public class Wydarzenie_Wielodniowe: Wydarzenie
    {
        public DateOnly Data_Rozpoczęcia { get; set; }
        public DateOnly Data_Zakończenia { get; set; }

        public override bool CzywDniu(DateOnly dzień)
        {
            return (dzień >= Data_Rozpoczęcia && dzień <= Data_Zakończenia);
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Data Rozpoczęcia: {Data_Rozpoczęcia}, Data Zakończenia: {Data_Zakończenia}";
        }

    }
}
