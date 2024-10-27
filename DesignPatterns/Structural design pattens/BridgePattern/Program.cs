
namespace BridgePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Output from Problem section");

            var remote = new Problem.SonyRemote();
            remote.TurnOn();

            var advanceRemote = new Problem.SamsungAdvanceRemote();
            advanceRemote.Ply();

            //now if we get new type of remote like MovieRemote and it is supported in Netfilx and Amazon TV 
            //so we have to create again need to create lots of classes 
            // MovieRemote : RemoteControl
            //NetflexRemote : MovieRemote
            // AmazonRemote : MovieRemote

            Console.WriteLine("Output from Solution Section");

            // here we can dynamically attach any device with any type of it  

            var normalSonyTV = new Solution.RemoteControl(new Solution.SonyTV());
            normalSonyTV.TurnOnTV();

            var advanceSonyTv = new Solution.AdvanceRemote(new  Solution.SonyTV());
            advanceSonyTv.Ply();

            var samsnugTv = new Solution.RemoteControl(new Solution.SamsungTv());
            samsnugTv.TurnOnTV();

            var advanceSamsungTv = new Solution.AdvanceRemote(new Solution.SamsungTv());
            advanceSamsungTv.Pause();

            Console.ReadKey();
        }
    }
}
