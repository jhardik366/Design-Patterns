using FactoryPattern;

class Program
{
    public static void Main()
    {
        try
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            IShape shape = shapeFactory.GetShape("Circles");
            shape.Draw();
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}