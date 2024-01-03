using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Configs
{
        internal sealed class TicketConfig : IEntityTypeConfiguration<Ticket>
        {
            public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Ticket> builder)
             {
                    builder.ToTable("Tickets");
                    builder.HasKey(e => e.TicketId);
                    builder.Property(e => e.CustomerFullName).IsRequired();
                    builder.Property(e => e.Cost).IsRequired();
                    builder.Property(e => e.Date).IsRequired();
                    builder.Property(e => e.CustomerFullName).HasColumnType("varchar(30)");
                    builder.Property(e => e.Cost).HasColumnType("money");

             }
        }
    }

