using InvoicePI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvoicePI.Infrastructure.Config;

public class AuditableEntityConfiguration<TBase> : IEntityTypeConfiguration<TBase> where TBase : AuditableEntity
{
    public virtual void Configure(EntityTypeBuilder<TBase> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.CreatedAt)
            .HasColumnType("datetime2(0)")
            .IsRequired();

        builder.Property(x => x.UpdatedAt)
            .HasColumnType("datetime2(0)")
            .IsRequired();
    }
}
