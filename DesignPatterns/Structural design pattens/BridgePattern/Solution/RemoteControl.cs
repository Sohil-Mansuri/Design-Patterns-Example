
namespace BridgePattern.Solution
{
    /// <summary>
    /// Basic Operation
    /// </summary>
    /// <param name="device"></param>
    internal class RemoteControl(IDevice device)
    {
        public void TurnOnTV()
        {
            device.TurnOn();
        }

        public void TurnOffTV()
        {
            device.TurnOff();
        }
    }
}
