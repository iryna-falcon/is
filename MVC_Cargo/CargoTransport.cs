namespace MVC_Cargo
{
    public class CargoTransport
    {
        double weight;
        double tariffKg;
        double distance;
        double tariffKm;

        public CargoTransport()
        {
            weight = 10;
            tariffKg = 5;
            distance = 100;
            tariffKm = 2;
        }

        public CargoTransport(double w, double tk, double d, double tkm)
        {
            weight = w;
            tariffKg = tk;
            distance = d;
            tariffKm = tkm;
        }

        public double Weight { get { return weight; } set { weight = value; } }
        public double TariffKg { get { return tariffKg; } set { tariffKg = value; } }
        public double Distance { get { return distance; } set { distance = value; } }
        public double TariffKm { get { return tariffKm; } set { tariffKm = value; } }

        public double Cost
        {
            get { return (weight * tariffKg) + (distance * tariffKm); }
        }
    }
}