using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HungryFoodCorner.Models
{
    public class BillItem
    {
        public int Id { get; set; }
        public int BillId { get; set; }
        public int ItemId { get; set; }
        public virtual List<Item> Item { get; set; }
    }
}
