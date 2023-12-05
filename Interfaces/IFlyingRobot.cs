
namespace Interfaces.Interfaces
{
    internal interface IFlyingRobot : IRobot
    {
        public string GetRobotType()
        {
            return "I am a flying robot.";
        }
    }
}
