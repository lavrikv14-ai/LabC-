using System;

namespace RestaurandSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Restaurant restaurant = new Restaurant("Пий разом з Владом");
            Console.WriteLine($"=== Ресторан '{restaurant.Name}' ===\n");

            restaurant.ShowMenu();

            IMenuItem menuItem = new Dish("Вареники", 85, DishCategory.MainCourse, 200);
            Console.WriteLine(menuItem.GetDescription());

            if (menuItem is Dish dish)
                Console.WriteLine($"Downcast: вага = {dish.Weight}г");

            Order order1 = restaurant.CreateOrder(5);
            restaurant.AddItemToOrder(order1, 0);
            restaurant.AddItemToOrder(order1, 5);

            order1.ChangeStatus(OrderStatus.Ready);

            restaurant.DisplayAllOrders();

            Console.ReadKey();
        }
    }
}
