namespace MVVM_Cargo
{
    public class CargoTransport
    {
        public double Weight { get; set; }
        public double TariffKg { get; set; }
        public double Distance { get; set; }
        public double TariffKm { get; set; }

        public CargoTransport(double weight, double tariffKg, double distance, double tariffKm)
        {
            Weight = weight;
            TariffKg = tariffKg;
            Distance = distance;
            TariffKm = tariffKm;
        }

        public double Cost()
        {
            return (Weight * TariffKg) + (Distance * TariffKm);
        }
    }
}