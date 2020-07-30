namespace DesignPatternPractice.TemplateMethodPattern
{
    public abstract class TaskBase
    {
        private readonly AuditTrail _auditTrail;

        public TaskBase(AuditTrail auditTrail)
        {
            _auditTrail = auditTrail;
        }

        public void Execute()
        {
            _auditTrail.Record();
            doExecute();
        }

        protected abstract void doExecute();
    }
}