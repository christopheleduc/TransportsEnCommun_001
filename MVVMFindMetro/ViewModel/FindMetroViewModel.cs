using MetroLibrary;
using MVVMFindMetro.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MVVMFindMetro.ViewModel
{
    public class FindMetroViewModel: Page, INotifyPropertyChanged
    {
        //public ObservableCollection<FindMetro> FindMetros
        //{
        //    get;
        //    set;
        //}

        public event PropertyChangedEventHandler PropertyChanged;

        //public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        //public void LoadFindMetros()
        //{
        //    ObservableCollection<FindMetro> findmetros = new ObservableCollection<FindMetro>();

        //    findmetros.Add(new FindMetro { LongiTude = "5.727718", LatiTude = "45.185603", PeriMetre = 500 });
        //    findmetros.Add(new FindMetro { LongiTude = "3.727718", LatiTude = "32.185603", PeriMetre = 700 });
        //    findmetros.Add(new FindMetro { LongiTude = "7.727718", LatiTude = "47.185603", PeriMetre = 900 });

        //    FindMetros = findmetros;
        //}
    }
}
