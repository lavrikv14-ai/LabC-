namespace RestaurandSystem
{
    public interface IMenuItem
    {
        string Name { get; }
        decimal Price { get; }
        DishCategory Category { get; }
        string GetDescription();
    }
}
