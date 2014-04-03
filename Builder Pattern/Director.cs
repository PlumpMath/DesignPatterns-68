using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder_Pattern
{
    class Director
    {
        public Computer BuildComputer(IComputerBuilder b)
        {
            b.BuildComputer();
            b.BuildOS();
            return b.GetProduct();
        }
    }
}
