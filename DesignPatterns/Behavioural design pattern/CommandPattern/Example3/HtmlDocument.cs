
namespace CommandPattern.Example3
{
    /// <summary>
    /// Actual businees logic to do Bold
    /// </summary>
    internal class HtmlDocument
    {
        public string? Content { get; set; }

        public int Size { get; set; }


        public void makeBold()
        {
            Content = $"<b>{Content}</b>";
        }

        /// <summary>
        /// Add 200 in current size
        /// </summary>
        public void ReSize()
        {
            Size += 200;
        }

    }
}
