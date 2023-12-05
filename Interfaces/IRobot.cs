
namespace Interfaces.Interfaces
{
    internal interface IRobot
    {
        public string GetInfo();
        public List<string> GetComponent();
        public string GetRobotType()
        {
            return "I am a simple robot.";
        }
    }
}
