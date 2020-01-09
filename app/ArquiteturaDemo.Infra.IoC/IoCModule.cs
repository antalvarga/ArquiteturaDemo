using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ninject.Modules;
using ArquiteturaDemo.Infra.Repositories;
using ArquiteturaDemo.Domain.Interface;
using ArquiteturaDemo.Infra.Repositories.EF;

namespace ArquiteturaDemo.Infra.IoC
{
    public class IoCModule : NinjectModule
    {
        public override void Load()
        {
            // Bind gen�rico
            Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));

            //Bind espec�fico para Product
            Bind<IProductRepository>().To<ProductRepository>();

            Bind<IUnitOfWork>().To<UnitOfWork>();
            Bind<ContextManager>().ToSelf();
        }

    }
}
