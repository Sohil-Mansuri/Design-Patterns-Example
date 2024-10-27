
namespace BridgePattern.Problem
{
    internal class SonyRemote : RemoteControl
    {
        public override void TurnOff()
        {
            Console.WriteLine("Sony : TV Off");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Sony : TV On");
        }
    }
}
