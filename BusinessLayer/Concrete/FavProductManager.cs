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
    public class FavProductManager : IFavProductService
    {
        IFavProductDal _favProductDal;

        public FavProductManager(FavProductDal favProductDal)
        {
            _favProductDal = favProductDal;
        }

        public void DeleteService(FavProduct t)
        {
            _favProductDal.Delete(t);
        }

        public FavProduct GetByIDService(int id)
        {
            return _favProductDal.GetByID(id);
        }

        public int GetByProductIDService(int id)
        {
            return _favProductDal.GetByProductID(id);
        }

        public List<FavProduct> GetListAllService()
        {
            return _favProductDal.GetListAll();
        }

        public List<FavProduct> GetListAllService(Expression<Func<FavProduct, bool>> filter)
        {
            return _favProductDal.GetListAll(filter);
        }

        public void InsertService(FavProduct t)
        {
            _favProductDal.Insert(t);
        }

        public void UpdateService(FavProduct t)
        {
            _favProductDal.Update(t);
        }
    }
}
