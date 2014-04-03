using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern
{
    class RightClickCommand:ICommand
    {
        private IMouseCommand _mouse;
        public RightClickCommand(IMouseCommand mouse)
        {
            _mouse = mouse;
        }
        #region ICommand Members

        public void Execute()
        {
            _mouse.DoRightClick();
        }

        #endregion
    }
}
