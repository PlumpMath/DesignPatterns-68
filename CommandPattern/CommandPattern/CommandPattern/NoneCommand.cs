using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern
{
    class NoneCommand:ICommand
    {
        #region ICommand Members

        public void Execute()
        {
            Console.WriteLine("Click Not Found");
        }

        #endregion
    }
}
