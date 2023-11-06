using FluentValidation;
using FluentValidation.Results;
using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;

namespace InvoicePI.DesktopUI.Helpers;

public class ValidationHelper<TCommand, TValidator>
    where TCommand : new()
    where TValidator : IValidator<TCommand>, new()
{
    public static async Task<ValidationResult> ValidateAsync(Expression<Func<TCommand, object>> propertySelector, string value)
    {
        var command = new TCommand(); 
        var validator = new TValidator();

        if (propertySelector.Body is MemberExpression memberExpression)
        {
            var propertyName = memberExpression.Member.Name;
            var propertyValue = GetValueFromExpression(propertySelector, value);
            typeof(TCommand).GetProperty(propertyName)?.SetValue(command, propertyValue);
        }

        var result = await validator.ValidateAsync(command, options =>
        {
            options.IncludeProperties(propertySelector);
        });

        return result;
    }

    private static object GetValueFromExpression(Expression<Func<TCommand, object>> propertySelector, string value)
    {
        if (propertySelector.Body is MemberExpression memberExpression)
        {
            if (memberExpression.Member is PropertyInfo propertyInfo)
            {
                return value;
            }
        }

        return null;
    }
}