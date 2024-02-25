using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Northwind.Business.Abstract;
using Northwind.Business.Utilities;
using Northwind.Business.ValidationRules.FluentValidation;
using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;


namespace Northwind.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productdal) { _productDal = productdal; }

        public void Add(Product product)
        {
            ValidationTool.Validatee(product, new ProductValidator());
            _productDal.Add(product);
        }

        public List<Product> GetAll() { return _productDal.GetAll(); }

        public List<Product> GetProductsByCategory(int CategoryID)
        {
            return _productDal.GetAll(p=>p.CategoryId == CategoryID);
        }

        public List<Product> GetProductsByName(string Productname)
        {
            return _productDal.GetAll(p => p.ProductName.Contains(Productname, StringComparison.CurrentCultureIgnoreCase));
        }

        public void Update(Product product)
        {
            ValidationTool.Validatee(product, new ProductValidator());
            _productDal.Update(product);
        }

        public void Delete(Product product)
        {
            try
            {
                _productDal.Delete(product);
            }

            catch (DbUpdateException)
            {
                throw new Exception("Güncellenemedi");
            }
        }   
    }
}
