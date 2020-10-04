using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace KomodoGreeting
{
    public class Customer: IEquatable<Customer>, IComparable<Customer>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TypeOfCustomer { get; set; }
        public string EmailAddress { get; set; }

        public Customer() { }

        public Customer(string firstName, string lastName, string typeOfCustomer, string emailAddress)
        {
            FirstName = firstName;
            LastName = lastName;
            TypeOfCustomer = typeOfCustomer;
            EmailAddress = emailAddress;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Customer objAsPart = obj as Customer;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }
        public int SortByNameAscending(string name1, string name2)
        {

            return name1.CompareTo(name2);
        }

        // Default comparer for Part type.
        public int CompareTo(Customer compareCustomer)
        {
            // A null value means that this object is greater.
            if (compareCustomer == null)
                return 1;

            else
                return this.FirstName.CompareTo(compareCustomer.FirstName);
        }
        
        public bool Equals(Customer other)
        {
            if (other == null) return false;
            return (this.FirstName.Equals(other.FirstName));
        }
    }

}
