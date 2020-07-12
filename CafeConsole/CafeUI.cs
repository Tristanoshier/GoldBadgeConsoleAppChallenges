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
            SeedMenuData();
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
                        DeleteMenuItem();
                        break;
                    case "3":
                        SeeAllMenuItems();
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

        private void DeleteMenuItem()
        {
            Console.WriteLine("Which menu item would you like to remove?");
            List<Menu> menuItems = _menuRepo.GetAllMenuItems();

            int count = 0;
            foreach(Menu item in menuItems)
            {
                count++;
                Console.WriteLine($"{item.MealNumber}.) {item.MealName}");
            }

            int targetItemId = int.Parse(Console.ReadLine());
            int targetIndex = targetItemId - 1;
            if(targetIndex >= 0 && targetIndex < menuItems.Count)
            {
                Menu item = menuItems[targetIndex];
                if(_menuRepo.DeleteMenuItem(item))
                {
                    Console.WriteLine($"{item.MealName} successfully deleted.");
                }
                else
                {
                    Console.WriteLine($"{item.MealName} was unable to be deleted. Try again.");
                }
            } else
            {
                Console.WriteLine("Menu item ID does not exist");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private void SeeAllMenuItems()
        {
            Console.Clear();
            List<Menu> menuItems = _menuRepo.GetAllMenuItems();

            foreach(Menu item in menuItems)
            {
                Console.WriteLine
                    (
                        $"-----------------------\n" +
                        $"Number: {item.MealNumber}\n" +
                        $"Name: {item.MealName}\n" +
                        $"Description: {item.Description}\n" +
                        $"Ingredients: {item.Ingredients}\n" +
                        $"Price: ${item.Price}"
                    );
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }

        private void SeedMenuData()
        {
            var itemOne = new Menu(1, "Coffee", "Our house made coffee", "coffee beans, water", 3.99);
            var itemTwo = new Menu(2, "Komodo Club", "Our house club sandwich", "Tomato, Onion, Turkey, Mayo, Lettuce", 9.99);
            var itemThree = new Menu(3, "Komodo pizza", "A personal pizza serves 1-2", "Pepperoni, Cheese, bread", 8.99);

            _menuRepo.AddMenuItem(itemOne);
            _menuRepo.AddMenuItem(itemTwo);
            _menuRepo.AddMenuItem(itemThree);

        }
    }
}
