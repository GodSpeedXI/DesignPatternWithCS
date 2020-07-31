using System.Collections.Generic;

namespace DesignPatternPractice.CommandPattern
{
    public class CustomerService
    {
        private readonly List<CustomerModel> _customerModels = new List<CustomerModel>();

        public void AddCustomer(CustomerModel customer)
        {
            _customerModels.Add(customer);
            "Customer added!!".Dump();
        }

        public void ShowAllCustomer()
        {
            foreach (var customerModel in _customerModels)
            {
                $"Customer: ID: {customerModel.Id} Name: {customerModel.Name} Age: {customerModel.Age}".Dump();
            }
        }
    }
}