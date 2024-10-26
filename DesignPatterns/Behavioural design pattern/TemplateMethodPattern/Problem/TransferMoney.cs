
namespace TemplateMethodPattern.Problem
{
    internal class TransferMoney(AuditTrail auditTrail)
    {
        public void Execure()
        {
            auditTrail.Record();

            Console.WriteLine("money transter done");
        }
    }
}
