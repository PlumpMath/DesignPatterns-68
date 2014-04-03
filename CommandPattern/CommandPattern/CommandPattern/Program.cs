using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Hand hand = new Hand();
            var dellmouse = new DellMouse();
            var rightclick = new RightClickCommand(dellmouse);
            var leftclick = new LeftClickCommand(dellmouse);
            var noncomd = new NoneCommand();
            
            Console.WriteLine("1. Right Click \n2. Left Click \n");
            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    hand.Execute(rightclick);
                    break;
                case "2":
                    hand.Execute(leftclick);
                    break;
                default:
                    hand.Execute(noncomd);
                    break;
            }

            Console.ReadKey();

        }
    }
}
