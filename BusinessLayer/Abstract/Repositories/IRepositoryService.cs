using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract.Repositories
{
    public interface IRepositoryService<T> where T:class
    {
        void InsertService(T t);
        void DeleteService(T t);
        void UpdateService(T t);
        List<T> GetListAllService();
        List<T> GetListAllService(Expression<Func<T, bool>> filter);
        T GetByIDService(int id);
    }
}
