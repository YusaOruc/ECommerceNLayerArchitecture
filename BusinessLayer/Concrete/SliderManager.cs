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
    public class SliderManager : ISliderService
    {
        ISliderDal _sliderDal;

        public SliderManager(SliderDal sliderDal)
        {
            _sliderDal = sliderDal;
        }

        public void DeleteService(Slider t)
        {
            _sliderDal.Delete(t);
        }

        public Slider GetByIDService(int id)
        {
            return _sliderDal.GetByID(id);
        }

        public List<Slider> GetListAllService()
        {
            return _sliderDal.GetListAll();
        }

        public List<Slider> GetListAllService(Expression<Func<Slider, bool>> filter)
        {
            return _sliderDal.GetListAll(filter);
        }

        public void InsertService(Slider t)
        {
            _sliderDal.Insert(t);
        }

        public void UpdateService(Slider t)
        {
            _sliderDal.Update(t);
        }
    }
}
