using Models.ModelsDTO;
using Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class FakeProductService : IProductService
    {
        private List<ProductDTO> _products;

        public FakeProductService()
        {
            _products = new List<ProductDTO>
            {
                new ProductDTO { Id = 1, Name = "Product 1", Price = 10.99m },
                new ProductDTO { Id = 2, Name = "Product 2", Price = 20.49m },
                new ProductDTO { Id = 3, Name = "Product 3", Price = 15.99m }
            };
        }
        public void AddProduct(ProductDTO product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                _products.Remove(product);
            }
        }

        public List<ProductDTO> GetAllProducts()
        {
            return _products;
        }

        public ProductDTO GetProductById(int id)
        {
            return _products.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateProduct(ProductDTO product)
        {
            var existingProduct = _products.FirstOrDefault(x => x.Id == product.Id);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Price = product.Price;
            }
        }
    }
}
