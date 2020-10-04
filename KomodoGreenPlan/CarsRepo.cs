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
            if (car.Type.ToLower() == "gas")
            {
                gasCar.Add(car);
            }
            else if (car.Type.ToLower() == "electric")
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
        public void UpdateCar(string make, string model, int mpg)
        {
            foreach (Car car in gasCar)
            {
                if (car.Make == make && car.Model == model)
                {
                    car.Make = make;
                    car.Model = model;
                    car.MilesPerGallon = mpg;
                    break;
                }
            }
            foreach (Car car in electricCar)
            {
                if (car.Make == make && car.Model == model)
                {
                    car.Make = make;
                    car.Make = model;
                    car.MilesPerGallon = mpg;
                    break;
                }
            }

            foreach (Car car in hybridCar)
            {
                if (car.Make == make && car.Model == model)
                {
                    car.Make = make;
                    car.Make = model;
                    car.MilesPerGallon = mpg;
                    break;
                }
            }
          
        }
        //Delete
        public bool RemoveCarFromList(Car car)
        {
            if(car.Type == "Gas")
            {
                gasCar.Remove(car);
            }
            else if(car.Type == "Electric")
            {
                electricCar.Remove(car);
            }
            else if(car.Type == "Hybrid")
            {
                hybridCar.Remove(car);
            }
            return true; 
        }
        //Helper Method
        public Car GetCarByModel(string model)
        {
            Car rtnCar = new Car();

            foreach (Car car in gasCar)
            {
                if (car.Model.ToLower() == model.ToLower())
                {
                    rtnCar = car;
                    break;
                }
            }

            if (rtnCar != null)

            {
                foreach (Car car1 in electricCar)
                {
                    if (car1.Model.ToLower() == model.ToLower())
                    {
                        rtnCar = car1;
                        break;
                    }
                }
            }

            if (rtnCar != null)
           
            {
                foreach (Car car2 in hybridCar)
                {
                    if (car2.Model.ToLower() == model.ToLower())
                    {
                        rtnCar = car2;
                        break;
                    }
                }
                                              
              
            }
            return rtnCar;
        }

    }
}