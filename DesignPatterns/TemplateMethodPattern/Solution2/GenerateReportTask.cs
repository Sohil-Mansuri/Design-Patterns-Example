

namespace TemplateMethodPattern.Solution2
{
    internal class GenerateReportTask : Task
    {
        protected override void Run()
        {
            Console.WriteLine("Report is generated");
        }
    }
}
