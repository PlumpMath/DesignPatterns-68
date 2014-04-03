using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public class ITManager:RequestHandler 
    {
        private string _name;
        public override string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public override void SendToRequestHandler(Request c)
        {
            if (c != null)
            {
                if (c.Level == Level.Hard)
                {
                    Console.WriteLine("{0} can work with this level Hard", Name);
                }
            }
        }
    }
}
