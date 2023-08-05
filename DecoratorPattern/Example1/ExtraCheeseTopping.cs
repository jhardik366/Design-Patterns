namespace DecoratorPattern
{
    public class ExtraCheeseTopping : ToppingDecorator
    {
        private readonly BasePizza _basePizza;
        private const int toppingCost = 30;
        private const string toppingType = "Extra Cheese";

        public ExtraCheeseTopping(BasePizza basePizza)
        {
            _basePizza = basePizza;
        }

        public override int Cost()
        {
            return _basePizza.Cost() + toppingCost;
        }

        public override string Description()
        {
            return $"{_basePizza.Description()}, {toppingType}";
        }
    }
}
