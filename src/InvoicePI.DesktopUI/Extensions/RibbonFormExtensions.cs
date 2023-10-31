using DevExpress.XtraBars.Ribbon;
using WinForms = System.Windows.Forms;

namespace InvoicePI.DesktopUI.Extensions;

public static class RibbonFormExtensions
{
    public static void OpenTab(this RibbonForm sourceForm, RibbonForm form)
    {
        var existingForm = WinForms.Application.OpenForms[form.Name];
        if (existingForm != null)
        {
            existingForm.MdiParent = sourceForm;
            existingForm.BringToFront();
        }
        else
        {
            form.MdiParent = sourceForm;
            form.Show();
        }
    }
}

