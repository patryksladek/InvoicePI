using InvoicePI.Domain.Entities.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvoicePI.Infrastructure.Config;

public class UnitConfiguration : BaseEntityConfiguration<Unit>
{
    public override void Configure(EntityTypeBuilder<Unit> builder)
    {
        builder.ToTable("Units", "products");

        builder.Property(x => x.Code)
            .HasMaxLength(10)
            .IsRequired();

        builder.Property(x => x.Description)
            .HasMaxLength(80)
           .IsRequired();

        base.Configure(builder);
    }
}
