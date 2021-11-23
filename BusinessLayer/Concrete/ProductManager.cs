using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concreate.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(ProductDal productDal)
        {
            _productDal = productDal;
        }

        public void DeleteService(Product t)
        {
            _productDal.Delete(t);
        }

        public Product GetByIDService(int id)
        {
            return _productDal.GetByID(id);
        }

        public List<Product> GetListAllService()
        {
            return _productDal.GetListAll();
        }

        public List<Product> GetListAllService(Expression<Func<Product, bool>> filter)
        {
            return _productDal.GetListAll(filter);
        }

        public List<Product> GetListAllWithCategory()
        {
            return _productDal.GetListAllWithCategory();
        }

        public List<Product> GetListAllWithCategory(Expression<Func<Product, bool>> filter)
        {
            return _productDal.GetListAllWithCategory(filter);
        }

        public void InsertService(Product t)
        {
            _productDal.Insert(t);
        }

        public void UpdateService(Product t)
        {
            _productDal.Update(t);
        }
    }
}
