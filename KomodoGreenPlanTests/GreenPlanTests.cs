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
            Assert.AreSame(car.Model, "Sedona", "car model does not match");
             
        }
        [TestMethod]
        public void TestUpdateCar()
        {
            //Arrange
            Car newCar = new Car();
            string Make = "Kia";
            string Model = "Sedona";
            int MilesPerGallon = 35;
           
            //Act
            newCar.Make = Make;
            newCar.Model = Model;
            newCar.MilesPerGallon = MilesPerGallon;
            carRepo.UpdateCar(Make, Model, MilesPerGallon);
            
            //Assert
            Assert.AreNotEqual(Model, "Forte");
        }
        [TestMethod]
        public void TestRemoveCar()
        {
            //Arrange
            Car car = new Car();
            string Model = "Forte";
            //Act
            carRepo.RemoveCarFromList(car);
            //Assert
            Assert.IsNotNull(carRepo.GetCarByModel(Model), "car not found.");

        }
        [TestMethod]
        public void TestGetCarList()
        {
            //Arrange
            List<Car> cars = new List<Car>();
            //Act
            cars = carRepo.GetCarList("gas");
            //Assert
            Assert.IsNotNull(cars, "No cars list found.");
        }
    }
}
