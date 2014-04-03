using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern
{
    interface IMouseCommand
    {
        void DoRightClick();
        void DoLeftClick();
    }
}
