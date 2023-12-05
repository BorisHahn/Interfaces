namespace Interfaces
{
    internal class Program
    {
        static void Main()
        {
           var quadcopter = new Quadcopter();
            Console.WriteLine(quadcopter.GetInfo());
            Console.WriteLine(quadcopter.GetComponent());
            quadcopter.Charge();
        }
    }
}