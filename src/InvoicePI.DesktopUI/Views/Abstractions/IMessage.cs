using System.Windows.Forms;

namespace InvoicePI.DesktopUI.Views.Abstractions;

/// <summary>
/// Marks types that support displaying messages.
/// </summary>
public interface IMessage 
{
    void ShowMessage(string message, string caption, MessageBoxIcon icon);
}
