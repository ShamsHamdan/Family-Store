using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Family_Store.Models
{
    public class Jakets
    {   [Key]
        public int IDJ { get; set; }

        public int IDC { get; set; }
        [ForeignKey("IDC")]
        public Clothes Clothes { get; set; }

        [Required(ErrorMessage = "Please enter the color of the jaket ")]

        public string Jcolor { get; set; }

        [Required(ErrorMessage = "Please enter the brand of the jaket  ")]
        public string Jbrand { get; set; }

        

        [Required(ErrorMessage = "Please enter the price of the jaket ")]
        public string Jprice { get; set; }

        [Required(ErrorMessage = "Please enter the size of the jaket ")]
        public string Jsize { get; set; }
    }
}
