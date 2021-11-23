using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repoitories;
using EntityLayer.Concreate.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class ProductDal : GenericRepository<Product>, IProductDal
    {
        public List<Product> GetListAllWithCategory()
        {
            using(var c=new Context())
            {
                return c.Products.Include(x => x.Category).ToList();
            }
        }

        public List<Product> GetListAllWithCategory(Expression<Func<Product, bool>> filter)
        {
           
           
            using (var c = new Context())
            {
                return c.Products.Include(x => x.Category).Where(filter).ToList();
                
            }
        }
    }
}
