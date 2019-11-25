using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MetroLibrary
{
    public class Requette : IRequette
    {
        public string RequetteMetro (string x, string y, int z, bool details, string lien)
        {
            WebRequest request = WebRequest.Create($"{lien}");

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Console.WriteLine(response.StatusDescription);

            Stream dataStream = response.GetResponseStream();

            StreamReader reader = new StreamReader(dataStream);

            //List<SerializeProxima> serializeproxima = JsonConvert.DeserializeObject<List<SerializeProxima>>(reader.ReadToEnd());

            string responseFromServer = reader.ReadToEnd();

            reader.Close();
            dataStream.Close();
            response.Close();

            return responseFromServer;
        }
    }
}
