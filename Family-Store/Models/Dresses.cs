using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Family_Store.Models
{
    public class Dresses
    {   [Key]
        public int IDD { get; set; }

        public int IDC { get; set; }
        [ForeignKey("IDC")]
    
        public Clothes clothes { get; set; }

        [Required(ErrorMessage = "Please enter the color of the dress ")]
        
        public string Dcolor { get; set; }

        [Required(ErrorMessage = "Please enter the length of the dress  ")]
        public string Dlength { get; set; }

        [Required(ErrorMessage = "Please enter the fabric type of the dress  ")]
        public string Dfabric { get; set; }

        [Required(ErrorMessage = "Please enter the price of the dress ")]
        public string Dprice { get; set; }

        [Required(ErrorMessage = "Please enter the size of the dress ")]
        public string Dsize { get; set; }




    }
}
