
namespace BridgePattern.Problem
{
    internal class SamsungRemote : RemoteControl
    {
        public override void TurnOff()
        {
            Console.WriteLine("Samsung TV  Off");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Samsung TV On");
        }
    }
}
