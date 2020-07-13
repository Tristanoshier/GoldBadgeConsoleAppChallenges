using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingRepo
{
    public enum CustomerType { Potential, Current, Past }
    public class Customer
    {
        public Customer()
        {
        }

        public Customer(string firstName, string lastName, CustomerType typeOfCustomer)
        {
            FirstName = firstName;
            LastName = lastName;
            TypeOfCustomer = typeOfCustomer;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public CustomerType TypeOfCustomer { get; set; }
        public string Email
        {
            get
            {
                if(TypeOfCustomer == CustomerType.Potential)
                {
                    return "We currently have the lowest rates on Helicopter Insurance!";
                }
                else if (TypeOfCustomer == CustomerType.Current)
                {
                    return "Thank you for your work with us. We appreciate your loyalty. Here's a coupon.";
                } 
                else
                {
                    return "It's been a long time since we've heard from you, we want you back.";
                }
            }
        }

    }
}
