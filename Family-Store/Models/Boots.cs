using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Family_Store.Models
{   
    public class Boots
    {   [Key]
        public int IDBO { get; set; }

        public int IDC { get; set; }
        [ForeignKey("IDC")]
        public Clothes Clothes { get; set; }

        [Required(ErrorMessage = "Please enter the color of the boots ")]

        public string BOcolor { get; set; }


        [Required(ErrorMessage = "Please enter the brand of the boots ")]
        public string BObrand { get; set; }

        [Required(ErrorMessage = "Please enter the price of the boots")]
        public string BOprice { get; set; }

        [Required(ErrorMessage = "Please enter the size of the boots")]
        public string BOsize { get; set; }
    }
}
