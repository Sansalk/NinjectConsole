using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NinjectConsole
{
    class BL
    {
        IProduct objIpro;

        public BL(IProduct objIproduct)
        {
            objIpro = objIproduct;
        }

        public void Insert()
        {
            objIpro.InsertProduct();
        }

    }
}
