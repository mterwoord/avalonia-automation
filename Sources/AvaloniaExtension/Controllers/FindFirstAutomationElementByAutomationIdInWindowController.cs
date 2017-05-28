using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Threading;
using AvaloniaExtension.Data;
using Microsoft.AspNetCore.Mvc;

namespace AvaloniaExtension.Controllers
{
    public class FindFirstAutomationElementByAutomationIdInWindowController
    {
        public async Task<AutomationElementInfo> Index([FromQuery] long windowHandle, [FromQuery] string automationId)
        {
            var xResult = new List<AutomationElementInfo>();

            await Dispatcher.UIThread.InvokeTaskAsync(() =>
                                                      {
                                                          var xWindow = Window.OpenWindows.FirstOrDefault(i => i.PlatformImpl.Handle.Handle.ToInt64() == windowHandle);
                                                          if (xWindow == null)
                                                          {
                                                              throw new Exception("Window not found!");
                                                          }
                                                          var xControl = xWindow.FindControl<Control>(automationId);
                                                          var xResultItem = DataCreators.Create(xControl);
                                                          xResult.Add(xResultItem);
                                                      });
            return xResult.FirstOrDefault();
        }
    }
}