namespace DecoratorPattern.Problem
{
    internal class CloudStream
    {
        public virtual void Write(string data)
        {
            Console.WriteLine("Stream {0}", data);
        }
    }
}
