using MetroLibrary;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace MVVMFindMetro.Model
{
    class FindMetroModel
    {
    }

    public class FindMetro : Page, INotifyPropertyChanged
    {
        private string longiTude;
        private string latiTude;
        private int periMetre;
        private ICommand command;

        private ICommand Command
        {
            get { return command ?? (command = new RelayCommand(() => MyAction())); }
        }

        public string LongiTude
        {
            get
            {
                return longiTude;
            }

            set
            {
                if (longiTude != value)
                {
                    longiTude = value;
                    RaisePropertyChanged("LongiTude");
                }
            }
        }

        public string LatiTude
        {
            get { return latiTude; }

            set
            {
                if (latiTude != value)
                {
                    latiTude = value;
                    RaisePropertyChanged("LongiTude");
                }
            }
        }

        public int PeriMetre
        {
            get
            {
                return periMetre;
            }

            set
            {
                if (periMetre != value)
                {
                    periMetre = value;
                    RaisePropertyChanged("PeriMetre");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public Dictionary<string, SerializeProxima> Stations
        {
            get { return (Dictionary<string, SerializeProxima>)GetValue(StationsProperty); }
            set { SetValue(StationsProperty, value); }
        }

        public static readonly DependencyProperty StationsProperty = DependencyProperty.Register("Stations", typeof(Dictionary<string, SerializeProxima>), typeof(MainWindow));

        //public event PropertyChangedEventHandler PropertyChanged;

        private void MyAction(string x = "5.727718", string y = "45.185603", int z = 500)
        {
            Result result = new Result();
            this.NavigationService.Navigate(result);

            this.DataContext = this;

            Metro linemetro = new Metro();

            this.Stations = linemetro.GetLinesMetro(x, y, z, true, "http://data.metromobilite.fr/api/linesNear/json?x=5.727718&y=45.185603&dist=500&details=true");

        }
    }
}
