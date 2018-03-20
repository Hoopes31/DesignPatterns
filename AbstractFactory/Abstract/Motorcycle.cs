namespace AbstractFactory
{
    public abstract class Motorcycle
    {
        public int Wheels { get; set; }

        public Motorcycle()
        {
            Wheels = 2;
        }
    }
}
