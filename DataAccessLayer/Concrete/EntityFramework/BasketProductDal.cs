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
    public class BasketProductDal : GenericRepository<BasketProduct>, IBasketProductDal
    {
        public void BasketProductInsert(Product product,int id=0)
        {
            using var c = new Context();
            BasketProduct basketProduct = new BasketProduct();


            if (id!=0)
            {
                basketProduct.SelectedBasketProductID = product.ProductID;
                basketProduct.UserID = id;
                basketProduct.BasketProductImg = product.ProductImg1;
                basketProduct.BasketProductNumber = 1;
                basketProduct.BasketProductPrice = product.ProductPrice;
                basketProduct.BasketProductTitle = product.ProductName;

                c.Add(basketProduct);
                c.SaveChanges();
            }
            
        }

        public int GetByProductID(int id)
        {
            using var c = new Context();
            
            return c.BasketProducts.Where(x => x.SelectedBasketProductID == id).FirstOrDefault().BasketProductID;
        }
    }
}
