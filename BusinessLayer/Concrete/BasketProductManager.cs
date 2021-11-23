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
    public class BasketProductManager : IBasketProductService
    {
        IBasketProductDal _basketProductDal;

        public BasketProductManager(BasketProductDal basketProductDal)
        {
            _basketProductDal = basketProductDal;
        }

        public void BasketProductInsertService(Product product, int id)
        {
            _basketProductDal.BasketProductInsert(product,id);
        }

        public void DeleteService(BasketProduct t)
        {
            _basketProductDal.Delete(t);
        }

        public BasketProduct GetByIDService(int id)
        {
            return _basketProductDal.GetByID(id);
        }

        public int GetByProductIDService(int id)
        {
            return _basketProductDal.GetByProductID(id);
        }

        public List<BasketProduct> GetListAllService()
        {
            return _basketProductDal.GetListAll();
        }

        public List<BasketProduct> GetListAllService(Expression<Func<BasketProduct, bool>> filter)
        {
            return _basketProductDal.GetListAll(filter);
        }

        public void InsertService(BasketProduct t)
        {
            _basketProductDal.Insert(t);
        }

        public void UpdateService(BasketProduct t)
        {
            _basketProductDal.Update(t);
        }
    }
}
