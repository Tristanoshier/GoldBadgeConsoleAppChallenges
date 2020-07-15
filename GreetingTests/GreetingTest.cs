using System;
using System.Collections.Generic;
using GreetingRepo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GreetingTests
{
    [TestClass]
    public class GreetingTest
    {
        [TestMethod]
        public void GetAllCustomers_ShouldReturnCorrectList()
        {
            Customer customer = new Customer();
            CustomerRepository customerRepo = new CustomerRepository();
            customerRepo.AddCustomer(customer);

            List<Customer> customers = customerRepo.GetAllCustomers();
            bool directoryContainsCustomer = customers.Contains(customer);

            Assert.IsTrue(directoryContainsCustomer);
        }

        [TestMethod]
        public void AddCustomer_ShouldReturnCorrectBool()
        {
            Customer customer = new Customer();
            CustomerRepository customerRepo = new CustomerRepository();

            bool customerAdded = customerRepo.AddCustomer(customer);

            Assert.IsTrue(customerAdded);
        }

        [TestMethod]
        public void UpdateCustomerInfo_ShouldReturnTrue()
        {
            var customer = new Customer("Parker", "Dahl", CustomerType.Current);
            var updatedCustomer = new Customer("Parker", "James", CustomerType.Potential);
            CustomerRepository customerRepo = new CustomerRepository();

            bool updateResult = customerRepo.UpdateCustomerInfo(customer, updatedCustomer);

            Assert.IsTrue(updateResult);
        }

        [TestMethod]
        public void DeleteCustomer_ShouldReturnTrue()
        {
            var customer = new Customer("Parker", "Dahl", CustomerType.Current);
            CustomerRepository customerRepo = new CustomerRepository();
            customerRepo.AddCustomer(customer);

            bool customerRemoved = customerRepo.DeleteCustomer(customer);

            Assert.IsTrue(customerRemoved);
        }
    }
}
