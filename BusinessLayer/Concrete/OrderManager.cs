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
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;

        public OrderManager(OrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public void DeleteService(Order t)
        {
            _orderDal.Delete(t);
        }

        public Order GetByIDService(int id)
        {
            return _orderDal.GetByID(id);
        }

        public List<Order> GetListAllService()
        {
            return _orderDal.GetListAll();
        }

        public List<Order> GetListAllService(Expression<Func<Order, bool>> filter)
        {
            return _orderDal.GetListAll(filter);
        }

        public List<Order> GetListAllWithProductService()
        {
            return _orderDal.GetListAllWithProduct();
        }

        public List<Order> GetListAllWithProductService(Expression<Func<Order, bool>> filter)
        {
            return _orderDal.GetListAllWithProduct(filter);
        }

        public void InsertService(Order t)
        {
            _orderDal.Insert(t);
        }

        public void UpdateService(Order t)
        {
            _orderDal.Update(t);
        }
    }
}
