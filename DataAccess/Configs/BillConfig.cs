using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Configs
{
    internal sealed class BillConfig : IEntityTypeConfiguration<Bill>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Bill> builder)
        {
            builder.ToTable("Bills");
            builder.HasKey(e => e.PaymentId);
            builder.Property(e => e.Identification_number).IsRequired();
            builder.Property(e => e.CustomerName).IsRequired();
            builder.Property(e => e.CustomerLastName).IsRequired();
            builder.Property(e => e.Cost).IsRequired();
            builder.Property(e => e.Identification_number).HasColumnType("int");
            builder.Property(e => e.CustomerName).HasColumnType("varchar(30)");
            builder.Property(e => e.CustomerLastName).HasColumnType("varchar(30)");
            
        }
    }
}
