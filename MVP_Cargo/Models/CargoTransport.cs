namespace MVP_Cargo
{
    public class CargoTransport : ICargoModel
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

        public double Cost()
        {
            return (weight * tariffKg) + (distance * tariffKm);
        }
    }
}