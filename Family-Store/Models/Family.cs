using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Family_Store.Models
{
    public class family
    {   
        [Key]
        public int IDF { get; set; }
        [Required(ErrorMessage ="Please enter a part name ")]
        public string Part { get; set; }

    }
}
