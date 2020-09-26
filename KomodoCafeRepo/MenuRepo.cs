using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCafeChallenge
{
   public class MenuRepo
    {
        public List<Meal> _menuItems = new List<Meal>();

        //Create
        public void AddItemToMenu(Meal item)
        {
            _menuItems.Add(item);
        }
        //Read
        public List<Meal> GetMenuItems()
        {
            return _menuItems;
        }
        //Delete
        public bool RemoveMenuItembyName(string mealName)
        {
            Meal item = GetMealByName(mealName);
            if(item == null)
            {
                return true;
            }
            else
            {
                return true;
            }
        }
        //Helper
        public Meal GetMealByName(string mealName)
        {
            foreach(Meal item in _menuItems)
            {
                if (item.Name == mealName)
                {
                    return item;
                }
            }
            return null;
        }
        
    }
}
