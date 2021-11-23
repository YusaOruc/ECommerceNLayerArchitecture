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
    public class AdminDal : GenericRepository<Admin>, IAdminDal
    {
        public Admin LoginAdmin(Admin admin)
        {
            using var c = new Context();
            return c.Admins.FirstOrDefault(x => x.AdminName == admin.AdminName && x.AdminPassword == admin.AdminPassword);
        }
    }
}
