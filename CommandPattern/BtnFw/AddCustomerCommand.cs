using System;
using System.Windows.Input;

namespace DesignPatternPractice.CommandPattern.BtnFw
{
    public class AddCustomerCommand : ICommand, IUndoCommand
    {
        private CustomerModel _customerModel;
        private readonly CustomerService _customerService;

        public AddCustomerCommand(CustomerService customerService, CustomerModel customerModel = null)
        {
            _customerService = customerService;
            _customerModel = customerModel;
        }

        public bool CanExecute(object parameter = null)
        {
            return true;
        }

        /// <summary>
        ///     AddCustomer by passing CustomerModel
        /// </summary>
        /// <param name="parameter">CustomerModel</param>
        public void Execute(object parameter = null)
        {
            if (parameter?.GetType() == typeof(CustomerModel))
            {
                _customerService.AddCustomer((CustomerModel) parameter);
                _customerModel = (CustomerModel) parameter;
            }
            else if (!(_customerModel is null)) _customerService.AddCustomer(_customerModel);
            
        }

        public event EventHandler CanExecuteChanged;
        public void ExecuteUndo()
        {
            _customerService.DeleteCustomer(_customerModel.Id);
        }
    }
}