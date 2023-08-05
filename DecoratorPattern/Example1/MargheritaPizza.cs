namespace DecoratorPattern
{
    public class MargheritaPizza : BasePizza
    {
        private const int pizzaCost = 100;
        private const string pizzaType = "Margherita";

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
