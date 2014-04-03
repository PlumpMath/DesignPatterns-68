using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TypesPizza> pizzas = new List<TypesPizza>();
            pizzas.Add(new CheesePizza() { Nombre = "Queso" });
            pizzas.Add(new PeperoniPizza() { Nombre = "Peperoni" });

            foreach (var item in pizzas)
            {
                item.PizzaName();
            }

            Console.ReadLine();
        }
    }
}
