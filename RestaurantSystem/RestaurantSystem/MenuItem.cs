namespace RestaurandSystem
{
    public abstract class MenuItem : IMenuItem
    {
        private string _name;
        private decimal _price;
        private DishCategory _category;

        public string Name { get => _name; protected set => _name = value; }
        public decimal Price { get => _price; protected set => _price = value; }
        public DishCategory Category { get => _category; protected set => _category = value; }

        protected MenuItem(string name, decimal price, DishCategory category)
        {
            _name = name;
            _price = price;
            _category = category;
        }

        public abstract string GetDescription();
    }
}
