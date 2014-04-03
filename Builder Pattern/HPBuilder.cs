using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder_Pattern
{
    class HPBuilder:IComputerBuilder
    {
        private Computer computer = new Computer();
        public void BuildComputer()
        {
            computer.ComputerName = "HP";
        }

        public void BuildOS()
        {
            computer.ComputerOS = "Windows 7 64 bits";
        }

        public Computer GetProduct()
        {
            return computer;
        }
    }
}
