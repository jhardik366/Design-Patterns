namespace FactoryPattern
{
    public class ShapeFactory
    {
        public IShape GetShape(string input)
        {
            return input switch
            {
                "Circle" => new Circle(),
                "Rectangle" => new Rectangle(),
                "Square" => new Square(),
                _ => throw new NotImplementedException("Working on this shape."),
            };
        }
    }
}
