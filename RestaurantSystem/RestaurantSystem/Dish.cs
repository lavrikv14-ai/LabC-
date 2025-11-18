namespace RestaurandSystem
{
    public class Dish : MenuItem
    {
        private int _weight;

        public int Weight { get => _weight; set => _weight = value; }

        public Dish(string name, decimal price, DishCategory category, int weight)
            : base(name, price, category)
        {
            _weight = weight;
        }

        public override string GetDescription()
        {
            return $"{Name} ({GetCategoryName()}, {Weight}г) - {Price} грн";
        }

        private string GetCategoryName()
        {
            return Category switch
            {
                DishCategory.FirstCourse => "Перша страва",
                DishCategory.MainCourse => "Друга страва",
                DishCategory.Dessert => "Десерт",
                _ => "Інше"
            };
        }
    }
}
