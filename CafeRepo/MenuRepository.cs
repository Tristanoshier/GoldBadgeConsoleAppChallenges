using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRepo
{
    public class MenuRepository
    {
        protected readonly List<Menu> _menuDirectory = new List<Menu>();

        //POST
        public bool AddMenuItem(Menu item)
        {
            int count = _menuDirectory.Count;
            _menuDirectory.Add(item);
            bool success = (_menuDirectory.Count > count) ? true : false;
            return success;
        }

        //GET ALL
        public List<Menu> GetAllMenuItems()
        {
            return _menuDirectory;
        }

        //DELETE
        public bool DeleteMenuItem(Menu item)
        {
            bool success = _menuDirectory.Remove(item);
            return success;
        }
    }
}
