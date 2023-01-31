using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Family_Store.Models
{
    public class Shirts
    {    [Key]
        public int IDS { get; set; }

        public int IDC { get; set; }
        [ForeignKey("IDC")]
        public Clothes Clothes { get; set; }

        [Required(ErrorMessage = "Please enter the color of the shirt ")]

        public string Scolor { get; set; }

        [Required(ErrorMessage = "Please enter the length of the shirt's sleeves  ")]
        public string Slength { get; set; }

        [Required(ErrorMessage = "Please enter the fabric type of the shirt ")]
        public string Sfabric { get; set; }

        [Required(ErrorMessage = "Please enter the price of the shirt ")]
        public string Sprice { get; set; }

        [Required(ErrorMessage = "Please enter the size of the shirt ")]
        public string Ssize { get; set; }


    }
}