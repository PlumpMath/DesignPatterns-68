using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder_Pattern
{
    class Computer
    {
        public string ComputerName { get; set; }
        public string ComputerOS { get; set; }

        public void Show()
        {
            Console.WriteLine(ComputerName);
            Console.WriteLine(ComputerOS);
        }
    }
}
