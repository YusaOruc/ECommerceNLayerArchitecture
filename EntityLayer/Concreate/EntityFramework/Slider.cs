using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate.EntityFramework
{
    public class Slider
    {
        [Key]
        public int SliderID { get; set; }
        public string SliderHeader { get; set; }
        public string SliderDescription { get; set; }
        public string SliderImg { get; set; }
    }
}
