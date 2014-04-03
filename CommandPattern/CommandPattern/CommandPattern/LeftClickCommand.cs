using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern
{
    class LeftClickCommand:ICommand
    {
        private IMouseCommand _mouse;
        public LeftClickCommand(IMouseCommand mouse)
        {
            _mouse = mouse;
        }

        #region ICommand Members

        public void Execute()
        {
            _mouse.DoLeftClick();
        }

        #endregion
    }
}
