using KomodoGreenPlan;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KomodoGreenPlanConsole
{
    public class CarProgramUI
    {
        public GasCars _gasCars = new GasCars();
        public ElectricCars _electricCars = new ElectricCars();
        public HybridCars _hybridCars = new HybridCars();

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
                        GetGasCarsList();
                        break;
                    case "2":
                        GetElectricCarsList();
                        break;
                    case "3":
                        GetHybricCarsList();
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
        public void GetGasCarsList()
        {
            Console.Clear();
            Console.WriteLine("Please select an option for the Gas Cars.\n" +
                "1. Create new car.\n" +
                "2. Update existing car.\n" +
                "3. Delete existing car.\n" +
                "4. Return to main menu.");
            List<GasCars> gasCars = GetGasCarsList();

                foreach (GasCars gasCars1 in gasCars)
                {
                Console.WriteLine($"Make: {gasCars1.Make}\n" +
                    $"Model: {gasCars1.Model}\n" +
                    $"Number of wheels: {gasCars1.NumberOfWheels}\n" +
                    $"Miles per gallon of gas: {gasCars1.MilesPerGallon}\n" +
                    $"");
                }
            string choice1 = Console.ReadLine();
            switch (choice1)
            {
                case "1":
                    CreateNewGasCar();
                    break;
                case "2":
                    UpdateExistingGasCar();
                    break;
                case "3":
                    DeleteExistingGasCar();
                    break;
                case "4":
                    Menu();
                    break;
                default:
                    Console.WriteLine("Please make a valid selection.");
                    break;
            }

        }
        public void CreateNewGasCar()
        {
            Console.Clear();
            GasCars newGasCar = new GasCars();
            Console.WriteLine("Please enter the make of the new gas car.");
            newGasCar.Make = Console.ReadLine();
            Console.WriteLine("Please enter the model of the new gas car.");
            newGasCar.Model = Console.ReadLine();


        }



    }
}
