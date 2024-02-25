using Northwind.Entities.Concrete;

namespace Northwind.Business.Abstract
{
    public interface IProductService
    {
        void Add(Product product);
        void Delete(Product product);
        List<Product> GetAll();
        List<Product> GetProductsByCategory(int CategoryID);
        List<Product> GetProductsByName(string Productname);
        void Update(Product product);
    }
}
