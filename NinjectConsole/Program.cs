using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using System.Reflection;

namespace NinjectConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initializes a new instance of the Ninject.StandardKernel class.
            StandardKernel _Kernal = new StandardKernel();

            //load Modules
            _Kernal.Load(Assembly.GetExecutingAssembly());

            //Gets an instance of the specified service. 
            IProduct _objIpro = _Kernal.Get<IProduct>();

            // In this step Ninject will inject DL object to BL 
            BL objbl = new BL(_objIpro);

            // calling method of BL from that Dependency 
            objbl.Insert(); 

            Console.ReadLine();
        }
    }
}
