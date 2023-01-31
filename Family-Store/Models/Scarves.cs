using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Family_Store.Models
{   
    public class Scarves
    {   [Key]
        public int IDSC { get; set; }

        public int IDC { get; set; }
        [ForeignKey("IDC")]
        public Clothes Clothes { get; set; }

        [Required(ErrorMessage = "Please enter the color of the scarf ")]

        public string SCcolor { get; set; }


        [Required(ErrorMessage = "Please enter the fabric type of the scarf ")]
        public string SCfabric { get; set; }

        [Required(ErrorMessage = "Please enter the price of the scarf")]
        public string SCprice { get; set; }

       
    }
}
