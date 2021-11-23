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
    public class AdminManager : IAdminService
    {
        IAdminDal _adminDal;

        public AdminManager(AdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public void DeleteService(Admin t)
        {
            _adminDal.Delete(t);
        }

        public Admin GetByIDService(int id)
        {
            return _adminDal.GetByID(id);
        }

        public List<Admin> GetListAllService()
        {
            return _adminDal.GetListAll();
        }

        public List<Admin> GetListAllService(Expression<Func<Admin, bool>> filter)
        {
            return _adminDal.GetListAll(filter);
        }

        public void InsertService(Admin t)
        {
            _adminDal.Insert(t);
        }

        public Admin LoginAdminService(Admin admin)
        {
            return _adminDal.LoginAdmin(admin);
        }

        public void UpdateService(Admin t)
        {
            _adminDal.Update(t);
        }
    }
}
