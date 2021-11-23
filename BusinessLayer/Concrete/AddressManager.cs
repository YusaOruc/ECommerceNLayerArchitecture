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
    public class AddressManager : IAddressService
    {
        IAddressDal _addressDal;

        public AddressManager(IAddressDal addressDal)
        {
            _addressDal = addressDal;
        }

        public void DeleteService(Address t)
        {
            _addressDal.Delete(t);
        }

        public Address GetByIDService(int id)
        {
            return _addressDal.GetByID(id);
        }

        public List<Address> GetListAllService()
        {
            return _addressDal.GetListAll();
        }

        public List<Address> GetListAllService(Expression<Func<Address, bool>> filter)
        {
            return _addressDal.GetListAll(filter);
        }

        public void InsertService(Address t)
        {
            _addressDal.Insert(t);
        }

        public void UpdateService(Address t)
        {
            _addressDal.Update(t);
        }
    }
}
