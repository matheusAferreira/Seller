using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seller.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal ValueSale { get; set; }
        public decimal ValueBuy { get; set; }
        public int Amount { get; set; }
        public DateTime DataCreate { get; set; }
    }
}
