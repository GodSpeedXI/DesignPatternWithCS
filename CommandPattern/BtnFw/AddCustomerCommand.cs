using System;
using System.Windows.Input;

namespace DesignPatternPractice.CommandPattern.BtnFw
{
    public class AddCustomerCommand : ICommand
    {
        private readonly CustomerService _customerService;
        public AddCustomerCommand(CustomerService customerService)
        {
            _customerService = customerService;
        }

        public bool CanExecute(object parameter = null)
        {
            return true;
        }

        /// <summary>
        /// AddCustomer by passing CustomerModel
        /// </summary>
        /// <param name="parameter">CustomerModel</param>
        public void Execute(object parameter = null)
        {
            if (parameter?.GetType() == typeof(CustomerModel))
            {
                _customerService.AddCustomer((CustomerModel)parameter);
            }
        }

        public event EventHandler CanExecuteChanged;
    }
}