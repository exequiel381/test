using Data;
using Domain;

namespace Services
{
    public class ProductService : IProductService
    {
        private IRepository _repository;
        public ProductService()
        {
            _repository = new Repository();
        }

        public List<Product> GetProductsInDiscount()
        {
            var lista = _repository.getProducts().Where(p => p.IsInDiscount);
            return lista.ToList();
        }

        public List<Product> GetProducts()
        {
          return _repository.getProducts().ToList();
        }
    }
}
