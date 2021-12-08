using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate.EntityFramework
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserMail { get; set; }
        public string UserPassword { get; set; }
        public  int UserNumber { get; set; }
        public string Roles { get; set; }

        //---------------İlişkiler---------------
        public List<BasketProduct> BasketProducts { get; set; }
        public List<FavProduct> FavProducts { get; set; }
        public List<Address> Addresses { get; set; }
        public User Users { get; set; }
    }
}
