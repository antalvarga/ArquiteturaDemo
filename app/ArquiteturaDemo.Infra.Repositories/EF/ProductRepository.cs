using ArquiteturaDemo.Domain.Entities;
using ArquiteturaDemo.Domain.Interface;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquiteturaDemo.Infra.Repositories.EF
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public IEnumerable<Product> GetByPrice(decimal price)
        {
            // Aos 26:43
            ///return Context.Products.Where(x => x.Price == price).ToList();
            //return Context.Set<Product>().Find(x => x.Price == price).ToList();
            return Context.Products.Where(x => x.Price == price).ToList();
            //
        }
    }
}
