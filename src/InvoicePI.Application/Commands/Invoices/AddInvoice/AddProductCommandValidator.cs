using FluentValidation;
using FluentValidation.Results;
using InvoicePI.Application.Commands.Products.AddProduct;
using InvoicePI.Application.Validation.Constatns;

namespace InvoicePI.Application.Commands.Invoices.AddInvoice;

public class AddInvoiceCommandValidator : AbstractValidator<AddInvoiceCommand>
{
    public AddInvoiceCommandValidator()
    {
        RuleLevelCascadeMode = CascadeMode.Stop;
    }

    public override Task<ValidationResult> ValidateAsync(ValidationContext<AddInvoiceCommand> context, CancellationToken cancellation = default)
    {
        RuleFor(x => x.CustomerId)
            .NotNull().WithMessage(ValidationMessageConstans.NotEmpty).WithSeverity(Severity.Error);

        return base.ValidateAsync(context, cancellation);
    }
}
