using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoGreenPlan
{
    public class GasCars
    {  
        public string Make { get; set; }
        public string Model { get; set; }
        public bool UsesGas { get; set; }
        public int NumberOfWheels { get; set; }
        public int MilesPerGallon { get; set; }
        
        public GasCars() { }

        public GasCars (string make, string model, bool usesGas, int numberofWheels, int milesPerGallon)
        {
            Make = make;
            Model = model;
            UsesGas = usesGas;
            NumberOfWheels = numberofWheels;
            MilesPerGallon = milesPerGallon;
        }
    }
    public class ElectricCars
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public bool IsElectric { get; set; }
        public int NumberOfWheels { get; set; }
        public int MilesPerGallon { get; set; }
        public ElectricCars() { }

        public ElectricCars(string make, string model, bool isElectric, int numberofWheels, int milesPerGallon)
        {
            Make = make;
            Model = model;
            IsElectric = isElectric;
            NumberOfWheels = numberofWheels;
            MilesPerGallon = milesPerGallon;
        }
    }
    public class HybridCars
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public bool IsHybrid { get; set; }
        public int NumberOfWheels { get; set; }
        public int MilesPerGallon { get; set; }
        public HybridCars() { }

        public HybridCars(string make, string model, bool isHybrid, int numberofWheels, int milesPerGallon)
        {
            Make = make;
            Model = model;
            IsHybrid = IsHybrid;
            NumberOfWheels = numberofWheels;
            MilesPerGallon = milesPerGallon;
        }
    }
}
