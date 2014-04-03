using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var dell = new DellBuilder();
            var hp = new HPBuilder();
            var director = new Director();
            director.BuildComputer(dell).Show();
            director.BuildComputer(hp).Show();
        }
    }
}
