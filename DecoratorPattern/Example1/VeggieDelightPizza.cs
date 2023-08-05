namespace DecoratorPattern
{
    public class VeggieDelightPizza : BasePizza
    {
        private const int pizzaCost = 200;
        private const string pizzaType = "Veggie Delight";

        public override int Cost()
        {
            return pizzaCost;
        }

        public override string Description()
        {
            return pizzaType;
        }
    }
}
