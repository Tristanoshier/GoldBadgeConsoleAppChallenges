using System;
using System.Collections.Generic;
using CafeRepo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CafeTests
{
    [TestClass]
    public class CafeTest
    {
        [TestMethod]
        public void AddMenuItem_ShouldReturnCorrectBool()
        {
            Menu item = new Menu();
            MenuRepository menuRepo = new MenuRepository();

            bool itemAdded = menuRepo.AddMenuItem(item);

            Assert.IsTrue(itemAdded);
        }

        [TestMethod]
        public void GetAllMenuItems_ShouldReturnCorrectList()
        {
            Menu item = new Menu();
            MenuRepository menuRepo = new MenuRepository();
            menuRepo.AddMenuItem(item);

            List<Menu> menuItems = menuRepo.GetAllMenuItems();
            bool directoryContainsItem = menuItems.Contains(item);

            Assert.IsTrue(directoryContainsItem);
        }

        [TestMethod]
        public void DeleteMenuItem_ShouldReturnTrue()
        {
            Menu item = new Menu(1, "Coffee", "Our house made coffee", "coffee beans, water", 3.99);
            MenuRepository menuRepo = new MenuRepository();
            menuRepo.AddMenuItem(item);

            bool itemRemoved = menuRepo.DeleteMenuItem(item);

            Assert.IsTrue(itemRemoved);
        }
    }
}
