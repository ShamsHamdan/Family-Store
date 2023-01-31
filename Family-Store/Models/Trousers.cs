using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Family_Store.Models
{
    public class Trousers
    {   [Key]
        public int IDT { get; set; }

        public int IDC { get; set; }
        [ForeignKey("IDC")]
        public Clothes Clothes { get; set; }

        [Required(ErrorMessage = "Please enter the color of the trousers ")]

        public string Tcolor { get; set; }


        [Required(ErrorMessage = "Please enter the fabric type of the trousers ")]
        public string Tfabric { get; set; }

        [Required(ErrorMessage = "Please enter the price of the trousers")]
        public string Tprice { get; set; }

        [Required(ErrorMessage = "Please enter the size of the trousers")]
        public string Tsize { get; set; }


    }
}
