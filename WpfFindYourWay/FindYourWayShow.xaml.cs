using MetroLibrary;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class FindYourWayShow : Page, INotifyPropertyChanged
    {
        public Dictionary<string, SerializeProxima> Stations
        {
            get { return (Dictionary<string, SerializeProxima>)GetValue(StationsProperty); }
            set { SetValue(StationsProperty, value); }
        }

        public static readonly DependencyProperty StationsProperty = DependencyProperty.Register("Stations", typeof(Dictionary<string, SerializeProxima>), typeof(MainWindow));

        public event PropertyChangedEventHandler PropertyChanged;

        public FindYourWayShow(string x= "5.727718", string y= "45.185603", int z=500)
        {
            InitializeComponent();
            this.DataContext = this;


            Metro linemetro = new Metro();

            this.Stations = linemetro.GetLinesMetro(x, y, z, true, "http://data.metromobilite.fr/api/linesNear/json?x=5.727718&y=45.185603&dist=500&details=true");

            //Dictionary<string, SerializeProxima> LineMetro;

            //this.Stations = linemetro.GetLinesMetro("5.727718", "45.185603", 500, true, "http://data.metromobilite.fr/api/linesNear/json?x=5.727718&y=45.185603&dist=500&details=true");


        }
    }
}
