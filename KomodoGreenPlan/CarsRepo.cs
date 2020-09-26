using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KomodoGreenPlan
{
    public class GasCars
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
    public class ElectricCars
        
        public List<ElectricCars> _electricCars = new List<ElectricCars>();
        //Create
        public void AddElectricCarToList(GasCars electricCars)
        {
            _electricCars.Add(electricCars);
        }
        //Read
        //Update
        //Delete
        //Helper Method


        public List<HybridCars> _hybridCars = new List<HybridCars>();
        //Create
        //Read
        //Update
        //Delete
        //Helper Method
    }
}
