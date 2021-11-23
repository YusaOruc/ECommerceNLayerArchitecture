using EntityLayer.Concreate.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IProductDal :IGenericDal<Product>
    {
        List<Product> GetListAllWithCategory();
        List<Product> GetListAllWithCategory(Expression<Func<Product, bool>> filter);

    }
}
