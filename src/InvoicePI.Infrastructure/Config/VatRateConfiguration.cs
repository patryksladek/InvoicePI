using InvoicePI.Domain.Entities.Definitions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvoicePI.Infrastructure.Config;

public class VatRateConfiguration : BaseEntityConfiguration<VatRate>
{
    public override void Configure(EntityTypeBuilder<VatRate> builder)
    {
        builder.ToTable("VatRates", "definitions");

        builder.Property(x => x.Symbol)
            .HasMaxLength(12)
            .IsRequired();

        builder.Property(x => x.Value)
           .HasPrecision(2)
           .IsRequired();

        base.Configure(builder);
    }
}
