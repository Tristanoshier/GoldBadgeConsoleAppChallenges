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
            Console.Clear();
            List<Outing> outings = _outingRepo.GetAllOutings();

            foreach(Outing outing in outings)
            {
                Console.WriteLine
                    (
                        $"----------------------------------\n" +
                        $"Event type: {outing.TypeOfEvent}\n" +
                        $"Number of people that attended: {outing.NumOfPeopleAttended}\n" +
                        $"Date of event: {outing.Date}\n" +
                        $"Total cost per person: {outing.CostPerPerson}\n" +
                        $"Total cost for the event: {outing.TotalCostOfEvent}"
                    );
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private void AddOuting()
        {
            Console.Clear();
            var outing = new Outing();

            //Type of Event
            Console.WriteLine("Select an Event Type: \n" +
                "1.) Golf\n" +
                "2.) Bowling\n" +
                "3.) Amusement Park\n" +
                "4.) Concert");
            string outingTypeString = Console.ReadLine();
            switch (outingTypeString)
            {
                case "1":
                    outing.TypeOfEvent = EventType.Golf;
                    break;
                case "2":
                    outing.TypeOfEvent = EventType.Bowling;
                    break;
                case "3":
                    outing.TypeOfEvent = EventType.AmusementPark;
                    break;
                case "4":
                    outing.TypeOfEvent = EventType.Concert;
                    break;
            }

            Console.WriteLine("Please enter the number of people that attended the event:");
            outing.NumOfPeopleAttended = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the date of the event: (DD-MM-YYYY)");
            outing.Date = Console.ReadLine();
            Console.WriteLine("Please enter the cost per person:");
            outing.CostPerPerson = double.Parse(Console.ReadLine());

            _outingRepo.AddOuting(outing);
        }

        private void SeeCostOfAllOutings()
        {

        }

        private void SeeSpecificOutingTypeCost()
        {

        }


    }
}
