using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCafeChallenge
{
    public class Meal
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        List<string> Ingredients = new List<string>();
        public decimal Price { get; set; }
        

        public Meal() { }

        public Meal(int number, string name, string description, List<string>ingredients, decimal price)
        {
            Number = number;
            Name = name;
            Description = description;
            Ingredients = ingredients;
            Price = price;
        }
    }
}
