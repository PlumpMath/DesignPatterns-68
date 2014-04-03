using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder_Pattern
{
    interface IComputerBuilder
    {
        void BuildComputer();
        void BuildOS();
        Computer GetProduct();
    }
}
