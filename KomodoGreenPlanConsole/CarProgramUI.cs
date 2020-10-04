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
        private CarRepository carRepo = new CarRepository();

        public void Run()
        {
            Menu();
        }
        //display menu of each type of car
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Select menu option:\n" +
                    "1. Create new car\n" +
                    "2. Display all cars\n" +
                    "3. Update car\n" +
                    "4. Delete car\n" +
                    "5. Exit");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        CreateNewCar();
                        break;
                    case "2":
                        string choice1 = String.Empty;
                        while (choice1.ToLower() != "gas" && choice1.ToLower() != "electric" && choice1.ToLower() != "hybrid")
                        {
                            Console.WriteLine("Enter gas, electric, or hybrid");
                            choice1 = Console.ReadLine().ToLower();
                        }
                        List<Car> cars = carRepo.GetCarList(choice1);
                        DisplayCarList(cars);
                        break;
                    case "3":
                        UpdateExistingCar();
                        break;
                    case "4":
                        RemoveCarFromList();
                        break;
                    case "5":
                        Console.WriteLine("Goodbye!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please choose a valid option.");
                        break;
                }

            }
        }



        //Create new car
        private void CreateNewCar()
        {
            string type = String.Empty;
            Console.Clear();
            Car newCar = new Car();
            Console.WriteLine("Please enter the make of the new car.");
            newCar.Make = Console.ReadLine();
            Console.WriteLine("Please enter the model of the new car.");
            newCar.Model = Console.ReadLine();
            while (type.ToLower() != "gas" && type.ToLower() != "electric" && type.ToLower() != "hybrid")
            {
                Console.WriteLine("Please enter the type of new car.");
                type = Console.ReadLine();
            }
            newCar.Type = type;
            Console.WriteLine("Please enter the miles per gallon of the new gas car.");
            string milesPerGallonAsString = Console.ReadLine();
            newCar.MilesPerGallon = int.Parse(milesPerGallonAsString);
            carRepo.AddCarToList(newCar);
        }
        //Display car lists
        private void DisplayCarList(List<Car> cars)
        {
            foreach (Car car in cars)
            {
                Console.WriteLine(car.Make + " " + car.Model + " " + car.Type + " " + car.MilesPerGallon + "\n");
            }
        }
        //Update existing car
        private void UpdateExistingCar()
        {
            Console.WriteLine("Enter the make of the car:");
            string Make = Console.ReadLine();
            Console.WriteLine("Enter the model of the car:");
            string Model = Console.ReadLine();
            Console.WriteLine("Enter the miles per gallon of the car:");
            string milesPerGallonAsString = Console.ReadLine();
            int MilesPerGallon = int.Parse(milesPerGallonAsString);
            carRepo.UpdateCar(Make, Model, MilesPerGallon);
        }
        //Delete existing car
        private void RemoveCarFromList()
        {

            Console.WriteLine("Enter the model of car you would like to remove.");
            string choice2 = Console.ReadLine();
            Car car = carRepo.GetCarByModel(choice2);
            if (car != null)
            {
                bool wasCarDeleted = carRepo.RemoveCarFromList(car);
                if (wasCarDeleted)
                {
                    Console.WriteLine("The car was successfully deleted.");
                }
                else
                {
                    Console.WriteLine("The car could not be deleted.");
                }
            }


        }
    }
}
