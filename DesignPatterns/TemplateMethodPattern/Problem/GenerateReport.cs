
namespace TemplateMethodPattern.Problem
{
    internal class GenerateReport(AuditTrail auditTrail)
    {
        public void Generate()
        {
            auditTrail.Record();
            Console.WriteLine("Report is generated");
        }
    }
}
