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
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(CategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void DeleteService(Category t)
        {
            _categoryDal.Delete(t);
        }

        public Category GetByIDService(int id)
        {
            return _categoryDal.GetByID(id);
        }

        public List<Category> GetListAllService()
        {
            return _categoryDal.GetListAll();
        }

        public List<Category> GetListAllService(Expression<Func<Category, bool>> filter)
        {
            return _categoryDal.GetListAll(filter);
        }

        public void InsertService(Category t)
        {
            _categoryDal.Insert(t);
        }

        public void UpdateService(Category t)
        {
            _categoryDal.Update(t);
        }
    }
}
