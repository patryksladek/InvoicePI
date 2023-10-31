using DevExpress.XtraEditors.DXErrorProvider;
using System.Windows.Forms;

namespace InvoicePI.DesktopUI.Views.Abstractions;

/// <summary>
/// Marks types that support error handling.
/// </summary>
public interface IError
{
    void SetErrorMessage(Control control, string errorMessage, ErrorType errorType);
    void ShowErrorMessage(string errorMessage);

}
