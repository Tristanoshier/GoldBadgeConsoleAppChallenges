using CafeRepo;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeConsole
{
    public class CafeUI
    {
        private readonly MenuRepository _menuRepo = new MenuRepository();

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
                        "Welcome Manager of Komodo Cafe!\n" +
                        "1.) Add menu item\n" +
                        "2.) Delete menu item\n" +
                        "3.) See all menu items\n" +
                        "4.) quit"
                    );
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        AddMenuItem();
                        break;
                    case "2":
                        //DeleteMenuItem();
                        break;
                    case "3":
                        //SeeAllMenuItems();
                        break;
                    case "4":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please enter and option between 1 and 4. \n" +
                            "Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            } 
        }

        private void AddMenuItem()
        {
            Console.Clear();
            var item = new Menu();

            Console.WriteLine("Enter a Menu item number:");
            item.MealNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the name of the menumenu item:");
            item.MealName = Console.ReadLine();
            Console.WriteLine("Enter a description of the menu item:");
            item.Description = Console.ReadLine();
            Console.WriteLine("Enter the ingredients of the menu item:");
            item.Ingredients = Console.ReadLine();
            Console.WriteLine("Enter the price of the menu item:");
            item.Price = double.Parse(Console.ReadLine());

            _menuRepo.AddMenuItem(item);
        }

        public void SeedMenuData()
        {

        }
    }
}
