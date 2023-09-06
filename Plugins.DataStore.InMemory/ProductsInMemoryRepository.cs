using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
   
    public class ProductsInMemoryRepository: IProductRepository
    {
        private List<Product> products;
        public ProductsInMemoryRepository()
        {
            products = new List<Product>()
            {
                new Product {ProductId = 1, CategoryId= 1, Name = "Iced Tea", Quantity= 50, Price= 20.00}
            };
        }

        public IEnumerable<Product> GetProducts()
        {
            throw new NotImplementedException();
        }
    }
}
