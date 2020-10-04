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
                Assert.AreSame(customer1.LastName, "Korycki", "Customer name does not match.");
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
            Customer newCustomer = new Customer();
            string FirstName = "Brittany";
            string LastName = "Korycki";
            string TypeOfCustomer = "current";
            string EmailAddress = "brittany@gmail.com";
            //Act
            newCustomer.FirstName = FirstName;
            newCustomer.LastName = LastName;
            newCustomer.TypeOfCustomer = TypeOfCustomer;
            newCustomer.EmailAddress = EmailAddress;
            customerRepo.UpdateExistingCustomer(TypeOfCustomer, newCustomer);
            //Assert
            Assert.AreNotEqual(TypeOfCustomer, "past");
        }
        [TestMethod]
        public void TestEmailToSend()
        {
            //Arrange
            Customer customer = new Customer();
            string FirstName = "Brittany";
            string LastName = "Korycki";
            string TypeOfCustomer = "past";
            string EmailAddress = "brittany@gmail.com";
            //Act
            customer.FirstName = FirstName;
            customer.LastName = LastName;
            customer.TypeOfCustomer = TypeOfCustomer;
            customer.EmailAddress = EmailAddress;
            //Assert
            Assert.IsTrue(customerRepo.EmailToSend(customer.TypeOfCustomer, customer.EmailAddress), "email not sent");
        }
    }
    
}
