using System;
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
    /// Logique d'interaction pour FindYourWayHome.xaml
    /// </summary>
    public partial class FindYourWayHome : Page
    {
        public FindYourWayHome()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FindYourWayShow findYourWayShow = new FindYourWayShow();
            this.NavigationService.Navigate(findYourWayShow);
        }
    }
}
