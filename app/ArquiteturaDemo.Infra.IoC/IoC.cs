
using System;
//using CommonServiceLocator.NinjectAdapter.Unofficial;
using Ninject;
using Microsoft.Practices.ServiceLocation;
using System.Collections;
using System.Collections.Generic;
//using Unity;


namespace ArquiteturaDemo.Infra.IoC
{
    public class IoC
    {
        private static StandardKernel _kernel;
        
        public static void Init()
        {
            var _kernel = new StandardKernel(new IoCModule());

            //ServiceLocator.SetLocatorProvider(() => new NinjectServiceLocator(_kernel) );
            ServiceLocator.SetLocatorProvider(() => new NinjectServiceLocator(_kernel) );
            //ServiceLocator.SetLocatorProvider(() => new ServiceLocator(_kernel));            
        }

        public static object Get(Type serviceType)
        {
            return _kernel.TryGet(serviceType);
        }

        public static IEnumerable<object> GetAll(Type type)
        {
            return _kernel.GetAll(type);
        }
    }
}
