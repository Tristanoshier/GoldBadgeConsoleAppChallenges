using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOutingsRepository
{
    public enum EventType { Golf, Bowling, AmusementPark, Concert }
    public class Outing
    {
        public Outing()
        {
        }

        public Outing(int numOfPeopleAttended, string date, double costPerPerson, EventType typeOfEvent)
        {
            NumOfPeopleAttended = numOfPeopleAttended;
            Date = date;
            CostPerPerson = costPerPerson;
            TypeOfEvent = typeOfEvent;
        }

        public int NumOfPeopleAttended { get; set; }
        public string Date { get; set; }
        public double CostPerPerson { get; set; }
        public EventType TypeOfEvent { get; set; }
        public double TotalCostOfEvent
        {
            get
            {
                return NumOfPeopleAttended * CostPerPerson;
            }
        }
    }
}
