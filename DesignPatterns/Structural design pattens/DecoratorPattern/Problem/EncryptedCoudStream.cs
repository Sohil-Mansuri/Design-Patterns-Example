
namespace DecoratorPattern.Problem
{
    internal class EncryptedCoudStream : CloudStream
    {
        public override void Write(string data)
        {
            var encryptedDatad = "48394893483943#333###";
            base.Write(encryptedDatad);
        }
    }
}
