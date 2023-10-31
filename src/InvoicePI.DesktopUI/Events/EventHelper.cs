using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InvoicePI.DesktopUI.Events;

public class EventHelper
{
    public static void RaiseEvent(object objectRaisingEvent, EventHandler eventHandlerRaised, EventArgs eventArgs)
    {
        if (eventHandlerRaised != null)
        {
            eventHandlerRaised(objectRaisingEvent, eventArgs);
        }
    }

    public static async Task RaiseEventAsync(object objectRaisingEvent, AsyncEventHandler eventHandlerRaised, EventArgs eventArgs)
    {
        if (eventHandlerRaised != null)
        {
            Delegate[] subscribers = eventHandlerRaised.GetInvocationList();
            List<Task> invocationTasks = new List<Task>();

            foreach (var subscriber in subscribers)
            {
                if (subscriber is AsyncEventHandler asyncSubscriber)
                {
                    invocationTasks.Add(asyncSubscriber(objectRaisingEvent, eventArgs));
                }
                else if (subscriber is EventHandler nonAsyncSubscriber)
                {
                    invocationTasks.Add(Task.Run(() => nonAsyncSubscriber(objectRaisingEvent, eventArgs)));
                }
            }

            await Task.WhenAll(invocationTasks);
        }
    }
}