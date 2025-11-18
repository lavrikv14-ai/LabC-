using System;
using System.Collections.Generic;
using System.Linq;

namespace RestaurandSystem
{
    public class Restaurant
    {
        private string _name;
        private Menu _menu;
        private List<Order> _orders;

        public string Name { get => _name; set => _name = value; }

        public Restaurant(string name)
        {
            _name = name;
            _menu = new Menu();
            _orders = new List<Order>();
            InitializeMenu();
        }

        private void InitializeMenu()
        {
            _menu.AddItem(new Dish("Шашлик", 140, DishCategory.FirstCourse, 150));
            _menu.AddItem(new Dish("Крем-суп з гарбуза", 110, DishCategory.FirstCourse, 300));
            _menu.AddItem(new Dish("Куряча відбивна з картопляним пюре", 100, DishCategory.MainCourse, 250));
            _menu.AddItem(new Dish("Шоколадний фондю з ягодами", 500, DishCategory.MainCourse, 300));
            _menu.AddItem(new Dish("Салат із буряка з сиром фета", 150, DishCategory.Dessert, 100));

            _menu.AddItem(new Beverage("Водка", 30, 50, true));
            _menu.AddItem(new Beverage("Віскі", 150, 50, true));
            _menu.AddItem(new Beverage("Пиво", 500, 500, true));
            _menu.AddItem(new Beverage("Байкал", 30, 500, false));
        }

        public void ShowMenu() => _menu.DisplayMenu();

        public Order CreateOrder(int tableNumber)
        {
            Order order = new Order(tableNumber);
            _orders.Add(order);
            Console.WriteLine($"\nСтворено нове замовлення #{order.OrderId} для столика №{tableNumber}");
            return order;
        }

        public void AddItemToOrder(Order order, int index)
        {
            var item = _menu.GetItemByIndex(index);
            if (item != null)
                order.AddItem(item);
            else
                Console.WriteLine("Невірний номер позиції меню");
        }

        public Order FindOrderById(int id)
        {
            return _orders.FirstOrDefault(o => o.OrderId == id);
        }

        public void DisplayAllOrders()
        {
            Console.WriteLine("\n--- УСІ ЗАМОВЛЕННЯ ---");
            if (_orders.Count == 0)
                Console.WriteLine("Немає активних замовлень");
            else
                foreach (var o in _orders)
                    Console.WriteLine(o.GetShortInfo());
        }

        public void SearchMenuByName(string name)
        {
            var items = _menu.SearchByName(name);
            Console.WriteLine($"\n--- Пошук за '{name}' ---");
            foreach (var item in items)
                Console.WriteLine(item.GetDescription());
        }

        public void SearchMenuByCategory(DishCategory category)
        {
            var items = _menu.SearchByCategory(category);
            Console.WriteLine($"\n--- Пошук за категорією '{category}' ---");
            foreach (var item in items)
                Console.WriteLine(item.GetDescription());
        }
    }
}
