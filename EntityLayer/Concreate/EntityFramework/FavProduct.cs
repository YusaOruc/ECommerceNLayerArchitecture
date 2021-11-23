using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate.EntityFramework
{
     public class FavProduct
    {
        [Key]
        public int FavProductID { get; set; }
        public int SelectedFavProductID { get; set; }

        //---------------İlişkiler---------------
        public int UserID { get; set; }
        public User User { get; set; }
    }
}
