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

        public override TimeSpan IlePozostało(DateTime Teraz)
        {
            return Data_Rozpoczęcia.ToDateTime(TimeOnly.Parse("00:00 AM")) - Teraz;
        }

        public Wydarzenie_Wielodniowe(String nazwa, String opis, DateOnly data_Rozpoczęcia, DateOnly data_Zakończenia) : base(nazwa, opis)
        {
            Data_Rozpoczęcia = data_Rozpoczęcia;
            data_Zakończenia = data_Zakończenia;
        }

    }
}
