namespace AbstractFactory
{
    public abstract class Car
    {
        public int Wheels { get; set; }

        public Car()
        {
            Wheels = 4;
        }
    }
}
