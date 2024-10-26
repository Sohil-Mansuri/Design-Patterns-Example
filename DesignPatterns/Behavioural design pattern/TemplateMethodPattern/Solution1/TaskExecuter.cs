
namespace TemplateMethodPattern.Solution1
{
    internal class TaskExecuter(ITask task)
    {
        private AuditTrail _auditTrail = new();

        public void Execure()
        {
            _auditTrail.Record();
            task.Run();
        }
    }
}
