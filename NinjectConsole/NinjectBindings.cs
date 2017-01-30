using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NinjectConsole
{
    public class NinjectBindings : Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
            // Bind (Declares a binding for the specified service)

            // Here We are Binding services to Inject 
            // In this we will inject DL using Interface Iproduct
            Bind<IProduct>().To<DL>();
        }
    }
}
