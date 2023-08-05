using DecoratorPattern;

class Program
{
    public static void Main()
    {
        BasePizza pizza1 = new ExtraCheeseTopping(new MushroomTopping(new FarmhousePizza()));
        Console.WriteLine($"Pizza Type: {pizza1.Description()}");
        Console.WriteLine($"Cost: {pizza1.Cost()}");

        BasePizza pizza2 = new MushroomTopping(new MargheritaPizza());
        Console.WriteLine($"Description: {pizza2.Description()}");
        Console.WriteLine($"Cost: {pizza2.Cost()}");

        BasePizza pizza3 = new ExtraCheeseTopping(new VeggieDelightPizza());
        Console.WriteLine($"Description: {pizza3.Description()}");
        Console.WriteLine($"Cost: {pizza3.Cost()}");
    }
}