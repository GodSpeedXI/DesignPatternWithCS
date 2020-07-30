namespace DesignPatternPractice.TemplateMethodPattern
{
    public class TransferMoneyTask : TaskBase
    {
        public TransferMoneyTask(AuditTrail auditTrail) : base(auditTrail) { }

        protected override void doExecute()
        {
            "TransferMoney".Dump();
        }
    }
}