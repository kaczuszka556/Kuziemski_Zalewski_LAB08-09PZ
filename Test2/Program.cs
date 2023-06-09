
using Kuziemski_Zalewski_LAB08_09PZ_BK;

namespace Test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PreferencjeService service = new PreferencjeService();
            String jezyk = "pl";
            service.UstawJezyk(jezyk);
            String jezyk2 = service.PobierzJezyk();
            Console.WriteLine(jezyk2);
            jezyk = "en";
            service.UstawJezyk(jezyk);
            jezyk2 = service.PobierzJezyk();
            Console.WriteLine(jezyk2);
        }
    }
}