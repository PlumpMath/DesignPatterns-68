using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgePattern
{
    class AdicTocino:IIngredientesAdic
    {
        public void PrintIgreAdic()
        {
            Console.WriteLine("Ingredientes Adiccional" + Ingredientes.Tocino);
        }
    }
}
