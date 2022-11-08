using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLB1 {
    internal class CoffeMachine
    {
        private readonly int _maxCoffe = 2000;
        private readonly int _maxMilk = 5000;
        private readonly int _maxWater = 10000;
        private readonly int _maxSugar = 1000;

        private string _name;
        private int _coffe;
        private int _milk;
        private int _water;
        private int _sugar;
        private uint _paydesk;
        public string Name
        {
            get { return _name; }
            
            set
            {
                if (value.Length > 0)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Name can not be empty");
                    _name = "name: IS_EMPTY";
                }
            }
        }
        public int Coffe
        {
            get { return _coffe; }
            set
            {
                _coffe = value;
            }
        }
        public int Milk
        {
            get { return _milk; }
            set
            {
                _milk = value;
            }
        }
        public int Water
        {
            get { return _water; }
            set
            {
                _water = value;
            }
        }
        public int Sugar
        {
            get { return _sugar; }
            set
            {
                _sugar = value;
            }
        }
        public uint Paydesk
        {
            get { return _paydesk; }
            set
            {
                _paydesk = value;
            }
        }

        public bool CreateDrink(Drinks drinkType, uint price = 0)
        {
            switch (drinkType)
            {
                case Drinks.Espresso:
                    if (UseCoffe(20) && UseWater(100) && UseSugar(5))
                    {
                        this.Paydesk += price;
                        Console.WriteLine("Your " + Drinks.Espresso.ToString() + " is ready.");
                        return true;
                    }
                    return false;
                    
                case Drinks.Latte:
                    if (UseCoffe(10) && UseWater(100) && UseMilk(75) && UseSugar(5))
                    {
                        this.Paydesk += price;
                        Console.WriteLine("Your " + Drinks.Latte.ToString() + " is ready.");
                        return true;
                    }
                    return false;
                    
                case Drinks.Americano:
                    if (UseCoffe(10) && UseWater(100) && UseSugar(5))
                    {
                        this.Paydesk += price;
                        Console.WriteLine("Your " + Drinks.Americano.ToString() + " is ready.");
                        return true;
                    }
                    return false;
                    
                case Drinks.Cappuccino:
                    if (UseCoffe(15) && UseWater(100) && UseMilk(50) && UseSugar(5))
                    {
                        this.Paydesk += price;
                        Console.WriteLine("Your " + Drinks.Cappuccino.ToString() + " is ready.");
                        return true;
                    }
                    return false;
                    
                case Drinks.HotChocolate:
                    if (UseCoffe(10) && UseWater(100) && UseMilk(100) && UseSugar(5))
                    {
                        this.Paydesk += price;
                        Console.WriteLine("Your " + Drinks.HotChocolate.ToString() + " is ready.");
                        return true;
                    }
                    return false;
                    
                default:
                    return true;
                    
            }

        }

        public void CreateDrinks(List<Drinks> drinks, uint price)
        {
            foreach(var drink in drinks)
            {
                bool isSuccessfull = CreateDrink(drink);
                if (!isSuccessfull)
                {
                    return;
                }
            }
            this.Paydesk += price;
        }

        public void AddWater(int value)
        {
            if (this.Water >= _maxWater)
            {
                Console.WriteLine("Machine if full of water!");
                return;
            }
            this.Water += value;
            if(this.Water >= _maxWater)
            {
                this.Water = _maxWater;
                Console.WriteLine("You have completely filled the machine with water!");
            }
        }
        public void AddSugar(int value)
        {
            if (this.Sugar >= _maxSugar)
            {
                Console.WriteLine("Machine if full of sugar!");
                return;
            }
            this.Sugar += value;
            if (this.Sugar >= _maxSugar)
            {
                this.Sugar = _maxSugar;
                Console.WriteLine("You have completely filled the machine with sugar!");
            }
        }
        public void AddCoffe(int value)
        {
            if (this.Coffe >= _maxCoffe)
            {
                Console.WriteLine("Machine if full of coffe!");
                return;
            }
            this.Coffe += value;
            if (this.Coffe >= _maxCoffe)
            {
                this.Coffe = _maxCoffe;
                Console.WriteLine("You have completely filled the machine with coffe!");
            }
        }
        public void AddMilk(int value)
        {
            if (this.Milk >= _maxMilk)
            {
                Console.WriteLine("Machine if full of milk!");
                return;
            }
            this.Milk += value;
            if (this.Milk >= _maxMilk)
            {
                this.Milk = _maxMilk;
                Console.WriteLine("You have completely filled the machine with milk!");
            }
        }


        private bool UseWater(int value)
        {
            this.Water -= value;
            if (this.Water < 0)
            {
                this.Water += value;
                Console.WriteLine("It is not enough water, please refill the machine!");
                return false;
            }
            return true;
        }
        private bool UseSugar(int value)
        {
            this.Sugar -= value;
            if (this.Sugar < 0)
            {
                this.Sugar += value;
                Console.WriteLine("It is not enough sugar, please refill the machine!");
                return false;
            }
            return true;
        }
        private bool UseCoffe(int value)
        {
            this.Coffe -= value;
            if (this.Coffe < 0)
            {
                this.Coffe += value;
                Console.WriteLine("It is not enough coffe, please refill the machine!");
                return false;
            }
            return true;
        }
        private bool UseMilk(int value)
        {
            this.Milk -= value;
            if (this.Milk < 0)
            {
                this.Milk += value;
                Console.WriteLine("It is not enough milk, please refill the machine!");
                return false;
            }
            return true;
        }
        public void GetPaydesk()
        {
            Console.WriteLine("Current paydesk is : " + Paydesk);
        }

    }
}
