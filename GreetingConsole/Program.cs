using GreetingRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            GreetingUI ui = new GreetingUI();
            ui.Run();
        }
    }
}
