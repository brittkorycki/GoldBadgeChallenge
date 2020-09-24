using KomodoCafeChallenge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCafeConsole
{
    public class CafeProgramUI
    {
       private MenuRepo menuRepo = new MenuRepo();

        public void Run()
        {
            SeedMealMenu();
            Options();
        }
        private void Options()
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
                        MenuRepo.AddItemToMenu();
                        break;
                    case "2":
                        MenuRepo.GetMenuItems();
                        break;
                    case "3":
                        MenuRepo.RemoveMenuItemByName();
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

        private void AddNewItemToMenu()
        {
            Console.Clear();
            Meal newMeal = new Meal();
            Console.WriteLine("Enter the number for the menu item:");
            string numberAsString = Console.ReadLine();
            newMeal.Number = int.Parse(numberAsString);
            Console.WriteLine("Enter the name for the menu item:");
            newMeal.Name = Console.ReadLine();
            Console.WriteLine("Enter a description for the menu item:");
            newMeal.Description = Console.ReadLine();
            Console.WriteLine("Enter the ingredients for the menu item:");
            //newMeal.List < Ingredients > = Console.ReadLine();

        }

    }
}
