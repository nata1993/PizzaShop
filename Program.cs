using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Linq;

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
                WriteLine($"   - {pizza.Flavor4}");
                WriteLine("   - Thick/thin dough\n");
            }
            //WriteLine("You can add aditional flavors too if you want.");
        }
    }

    class ShoppingCart
    {
        protected PizzaMenu pizzaMenu;
        readonly List<string> shoppingCart = new List<string>();
        protected int pizzaCount;
        protected double totalCost;
        public PizzaMenu PizzaMenu { get { return pizzaMenu; } set { } }
        //public int PizzaCount { get { return pizzaCount; } set { } }

        public void StandardPizzaShoppingCart(string choise)
        {
            pizzaMenu = new PizzaMenu();
            pizzaCount++;
            switch (choise)
            {
                case "1":
                    WriteLine($"You have added Mozzarella to your shopping cart:\n");
                    break;
                case "2":
                    WriteLine($"You have added Hawaii to your shopping cart:\n");
                    break;
                case "3":
                    WriteLine($"You have added Shotgun to your shopping cart:\n");
                    break;
                case "4":
                    WriteLine($"You have added Chippolino to your shopping cart:\n");
                    break;
                case "5":
                    WriteLine($"You have added Americano to your shopping cart:\n");
                    break;
                case "mozzarella":
                    WriteLine($"You have added Mozzarella to your shopping cart:\n");
                    break;
                case "hawaii":
                    WriteLine($"You have added Hawaii to your shopping cart:\n");
                    break;
                case "shotgun":
                    WriteLine($"You have added Shotgun to your shopping cart:\n");
                    break;
                case "chippolino":
                    WriteLine($"You have added Chippolino to your shopping cart:\n");
                    break;
                case "americano":
                    WriteLine($"You have added Americano to your shopping cart:\n");
                    break;
            }

            if (choise.Contains($"{Pizza.Mozzarella}".ToLower()) || choise == "1")
            {
                shoppingCart.Add(pizzaMenu.Menu[0].Name + " pizza:");
                shoppingCart.Add("   - " + pizzaMenu.Menu[0].Price.ToString() + " €");
                totalCost += PizzaMenu.Menu[0].Price;
                shoppingCart.Add("   - " + pizzaMenu.Menu[0].Flavor1);
                shoppingCart.Add("   - " + pizzaMenu.Menu[0].Flavor2);
                shoppingCart.Add("   - " + pizzaMenu.Menu[0].Flavor3);
                shoppingCart.Add("   - " + pizzaMenu.Menu[0].Flavor4);
            }
            else if (choise.Contains($"{Pizza.Hawaii}".ToLower()) || choise == "2")
            {
                shoppingCart.Add(pizzaMenu.Menu[1].Name + " pizza:");
                shoppingCart.Add("   - " + pizzaMenu.Menu[1].Price.ToString() + " €");
                totalCost += PizzaMenu.Menu[1].Price;
                shoppingCart.Add("   - " + pizzaMenu.Menu[1].Flavor1);
                shoppingCart.Add("   - " + pizzaMenu.Menu[1].Flavor2);
                shoppingCart.Add("   - " + pizzaMenu.Menu[1].Flavor3);
                shoppingCart.Add("   - " + pizzaMenu.Menu[1].Flavor4);
            }
            else if (choise.Contains($"{Pizza.Shotgun}".ToLower()) || choise == "3")
            {
                shoppingCart.Add(pizzaMenu.Menu[2].Name + " pizza:");
                shoppingCart.Add("   - " + pizzaMenu.Menu[2].Price.ToString() + " €");
                totalCost += PizzaMenu.Menu[2].Price;
                shoppingCart.Add("   - " + pizzaMenu.Menu[2].Flavor1);
                shoppingCart.Add("   - " + pizzaMenu.Menu[2].Flavor2);
                shoppingCart.Add("   - " + pizzaMenu.Menu[2].Flavor3);
                shoppingCart.Add("   - " + pizzaMenu.Menu[2].Flavor4);
            }
            else if (choise.Contains($"{Pizza.Chippolino}".ToLower()) || choise == "4")
            {
                shoppingCart.Add(pizzaMenu.Menu[3].Name + " pizza:");
                shoppingCart.Add("   - " + pizzaMenu.Menu[3].Price.ToString() + " €");
                totalCost += PizzaMenu.Menu[3].Price;
                shoppingCart.Add("   - " + pizzaMenu.Menu[3].Flavor1);
                shoppingCart.Add("   - " + pizzaMenu.Menu[3].Flavor2);
                shoppingCart.Add("   - " + pizzaMenu.Menu[3].Flavor3);
                shoppingCart.Add("   - " + pizzaMenu.Menu[3].Flavor4);
            }
            else if (choise.Contains($"{Pizza.Americano}".ToLower()) || choise == "5")
            {
                shoppingCart.Add(pizzaMenu.Menu[4].Name + " pizza:");
                shoppingCart.Add("   - " + pizzaMenu.Menu[4].Price.ToString() + " €");
                totalCost += PizzaMenu.Menu[4].Price;
                shoppingCart.Add("   - " + pizzaMenu.Menu[4].Flavor1);
                shoppingCart.Add("   - " + pizzaMenu.Menu[4].Flavor2);
                shoppingCart.Add("   - " + pizzaMenu.Menu[4].Flavor3);
                shoppingCart.Add("   - " + pizzaMenu.Menu[4].Flavor4);
            }
        }
        public void StandardPizzaDough(string choise)
        {
            if(choise.Contains("thin"))
            {
                shoppingCart.Add($"   - {Dough.Thin} dough");
            }

            else if (choise.Contains("thick"))
            {
                shoppingCart.Add($"   - {Dough.Thick} dough");
            }
        }
        protected void RemoveDough(string doughChoise)
        {
            if (doughChoise.Contains("thin"))
            {
                shoppingCart.Remove($"   - {Dough.Thin} dough");
            }

            else if (doughChoise.Contains("thick"))
            {
                shoppingCart.Remove($"   - {Dough.Thick} dough");
            }
        }
        public void EmptyStandardPizzaShoppingCart(string choise, string doughChoise)
        {
            if (choise == $"{Pizza.Mozzarella}".ToLower() || choise == "1")
            {
                shoppingCart.Remove($"{pizzaMenu.Menu[0].Name} pizza:");
                shoppingCart.Remove($"   - {pizzaMenu.Menu[0].Price.ToString()} €");
                shoppingCart.Remove($"   - {pizzaMenu.Menu[0].Flavor1}");
                shoppingCart.Remove($"   - {pizzaMenu.Menu[0].Flavor2}");
                shoppingCart.Remove($"   - {pizzaMenu.Menu[0].Flavor3}");
                shoppingCart.Remove($"   - {pizzaMenu.Menu[0].Flavor4}");
                RemoveDough(doughChoise);
                pizzaCount--;
                totalCost -= pizzaMenu.Menu[0].Price;
            }
            else if (choise == $"{Pizza.Hawaii}".ToLower() || choise == "2")
            {
                shoppingCart.Remove(pizzaMenu.Menu[1].Name + " pizza:");
                shoppingCart.Remove("   - " + pizzaMenu.Menu[1].Price.ToString() + " €");
                shoppingCart.Remove($"   - {pizzaMenu.Menu[1].Flavor1}");
                shoppingCart.Remove($"   - {pizzaMenu.Menu[1].Flavor2}");
                shoppingCart.Remove($"   - {pizzaMenu.Menu[1].Flavor3}");
                shoppingCart.Remove($"   - {pizzaMenu.Menu[1].Flavor4}");
                RemoveDough(doughChoise);
                pizzaCount--;
                totalCost -= pizzaMenu.Menu[1].Price;
            }
            else if (choise == $"{Pizza.Shotgun}".ToLower() || choise == "3")
            {
                shoppingCart.Remove(pizzaMenu.Menu[2].Name + " pizza:");
                shoppingCart.Remove("   - " + pizzaMenu.Menu[2].Price.ToString() + " €");
                shoppingCart.Remove($"   - {pizzaMenu.Menu[2].Flavor1}");
                shoppingCart.Remove($"   - {pizzaMenu.Menu[2].Flavor2}");
                shoppingCart.Remove($"   - {pizzaMenu.Menu[2].Flavor3}");
                shoppingCart.Remove($"   - {pizzaMenu.Menu[2].Flavor4}");
                RemoveDough(doughChoise);
                pizzaCount--;
                totalCost -= pizzaMenu.Menu[2].Price;
            }
            else if (choise == $"{Pizza.Chippolino}".ToLower() || choise == "4")
            {
                shoppingCart.Remove(pizzaMenu.Menu[3].Name + " pizza:");
                shoppingCart.Remove("   - " + pizzaMenu.Menu[3].Price.ToString() + " €");
                shoppingCart.Remove($"   - {pizzaMenu.Menu[3].Flavor1}");
                shoppingCart.Remove($"   - {pizzaMenu.Menu[3].Flavor2}");
                shoppingCart.Remove($"   - {pizzaMenu.Menu[3].Flavor3}");
                shoppingCart.Remove($"   - {pizzaMenu.Menu[3].Flavor4}");
                RemoveDough(doughChoise);
                pizzaCount--;
                totalCost -= pizzaMenu.Menu[3].Price;
            }
            else if (choise == $"{Pizza.Americano}".ToLower() || choise == "5")
            {
                shoppingCart.Remove(pizzaMenu.Menu[4].Name + " pizza:");
                shoppingCart.Remove("   - " + pizzaMenu.Menu[4].Price.ToString() + " €");
                shoppingCart.Remove($"   - {pizzaMenu.Menu[4].Flavor1}");
                shoppingCart.Remove($"   - {pizzaMenu.Menu[4].Flavor2}");
                shoppingCart.Remove($"   - {pizzaMenu.Menu[4].Flavor3}");
                shoppingCart.Remove($"   - {pizzaMenu.Menu[4].Flavor4}");
                RemoveDough(doughChoise);
                pizzaCount--;
                totalCost -= pizzaMenu.Menu[4].Price;
            }
        }

        public void PrintShoppingCart()
        {
            if (!shoppingCart.Any())
            {
                WriteLine("Your shopping cart is empty");
            }

            else
            {
                WriteLine("Shopping cart:");
                foreach (var item in shoppingCart)
                {
                    WriteLine($"{item}");
                }
                WriteLine($"\nTotal pizzas: {pizzaCount}");
                WriteLine($"Total cost: {Math.Round(totalCost, 2)} €");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            OutputEncoding = Encoding.UTF8;
            PizzaMenu pizzaMenu = new PizzaMenu();
            ShoppingCart shoppingCart = new ShoppingCart();
            string firstUserChoise;
            string secondUserChoise;
            string doughUserChoise;
            string thirdUserChoise;

            WriteLine("Hello! Welcome to the PitsaKiosk!\n");
            WriteLine("Menu:");
            pizzaMenu.PrintMenu();
            shoppingCart.PrintShoppingCart();
            while (true)
            {
                WriteLine("\nMake your choise:");
                WriteLine("add = add pizza | own = make your own pizza | exit = leave PitsaKiosk...");
                firstUserChoise = ReadLine().ToLower();

                if (firstUserChoise == "add")
                {
                    Clear();
                    pizzaMenu.PrintMenu();
                    Write("Did not find what you wanted? exit = exit shop. Found? Then choose your pizza: ");
                    var pizzaChoise = ReadLine().ToLower();
                    if( pizzaChoise == "exit")
                    {
                        Exit();
                        break;
                    }
                    Clear();
                    shoppingCart.StandardPizzaShoppingCart(pizzaChoise);
                    shoppingCart.PrintShoppingCart();
                    WriteLine("\nWhat type of dough you want - thick or thin?: ");
                    doughUserChoise = ReadLine().ToLower();
                    shoppingCart.StandardPizzaDough(doughUserChoise);
                    WriteLine("\nCheckout?");
                    WriteLine("Yes = y | No = n");
                    secondUserChoise = ReadLine().ToLower();
                    if (secondUserChoise == "y")
                    {
                        Clear();
                        WriteLine("Your order is being prepared:\n");
                        shoppingCart.PrintShoppingCart();
                        break;
                    }
                    else if (secondUserChoise == "n")
                    {
                        Start:
                        WriteLine("Want to add another pizza or change your order all together?");
                        WriteLine("add = add another pizza || delete = change your order");
                        thirdUserChoise = ReadLine().ToLower();

                        if (thirdUserChoise == "add")
                        {
                            Clear();
                            pizzaMenu.PrintMenu();
                            WriteLine("Pizza in the shopping cart:");
                            shoppingCart.PrintShoppingCart();
                            WriteLine("\nAdd another pizza of your choise: ");
                            var pizzaAnotherChoise = ReadLine().ToLower();
                            shoppingCart.StandardPizzaShoppingCart(pizzaAnotherChoise);
                            WriteLine("What type of dough you want - thick or thin?: ");
                            doughUserChoise = ReadLine();
                            shoppingCart.StandardPizzaDough(doughUserChoise);
                            Clear();
                            shoppingCart.PrintShoppingCart();
                            WriteLine("\nCheckout?");
                            WriteLine("Yes = y | No = n");
                            secondUserChoise = ReadLine().ToLower();
                            if (secondUserChoise == "y")
                            {
                                Clear();
                                WriteLine("Your order is being prepared:\n");
                                shoppingCart.PrintShoppingCart();
                                break;
                            }

                            if (secondUserChoise == "n")
                            {
                                goto Start;
                            }
                        }

                        else if (thirdUserChoise.Contains("del"))
                        {
                            Clear();
                            WriteLine("Your order is:");
                            shoppingCart.PrintShoppingCart();
                            WriteLine("\nChoose which order to delete:");
                            var deletePizzaChoise = ReadLine().ToLower();
                            shoppingCart.EmptyStandardPizzaShoppingCart(deletePizzaChoise, doughUserChoise);
                            Clear();
                            shoppingCart.PrintShoppingCart();
                            WriteLine("\nCheckout?");
                            WriteLine("Yes = y | No = n");
                            secondUserChoise = ReadLine().ToLower();
                            if (secondUserChoise == "y")
                            {
                                Clear();
                                WriteLine("Your order is being prepared:\n");
                                shoppingCart.PrintShoppingCart();
                                break;
                            }
                        }
                    }
                }
                else if (firstUserChoise == "own")
                {

                }
                else if (firstUserChoise == "exit")
                {
                    Exit();
                    break;
                }
            }

            static void Exit()
            {
                Clear();
                WriteLine("Good bye and have a nice day!");
            }
        }
    }
}