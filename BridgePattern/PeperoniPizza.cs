using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgePattern
{
    public class PeperoniPizza:TypesPizza
    {
        private string _nombre;
        public override void PizzaName()
        {
            Console.WriteLine("Esta Pizza es de peperoni");
        }

        public override string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }
    }
}
