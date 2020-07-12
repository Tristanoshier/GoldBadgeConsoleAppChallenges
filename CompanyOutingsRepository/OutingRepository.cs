using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOutingsRepository
{
    public class OutingRepository
    {
        protected readonly List<Outing> _outingDirectory = new List<Outing>();

        //GET ALL
        public List<Outing> GetAllOutings()
        {
            return _outingDirectory;
        }

        //POST
        public bool AddOuting(Outing outing)
        {
            int count = _outingDirectory.Count;
            _outingDirectory.Add(outing);
            bool success = (_outingDirectory.Count > count) ? true : false;
            return success;
        }

        //GET OUTINGS BY TYPE
        public List<Outing> GetAllOutingsByType(string outingType)
        {
            List<Outing> specificTypeList = new List<Outing>();
            foreach(Outing outing in _outingDirectory)
            {
                if(outing.TypeOfEvent.ToString().ToLower() == outingType.ToLower())
                {
                    specificTypeList.Add(outing);
                }
            }
            return specificTypeList;
        }
    }
}
