using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public class Request
    {
        public Client Client { get; set; }
        public Level Level { get; set; }
    }

    public enum Level
    {
        Easy = 1,
        Normal = 2,
        Hard = 3
    }
}
