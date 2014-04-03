using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern
{
    class DellMouse:IMouseCommand
    {
        #region IMouseCommand Members

        public void DoRightClick()
        {
            Console.WriteLine("Dell Mouse executes right click");
        }

        public void DoLeftClick()
        {
            Console.WriteLine("Dell Mouse executes leftt click");
        }

        #endregion
    }
}
