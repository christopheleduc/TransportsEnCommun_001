using MetroLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;

namespace TestTransport_01
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Metro retour = new Metro(new FakeRequette());
            Dictionary<string, SerializeProxima> result = retour.GetLinesMetro();

            string id = "TEST:1111";
            string name = "TEST";
            double lon = 5.55555;
            double lat = 1.11111;
            string zone = "TEST_TEST";
            IList<string> lines = new List<string> { "TEST:11", "TEST:22" };

            //string result = target.Afficher(name);
            Assert.AreEqual(id, result[name].Id);
            Assert.AreEqual(name, result[name].Name);
            Assert.AreEqual(lon, result[name].Lon);
            Assert.AreEqual(lat, result[name].Lat);
            Assert.AreEqual(zone, result[name].Zone);
            Assert.AreEqual(lines[0], result[name].Lines[0]);
            Assert.AreEqual(lines[1], result[name].Lines[1]);
        }
    }
}
