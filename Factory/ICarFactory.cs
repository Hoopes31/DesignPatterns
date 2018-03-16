namespace Factory
{
    public interface ICarFactory
    {
        ICar BuildVehicle(string make, string model);
    }
}
