using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MVVM_Cargo
{
    public class MainVM : INotifyPropertyChanged
    {
        private double _weight = 10;
        private double _tariffKg = 5;
        private double _distance = 100;
        private double _tariffKm = 2;
        private double _cost;

        public double Weight
        {
            get => _weight;
            set { _weight = value; OnPropertyChanged(); Calculate(); }
        }

        public double TariffKg
        {
            get => _tariffKg;
            set { _tariffKg = value; OnPropertyChanged(); Calculate(); }
        }

        public double Distance
        {
            get => _distance;
            set { _distance = value; OnPropertyChanged(); Calculate(); }
        }

        public double TariffKm
        {
            get => _tariffKm;
            set { _tariffKm = value; OnPropertyChanged(); Calculate(); }
        }

        public double Cost
        {
            get => _cost;
            private set { _cost = value; OnPropertyChanged(); }
        }

        public MainVM()
        {
            Calculate();
        }

        private void Calculate()
        {
            var cargo = new CargoTransport(_weight, _tariffKg, _distance, _tariffKm);
            Cost = cargo.Cost();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}