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
    public class OrderDal : GenericRepository<Order>, IOrderDal
    {
        public List<Order> GetListAllWithProduct()
        {
            using (var c = new Context())
            {
                return c.Orders.Include(x => x.Products).ToList();
            }
        }

        public List<Order> GetListAllWithProduct(Expression<Func<Order, bool>> filter)
        {
            using (var c = new Context())
            {
                return c.Orders.Include(x => x.Products).Include(y => y.Addresses).Include(x => x.Users).Where(filter).ToList();

            }
        }

      
    }
}
