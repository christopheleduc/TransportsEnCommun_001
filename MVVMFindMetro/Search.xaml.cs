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

namespace MVVMFindMetro
{
    /// <summary>
    /// Logique d'interaction pour Search.xaml
    /// </summary>
    public partial class Search : Page, INotifyPropertyChanged
    {
        public Search()
        {
            InitializeComponent();
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    Result result = new Result();
        //    this.NavigationService.Navigate(result);
        //}

        public event PropertyChangedEventHandler PropertyChanged;

        private void FindMetroViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            MVVMFindMetro.Model.FindMetroModel findmetroViewModelObject =
               new MVVMFindMetro.Model.FindMetroModel();

            FindMetroViewControl.DataContext = findmetroViewModelObject;
        }
    }
}
