using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MetroLibrary
{
    public class Metro
    {
        private IRequette requette;

        public Metro()
        {
            requette = new Requette();
        }

        public Metro(IRequette faker)
        {
            requette = faker;
        }

        public Dictionary<string, SerializeProxima> GetLinesMetro(string latitude = "5.727718", string longitude = "45.185603", int distance = 500, bool details = false, string lien = "http://data.metromobilite.fr/api/linesNear/json?x=5.727718&y=45.185603&dist=500&details=true")
        {
            Dictionary<string, SerializeProxima> retour = LinesMetro(latitude, longitude, distance, details, lien = "http://data.metromobilite.fr/api/linesNear/json?x=5.727718&y=45.185603&dist=500&details=true");
            return retour;
        }

        private Dictionary<string, SerializeProxima> LinesMetro(string x, string y, int z, bool details, string lien = "http://data.metromobilite.fr/api/linesNear/json?x=5.727718&y=45.185603&dist=500&details=true")
        {
            //Requette requette = new Requette();
            string RetourJson;
            RetourJson = requette.RequetteMetro(x, y, z, details, lien);

            IList<SerializeProxima> serializeproxima = JsonConvert.DeserializeObject<List<SerializeProxima>>(RetourJson);

            Dictionary<string, SerializeProxima> arretsAndLines = new Dictionary<string, SerializeProxima>();

            foreach (SerializeProxima metro in serializeproxima)
            {
                if (!arretsAndLines.ContainsKey(metro.Name) == true)
                {
                    arretsAndLines.Add(metro.Name, metro);
                }

                foreach (string line in metro.Lines)
                {
                    if (!arretsAndLines[metro.Name].Lines.Contains(line) == true)
                    {
                        arretsAndLines[metro.Name].Lines.Add(line);
                    }
                }
            }
            return arretsAndLines;
        }
    }
}
