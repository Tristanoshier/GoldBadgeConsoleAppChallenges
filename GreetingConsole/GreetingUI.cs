using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingConsole
{
    public class GreetingUI
    {

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
                        //SeeAllCustomers();
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
    }
}
