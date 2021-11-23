using BusinessLayer.Abstract.Repositories;
using EntityLayer.Concreate.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IFavProductService : IRepositoryService<FavProduct>
    {
        int GetByProductIDService(int id);
    }
}
