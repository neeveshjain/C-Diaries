using System.Collections.Generic;

class Burger
{
    // fields matching what BurgerDefination collected
    private string patty;
    private string bun;
    private bool withCheese;
    private string withDrink;
    private string withSide;
    private List<string> toppings;

    // Only the Builder should construct a Burger, so this stays private
    private Burger(string patty, string bun, bool withCheese, string withDrink, string withSide, List<string> toppings)
    {
        this.patty = patty;
        this.bun = bun;
        this.withCheese = withCheese;
        this.withDrink = withDrink;
        this.withSide = withSide;
        this.toppings = toppings;
    }

    public class BurgerBuilder
    {
        // required
        private string patty;
        private string bun;

        // optional
        private bool withCheese;
        private string withDrink;
        private string withSide;
        private List<string> toppings;

        public BurgerBuilder(string patty, string bun)
        {
            this.patty = patty;
            this.bun = bun;
        }

        public BurgerBuilder WithCheese(bool withCheese)
        {
            this.withCheese = withCheese;
            return this;
        }

        public BurgerBuilder WithDrink(string withDrink)
        {
            this.withDrink = withDrink;
            return this;
        }

        public BurgerBuilder WithSide(string withSide)
        {
            this.withSide = withSide;
            return this;
        }

        public BurgerBuilder WithToppings(List<string> toppings)
        {
            this.toppings = toppings;
            return this;
        }

        public Burger Build()
        {
            return new Burger(patty, bun, withCheese, withDrink, withSide, toppings);
        }
    }
}

class BurgerMeal
{
    public static void Main(string[] args)
    {
        Burger myBurger = new Burger.BurgerBuilder("Bun", "Patty")
            .WithCheese(true)
            .WithDrink("Coke")
            .Build();
    }
}