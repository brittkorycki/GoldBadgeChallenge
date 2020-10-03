using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KomodoGreeting;
using System.Collections.Generic;

namespace KomodoGreetingTests
{
    [TestClass]
    public class GreetingTests
    {
        Customer customers = new Customer();
        CustomerRepo customerRepo = new CustomerRepo();

        [TestMethod]
        public void TestCreateCustomer()
        {
            //Arrange
            {
                Customer customer = new Customer();
                string FirstName = "Brittany";
                string LastName = "Korycki";
                string TypeOfCustomer = "current";
                //Act
                customer.FirstName = FirstName;
                customer.LastName = LastName;
                customer.TypeOfCustomer = TypeOfCustomer;
                customerRepo.AddCustomer(customer);
                Customer customer1 = customerRepo.GetCustomersByLastName(LastName);
                //Assert
                Assert.AreSame(customer1.LastName, "Brittany", "Customer name does not match.");
            }
        }
        [TestMethod]
        public void TestRemoveCustomer()
        {
            //Arrange
            Customer customer = new Customer();
            string LastName = "Korycki";
            //Act
            customerRepo.RemoveCustomer(LastName);
            //Assert
            Assert.IsNull(customerRepo.GetCustomersByLastName(LastName), "customer not found.");
        }
        [TestMethod]
        public void TestUpdateCustomer()
        {
            //Arrange
            Customer customer = new Customer();

        }
    }
}
