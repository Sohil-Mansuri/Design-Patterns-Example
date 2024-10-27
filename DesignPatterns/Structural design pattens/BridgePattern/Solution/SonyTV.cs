
namespace BridgePattern.Solution
{
    /// <summary>
    /// This is implementaiton of device
    /// </summary>
    internal class SonyTV : IDevice
    {
        public void Pause()
        {
            Console.WriteLine("SonyTV : Pause");
        }

        public void Ply()
        {
            Console.WriteLine("SonyTV : Ply");
        }

        public void Stop()
        {
            Console.WriteLine("SonyTV : Stop");
        }

        public void TurnOff()
        {
            Console.WriteLine("SonyTV : Off");
        }

        public void TurnOn()
        {
            Console.WriteLine("SonyTV : On");
        }
    }
}
