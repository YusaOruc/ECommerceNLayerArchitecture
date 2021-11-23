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
    public interface IOrderService : IRepositoryService<Order>
    {
        List<Order> GetListAllWithProductService();
        List<Order> GetListAllWithProductService(Expression<Func<Order, bool>> filter);
    }
}
