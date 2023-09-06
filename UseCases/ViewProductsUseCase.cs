using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class ViewProductsUseCase
    {
        private readonly IProductRepository _productRepository;

        public ViewProductsUseCase(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IEnumerable<Product> Execute()
        {
           var products = _productRepository.GetProducts().ToList();
            return products;
        }
    }
}
