using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seller.Model
{
    public class InputProduct
    {
        public int Id { get; set; }
        public int Prdid { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }
        public Product Product { get; set; }

    }
}
