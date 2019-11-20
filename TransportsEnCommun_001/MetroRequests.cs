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

        public string GetLinesNearProx(string latitude = "5.727718", string longitude = "45.185603", int distance = 500, bool details = false)
        {
            string retour = LinesNearProx(latitude, longitude, distance, details);
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

            //Console.WriteLine(responseFromServer);
            //WebResponse response2 = request.GetResponse();
            //Stream dataStream = response2.GetResponseStream();
            //StreamReader reader = new StreamReader(dataStream);

            reader.Close();
            dataStream.Close();
            response2.Close();

            return responseFromServer;
        }

        private string LinesNearProx(string x, string y, int z, bool details)
        {

            WebRequest request = WebRequest.Create($"http://data.metromobilite.fr/api/linesNear/json?x={x}&y={y}&dist={z}&details={details}");

            HttpWebResponse response2 = (HttpWebResponse)request.GetResponse();

            Console.WriteLine(response2.StatusDescription);

            Stream dataStream = response2.GetResponseStream();

            StreamReader reader = new StreamReader(dataStream);

            string responseFromServer = reader.ReadToEnd();

            //Console.WriteLine(responseFromServer);
            //WebResponse response2 = request.GetResponse();
            //Stream dataStream = response2.GetResponseStream();
            //StreamReader reader = new StreamReader(dataStream);

            reader.Close();
            dataStream.Close();
            response2.Close();

            return responseFromServer;
        }

    }
}
