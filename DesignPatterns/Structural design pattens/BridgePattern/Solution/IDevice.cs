
namespace BridgePattern.Solution
{
    /// <summary>
    /// All Operation suported by any Device
    /// </summary>
    internal interface IDevice
    {
        void TurnOn();
        void TurnOff();
        void Ply();
        void Pause();
        void Stop();
    }
}
