using System;
using System.Collections.Generic;
using static System.Console;

namespace PizzaShop
{
    class Pizza
    {
        readonly string name;
        readonly double price;

        public Pizza(string _name, double _price)
        {
            name = _name;
            price = _price;
        }

        public string Name { get { return name; } set { } }
        public double Price { get { return price; } set { } }
        
    }

    class PizzaMenu
    {
        readonly List<Pizza> menu;

        public PizzaMenu()
        {
            menu = new List<Pizza>();
            Pizza mozzarella = new Pizza("Mozzarella", 5.99);
            menu.Add(mozzarella);
            Pizza hawaii = new Pizza("Hawaii", 6.99);
            menu.Add(hawaii);
            Pizza monsterTruck = new Pizza("Monster truck", 7.99);
            menu.Add(monsterTruck);
            Pizza chippolino = new Pizza("Chippolino", 8.99);
            menu.Add(chippolino);
            Pizza americano = new Pizza("Americano", 9.99);
            menu.Add(americano);
        }

        public void PrintMenu()
        {
            byte count = 1;
            foreach(Pizza item in menu)
            {
                count++;
                WriteLine($"{count}) {item.Name} - {item.Price}");
            }
        }
    }

    class Flavoring
    {
        readonly List<string> flavor;

        public Flavoring()
        {

        }
    }

    class ShoppingCart
    {

    }
    class Program
    {
        
        static void Main()
        {
            PizzaMenu pizzaMenu = new PizzaMenu();
            WriteLine("Hello! \n");
            WriteLine("Menu:");
            pizzaMenu.PrintMenu();
            while (true)
            {
                string userChoise = ReadLine();
            }

        }
    }
}
