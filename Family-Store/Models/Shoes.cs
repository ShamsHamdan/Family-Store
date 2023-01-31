using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Family_Store.Models
{
    public class Shoes
    {   [Key]
        public int IDSH { get; set; }

        public int IDC { get; set; }
        [ForeignKey("IDC")]
        public Clothes Clothes { get; set; }

        [Required(ErrorMessage = "Please enter the color of the shoes ")]

        public string SHcolor { get; set; }


        [Required(ErrorMessage = "Please enter the brand of the shoes ")]
        public string SHbrand { get; set; }

        [Required(ErrorMessage = "Please enter the price of the shoes")]
        public string SHprice { get; set; }

        [Required(ErrorMessage = "Please enter the size of the shoes")]
        public string SHsize { get; set; }
    }
}
