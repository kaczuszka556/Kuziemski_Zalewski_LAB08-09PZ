
using Kuziemski_Zalewski_LAB08_09PZ_BK;

namespace Test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KalendarzService service = new KalendarzService();
            String jezyk = "pl-PL";
            service.UstawJezyk(jezyk);
            String jezyk2 = service.PobierzJezyk();
            Console.WriteLine(jezyk2);
            jezyk = "en-US";
            service.UstawJezyk(jezyk);
            jezyk2 = service.PobierzJezyk();
            Console.WriteLine(jezyk2);
        }
    }
}