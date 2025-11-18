namespace RestaurandSystem
{
    public class Beverage : MenuItem
    {
        private int _volume;
        private bool _isAlcoholic;

        public int Volume { get => _volume; set => _volume = value; }
        public bool IsAlcoholic { get => _isAlcoholic; set => _isAlcoholic = value; }

        public Beverage(string name, decimal price, int volume, bool isAlcoholic)
            : base(name, price, DishCategory.Beverage)
        {
            _volume = volume;
            _isAlcoholic = isAlcoholic;
        }

        public override string GetDescription()
        {
            string alcoholInfo = _isAlcoholic ? "алкогольний" : "безалкогольний";
            return $"{Name} ({Volume} мл, {alcoholInfo}) - {Price} грн";
        }
    }
}
