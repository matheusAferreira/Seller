using Seller.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seller.Mapping
{
    public class ProductMAP : EntityTypeConfiguration<Product>
    {
        public ProductMAP()
        {
            ToTable("TB_PRODUCT");

            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("PRD_ID");
            Property(x => x.Name).HasColumnName("PRD_NAME");
            Property(x => x.Description).HasColumnName("PRD_DESCRIPTION");
            Property(x => x.ValueSale).HasColumnName("PRD_VALUE_SALE");
            Property(x => x.ValueBuy).HasColumnName("PRD_VALUE_BUY");
            Property(x => x.Amount).HasColumnName("PRD_AMOUNT");
            Property(x => x.DataCreate).HasColumnName("PRD_DATE_CREATE");
        }
    }
}
