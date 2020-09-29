using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCafeChallenge
{
   public class MenuRepo
    {
        public List<Menu> _menuItems = new List<Menu>();

        //Create
        public void AddItemToMenu(Menu item)
        {
            _menuItems.Add(item);
        }
        //Read
        public List<Menu> GetMenuItems()
        {
            return _menuItems;
        }
        //Delete
        public bool RemoveMenuItembyName(string mealName)
        {
            Menu item = GetMealByName(mealName);
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
        public Menu GetMealByName(string mealName)
        {
            foreach(Menu item in _menuItems)
            {
                if (item.Name == mealName)
                {
                    return item;
                }
            }
            return null;
        }
        public void AddIngredientsToList(List<string> ingredients)
        {
            ingredients.Add("bread");
            ingredients.Add("burger patty");
            ingredients.Add("pickle");
        }
        
    }
}
