using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder_Pattern
{
    class DellBuilder:IComputerBuilder
    {
        private Computer computer = new Computer();
        public void BuildComputer()
        {
            computer.ComputerName = "Dell";
        }

        public void BuildOS()
        {
            computer.ComputerOS = "Windows 8 64 bits";
        }

        public Computer GetProduct()
        {
            return computer;
        }
    }
}
