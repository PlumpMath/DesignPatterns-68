using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern
{
    class Hand
    {
        public void Execute(ICommand cmd)
        {
            cmd.Execute();
        }
    }
}
