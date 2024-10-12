

namespace TemplateMethodPattern.Example2
{
    internal class DataBaseProcessing : DataProcessing
    {
        protected override void LoadData()
        {
            Console.WriteLine("Loading data from DB");
        }

        protected override void ProcessData()
        {
            Console.WriteLine("Processing DB data");
        }
    }
}
