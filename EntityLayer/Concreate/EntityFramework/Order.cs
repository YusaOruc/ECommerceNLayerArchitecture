using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate.EntityFramework
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public int UserID { get; set; }
        public int AddressID { get; set; }
        public int ProductID { get; set; }
        public int ProductNumber { get; set; }
        public bool OrderStatus { get; set; }

        public Product Products { get; set; }
        public Address Addresses { get; set; }
        public List<User> Users { get; set; }


    }
}
