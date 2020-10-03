using System;
using System.Collections.Generic;
using KomodoGreenPlan;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KomodoGreenPlanTests
{
    [TestClass]
    public class GreenPlanTests
    {
        CarRepository carRepo = new CarRepository();
        //List<Car> gasCar = new List<Car>();
        //List<Car> electricCar = new List<Car>();
        //List<Car> hybridCar = new List<Car>();

        [TestMethod]
        public void TestMehodAddCar()
        {
            //Arrange
            Car car1 = new Car();
            string Make = "Kia";
            string Model = "Sedona";
            string Type = "gas";
            int MilesPerGallon = 16;

            //Act
            car1.Make = Make;
            car1.Model = Model;
            car1.Type = Type;
            car1.MilesPerGallon = MilesPerGallon;
            carRepo.AddCarToList(car1);
            Car car = carRepo.GetCarByModel(Model);

            //Assert
            Assert.AreSame(car.Model, "Toyota", "car model does not match");
             


        }
    }
}
