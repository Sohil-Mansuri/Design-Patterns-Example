
namespace BridgePattern.Problem
{
    internal class SamsungAdvanceRemote : AdvanceRemoteControl
    {
        public override void TurnOff()
        {
            Console.WriteLine("Samsung : Off");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Samsung : On");
        }

        public override void Pause()
        {
            Console.WriteLine("Samsung : Pause");
        }

        public override void Ply()
        {
            Console.WriteLine("Samsung : Ply");
        }

        public override void Stop()
        {
            Console.WriteLine("Samsung : Stop");
        }

    }
}
