using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public class TechnicalSupport:RequestHandler
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
                if (c.Level == Level.Easy || c.Level == Level.Normal)
                {
                    Console.WriteLine("{0} cant Work With this request", Name);

                }

                else
                {
                    SendRequestHandler(c);
                }
            }

          
        }
    }
}
