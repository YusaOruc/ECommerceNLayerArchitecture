using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repoitories;
using EntityLayer.Concreate.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class UserDal : GenericRepository<User>, IUserDal
    {
        public User LoginUser(User user)
        {
            using var c = new Context();
            return c.Users.FirstOrDefault(x => x.UserMail == user.UserMail && x.UserPassword == user.UserPassword);
        }
    }
}
