using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HungryFoodCorner.Models
{
    public class Item
    {
        public int Id { get; set; }
        [Required]
        [StringLength(40)]
        public int Name { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }
       
    }
}
