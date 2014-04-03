using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgePattern
{
    interface IIngredientesAdic
    {
        
        void PrintIgreAdic();
    }

    public enum Ingredientes
    {
        Huevo = 1,
        Tocino = 2,
        Salami = 3
    }
}
