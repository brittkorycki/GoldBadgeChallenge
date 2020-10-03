using KomodoGreeting;
using System;
using System.Collections.Generic;
using System.Linq;
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

        private void CreateCustomer()
        {
            Console.Clear();
            Customer newCustomer = new Customer();
            Console.WriteLine("Enter the customer's first name:");
            newCustomer.FirstName = Console.ReadLine();
            Console.WriteLine("Enter the customer's last name:");
            newCustomer.LastName = Console.ReadLine();
            Console.WriteLine("Is the customer a current, potential or past customer?");
            Console.ReadLine().ToLower();

        }
    }
}
