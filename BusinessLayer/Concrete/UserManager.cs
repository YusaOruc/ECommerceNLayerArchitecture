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
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(UserDal userDal)
        {
            _userDal = userDal;
        }

        public void DeleteService(User t)
        {
            _userDal.Delete(t);
        }

        public User GetByIDService(int id)
        {
            return _userDal.GetByID(id);
        }

        public List<User> GetListAllService()
        {
            return _userDal.GetListAll();
        }

        public List<User> GetListAllService(Expression<Func<User, bool>> filter)
        {
            return _userDal.GetListAll(filter);
        }

        public void InsertService(User t)
        {
            _userDal.Insert(t);
        }

        public User LoginUserService(User user)
        {
           return _userDal.LoginUser(user);
        }

        public void UpdateService(User t)
        {
            _userDal.Update(t);
        }
    }
}
