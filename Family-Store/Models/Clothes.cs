using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Family_Store.Models
{
    public class Clothes
    {
        [Key]
        public int IDC { get; set; }


        [Required(ErrorMessage = "Please enter a type of clothes  ")]
        public string Ctype { get; set; }

        public int IDF { get; set; }
        [ForeignKey("IDF")]
        public family family { get; set; }
    }
}
