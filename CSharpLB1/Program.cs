namespace CSharpLB1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CoffeMachine machineWithoutName = new CoffeMachine
            {
                Name = "",
                Coffe = 50,
                Milk = 300,
                Water = 500,
                Sugar = 20,
            };
            CoffeMachine coffeMachine = new CoffeMachine
            {
                Name = "Test",
                Coffe = 50,
                Milk = 300,
                Water = 500,
                Sugar = 20,
            };

            coffeMachine.CreateDrink(Drinks.Cappuccino, 50);
            coffeMachine.CreateDrink(Drinks.Latte, 100);
            coffeMachine.AddCoffe(30);
            coffeMachine.AddSugar(10);

            List<Drinks> drinks = new List<Drinks>();
            drinks.Add(Drinks.HotChocolate);
            drinks.Add(Drinks.Espresso);
            coffeMachine.CreateDrinks(drinks, 300);
            drinks.Add(Drinks.Latte);
            drinks.Add(Drinks.Cappuccino);
            coffeMachine.CreateDrinks(drinks, 600);
            coffeMachine.GetPaydesk();
            coffeMachine.AddWater(10000);
            coffeMachine.AddCoffe(10000);
            coffeMachine.AddMilk(10000);
            coffeMachine.AddSugar(10000);
            coffeMachine.CreateDrinks(drinks, 600);
            coffeMachine.GetPaydesk();

        }
    }
}