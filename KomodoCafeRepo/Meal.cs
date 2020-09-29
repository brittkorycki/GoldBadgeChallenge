using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCafeChallenge
{
    public class Menu
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> IngredientsList = new List<string>();
        public object ingredientsList { get; set; }
        public decimal Price { get; set; }
        

        public Menu() { }

        public Menu(int number, string name, string description, List<string>ingredientsList, decimal price)
        {
            Number = number;
            Name = name;
            Description = description;
            IngredientsList = ingredientsList;
            Price = price;
        }
    }
}
