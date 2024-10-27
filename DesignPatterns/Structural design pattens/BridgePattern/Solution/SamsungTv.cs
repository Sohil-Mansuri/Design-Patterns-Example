
namespace BridgePattern.Solution
{
    /// <summary>
    /// concreate implementation
    /// </summary>
    internal class SamsungTv : IDevice
    {
        public void Pause()
        {
            Console.WriteLine("SamsumgTV : Pause");
        }

        public void Ply()
        {
            Console.WriteLine("SamsumgTV : Ply");
        }

        public void Stop()
        {
            Console.WriteLine("SamsumgTV : Stop");
        }

        public void TurnOff()
        {
            Console.WriteLine("SamsumgTV : Off");
        }

        public void TurnOn()
        {
            Console.WriteLine("SamsumgTV : On");
        }
    }
}
