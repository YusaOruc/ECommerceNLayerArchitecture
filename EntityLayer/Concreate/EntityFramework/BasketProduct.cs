using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate.EntityFramework
{
    public class BasketProduct
    {
        [Key]
        public int BasketProductID { get; set; }
        public int SelectedBasketProductID { get; set; }
        public int BasketProductNumber { get; set; }
        public string BasketProductImg{ get; set; }
        public string BasketProductTitle{ get; set; }
        public double BasketProductPrice { get; set; }

        //---------------İlişkiler---------------
        public int UserID { get; set; }
        public User User { get; set; }
    }
}
