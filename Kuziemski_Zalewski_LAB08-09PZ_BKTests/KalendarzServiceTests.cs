using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kuziemski_Zalewski_LAB08_09PZ_BK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Kuziemski_Zalewski_LAB08_09PZ_BK.Tests
{
    [TestClass()]
    public class KalendarzServiceTests
    {
        [TestMethod()]
        public void AddWydarznieTest()
        {
            DateTime p1 = new DateTime(2023, 10, 10, 21, 30, 5);
            DateTime p2 = new DateTime(2023, 10, 10, 23, 30, 5);
            Wydarzenie w1 = new Wydarzenie("Wydarzenie 1", "grfrgrtrtgttgewfrtge", p1, p2);
            KalendarzService service = new KalendarzService();
            service.DeleteAll();
            service.AddWydarznie(w1);
            Assert.AreEqual(1, service.LiczbaWydarzeńDnia(new DateOnly(2023, 10, 10)));
        }

        [TestMethod()]
        public void CzyDzieńZajętyTest()
        {
            DateTime p1 = new DateTime(2023, 10, 10, 21, 30, 5);
            DateTime p2 = new DateTime(2023, 10, 10, 23, 30, 5);
            Wydarzenie w1 = new Wydarzenie("Wydarzenie 1", "grfrgrtrtgttgewfrtge", p1, p2);
            KalendarzService service = new KalendarzService();
            service.DeleteAll();
            service.AddWydarznie(w1);
            Assert.AreEqual(true, service.CzyDzieńZajęty(new DateOnly(2023, 10, 10)));
        }

        [TestMethod()]
        public void LiczbaWydarzeńDniaTest()
        {
            DateTime p1 = new DateTime(2023, 10, 10, 21, 30, 5);
            DateTime p2 = new DateTime(2023, 10, 10, 23, 30, 5);
            DateTime p3 = new DateTime(2023, 10, 10, 10, 30, 5);
            DateTime p4 = new DateTime(2023, 10, 10, 15, 30, 5);
            Wydarzenie w1 = new Wydarzenie("Wydarzenie 1", "grfrgrtrtgttgewfrtge", p1, p2);
            Wydarzenie w2 = new Wydarzenie("Wydarzenie 2", "hyfgbssdfgfsfdsfggdf", p3, p4);
            KalendarzService service = new KalendarzService();
            service.DeleteAll();
            service.AddWydarznie(w1);
            service.AddWydarznie(w2);
            Assert.AreEqual(2, service.LiczbaWydarzeńDnia(new DateOnly(2023, 10, 10)));
        }

        [TestMethod()]
        public void DeleteAllTest()
        {
            DateTime p1 = new DateTime(2023, 10, 10, 21, 30, 5);
            DateTime p2 = new DateTime(2023, 10, 10, 23, 30, 5);
            Wydarzenie w1 = new Wydarzenie("Wydarzenie 3", "grfrgrtrtgttgewfrtge", p1, p2);
            KalendarzService service = new KalendarzService();
            service.AddWydarznie(w1);
            service.DeleteAll();
            Assert.AreEqual(0,service.LiczbaWydarzeń);
        }

        [TestMethod()]
        public void DeleteWydarzeniePoIdTest()
        {
            DateTime p1 = new DateTime(2023, 10, 10, 21, 30, 5);
            DateTime p2 = new DateTime(2023, 10, 10, 23, 30, 5);
            Wydarzenie w1 = new Wydarzenie("Wydarzenie 1", "grfrgrtrtgttgewfrtge", p1, p2);
            KalendarzService service = new KalendarzService();
            service.DeleteAll();
            service.AddWydarznie(w1);
            int pom = service.LiczbaWydarzeń;
            Wydarzenie w3 = service.ZnajdżWydarzeniePoNazwie("Wydarzenie 1");
            service.DeleteWydarzeniePoId(w3.WydarzenieId);
            Assert.AreEqual(1,pom-service.LiczbaWydarzeń);
        }

        [TestMethod()]
        public void DeleteWydarzeniePoNazwieTest()
        {
            DateTime p1 = new DateTime(2023, 10, 10, 21, 30, 5);
            DateTime p2 = new DateTime(2023, 10, 10, 23, 30, 5);
            Wydarzenie w1 = new Wydarzenie("Wydarzenie X", "grfrgrtrtgttgewfrtge", p1, p2);
            KalendarzService service = new KalendarzService();
            service.AddWydarznie(w1);
            int pom = service.LiczbaWydarzeń;
            service.DeleteWydarzeniePoNazwie("Wydarzenie X");
            Assert.AreEqual(1,pom-service.LiczbaWydarzeń);
        }

        [TestMethod()]
        public void DeleteWydarzeniaPoDniuTest()
        {
            DateTime p1 = new DateTime(2023, 10, 10, 21, 30, 5);
            DateTime p2 = new DateTime(2023, 10, 10, 23, 30, 5);
            DateTime p3 = new DateTime(2023, 10, 10, 10, 30, 5);
            DateTime p4 = new DateTime(2023, 10, 10, 15, 30, 5);
            Wydarzenie w1 = new Wydarzenie("Wydarzenie 1", "grfrgrtrtgttgewfrtge", p1, p2);
            Wydarzenie w2 = new Wydarzenie("Wydarzenie 2", "hyfgbssdfgfsfdsfggdf", p3, p4);
            KalendarzService service = new KalendarzService();
            service.DeleteAll();
            service.AddWydarznie(w1);
            service.AddWydarznie(w2);
            int pom = service.LiczbaWydarzeń;
            service.DeleteWydarzeniaPoDniu(new DateOnly(2023, 10, 10));
            Assert.AreEqual(2, pom - service.LiczbaWydarzeń);
        }

        [TestMethod()]
        public void ZnajdżWydarzeniePoNazwieTest()
        {
            DateTime p1 = new DateTime(2023, 10, 10, 21, 30, 5);
            DateTime p2 = new DateTime(2023, 10, 10, 23, 30, 5);
            DateTime p3 = new DateTime(2023, 10, 10, 10, 30, 5);
            DateTime p4 = new DateTime(2023, 10, 10, 15, 30, 5);
            Wydarzenie w1 = new Wydarzenie("Wydarzenie 1", "grfrgrtrtgttgewfrtge", p1, p2);
            Wydarzenie w2 = new Wydarzenie("Wydarzenie 2", "hyfgbssdfgfsfdsfggdf", p3, p4);
            KalendarzService service = new KalendarzService();
            service.DeleteAll();
            service.AddWydarznie(w1);
            service.AddWydarznie(w2);
            Wydarzenie w3 = service.ZnajdżWydarzeniePoNazwie("Wydarzenie 2");
            Assert.AreEqual(w3.Opis, "hyfgbssdfgfsfdsfggdf");
        }

        [TestMethod()]
        public void ZnajdżWydarzeniaDniaTest()
        {
            DateTime p1 = new DateTime(2023, 10, 10, 21, 30, 5);
            DateTime p2 = new DateTime(2023, 10, 10, 23, 30, 5);
            DateTime p3 = new DateTime(2023, 10, 10, 10, 30, 5);
            DateTime p4 = new DateTime(2023, 10, 10, 15, 30, 5);
            Wydarzenie w1 = new Wydarzenie("Wydarzenie 1", "grfrgrtrtgttgewfrtge", p1, p2);
            Wydarzenie w2 = new Wydarzenie("Wydarzenie 2", "hyfgbssdfgfsfdsfggdf", p3, p4);
            KalendarzService service = new KalendarzService();
            service.DeleteAll();
            service.AddWydarznie(w1);
            service.AddWydarznie(w2); 
            Assert.AreEqual(2,service.ZnajdżWydarzeniaDnia(new DateOnly(2023, 10, 10)).Count());
        }
    }
}