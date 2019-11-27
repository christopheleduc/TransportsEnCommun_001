using System;
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
    /// Logique d'interaction pour FindYourWayHome.xaml
    /// </summary>
    public partial class FindYourWayHome : Page, INotifyPropertyChanged
    {
        private string longiTude;
        private string latiTude;
        private int periMetre;

        public FindYourWayHome()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FindYourWayShow findYourWayShow = new FindYourWayShow();
            this.NavigationService.Navigate(findYourWayShow);
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
                    RaisePropertyChanged("LatiTude");
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
    }
}
