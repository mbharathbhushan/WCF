﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace _03_WCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HelloService" in both code and config file together.
    public class HelloService : IHelloService
    {
        public string GetMessage(string message)
        {
            return "Hello" + message;
        }
    }
}
