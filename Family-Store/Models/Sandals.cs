using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Family_Store.Models
{
    public class Sandals
    {   [Key]
        public int IDSA { get; set; }

        public int IDC { get; set; }
        [ForeignKey("IDC")]
        public Clothes Clothes { get; set; }

        [Required(ErrorMessage = "Please enter the color of the sandals ")]

        public string SAcolor { get; set; }


        [Required(ErrorMessage = "Please enter the brand of the sandals ")]
        public string SAbrand { get; set; }

        [Required(ErrorMessage = "Please enter the price of the sandals")]
        public string SAprice { get; set; }

        [Required(ErrorMessage = "Please enter the size of the sandals")]
        public string SAsize { get; set; }
    }
}
