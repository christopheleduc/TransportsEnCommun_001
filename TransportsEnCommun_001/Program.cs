using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TransportsEnCommun_001
{
    public class LinesNear
    {
        public string id { get; set; }
        public string gtfsId { get; set; }
        public string shortName { get; set; }
        public string longName { get; set; }
        public string color { get; set; }
        public string textColor { get; set; }
        public string mode { get; set; }
        public string type { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            string listMetro;
            string ListMetroProx;
            MetroRequests metrorequests = new MetroRequests();
                    listMetro = metrorequests.GetLinesNear();
                    Console.WriteLine(listMetro);

            Console.WriteLine("**************************************************************************************");

            ListMetroProx = metrorequests.GetLinesNearProx("5.727718", "45.185603", 500, true);
                    Console.WriteLine(ListMetroProx);
            //WebRequest request = WebRequest.Create("https://data.metromobilite.fr/api/routers/default/index/routes");

            //HttpWebResponse response2 = (HttpWebResponse)request.GetResponse();

            //Console.WriteLine(response2.StatusDescription);

            //Stream dataStream = response2.GetResponseStream();

            //StreamReader reader = new StreamReader(dataStream);

            //string responseFromServer = reader.ReadToEnd();

            //Console.WriteLine(responseFromServer);

            //WebResponse response2 = request.GetResponse();
            //Stream dataStream = response2.GetResponseStream();
            //StreamReader reader = new StreamReader(dataStream);

            //reader.Close();
            //dataStream.Close();
            //response2.Close();

            Console.Write("Press any key to continue...");
            Console.ReadKey(true);
        }
    
    }
}
