using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgePattern
{
    class AdicQueso:IIngredientesAdic
    {
        

        public void PrintIgreAdic()
        {
            Console.WriteLine("Ingredientes Adiccional" + Ingredientes.Salami);
        }
    }
}
