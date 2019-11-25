using MetroLibrary;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestTransport_01
{
    class FakeRequette : IRequette
    {
        private readonly string fakeJson = "[{\"id\": \"TEST:1111\", \"name\": \"TEST\", \"lon\": 5.55555, \"lat\": 1.11111, \"zone\": \"TEST_TEST\", \"lines\":[\"TEST:11\", \"TEST:22\"]}]";

        //private readonly dynamic fakeJson = new JObject();
        //fakeJson.id = "TEST:1111";
        //fakeJson.name = "TEST";
        //fakeJson.lon = 5.55555;
        //fakeJson.lon = 1.11111;
        //fakeJson.zone = "TEST_TEST";
        //fakeJson.lines = new JArray("TEST:11", "TEST:22");

        public string RequetteMetro(string x, string y, int z, bool details, string lien)
        {
            return fakeJson;
        }
    }
}
