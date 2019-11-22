using Newtonsoft.Json;
using System;
using System.Collections;
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

    class Program
    {
        static void Main(string[] args)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            //List<SerializeData> listMetro;
            string listMetro;
            string ListMetroProxJson;
            IList<SerializeProxima> ListMetroProx;
            

            MetroRequests metrorequests = new MetroRequests();

            Console.WriteLine("********************************Données brut formatés*********************************");

            listMetro = metrorequests.GetLinesNear();
                    Console.WriteLine(listMetro);
            //Console.WriteLine(listMetro[0].Id);
            //foreach (SerializeData listmetro in listMetro)
            //{
            //    Console.WriteLine(listmetro.Id);
            //}

            Console.WriteLine("********************************Données dans un rayon de 500m*************************");

            ListMetroProxJson = metrorequests.GetLinesNearProxJson("5.727718", "45.185603", 500, true);
                    Console.WriteLine(ListMetroProxJson);

            Console.WriteLine("**********************Arrets + Lignes dans un rayon de 500m***************************");

            ListMetroProx = metrorequests.GetLinesNearProx("5.727718", "45.185603", 500, true);
            //Console.WriteLine(ListMetroProx[0].Id);
            foreach (SerializeProxima listmetro in ListMetroProx)
            {
                Console.WriteLine(listmetro.Name);

                foreach (string listline in listmetro.Lines)
                {
                    Console.WriteLine(listline);
                }
            }

            Console.WriteLine("**************Arrets + Lignes dans un rayon de 500m sans les doublons*****************");

            //List<string> arrets = new List<string>();
            //List<string> lignes = new List<string>();
            Dictionary<string, SerializeProxima> arretsAndLines = new Dictionary<string, SerializeProxima>();

            foreach (SerializeProxima metro in ListMetroProx)
            {
                if (!arretsAndLines.ContainsKey(metro.Name)==true)
                {
                    Console.WriteLine(metro.Name);
                    arretsAndLines.Add(metro.Name, metro);
                }

                    foreach (string line in metro.Lines)
                    {
                        if (!arretsAndLines[metro.Name].Lines.Contains(line)==true)
                        {
                            Console.WriteLine(line);
                            arretsAndLines[metro.Name].Lines.Add(line);
                        }  
                    }

            }
            foreach (KeyValuePair<string, SerializeProxima> ele2 in arretsAndLines)
            {
                Console.WriteLine("{0} and {1}", ele2.Key, ele2.Value);
            }

            Console.WriteLine("**************Dictionnaire: Clé/Objet************************************");

            IDictionaryEnumerator myEnumerator = arretsAndLines.GetEnumerator();

            // If MoveNext passes the end of the 
            // collection, the enumerator is positioned 
            // after the last element in the collection 
            // and MoveNext returns false. 
            while (myEnumerator.MoveNext())
            {
                string json = JsonConvert.SerializeObject(myEnumerator.Value, Formatting.Indented, new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });
                Console.WriteLine(myEnumerator.Key + " --> " + json);
            }
                



            Console.Write("Press any key to continue...");
            Console.ReadKey(true);
        }

    }
}
