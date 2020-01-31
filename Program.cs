using System;
using System.Collections.Generic;
using static System.Console;

namespace PizzaShop
{
    enum Flavoring
    {
        Onion,
        Cheese,
        Olive,
        Salami,
        Sauce,
        Pineapple,
        BBQ,
        Meat,
        Garlic,
        Jalapeno,
        Smoked
    }
    enum Dough
    {
        Thin,
        Thick
    }
    enum Pizza
    {
        Mozzarella,
        Hawaii,
        Chippolino,
        Americano,
        Shotgun
    }
    class StandartPizza
    {
        readonly string name;
        readonly double price;
        readonly string flavor1;
        readonly string flavor2;
        readonly string flavor3;
        readonly string flavor4;

        public StandartPizza(string _name, double _price, string _flavor1, string _flavor2, string _flavor3, string _flavor4)
        {
            name = _name;
            price = _price;
            flavor1 = _flavor1;
            flavor2 = _flavor2;
            flavor3 = _flavor3;
            flavor4 = _flavor4;
        }

        public string Name { get { return name; } set { } }
        public double Price { get { return price; } set { } }
        public string Flavor1 { get { return flavor1; } set { } }
        public string Flavor2 { get { return flavor2; } set { } }
        public string Flavor3 { get { return flavor3; } set { } }
        public string Flavor4 { get { return flavor4; } set { } }
    }
    class PizzaMenu
    {
        readonly List<StandartPizza> menu;
        public List<StandartPizza> Menu { get { return menu; } set { } }
        public PizzaMenu()
        {
            menu = new List<StandartPizza>();
            StandartPizza mozzarella = new StandartPizza($"{Pizza.Mozzarella}", 
                                                         5.99, 
                                                         $"{Flavoring.Cheese}", 
                                                         $"{Flavoring.Olive}", 
                                                         $"{Flavoring.Salami}", 
                                                         $"{Flavoring.Sauce}");
            menu.Add(mozzarella);
            StandartPizza hawaii = new StandartPizza($"{Pizza.Hawaii}", 
                                                     6.99, 
                                                     $"{Flavoring.Pineapple}", 
                                                     $"{Flavoring.Cheese}", 
                                                     $"{Flavoring.Onion}", 
                                                     $"{Flavoring.Sauce}");
            menu.Add(hawaii);
            StandartPizza shotgun = new StandartPizza($"{Pizza.Shotgun}", 
                                                           7.99, 
                                                           $"{Flavoring.Cheese}", 
                                                           $"{Flavoring.Salami}", 
                                                           $"{Flavoring.BBQ} {Flavoring.Meat}", 
                                                           $"{Flavoring.Sauce}");
            menu.Add(shotgun);
            StandartPizza chippolino = new StandartPizza($"{Pizza.Chippolino}", 
                                                         8.99, 
                                                         $"{Flavoring.Onion}", 
                                                         $"{Flavoring.Garlic}", 
                                                         $"{Flavoring.Jalapeno}", 
                                                         $"{Flavoring.Sauce}");
            menu.Add(chippolino);
            StandartPizza americano = new StandartPizza($"{Pizza.Americano}", 
                                                        9.99, 
                                                        $"{Flavoring.Smoked} {Flavoring.Meat}", 
                                                        $"{Flavoring.Olive}", 
                                                        $"{Flavoring.Salami}", 
                                                        $"{Flavoring.Pineapple}");
            menu.Add(americano);
        }
        public void PrintMenu()
        {
            byte count = 0;
            foreach(StandartPizza pizza in menu)
            {
                count++;
                WriteLine($"{count}) {pizza.Name} - {pizza.Price} EUR");
                WriteLine($"   - {pizza.Flavor1}");
                WriteLine($"   - {pizza.Flavor2}");
                WriteLine($"   - {pizza.Flavor3}");
                WriteLine($"   - {pizza.Flavor4}\n");
            }
            WriteLine("You can add aditional flavors too if you want.");
        }
    }

    class ShoppingCart
    {
        readonly PizzaMenu pizzaMenu = new PizzaMenu();
        readonly List<string> shoppingCart = new List<string>();

