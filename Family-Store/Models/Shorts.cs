using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Family_Store.Models
{
    public class Shorts
    {   [Key]
        public int IDSR { get; set; }

        public int IDC { get; set; }
        [ForeignKey("IDC")]
        public Clothes Clothes { get; set; }

        [Required(ErrorMessage = "Please enter the color of the short ")]

        public string SRcolor { get; set; }

        [Required(ErrorMessage = "Please enter the brand of the short ")]
        public string SRbrand { get; set; }



        [Required(ErrorMessage = "Please enter the price of the short ")]
        public string SRprice { get; set; }

        [Required(ErrorMessage = "Please enter the size of the short ")]
        public string SRsize { get; set; }
    }
}
