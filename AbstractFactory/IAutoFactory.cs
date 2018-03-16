namespace AbstractFactory
{
    public interface IAutoFactory
    {
        IVehicle BuildVehicle(string model);

        // Ridiculous example for factory method
        void StartVehicle(string model);
    }
}
