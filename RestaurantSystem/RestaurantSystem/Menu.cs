using System;
using System.Collections.Generic;
using System.Linq;

namespace RestaurandSystem
{
    public class Menu
    {
        private List<IMenuItem> _items = new List<IMenuItem>();

        public void AddItem(IMenuItem item)
        {
            _items.Add(item);
        }

        public void DisplayMenu()
        {
            Console.WriteLine("\n--- МЕНЮ РЕСТОРАНУ ---");
            for (int i = 0; i < _items.Count; i++)
                Console.WriteLine($"{i + 1}. {_items[i].GetDescription()}");
            Console.WriteLine();
        }

        public IMenuItem GetItemByIndex(int index)
        {
            return index >= 0 && index < _items.Count ? _items[index] : null;
        }

        public List<IMenuItem> SearchByName(string name)
        {
            return _items.Where(i => i.Name.ToLower().Contains(name.ToLower())).ToList();
        }

        public List<IMenuItem> SearchByCategory(DishCategory category)
        {
            return _items.Where(i => i.Category == category).ToList();
        }

        public int ItemCount => _items.Count;
    }
}
