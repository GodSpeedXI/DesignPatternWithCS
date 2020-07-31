using System;

namespace DesignPatternPractice.CommandPattern.BtnFw
{
    public class DeleteCustomerCommand : ICommandBase
    {
        private readonly CustomerModel _customer;
        private readonly CustomerService _customerService;

        public DeleteCustomerCommand(CustomerService customerService, CustomerModel customer)
        {
            _customerService = customerService;
            _customer = customer;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object customer)
        {
            if (customer?.GetType() == typeof(CustomerModel))
                _customerService.DeleteCustomer((CustomerModel) customer);
            else if (!(_customer is null)) _customerService.DeleteCustomer(_customer);
        }

        public event EventHandler CanExecuteChanged;

        public void ExecuteUndo()
        {
            _customerService.AddCustomer(_customer);
        }

        public bool IsUndo { get; set; }
    }
}