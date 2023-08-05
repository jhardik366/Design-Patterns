namespace DecoratorPattern
{
    public class MushroomTopping : ToppingDecorator
    {
        private readonly BasePizza _basePizza;
        private const int toppingCost = 50;
        private const string toppingType = "Mushroom";

        public MushroomTopping(BasePizza basePizza)
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
