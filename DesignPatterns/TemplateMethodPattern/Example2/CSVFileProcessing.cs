

namespace TemplateMethodPattern.Example2
{
    internal class CSVFileProcessing : DataProcessing
    {
        protected override void LoadData()
        {
            Console.WriteLine("Loading CSV files data");
        }

        protected override void ProcessData()
        {
            Console.WriteLine("Processing CSV files");
        }
    }
}
