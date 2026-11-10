namespace MVC_Cargo
{
    public class ControllerCargo
    {
        public double Calculate(double weight, double tariffKg, double distance, double tariffKm)
        {
            var cargo = new CargoTransport(weight, tariffKg, distance, tariffKm);
            return cargo.Cost;
        }
    }
}