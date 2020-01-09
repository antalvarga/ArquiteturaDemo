using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ArquiteturaDemo.Domain.Entities;
using ArquiteturaDemo.Domain.Interface;

namespace ArquiteturaDemo.Application
{
    public class ProductApplication : ApplicationBase
    {
        private readonly IProductRepository _productRepository;

        public ProductApplication( IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Register(Product product)
        {
            // iniciar transacao
            BeginTransation();

            // inserir
            _productRepository.Add(product);

            // commit
            Commit();
        }

        public IEnumerable<Product> Get()
        {
            return _productRepository.Get();
        }
    }
}
