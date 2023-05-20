using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuziemski_Zalewski_LAB08_09PZ_BK
{
    public static class Narzędziowa
    {
        private static int[] DniWMiesiacach = {31,0,31,30,31,30,31,31,30,31,30,31};

        public static Boolean CzyPrzestępny(int rok)
        {
            return (Math.Abs(rok - 2024) % 4 == 0);
        }

        public static int DniWMiesiacu(int miesiąc,int rok)
        {
            if (miesiąc > 12 || miesiąc < 1)
            {
                throw new ZłyMiesiącException();
            }

            else 
            { 
                if (miesiąc == 2)
                {
                    if (CzyPrzestępny(rok))
                    {
                        return 29;
                    }
                    else
                    {
                        return 28;
                    }
                }
                else 
                { 
                    return DniWMiesiacach[miesiąc - 1];
                }
            }
        }

        public static int PierwszyDzień(int miesiąc, int rok)
        {
            if (miesiąc > 12 || miesiąc < 1)
            {
                throw new ZłyMiesiącException();
            }
            else
            {
                DateOnly data = new DateOnly(rok, miesiąc, 1);
                return ((int)data.DayOfWeek);
            }
        }
    }
}
