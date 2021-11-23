using BusinessLayer.Abstract.Repositories;
using EntityLayer.Concreate.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProductService : IRepositoryService<Product>
    {
        List<Product> GetListAllWithCategory();
        List<Product> GetListAllWithCategory(Expression<Func<Product, bool>> filter);
    }
}
