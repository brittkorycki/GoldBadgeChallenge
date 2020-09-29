using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KomodoGreenPlan
{
           public class GasCarsRepository
           {
            public List<GasCars> _gasCars = new List<GasCars>();
            //Create
            public void AddGasCarToList(GasCars gasCars)
            {
                _gasCars.Add(gasCars);
            }
            //Read
            public List<GasCars> GetGasCarsList()
            {
                return _gasCars;
            }
            //Update
            public bool UpdateGasCars(string originalModel, GasCars newGasCars)
            {
                GasCars oldGasCars = GetGasCarsByModel(originalModel);
                if (oldGasCars != null)
                {
                    oldGasCars.Make = newGasCars.Make;
                    oldGasCars.Model = newGasCars.Model;
                    oldGasCars.UsesGas = newGasCars.UsesGas;
                    oldGasCars.NumberOfWheels = newGasCars.NumberOfWheels;
                    oldGasCars.MilesPerGallon = newGasCars.MilesPerGallon;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            //Delete
            public bool RemoveGasCarsFromList(string model)
            {
                GasCars gasCar = GetGasCarsByModel(model);
                if (model == null)
                {
                    return false;
                }
                else
                {
                    return false;
                }
            }
            //Helper Method
            public GasCars GetGasCarsByModel(string model)
            {
                foreach (GasCars gasCar in _gasCars)
                {
                    if (gasCar.Model.ToLower() == model.ToLower())
                    {
                        return model;
                    }
                }
                return null;
            }

           }
        public class ElectricCarsRepository
        {
            public List<ElectricCars> _electricCars = new List<ElectricCars>();
            //Create
            public void AddElectricCarToList(ElectricCars electricCars)
            {
                _electricCars.Add(electricCars);
            }
            //Read
            public List<ElectricCars> GetGElectricCarsList()
            {
                return _electricCars;
            }
            //Update
            public bool UpdateElectricCars(string originalModel, ElectricCars newElectricCars)
            {
                ElectricCars oldElectricCars = GetElectricCarsByModel(originalModel);
                if (oldElectricCars != null)
                {
                    oldElectricCars.Make = newElectricCars.Make;
                    oldElectricCars.Model = newElectricCars.Model;
                    oldElectricCars.IsElectric = newElectricCars.IsElectric;
                    oldElectricCars.NumberOfWheels = newElectricCars.NumberOfWheels;
                    oldElectricCars.MilesPerGallon = newElectricCars.MilesPerGallon;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            //Delete
            public bool RemoveElectricCarsFromList(string model)
            {
                ElectricCars electricCar = GetElectricCarsByModel(model);
                if (model == null)
                {
                    return false;
                }
                else
                {
                    return false;
                }
            }
            //Helper Method
            public ElectricCars GetElectricCarsByModel(string model)
            {
                foreach (ElectricCars electricCar in _electricCars)
                {
                    if (electricCar.Model.ToLower() == model.ToLower())
                    {
                        return model;
                    }
                }
                return null;
            }

        }
        public class HybridCarsRepository
        {
            public List<HybridCars> _hybridCars = new List<HybridCars>();
            //Create
            public void AddHybridCarToList(HybridCars hybridCars)
            {
                _hybridCars.Add(hybridCars);
            }
            //Read
            public List<HybridCars> GetHybridCarsList()
            {
                return _hybridCars;
            }
            //Update
            public bool UpdateHybridCars(string originalModel, HybridCars newHybridCars)
            {
                HybridCars oldHybridCars = GetHybridCarsByModel(originalModel);
                if (oldHybridCars != null)
                {
                    oldHybridCars.Make = newHybridCars.Make;
                    oldHybridCars.Model = newHybridCars.Model;
                    oldHybridCars.IsHybrid = newHybridCars.IsHybrid;
                    oldHybridCars.NumberOfWheels = newHybridCars.NumberOfWheels;
                    oldHybridCars.MilesPerGallon = newHybridCars.MilesPerGallon;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            //Delete
            public bool RemoveHybridCarsFromList(string model)
            {
                HybridCars hybridCar = GetHybridCarsByModel(model);
                if (model == null)
                {
                    return false;
                }
                else
                {
                    return false;
                }
            }
            //Helper Method
            public HybridCars GetHybridCarsByModel(string model)
            {
                foreach (HybridCars hybridCar in _hybridCars)
                {
                    if (hybridCar.Model.ToLower() == model.ToLower())
                    {
                        return model;
                    }
                }
                return null;
            }
        }
}