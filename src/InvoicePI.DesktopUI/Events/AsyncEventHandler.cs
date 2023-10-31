using System;
using System.Threading.Tasks;

namespace InvoicePI.DesktopUI.Events;

public delegate Task AsyncEventHandler(object sender, EventArgs e);
