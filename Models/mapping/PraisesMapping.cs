using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace sHe_Ministries.Models.mapping
{
    public class PraisesMapping: EntityTypeConfiguration<Praises>
    {
        public PraisesMapping()
        {

            HasKey(p => p.Id);
            Property(p => p.FirstName).IsRequired();
            Property(p => p.LastName).IsOptional();
            Property(p => p.Email).IsOptional();
            Property(p => p.Praise).IsRequired();
        }
    }
}