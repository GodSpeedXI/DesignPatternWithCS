namespace DesignPatternPractice.TemplateMethodPattern
{
    public class DepositMoneyTask : TaskBase
    {
        public DepositMoneyTask(AuditTrail auditTrail) : base(auditTrail) { }

        protected override void doExecute()
        {
            "DepositMoney".Dump();
        }
    }
}