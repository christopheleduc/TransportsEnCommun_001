using MVVMFindMetro.Model;
using System.Collections.ObjectModel;

namespace MVVMFindMetro.ViewModel
{
    public class FindMetroViewModel
    {
        public ObservableCollection<FindMetro> FindMetros
        {
            get;
            set;
        }

        public void LoadFindMetros()
        {
            ObservableCollection<FindMetro> findmetros = new ObservableCollection<FindMetro>();

            findmetros.Add(new FindMetro { LongiTude = "5.727718", LatiTude = "45.185603", PeriMetre = 500 });
            findmetros.Add(new FindMetro { LongiTude = "3.727718", LatiTude = "32.185603", PeriMetre = 700 });
            findmetros.Add(new FindMetro { LongiTude = "7.727718", LatiTude = "47.185603", PeriMetre = 900 });

            FindMetros = findmetros;
        }
    }
}
