using DesignPatternPractice.CommandPattern.BtnFw;

namespace DesignPatternPractice.CommandPattern
{
    /// <summary>
    ///     This is a simple of CommandPattern commonly use in MVVM pattern.
    ///     In this test, included
    ///     CustomerService as service, AddCustomerCommand as Command, CustomButton as Button.
    ///     We usd this pattern to decouple the button from the service by using AddCustomerCommand.
    /// </summary>
    public static class CommandPatternTest
    {
        public static void Run()
        {
            var cusService = new CustomerService();
            var addCusCommand = new AddCustomerCommand(cusService);
            var addJohnBtn = new CustomButton(addCusCommand, new CustomerModel {Id = 1, Age = 20, Name = "John"});
            var addDakeBtn = new CustomButton(addCusCommand, new CustomerModel {Id = 2, Age = 25, Name = "Dake"});

            addJohnBtn.Click();
            addDakeBtn.Click();
            addCusCommand.ExecuteUndo();

            var compoCommand = new CompositCommand();
            var addKimCmd = compoCommand.AddCommand(new AddCustomerCommand(cusService,
                new CustomerModel {Id = 3, Age = 28, Name = "Kim"}));
            var addJamesCmd = compoCommand.AddCommand(new AddCustomerCommand(cusService,
                new CustomerModel {Id = 4, Age = 18, Name = "James"}));
            compoCommand.AddCommand(new AddCustomerCommand(cusService,
                new CustomerModel { Id = 5, Age = 18, Name = "Boy" }));
            compoCommand.AddCommand(new DeleteCustomerCommand(cusService, new CustomerModel(){Id = 3}));

            compoCommand.AddCommand(addJamesCmd, true);

            var compoBtn = new CustomButton(compoCommand, null);
            compoBtn.Click();

            cusService.ShowAllCustomer();
        }
    }
}