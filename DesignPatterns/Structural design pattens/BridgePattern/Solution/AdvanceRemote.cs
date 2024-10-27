
namespace BridgePattern.Solution
{
    internal class AdvanceRemote(IDevice device) : RemoteControl(device)
    {
        public void Ply()
        {
            device.Ply();
        }

        public void Pause()
        {
            device.Pause();
        }

        public void Stop()
        {
            device.Stop();
        }
    }
}
