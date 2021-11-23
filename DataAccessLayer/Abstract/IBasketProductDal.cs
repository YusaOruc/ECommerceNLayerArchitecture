using EntityLayer.Concreate.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBasketProductDal:IGenericDal<BasketProduct>
    {
        int GetByProductID(int id);
        void BasketProductInsert(Product product, int id);
        
    }
}
