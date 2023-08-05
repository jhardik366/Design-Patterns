namespace DecoratorPattern
{
    public class FarmhousePizza : BasePizza
    {
        private const int pizzaCost = 150;
        private const string pizzaType = "Farmhouse";

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
