
using Interfaces.Interfaces;

namespace Interfaces
{
    internal class Quadcopter : IFlyingRobot, IChargeable
    {
        List<string> _components = new() { "rotor1", "rotor2", "rotor3", "rotor4" };

        public string GetInfo()
        {
            return "GetInfo";
        }

        public List<string> GetComponent()
        {
            return _components;
        }

        public void Charge()
        {
            Console.WriteLine("Charging...");
            Thread.Sleep(3000);
            Console.WriteLine("Charged!");
        }
    }
}
