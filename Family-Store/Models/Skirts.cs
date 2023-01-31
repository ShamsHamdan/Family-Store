using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Family_Store.Models
{
    public class Skirts
    {   [Key]
        public int IDSK { get; set; }

        public int IDC { get; set; }
        [ForeignKey("IDC")]
        public Clothes Clothes { get; set; }

        [Required(ErrorMessage = "Please enter the color of the skirt")]

        public string SKcolor { get; set; }

        [Required(ErrorMessage = "Please enter the length of the skirt  ")]
        public string SKlength { get; set; }

        [Required(ErrorMessage = "Please enter the fabric type of the skirt  ")]
        public string SKfabric { get; set; }

        [Required(ErrorMessage = "Please enter the price of the skirt ")]
        public string SKprice { get; set; }

        [Required(ErrorMessage = "Please enter the size of the skirt ")]
        public string SKsize { get; set; }

    }
}
