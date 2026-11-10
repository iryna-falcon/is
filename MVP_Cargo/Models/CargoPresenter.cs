namespace MVP_Cargo
{
    public class CargoPresenter
    {
        private readonly ICargoView view;
        private readonly ICargoModel model;

        public CargoPresenter(ICargoView view, ICargoModel model)
        {
            this.view = view;
            this.model = model;
        }

        public void LoadCargo(double weight, double tariffKg, double distance, double tariffKm)
        {
            var cargo = new CargoTransport(weight, tariffKg, distance, tariffKm);
            view.SetCost(cargo.Cost());
        }
    }
}