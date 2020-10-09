using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HungryFoodCorner.Models
{
    public class Bill
    {
        public int Id { get; set; }

        public DateTime Date = DateTime.Now;

        [Column(TypeName = "money")]
        public decimal TotalAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal Tip { get; set; }

        [Column(TypeName = "money")]
        decimal _FinalAmount;
        public decimal FinalAmount { 
            get { 
                return _FinalAmount; 
            } 
            set
            {
                _FinalAmount = TotalAmount + Tip;
            } 
        }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual List<BillItem> BillItem { get; set; }
    }
}
