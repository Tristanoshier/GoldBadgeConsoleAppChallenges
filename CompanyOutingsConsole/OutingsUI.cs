using CompanyOutingsRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOutingsConsole
{
    public class OutingsUI
    {
        private readonly OutingRepository _outingRepo = new OutingRepository();

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
                        $"Welcome Komodo Accountant!\n" +
                        $"1.) See all outings\n" +
                        $"2.) Add an outing\n" +
                        $"3.) See cost of all outings\n" +
                        $"4.) See cost of outing by type\n" +
                        $"5.) Quit"
                    );
                string userInput = Console.ReadLine();
                switch(userInput)
                {
                    case "1":
                        //SeeAllOutings();
                        break;
                    case "2":
                        //AddOuting();
                        break;
                    case "3":
                        //SeeCostOfAllOutings();
                        break;
                    case "4":
                        //SeeSpecificOutingTypeCost();
                        break;
                    case "5":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please enter an option between 1 and 4\n" +
                            "Press any key to continue");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private void SeeAllOutings()
        {
           

        }

        private void AddOuting()
        {

        }

        private void SeeCostOfAllOutings()
        {

        }

        private void SeeSpecificOutingTypeCost()
        {

        }


    }
}
