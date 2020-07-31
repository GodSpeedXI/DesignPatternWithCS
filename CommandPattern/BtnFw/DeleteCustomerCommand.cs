using System;
using System.Windows.Input;

namespace DesignPatternPractice.CommandPattern.BtnFw
{
    public class DeleteCustomerCommand : ICommand
    {
        private readonly int _customerId;
        private readonly CustomerService _customerService;

        public DeleteCustomerCommand(CustomerService customerService, int customerId)
        {
            _customerService = customerService;
            _customerId = customerId;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter?.GetType() == typeof(CustomerModel))
                _customerService.DeleteCustomer(((CustomerModel) parameter).Id);
            else if (_customerId != 0) _customerService.DeleteCustomer(_customerId);
        }

        public event EventHandler CanExecuteChanged;
    }
}