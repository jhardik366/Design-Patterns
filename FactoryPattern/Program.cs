using FactoryPattern;

class Program
{
    public static void Main()
    {
        ShapeFactory shapeFactory = new ShapeFactory();
        IShape shape = shapeFactory.GetShape("Circle");
        shape.Draw();
    }
}