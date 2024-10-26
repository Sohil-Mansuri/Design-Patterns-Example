

namespace TemplateMethodPattern.Solution2
{
    /// <summary>
    /// This is make sure developer to do Audit by default
    /// now whoever implment this class have to give implementation
    /// </summary>
    internal abstract class Task
    {
        private AuditTrail _auditTrail = new();

        /// <summary>
        /// Algorithem Steps defined
        /// </summary>
        public void Execute()
        {
            _auditTrail.Record();
            Run();
        }

        protected abstract void Run();
    }
}
