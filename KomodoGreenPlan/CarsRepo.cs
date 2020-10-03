using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KomodoGreenPlan
{
    public class CarRepository
    {
        
        public List<Car> gasCar = new List<Car>();
        public List<Car> electricCar = new List<Car>();
        public List<Car> hybridCar = new List<Car>();
        //Create
        public void AddCarToList(Car car)
        {
            if (car.Type == "Gas")
            {
                gasCar.Add(car);
            }
            else if (car.Type == "Electric")
            {
                electricCar.Add(car);
            }
            else 
            {
                hybridCar.Add(car);
            }
        }
        //Read
        public List<Car> GetCarList(string choice)
        {
            switch (choice)
            {
                case "gas":
                    return gasCar;
                    break;
                case "electric":
                    return electricCar;
                    break;
                case "hybrid":
                    return hybridCar;
                    break;
                default:
                    return null;
                    break;
            }
        }
        //Update
        public bool UpdateCar(string originalModel, Car newCar)
        {
            Car oldCar = GetCarByModel(originalModel);
            if (oldCar != null)
            {
                oldCar.Make = newCar.Make;
                oldCar.Model = newCar.Model;
                oldCar.Type = newCar.Type;
                oldCar.MilesPerGallon = newCar.MilesPerGallon;
                return true;
            }
            else
            {
                return false;
            }
        }
        //Delete
        public void RemoveCarFromList(string model)
        { 
            Car car = GetCarByModel(model);
            if (car == null)
            {
                Console.WriteLine("The car could not be found.");   
            }
            else if(car = model)
            {
                gasCar.Remove(car);
                Console.WriteLine("The car was removed from the gas cars list.");
            }
            else if(car = model)
            {
                electricCar.Remove(car);
                Console.WriteLine("The car was removed from the electric cars list.");
            }
            else
            {
                hybridCar.Remove(car);
                Console.WriteLine("The car was removed from the hybrid cars list.");
            }
        }
        //Helper Method
        public Car GetCarByModel(string model)
        {
            foreach (Car car in gasCar)
            {
                if (car.Model.ToLower() == model.ToLower())
                {
                    return car;
                }
                else
                {
                    foreach (Car car1 in electricCar)
                    {
                        if (car1.Model.ToLower() == model.ToLower())
                        {
                            return car1;
                        }
                        else
                        {
                            foreach (Car car2 in hybridCar)
                            {
                                if (car2.Model.ToLower() == model.ToLower())
                                {
                                    return car2;
                                }
                            }
                        }
                    }
                }
                    return null;                         
              
            }
                         
        }

    }
}