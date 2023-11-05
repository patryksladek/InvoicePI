using System.ComponentModel;
using FluentValidation.Results;
using System.Linq;
using System.Windows.Forms;
using System;
using DevExpress.XtraEditors.DXErrorProvider;
using FluentValidation;
using InvoicePI.DesktopUI.Views.Abstractions;

namespace InvoicePI.DesktopUI.Helpers;

public class ErrorHelper
{
    public static void SetErrorMessage(ValidationResult validationResult, IError errorProvider, object sender, EventArgs e)
    {
        var error = validationResult.Errors.FirstOrDefault();
        if (error is not null)
        {
            ErrorType errorType = GetErrorType(error.Severity);
            errorProvider.SetErrorMessage(sender as Control, error.ErrorMessage, errorType);
            if (errorType == ErrorType.Critical)
                (e as CancelEventArgs).Cancel = true;
            else
                (e as CancelEventArgs).Cancel = false;
        }
        else
            errorProvider.SetErrorMessage(sender as Control, string.Empty, ErrorType.None);
    }

    public static void SetErrorMessage(string message, IError errorProvider, ErrorType errorType, object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(message))
        {
            errorProvider.SetErrorMessage(sender as Control, message, errorType);
            if (errorType == ErrorType.Critical)
                (e as CancelEventArgs).Cancel = true;
            else
                (e as CancelEventArgs).Cancel = false;
        }
        else
            errorProvider.SetErrorMessage(sender as Control, string.Empty, ErrorType.None);
    }

    public static ErrorType GetErrorType(Severity severity) =>
      severity switch
      {
          Severity.Error => ErrorType.Critical,
          Severity.Warning => ErrorType.Warning,
          Severity.Info => ErrorType.Information,
          _ => throw new ArgumentException("Invalid enum value for severity", nameof(severity)),
      };
}

