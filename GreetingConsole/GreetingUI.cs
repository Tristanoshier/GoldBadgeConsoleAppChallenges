using GreetingRepo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GreetingConsole
{
    public class GreetingUI
    {
        private readonly CustomerRepository _customerRepo = new CustomerRepository();

        public void Run()
        {
            SeedCustomerInfo();
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
                        AddCustomer();
                        break;     
                    case "3":
                        UpdateCustomerInfo();
                        break;
                    case "4":
                        DeleteCustomer();
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
            Console.WriteLine("FirstName   LastName       Type                Email");

            foreach (Customer customer in customers)
            {
                Console.WriteLine($"{customer.FirstName}       {customer.LastName}          {customer.TypeOfCustomer}        {customer.Email}\n");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        private void AddCustomer()
        {
            Console.Clear();
            var customer = new Customer();

            Console.WriteLine("Enter your first name:");
            customer.FirstName = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            customer.LastName = Console.ReadLine();

            Console.WriteLine("Select a customer status: \n" +
                "1.) Potential\n" +
                "2.) Current\n" +
                "3.) Past");
            string customerStatusString = Console.ReadLine();
            switch (customerStatusString)
            {
                case "1":
                    customer.TypeOfCustomer = CustomerType.Potential;
                    break;
                case "2":
                    customer.TypeOfCustomer = CustomerType.Current;
                    break;
                case "3":
                    customer.TypeOfCustomer = CustomerType.Past;
                    break;
            }

            _customerRepo.AddCustomer(customer);
        }
        private void UpdateCustomerInfo()
        {
            Console.Clear();
            Console.WriteLine("Which customers info would you like to update?");
            List<Customer> customers = _customerRepo.GetAllCustomers();

            int count = 0;
            foreach (Customer customer in customers)
            {
                count++;
                Console.WriteLine($"{count}.) {customer.FirstName} {customer.LastName}");
            }

            int targetItemId = int.Parse(Console.ReadLine());
            int targetIndex = targetItemId - 1;
            if (targetIndex >= 0 && targetIndex < customers.Count)
            {
                Customer updatedCustomer = new Customer();
                Customer customer = customers[targetIndex];
                Console.WriteLine("Update First Name:");
                updatedCustomer.FirstName = Console.ReadLine();
                Console.WriteLine("Update Last Name:");
                updatedCustomer.LastName = Console.ReadLine();
                Console.WriteLine("Select a customer status: \n" +
                "1.) Potential\n" +
                "2.) Current\n" +
                "3.) Past");
                string customerStatusString = Console.ReadLine();
                switch (customerStatusString)
                {
                    case "1":
                        updatedCustomer.TypeOfCustomer = CustomerType.Potential;
                        break;
                    case "2":
                        updatedCustomer.TypeOfCustomer = CustomerType.Current;
                        break;
                    case "3":
                        updatedCustomer.TypeOfCustomer = CustomerType.Past;
                        break;
                }

                if (_customerRepo.UpdateCustomerInfo(customer, updatedCustomer))
                {
                    Console.WriteLine("Customers info is successfully updated\n" +
                        "Press any key to continue...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Customer info could not be updated");
                }
            }
            else
            {
                Console.WriteLine("Customer does not exist");
            }
        }
        private void DeleteCustomer()
        {
            Console.Clear();
            Console.WriteLine("Which customer would you like to remove?");
            List<Customer> customers = _customerRepo.GetAllCustomers();

            int count = 0;
            foreach (Customer customer in customers)
            {
                count++;
                Console.WriteLine($"{count}.) {customer.FirstName} {customer.LastName}");
            }

            int targetItemId = int.Parse(Console.ReadLine());
            int targetIndex = targetItemId - 1;
            if (targetIndex >= 0 && targetIndex < customers.Count)
            {
                Customer customer = customers[targetIndex];
                if (_customerRepo.DeleteCustomer(customer))
                {
                    Console.WriteLine($"{customer.FirstName} {customer.LastName} successfully deleted.");
                }
                else
                {
                    Console.WriteLine($"{customer.FirstName} {customer.LastName} was unable to be deleted. Try again.");
                }
            }
            else
            {
                Console.WriteLine("Customer does not exist");
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
