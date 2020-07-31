using System.Windows.Input;

namespace DesignPatternPractice.CommandPattern.BtnFw
{
    public class CustomButton
    {
        private readonly ICommand _addCommand;
        private readonly CustomerModel _customerModel;

        public CustomButton(ICommand addCommand, CustomerModel customerModel)
        {
            _addCommand = addCommand;
            _customerModel = customerModel;
        }

        public void Click()
        {
            _addCommand.Execute(_customerModel);
        }
    }
}