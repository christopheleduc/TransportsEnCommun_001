using System.ComponentModel;
using System.Windows.Input;

namespace MVVMFindMetro.Model
{
    class FindMetroModel
    {
    }

    public class FindMetro : INotifyPropertyChanged
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
                    RaisePropertyChanged("FullName");
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
                    RaisePropertyChanged("FullName");
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

        public string FullName
        {
            get
            {
                return longiTude + " " + latiTude;
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

        private void MyAction()
        {

        }
    }
}
