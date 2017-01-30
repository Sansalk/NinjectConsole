using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NinjectConsole
{
    class DL : IProduct
    {

        public string InsertProduct()
        {
            string value ="Dependency injection using Ninject";
            Console.WriteLine(value);
            return value;
        }
    }
}
