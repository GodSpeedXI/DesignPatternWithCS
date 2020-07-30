namespace DesignPatternPractice.TemplateMethodPattern
{
    public static class TemplateMethodTest
    {
        public static void Run()
        {
            var tranMoney = new TransferMoneyTask(new AuditTrail());
            var depoMoney = new DepositMoneyTask(new AuditTrail());

            tranMoney.Execute();
            depoMoney.Execute();
        }
    }
}