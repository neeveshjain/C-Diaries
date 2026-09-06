// Builder pattern

using System.ComponentModel;
using System.IO.IsolatedStorage;

class Burger
{
    ///required
        private string patty;
        private string bun;

        //optional
        private Boolean _withCheese;
        private string _withDrink;
        private string _withSide;
        private List<string> _toppings;
    public Burger(string patty,string bun,Boolean _withCheese, string _withDrink, string _withSide,List<string> _toppings)
    {
        this.patty = patty;
        this.bun = bun;
        this._withCheese = _withCheese;
        this._withDrink = _withDrink;
        this._withSide = _withSide;
        this._toppings = _toppings;
    }

    public class BurgerDefination
    {
        //required
        private string patty;
        private string bun;

        //optional
        private Boolean _withCheese;
        private string _withDrink;
        private string _withSide;
        private List<string> _toppings;

        public BurgerDefination(string patty, string bun)
        {
            this.bun = bun;
            this.patty = patty;
        }
        public BurgerDefination WithCheese(Boolean withCheese)
        {
            this._withCheese = withCheese;
            return this;
        }
        public BurgerDefination WithDrink(string withDrink)
        {
            this._withDrink = withDrink;
            return this;
        }
        public BurgerDefination WithSide(string withSide)
        {
            this._withSide = withSide;
            return this;
        }
        public BurgerDefination Toppings(List<string> Toppings)
        {
            this._toppings = Toppings;
            return this;
        }
        public Burger Build()
        {
            return new Burger(this.patty,this.bun,this._withCheese,this._withDrink,this._withSide,this._toppings);
        }

    }
}

class BurgerMeal
{
    public static void Main(string[] args)
    {
        Burger myburger = new Burger.BurgerDefination("Bun","veg").WithCheese(true).Build();
    }
}
