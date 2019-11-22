using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TransportsEnCommun_001
{
    public class MetroRequests
    {
        public string GetLinesNear()
        {
            string retour = LinesNear();
            return retour;
        }

        public IList<SerializeProxima> GetLinesNearProx(string latitude = "5.727718", string longitude = "45.185603", int distance = 500, bool details = false)
        {
            IList<SerializeProxima> retour = LinesNearProx(latitude, longitude, distance, details);
            return retour;
        }

        public string GetLinesNearProxJson(string latitude = "5.727718", string longitude = "45.185603", int distance = 500, bool details = false)
        {
            string retour = LinesNearProxJson(latitude, longitude, distance, details);
            return retour;
        }


        private string LinesNear()
        {

            WebRequest request = WebRequest.Create("https://data.metromobilite.fr/api/routers/default/index/routes");

            HttpWebResponse response2 = (HttpWebResponse)request.GetResponse();

            Console.WriteLine(response2.StatusDescription);

            Stream dataStream = response2.GetResponseStream();

            StreamReader reader = new StreamReader(dataStream);

            string responseFromServer = reader.ReadToEnd();

            reader.Close();
            dataStream.Close();
            response2.Close();

            IList<SerializeData> serializedata = JsonConvert.DeserializeObject<IList<SerializeData>>(responseFromServer);

            // Format JSON depuis une string:
            string json = JsonConvert.SerializeObject(serializedata, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });

            //IList<SerializeData> dataobject1 = JsonConvert.DeserializeObject<IList<SerializeData>>(json, new JsonSerializerSettings
            //{
            //    ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor
            //});

            //SerializeData dataobjet1 = JsonConvert.DeserializeObject<SerializeData>(json);
            //SerializeData serializedata = JsonConvert.DeserializeObject<SerializeData>(json);

            //return dataobject1;
            return json;
            //return o.ToString();
            //return serializedata;
            //return responseFromServer;
        }

        private IList<SerializeProxima> LinesNearProx(string x, string y, int z, bool details)
        {

            WebRequest request = WebRequest.Create($"http://data.metromobilite.fr/api/linesNear/json?x={x}&y={y}&dist={z}&details={details}");

            HttpWebResponse response2 = (HttpWebResponse)request.GetResponse();

            Console.WriteLine(response2.StatusDescription);

            Stream dataStream = response2.GetResponseStream();

            StreamReader reader = new StreamReader(dataStream);

            //List<SerializeProxima> serializeproxima = JsonConvert.DeserializeObject<List<SerializeProxima>>(reader.ReadToEnd());

            string response2FromServer = reader.ReadToEnd();

            reader.Close();
            dataStream.Close();
            response2.Close();

            IList<SerializeProxima> serializeproxima = JsonConvert.DeserializeObject<List<SerializeProxima>>(response2FromServer);

            //string json = JsonConvert.SerializeObject(serializeproxima, Formatting.Indented, new JsonSerializerSettings
            //{
            //    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            //});

            //return json;
            return serializeproxima;
            //return response2FromServer;
        }

        private string LinesNearProxJson(string x, string y, int z, bool details)
        {

            WebRequest request = WebRequest.Create($"http://data.metromobilite.fr/api/linesNear/json?x={x}&y={y}&dist={z}&details={details}");

            HttpWebResponse response3 = (HttpWebResponse)request.GetResponse();

            Console.WriteLine(response3.StatusDescription);

            Stream dataStream = response3.GetResponseStream();

            StreamReader reader = new StreamReader(dataStream);

            //List<SerializeProxima> serializeproxima = JsonConvert.DeserializeObject<List<SerializeProxima>>(reader.ReadToEnd());

            string response2FromServer = reader.ReadToEnd();

            reader.Close();
            dataStream.Close();
            response3.Close();

            IList<SerializeProxima> serializeproxima = JsonConvert.DeserializeObject<List<SerializeProxima>>(response2FromServer);

            string json = JsonConvert.SerializeObject(serializeproxima, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });

            return json;
            //return serializeproxima;
            //return response2FromServer;
        }

    }
}