        public void StandartPizzaShoppingCart(string choise)
        {
            WriteLine($"You have added {choise} to your shopping cart:\n");

            if (choise == $"{Pizza.Mozzarella}".ToLower())
            {
                shoppingCart.Add(pizzaMenu.Menu[0].Name + " pizza:");
                shoppingCart.Add("   - " + pizzaMenu.Menu[0].Price.ToString() + " €");
                shoppingCart.Add("   - " + pizzaMenu.Menu[0].Flavor1);
                shoppingCart.Add("   - " + pizzaMenu.Menu[0].Flavor2);
                shoppingCart.Add("   - " + pizzaMenu.Menu[0].Flavor3);
                shoppingCart.Add("   - " + pizzaMenu.Menu[0].Flavor4);
            }
            else if (choise == $"{Pizza.Hawaii}".ToLower())
            {
                shoppingCart.Add(pizzaMenu.Menu[1].Name + " pizza:");
                shoppingCart.Add("   - " + pizzaMenu.Menu[1].Price.ToString() + " €");
                shoppingCart.Add("   - " + pizzaMenu.Menu[1].Flavor1);
                shoppingCart.Add("   - " + pizzaMenu.Menu[1].Flavor2);
                shoppingCart.Add("   - " + pizzaMenu.Menu[1].Flavor3);
                shoppingCart.Add("   - " + pizzaMenu.Menu[1].Flavor4);
            }
            else if (choise == $"{Pizza.Shotgun}".ToLower())
            {
                shoppingCart.Add(pizzaMenu.Menu[2].Name + " pizza:");
                shoppingCart.Add("   - " + pizzaMenu.Menu[2].Price.ToString() + " €");
                shoppingCart.Add("   - " + pizzaMenu.Menu[2].Flavor1);
                shoppingCart.Add("   - " + pizzaMenu.Menu[2].Flavor2);
                shoppingCart.Add("   - " + pizzaMenu.Menu[2].Flavor3);
                shoppingCart.Add("   - " + pizzaMenu.Menu[2].Flavor4);
            }
            else if (choise == $"{Pizza.Chippolino}".ToLower())
            {
                shoppingCart.Add(pizzaMenu.Menu[3].Name + " pizza:");
                shoppingCart.Add("   - " + pizzaMenu.Menu[3].Price.ToString() + " €");
                shoppingCart.Add("   - " + pizzaMenu.Menu[3].Flavor1);
                shoppingCart.Add("   - " + pizzaMenu.Menu[3].Flavor2);
                shoppingCart.Add("   - " + pizzaMenu.Menu[3].Flavor3);
                shoppingCart.Add("   - " + pizzaMenu.Menu[3].Flavor4);
            }
            else if (choise == $"{Pizza.Americano}".ToLower())
            {
                shoppingCart.Add(pizzaMenu.Menu[4].Name + " pizza:");
                shoppingCart.Add("   - " + pizzaMenu.Menu[4].Price.ToString() + " €");
                shoppingCart.Add("   - " + pizzaMenu.Menu[4].Flavor1);
                shoppingCart.Add("   - " + pizzaMenu.Menu[4].Flavor2);
                shoppingCart.Add("   - " + pizzaMenu.Menu[4].Flavor3);
                shoppingCart.Add("   - " + pizzaMenu.Menu[4].Flavor4);
            }
        }

        public void PrintShoppingCart()
        {
            foreach (string item in shoppingCart)
            {
                WriteLine($"{item}");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            PizzaMenu pizzaMenu = new PizzaMenu();
            ShoppingCart shoppingCart = new ShoppingCart();

            string firstUserChoise;
            string pizzaChoise;
            string thirdUserChoise;
            WriteLine("Hello! Welcome to the PitsaKiosk!\n");
            WriteLine("Menu:");
            pizzaMenu.PrintMenu();
            while (true)
            {
                WriteLine("\nMake your choise:");
                WriteLine("add = add pizza | own = make your own pizza | delete = delete from cart | buy = checkout your order");
                firstUserChoise = ReadLine().ToLower();

                if (firstUserChoise == "add")
                {
                    Clear();
                    pizzaMenu.PrintMenu();
                    Write("Choose your pizza: ");
                    pizzaChoise = ReadLine().ToLower();
                    Clear();
                    shoppingCart.StandartPizzaShoppingCart(pizzaChoise);
                    shoppingCart.PrintShoppingCart();
                    WriteLine("\nCheckout?");
                    WriteLine("Yes = y | No = n");
                    thirdUserChoise = ReadLine().ToLower();
                    if (thirdUserChoise == "y")
                    {
                        Clear();
                        WriteLine("Your order is being prepared:\n");
                        shoppingCart.PrintShoppingCart();
                        break;
                    }
                }
                shoppingCart.PrintShoppingCart();
            }
        }
    }
}
