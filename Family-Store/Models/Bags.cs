using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Family_Store.Models
{
    public class Bags
    {   [Key]
        public int IDB { get; set; }

        public int IDC { get; set; }
        [ForeignKey("IDC")]
        public Clothes Clothes{ get; set; }
    

    [Required(ErrorMessage = "Please enter the color of the bag ")]

        public string Bcolor { get; set; }

        [Required(ErrorMessage = "Please enter the type of the bags  ")]
        public string Btype { get; set; }

        [Required(ErrorMessage = "Please enter the materail type of the bag ")]
        public string Bmaterail { get; set; }

        [Required(ErrorMessage = "Please enter the price of the bag")]
        public string Bprice { get; set; }
    }
}
