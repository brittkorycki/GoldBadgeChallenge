using System;
using System.Collections.Generic;
using KomodoCafeChallenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KomodoCafeTests
{
    [TestClass]
    public class CafeUnitTest1
    {
        public MenuRepo menuRepo = new MenuRepo();
        public Menu menu = new Menu();

        [TestMethod]
        public void TestMethodAddNewItem()
        {
            //Arrange
            Menu newMeal = new Menu();
            int Number = 4;
            string Name = "burger";
            string Description = "hamburger";
            List<string> IngredientsList = new List<string>();
            IngredientsList.Add("bun");
            IngredientsList.Add("patty");
            decimal Price = 2.50m;


            //Act
            newMeal.Number = Number;
            newMeal.Name = Name;
            newMeal.Description = Description;
            newMeal.IngredientsList = IngredientsList;
            newMeal.Price = Price;
            menuRepo.AddItemToMenu(newMeal);
            Menu item = menuRepo.GetMealByName(Name);
            //Assert
            Assert.AreSame(item.Name, "burger", "menu item name does not match.");
        }
        [TestMethod]
        public void TestMethodRemoveItem()
        {
            //Arrange
            Menu Meal = new Menu();
            string Name = "burger";

            //Act

            menuRepo.RemoveMenuItembyName(Name);

            //Assert
            Assert.IsNull(menuRepo.GetMealByName(Name), "Menu item not found.");
        }
        [TestMethod]
        public void TestMethodGetMenuItems()
        {
            //Arrange
            List<Menu> _menuItems = new List<Menu>();
            //Act
            _menuItems = menuRepo.GetMenuItems();
            //Assert
            Assert.IsNotNull(_menuItems, "No menu items found.");
        }
    }
}



