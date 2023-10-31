using InvoicePI.Domain.Entities.Customers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvoicePI.Infrastructure.Config;

public class ContactConfiguration : AuditableEntityConfiguration<Contact>
{
    public override void Configure(EntityTypeBuilder<Contact> builder)
    {
        builder.ToTable("Contacts", "customers");

        builder.Property(x => x.Phone)
            .HasMaxLength(30);

        builder.Property(x => x.Mobile)
           .HasMaxLength(30);

        builder.Property(x => x.Email)
            .HasMaxLength(100);

        builder.Property(x => x.Fax)
            .HasMaxLength(30);

        base.Configure(builder);
    }
}
