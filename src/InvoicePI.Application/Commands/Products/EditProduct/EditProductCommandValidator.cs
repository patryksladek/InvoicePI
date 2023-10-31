using FluentValidation;
using FluentValidation.Results;
using InvoicePI.Application.Validation.Constatns;

namespace InvoicePI.Application.Commands.Customers.EditCusotmer;

public class EditProductCommandValidator : AbstractValidator<EditProductCommand>
{
    public EditProductCommandValidator()
    {
        RuleLevelCascadeMode = CascadeMode.Stop;
    }

    public override Task<ValidationResult> ValidateAsync(ValidationContext<EditProductCommand> context, CancellationToken cancellation = default)
    {
        RuleFor(x => x.Name)
           .NotEmpty().WithMessage(ValidationMessageConstans.NotEmpty).WithSeverity(Severity.Error)
           .MaximumLength(ProductValidationRuleConstans.MaximumNameLength).WithMessage(ValidationMessageConstans.MaximumLength(ProductValidationRuleConstans.MaximumNameLength)).WithSeverity(Severity.Error);

        RuleFor(x => x.Code)
            .NotEmpty().WithMessage(ValidationMessageConstans.NotEmpty).WithSeverity(Severity.Error)
            .MaximumLength(ProductValidationRuleConstans.MaximumCodeLength).WithMessage(ValidationMessageConstans.MaximumLength(ProductValidationRuleConstans.MaximumCodeLength)).WithSeverity(Severity.Error);

        return base.ValidateAsync(context, cancellation);
    }
}
