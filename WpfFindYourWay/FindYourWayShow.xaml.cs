using MetroLibrary;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfFindYourWay
{
    /// <summary>
    /// Logique d'interaction pour FindYourWayShow.xaml
    /// </summary>
    public partial class FindYourWayShow : Page
    {
        public Dictionary<string, SerializeProxima> Stations
        {
            get { return (Dictionary<string, SerializeProxima>)GetValue(StationsProperty); }
            set { SetValue(StationsProperty, value); }
        }

        public static readonly DependencyProperty StationsProperty = DependencyProperty.Register("Stations", typeof(Dictionary<string, SerializeProxima>), typeof(MainWindow));

        public FindYourWayShow()
        {
            InitializeComponent();
            this.DataContext = this;
            //this.Stations = "Test!!!";
            //TextBlock textBlock = new TextBlock();
            //textBlock.Text = "Ceci est un TEST!!!";

            Metro linemetro = new Metro();

            //Dictionary<string, SerializeProxima> LineMetro;

            this.Stations = linemetro.GetLinesMetro("5.727718", "45.185603", 500, true, "http://data.metromobilite.fr/api/linesNear/json?x=5.727718&y=45.185603&dist=500&details=true");

            //IDictionaryEnumerator myEnumerator1 = LineMetro.GetEnumerator();

            //this.Stations = LineMetro

            //this.Stations = LineMetro["GRENOBLE, CASERNE DE BONNE"].Lines[0].ToString();
            //this.Stations = LineMetro["GRENOBLE, CASERNE DE BONNE"].Zone.ToString();
            //this.Stations = LineMetro["GRENOBLE, CASERNE DE BONNE"].Name.ToString();


            // If MoveNext passes the end of the 
            // collection, the enumerator is positioned 
            // after the last element in the collection 
            // and MoveNext returns false. 
            //while (myEnumerator1.MoveNext())
            //{
            //    string json1 = JsonConvert.SerializeObject(myEnumerator1.Value, Formatting.Indented, new JsonSerializerSettings
            //    {
            //        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            //    });
            //    //Console.WriteLine(myEnumerator1.Key + " --> " + json1);
            //    this.Stations = myEnumerator1.Key + " --> " + json1;
            //}
        }
    }
}
