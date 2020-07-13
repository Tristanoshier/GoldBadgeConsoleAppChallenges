using GreetingRepo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GreetingConsole
{
    public class GreetingUI
    {
        private readonly CustomerRepository _customerRepo = new CustomerRepository();

        public void Run()
        {
            Menu();
        }

        private void Menu()
        {
            bool continueToRun = true;
            while(continueToRun)
            {
                Console.Clear();
                Console.WriteLine
                    (
                        "Welcome Komodo Administrator!\n" +
                        "1.) See all customers\n" +
                        "2.) Add customer\n" +
                        "3.) Update customer info\n" +
                        "4.) Delete customer\n" +
                        "5.) Quit"
                    );
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        SeeAllCustomers();
                        break;
                    case "2":
                        //AddCustomer();
                        break;     
                    case "3":
                        //UpdateCustomerInfo();
                        break;
                    case "4":
                        //DeleteCustomer();
                        break;
                    case "5":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please choose a number between 1-5\n" +
                            "Press any key to continue...");
                        Console.ReadKey();
                        break;                   
                }
            }
        }

        private void SeeAllCustomers()
        {
            Console.Clear();
            List<Customer> customers = _customerRepo.GetAllCustomers();
            Console.WriteLine("FirstName                    LastName                     Type                             Email");

            foreach (Customer customer in customers)
            {
                Console.WriteLine($"{customer.FirstName}       {customer.LastName}          {customer.TypeOfCustomer}        {customer.Email}\n");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private void SeedCustomerInfo()
        {
            var customerOne = new Customer("Parker", "Dahl", CustomerType.Current);
            var customerTwo = new Customer("Trevor", "Kingma", CustomerType.Past);
            var customerThree = new Customer("Hayden", "Overpeck", CustomerType.Potential);

            _customerRepo.AddCustomer(customerOne);
            _customerRepo.AddCustomer(customerTwo);
            _customerRepo.AddCustomer(customerThree);
        }
    }
}
