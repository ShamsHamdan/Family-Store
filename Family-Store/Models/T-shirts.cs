using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Family_Store.Models
{
    public class T_shirts
    {  [Key]
        public int IDST { get; set; }

        public int IDC { get; set; }
        [ForeignKey("IDC")]
        public Clothes Clothes { get; set; }

        [Required(ErrorMessage = "Please enter the color of the T-Shirt ")]

        public string STcolor { get; set; }

        [Required(ErrorMessage = "Please enter the brand of the T-Shirt ")]
        public string STbrand { get; set; }



        [Required(ErrorMessage = "Please enter the price of the T-Shirt ")]
        public string STprice { get; set; }

        [Required(ErrorMessage = "Please enter the size of the T-Shirt ")]
        public string STsize { get; set; }
    }
}
