using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoGreenPlanConsole
{
    public class CarProgramUI
    {
        private CarsRepo _carsRepo = new CarsRepo();

        public void Run()
        { 
            Menu();
        }
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Select a list to use\n" +
                    "1. Gas Cars\n" +
                    "2. Electric Cars\n" +
                    "3. Hybrid Cars\n" +
                    "4. Exit");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        CarsRepo.GetGasCarsList();
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        Console.WriteLine("Goodbye!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please choose a valid option.");
                        break;
                }






            }
        }

    }
}
