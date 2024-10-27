
namespace DecoratorPattern.Problem
{
    /// <summary>
    /// 
    /// </summary>
    internal class CompressedCloudStream : CloudStream
    {
        public override void Write(string data)
        {
            var compressData = data.Substring(0, 4);
            base.Write(compressData);
        }
    }
}
