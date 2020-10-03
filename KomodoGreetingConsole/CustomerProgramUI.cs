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
            SeedCustomer();
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
            newCustomer.TypeOfCustomer = Console.ReadLine();
            while (type.ToLower() != "past" && type.ToLower() != "current" && type.ToLower() != "potential")
            {
                Console.WriteLine("Please enter the type of customer.");
                type = Console.ReadLine();
            }
            newCustomer.TypeOfCustomer = type;
            _customerRepo.AddCustomer(newCustomer);

        }
        //Read
        private void SeeAllCustomers()
        {
   
            Console.Clear();
            List<Customer> listOfCustomers = _customerRepo.GetCustomers();
            listOfCustomers.Sort();
            foreach(Customer customer in listOfCustomers)
            {
                Console.WriteLine(customer.FirstName + " " + customer.LastName + " " + customer.TypeOfCustomer + " " + "\n");
            }

        }
        //Update
        private void UpdateExistingCustomer()
        {
            SeeAllCustomers();
            Console.WriteLine("Enter the first name of the customer you would like to update:");
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
            SeeAllCustomers();
            Console.WriteLine("Enter the name of the customer you wish to delete.");
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
        //Helper
       
        private void EmailToSend(Customer customer)
        {
        
            if (customer.TypeOfCustomer== "past")
            {
                Console.WriteLine("It's been a long time since we've heard from you, we want you back.");
            }
            else if (customer.TypeOfCustomer == "current")
            {
                Console.WriteLine("Thank you for your work with us. We appreciate your loyalty. Here's a coupon.");
            }
            else
            {
                Console.WriteLine("We currently have the lowest rates on Helicopter Insurance!");      
            }
        }
        private void SeedCustomer()
        {
            Customer brittany = new Customer("Brittany", "Korycki", "past");
            Customer veronica = new Customer("Veronica", "Smith", "current");
            Customer jeff = new Customer("Jeff", "Korycki", "potential");

            _customerRepo.AddCustomer(brittany);
            _customerRepo.AddCustomer(veronica);
            _customerRepo.AddCustomer(jeff);
        }

    }  


    
}
