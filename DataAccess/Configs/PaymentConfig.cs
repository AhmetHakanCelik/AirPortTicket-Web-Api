using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Configs
{
    internal sealed class PaymentConfig : IEntityTypeConfiguration<Payment>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Payment> builder)
        {
            builder.ToTable("Payments");
            builder.HasKey(e => e.CardId);
            builder.Property(e => e.FullName).IsRequired();
            builder.Property(e => e.SecurityCode).IsRequired();
            builder.Property(e => e.ExpirationDate).IsRequired();
            builder.Property(e => e.FullName).HasColumnType("varchar(30)");
            builder.Property(e => e.SecurityCode).HasColumnType("int");
            builder.Property(e => e.FullName).HasColumnType("varchar(30)");
            
        }
    }
}
