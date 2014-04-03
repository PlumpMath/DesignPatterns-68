using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public abstract class RequestHandler
    {
        private bool hasLink;
        public abstract string Name { get; set; }
        protected RequestHandler r;
        public RequestHandler()
        {
            hasLink = false;
        }

        public void AddToRequestHandler(RequestHandler re)
        {
            r = re;
            hasLink = true;
        }

        public abstract void SendToRequestHandler(Request c);

        public bool HasRequestHandler()
        {
            return hasLink;
        }

        public void SendRequestHandler(Request c)
        {
            if (r != null)
                r.SendToRequestHandler(c);
        }
    }
}
