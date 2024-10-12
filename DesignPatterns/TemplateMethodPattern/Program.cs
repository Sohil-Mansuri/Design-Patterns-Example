

namespace TemplateMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Output from Soluiont1");

            var taskExecuter = new Solution1.TaskExecuter(new Solution1.GenerateReportTask());
            taskExecuter.Execure();

            Console.WriteLine("Output from Soluiont2");
            var task = new Solution2.GenerateReportTask();
            task.Execute();

            Console.WriteLine("Output from Example 2");

            var dataProcessing = new Example2.CSVFileProcessing();
            dataProcessing.DateProcesssing();

            Console.ReadKey();
        }
    }
}
