using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kuziemski_Zalewski_LAB08_09PZ_BK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuziemski_Zalewski_LAB08_09PZ_BK.Tests
{
    [TestClass()]
    public class PreferencjeServiceTests
    {
     [TestMethod()]
        public void JezykTest()
        {
            PreferencjeService service = new PreferencjeService();
            String jezyk = "pl";
            service.UstawJezyk(jezyk);
            String jezyk2 = service.PobierzJezyk();
            Assert.Equals(jezyk, jezyk2);
        }
    }
}