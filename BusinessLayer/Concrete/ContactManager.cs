using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void DeleteService(Contact t)
        {
            _contactDal.Delete(t);
        }

        public Contact GetByIDService(int id)
        {
            return _contactDal.GetByID(id);
        }

        public List<Contact> GetListAllService()
        {
            return _contactDal.GetListAll();
        }

        public List<Contact> GetListAllService(Expression<Func<Contact, bool>> filter)
        {
            return _contactDal.GetListAll(filter);
        }

        public void InsertService(Contact t)
        {
            _contactDal.Insert(t);
        }

        public void UpdateService(Contact t)
        {
            _contactDal.Update(t);
        }
    }
}
