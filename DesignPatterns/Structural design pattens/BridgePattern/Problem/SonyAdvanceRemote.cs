
namespace BridgePattern.Problem
{
    internal class SonyAdvanceRemote  : AdvanceRemoteControl
    {
        public override void TurnOff()
        {
            Console.WriteLine("Sony : Off");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Sony : On");
        }

        public override void Pause()
        {
            Console.WriteLine("Sony : Pause");
        }

        public override void Ply()
        {
            Console.WriteLine("Sony : Ply");
        }

        public override void Stop()
        {
            Console.WriteLine("Sony : Stop");
        }
    }
}
