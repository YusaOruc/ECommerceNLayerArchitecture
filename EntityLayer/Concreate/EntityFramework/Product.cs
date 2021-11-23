using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate.EntityFramework
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductImg1 { get; set; }
        public string ProductImg2 { get; set; }
        public string ProductImg3 { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public double ProductPrice { get; set; }

        //-------------------İlişkiler--------------
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public List<Order> Orders { get; set; }
    }
}
