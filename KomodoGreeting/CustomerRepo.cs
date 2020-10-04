using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoGreeting
{
     public class CustomerRepo
     {
        private List<Customer> customer = new List<Customer>();

        //Create
        public void AddCustomer(Customer person)
        {
            customer.Add(person);
        }
        //Read
        public List<Customer> GetCustomers()
        {
            return customer;
        }
        //Update
        public bool UpdateExistingCustomer(string lastName, Customer newCustomer)
        {
            Customer oldCustomer = GetCustomersByLastName(lastName);
            if(oldCustomer != null)
            {
                oldCustomer.FirstName = newCustomer.FirstName;
                oldCustomer.LastName = newCustomer.LastName;
                oldCustomer.TypeOfCustomer = newCustomer.TypeOfCustomer;
                return true;
            }
            else
            {
                return false;
            }
        }
        //Delete
        public bool RemoveCustomer(string lastName)
        {
            Customer person = GetCustomersByLastName(lastName);
            if (person == null)
            {
                return false;
            }
            else
            {
                customer.Remove(person);
                return true;
            }
        }
        //helper
        public Customer GetCustomersByLastName(string lastName)
        {
            foreach (Customer person in customer)
            {
                if (person.LastName.ToLower() == lastName.ToLower())
                {
                    return person;
                }
            }
            return null;
        }
        public bool EmailToSend(string type, string emailAddress)
        {

            if (type == "past")
            {
                Console.WriteLine("It's been a long time since we've heard from you, we want you back.");
                return true;
            }
            else if (type== "current")
            {
                Console.WriteLine("Thank you for your work with us. We appreciate your loyalty. Here's a coupon.");
                return true;
            }
            else if (type == "potential")
            {
                Console.WriteLine("We currently have the lowest rates on Helicopter Insurance!");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
