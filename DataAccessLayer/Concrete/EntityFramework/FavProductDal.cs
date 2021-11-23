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
    public class FavProductDal : GenericRepository<FavProduct>, IFavProductDal
    {
        public int GetByProductID(int id)
        {
            using var c = new Context();

            return c.FavProducts.Where(x => x.SelectedFavProductID == id).FirstOrDefault().FavProductID;
        }
    }
}
