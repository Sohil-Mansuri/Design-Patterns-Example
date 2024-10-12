
namespace TemplateMethodPattern.Solution1
{
    internal class GenerateReportTask : ITask
    {
        public void Run()
        {
            Console.WriteLine("Report is generated");
        }
    }
}
