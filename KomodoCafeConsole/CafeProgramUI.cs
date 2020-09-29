using KomodoCafeChallenge;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management.Instrumentation;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCafeConsole
{
    public class CafeProgramUI
    {
       public MenuRepo menuRepo = new MenuRepo();

        public void Run()
        {
            SeedMenuList();
            Options();
        }
        public void Options()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Select an option:\n" +
                    "1. Create New meal\n" +
                    "2. View all meals\n" +
                    "3. Delete existing meal\n" +
                    "4. Exit");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        AddNewItemToMenu();
                        break;
                    case "2":
                        DisplayMenuItems();
                        break;
                    case "3":
                        RemoveMenuItemByName();
                        break;
                    case "4":
                        Console.WriteLine("Goodbye!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public void AddNewItemToMenu()
        {
            Console.Clear();
            Menu newMeal = new Menu();
            Console.WriteLine("Enter the number for the menu item:");
            string numberAsString = Console.ReadLine();
            newMeal.Number = int.Parse(numberAsString);
            Console.WriteLine("Enter the name for the menu item:");
            newMeal.Name = Console.ReadLine();
            Console.WriteLine("Enter a description for the menu item:");
            newMeal.Description = Console.ReadLine();
            Console.WriteLine("Enter the ingredients for the menu item:");
            newMeal.IngredientsList.Add(Console.ReadLine());
            Console.WriteLine("Enter a price for the menu item:");
            string priceAsString = Console.ReadLine();
            newMeal.Price = decimal.Parse(priceAsString);
            menuRepo.AddItemToMenu(newMeal);
        }
        public void DisplayMenuItems()
        {
            Console.Clear();
            List<Menu> menuDisplay = menuRepo.GetMenuItems();
            foreach (Menu meal in menuDisplay)
            {
                Console.WriteLine($"Meal: {meal.Number}\n" +
                    $"Number: {meal.Name}\n" +
                    $"Description: {meal.Description}\n" +
                    $"Ingredients: {meal.IngredientsList}\n" +
                    $"Price: ${meal.Price}");
            }
         }
        public void RemoveMenuItemByName()
        {
            DisplayMenuItems();
            Console.WriteLine("Enter the name of the menu item you wish to delete.");
            string input = Console.ReadLine();
            bool wasDeleted = menuRepo.RemoveMenuItembyName(input);
            if (wasDeleted)
            {
                Console.WriteLine("The menu item was successfully deleted.");
            }
            else
            {
                Console.WriteLine("The menu item could not be deleted.");
            }
        }
        private void SeedMenuList()
        {
            Menu hamburger = new Menu(1, "Hamburger", "burger on bun", null, 1.25m);
            Menu cheeseburger = new Menu(2, "Cheeseburger", "burger with cheese on a bun", null, 1.75m);
            Menu nuggets = new Menu(3, "Chicken Nuggets", "nuggets", null, 2.00m);

            menuRepo.AddItemToMenu(hamburger);
            menuRepo.AddItemToMenu(cheeseburger);
            menuRepo.AddItemToMenu(nuggets);
          }
    }
}
