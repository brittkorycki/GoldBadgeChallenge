using KomodoGreeting;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KomodoGreetingConsole
{
    class CustomerProgramUI
    {
        private CustomerRepo _customerRepo = new CustomerRepo();
        public void Run()
        {

            Menu();
        }
        //display menu
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Select an option\n" +
                    "1. Create new customer\n" +
                    "2. See list of all customers\n" +
                    "3. Update customers\n" +
                    "4. Delete a customer\n" +
                    "5. Exit");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        CreateCustomer();
                        break;
                    case "2":
                        SeeAllCustomers();
                        break;
                    case "3":
                        UpdateExistingCustomer();
                        break;
                    case "4":
                        DeleteCustomer();
                        break;
                    case "5":
                        Console.WriteLine("Goodbye!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please choose a valid option.");
                        break;
                }

            }
        }
        //Create
        private void CreateCustomer()
        {
            string type = String.Empty;
          
            Console.Clear();
            Customer newCustomer = new Customer();
            Console.WriteLine("Enter the customer's first name:");
            newCustomer.FirstName = Console.ReadLine();
            Console.WriteLine("Enter the customer's last name:");
            newCustomer.LastName = Console.ReadLine();
            while (type.ToLower() != "past" && type.ToLower() != "current" && type.ToLower() != "potential")
            {
                Console.WriteLine("Please enter the type of customer:");
                type = Console.ReadLine();
            }
            newCustomer.TypeOfCustomer = type;
            Console.WriteLine("Enter the customer's email address:");
            newCustomer.EmailAddress = Console.ReadLine();
            _customerRepo.AddCustomer(newCustomer);

            _customerRepo.EmailToSend(newCustomer.TypeOfCustomer, newCustomer.EmailAddress);

        }
        //Read
        private void SeeAllCustomers()
        {
            Customer customer = new Customer();
            Console.Clear();
            List<Customer> listOfCustomers = _customerRepo.GetCustomers();
            listOfCustomers.Sort();
            foreach (Customer customer1 in listOfCustomers)
            {
                Console.WriteLine(customer1.FirstName + " " + customer1.LastName + " " + customer1.TypeOfCustomer + " " + "\n");

                if (customer1.TypeOfCustomer == "past")
                {
                    Console.WriteLine(customer1.FirstName + " " + customer1.LastName + " " + customer1.TypeOfCustomer + " " + "It's been a long time since we've heard from you, we want you back.");
                }
                else if (customer1.TypeOfCustomer == "current")
                {
                    Console.WriteLine(customer1.FirstName + " " + customer1.LastName + " " + customer1.TypeOfCustomer + " " + "Thank you for your work with us. We appreciate your loyalty. Here's a coupon.");
                }
                else if (customer1.TypeOfCustomer == "potential")
                {
                    Console.WriteLine(customer1.FirstName + " " + customer1.LastName + " " + customer1.TypeOfCustomer + " " + "We currently have the lowest rates on Helicopter Insurance!");
                    
                }
            }
        }
        //Update
        private void UpdateExistingCustomer()
        {
            SeeAllCustomers();
            Console.WriteLine("Enter the last name of the customer you would like to update:");
            string oldCustomer = Console.ReadLine();
            Console.Clear();
            Customer newCustomer = new Customer();
            Console.WriteLine("Enter the new first name of the customer:");
            newCustomer.FirstName = Console.ReadLine();
            Console.WriteLine("Enter the new last name of the customer:");
            newCustomer.LastName = Console.ReadLine();
            Console.WriteLine("Enter the new type of the customer (current, past, potential):");
            newCustomer.TypeOfCustomer = Console.ReadLine();
           //verify the update worked
      
            bool wasUpdated = _customerRepo.UpdateExistingCustomer(oldCustomer, newCustomer);

            if (wasUpdated)
            {
                Console.WriteLine("Customer was successfully updated!");
            }
            else
            {
                Console.WriteLine("Could not update customer.");
            }
        }


        //Delete
        private void DeleteCustomer()
        {
            string lastName = String.Empty;
            _customerRepo.GetCustomersByLastName(lastName);
            Console.WriteLine("Enter the last name of the customer you wish to delete.");
            string input = Console.ReadLine();
            bool wasDeleted = _customerRepo.RemoveCustomer(input);
            if (wasDeleted)
            {
                Console.WriteLine("The customer was successfully deleted.");
            }
            else
            {
                Console.WriteLine("The customer could not be deleted.");
            }
        }
        
    }  


    
}
