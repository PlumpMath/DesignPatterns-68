using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern
{
    interface IComponent
    {
        string Name { get; set; }
        int Salary { get; set; }
        void DisplaySalaryNet();
    }
}
