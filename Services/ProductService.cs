using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories;

namespace Services
{
    public class ProductService:IProductService
    {
        private IProductRepository productRepository = new ProductRepository();
        //get all products
		public List<Models.Product> GetAll()
        {
            return productRepository.GetAll();
        }

        public Models.Product GetById(int productId)
        {
			var product = productRepository.GetById(productId)
            return product;
        }

        public int Add(Models.Product product)
        {
            return productRepository.Add(product);
        }

        public bool Update(Models.Product product)
        {
            return productRepository.Update(product);
        }

        public bool Delete(int productId)
        {
            return productRepository.Delete(productId);
        }
    }
}
