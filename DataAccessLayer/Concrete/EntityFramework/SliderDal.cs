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
    public class SliderDal:GenericRepository<Slider>,ISliderDal
    {
    }
}
