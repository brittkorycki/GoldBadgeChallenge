using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoGreenPlan
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public int MilesPerGallon { get; set; }

        public Car() { }

        public Car(string make, string model, string type, int milesPerGallon)
        {
            Make = make;
            Model = model;
            Type = type;
            MilesPerGallon = milesPerGallon;
        }
    }
}
   
