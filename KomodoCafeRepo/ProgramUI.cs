using KomodoCafeChallenge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCafeConsole
{
    class ProgramUI
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
                    "3. Delete existing meal");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        AddItemToMenu();
                        break;
                }
            }
        }

    }
}
