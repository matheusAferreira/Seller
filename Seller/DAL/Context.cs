using Seller.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seller.DAL
{
    public class Context : DbContext
    {
        public Context() : base("Data Source=DESKTOP-UNPN1DK;Initial Catalog=Seller;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {
            this.Configuration.LazyLoadingEnabled = true;
        }
        public DbSet<Product> TB_PRODUCT { get; set; }
        public DbSet<Product> TB_INPUT_PRODUCT { get; set; }
        public DbSet<Product> TB_OUTPUT_PRODUCT { get; set; }



    }
}
