using Kuziemski_Zalewski_LAB08_09PZ_BK;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KalendarzService k = new KalendarzService();
           // k.DeleteWydarzeniePoNazwie("Wydarzenie 1");
            k.DeleteAll();

            DateTime p1 = new DateTime(2023, 10, 10, 21, 30, 5);
           DateTime p2 = new DateTime(2023, 10, 10, 23, 30, 5);
            Wydarzenie w1=new Wydarzenie("Wydarzenie 1","grfrgrtrtgttgewfrtge",p1,p2);
           k.AddWydarznie(w1);
            

          
            
            Console.WriteLine(k.LiczbaWydarzeń);
            Console.WriteLine(k.ZnajdżWydarzeniaDnia(new DateOnly(2023,10,10)).First().ToString());
            Console.WriteLine(k.ZnajdżWydarzeniePoNazwie("Wydarzenie 1").ToString());
            Console.WriteLine(k.LiczbaWydarzeńDnia(new DateOnly(2023, 10, 10)));
            Console.WriteLine(k.CzyDzieńZajęty(new DateOnly(2023, 10, 10)));
            Console.WriteLine(k.CzyDzieńZajęty(new DateOnly(2023, 10, 11)));
            k.DeleteWydarzeniePoId(10);
            Console.WriteLine(k.NajblizszeWydarzenie.ToString()+"....");
            // k.DeleteWydarzeniaPoDniu(new DateOnly(2023, 10, 10));
            Console.WriteLine(k.LiczbaWydarzeń);


            //k.
            //Console.WriteLine(k.NajblizszeWydarzenie.ToString());
            // k.ZnajdżWydarzeniaDnia

            Console.WriteLine(Narzędziowa.KtóryTydzień(new DateOnly(2021, 05, 02)));
            Console.WriteLine("Hello, World!");
        }
    }
}