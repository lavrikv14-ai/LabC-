using System;
using System.Collections.Generic;

namespace RestaurandSystem
{
    public class Order
    {
        private static int _nextId = 100;

        private int _orderId;
        private int _tableNumber;
        private List<IMenuItem> _items;
        private OrderStatus _status;

        public int OrderId => _orderId;
        public int TableNumber { get => _tableNumber; set => _tableNumber = value; }
        public OrderStatus Status { get => _status; set => _status = value; }

        public Order(int tableNumber)
        {
            _orderId = ++_nextId;
            _tableNumber = tableNumber;
            _items = new List<IMenuItem>();
            _status = OrderStatus.New;
        }

        public void AddItem(IMenuItem item)
        {
            _items.Add(item);
            Console.WriteLine($"Додано позицію: {item.Name}");
        }

        public void RemoveItem(IMenuItem item)
        {
            if (_items.Remove(item))
                Console.WriteLine($"Видалено позицію: {item.Name}");
            else
                Console.WriteLine("Позицію не знайдено в замовленні");
        }

        public decimal CalculateTotal()
        {
            decimal total = 0;
            foreach (var item in _items)
                total += item.Price;
            return total;
        }

        public void ChangeStatus(OrderStatus newStatus)
        {
            _status = newStatus;
            Console.WriteLine($"> Змінено статус: {_status}");
        }

        public void DisplayOrder()
        {
            Console.WriteLine($"\nЗамовлення #{_orderId} | Стіл #{_tableNumber}");
            Console.WriteLine($"Статус: {_status}");
            Console.WriteLine("Позиції:");
            foreach (var item in _items)
                Console.WriteLine($"  - {item.Name} ({item.Price} грн)");

            Console.WriteLine($"Загальна сума: {CalculateTotal()} грн\n");
        }

        public string GetShortInfo()
        {
            return $"ID: {_orderId} | Стіл: {_tableNumber} | Статус: {_status} | Сума: {CalculateTotal()} грн";
        }
    }
}
