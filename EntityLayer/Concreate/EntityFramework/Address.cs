using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate.EntityFramework
{
    public class Address
    {
        [Key]
        public int AddressID { get; set; }
        public string City { get; set; }
        public string AddressUser { get; set; }
        public string AddressHeader { get; set; }
        public int PostCode { get; set; }

        //---------------İlişkiler---------------
        public int UserID { get; set; }
        public User User { get; set; }
        public List<Address> Addresses { get; set; }
    }
}
