using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Configs
{
    internal sealed class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");
            builder.HasKey(e => e.CustomerId);
            builder.Property(e => e.Email).IsRequired();
            builder.Property(e => e.Address).IsRequired();
            builder.Property(e => e.CustomerName).IsRequired();
            builder.Property(e => e.Phone).IsRequired();
            builder.Property(e => e.Gender).IsRequired();
            builder.Property(e => e.Email).HasColumnType("text");
            builder.Property(e => e.Address).HasColumnType("text");
            builder.Property(e => e.CustomerName).HasColumnType("varchar(30)");
            builder.Property(e => e.Gender).HasColumnType("char");
            builder.Property(e => e.Gender).HasAnnotation("DisplayHint","M: For Male , F: For Female ");
        }
    }
}
