using Domain;

namespace Data
{
    public class Repository : IRepository
    {
        List<Product> products = new List<Product>();
        

    public Repository()
       {
            products.Add(new Product { Id = 1, Name = "p1", Category = "Limpieza",IsInDiscount = true });
            products.Add(new Product { Id = 2, Name = "p2", Category = "Comestible", IsInDiscount = false });
            products.Add(new Product { Id = 3, Name = "p3", Category = "Comestible", IsInDiscount = true });
        }
        public IQueryable<Product> getProducts()
        {
           return products.AsQueryable();
        }
    }
}
