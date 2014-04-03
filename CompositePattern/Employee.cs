using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern
{
    class Employee:IComponent
    {
        public string Name { get; set; }
        public int Salary { get; set; }

        public void DisplaySalaryNet()
        {
            Console.WriteLine("{0} has this Salary Net {1}", Name, Salary);
        }
    }
}
