using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Threading;
using AvaloniaExtension.Data;
using Microsoft.AspNetCore.Mvc;

namespace AvaloniaExtension.Controllers
{
    public class InvokeAutomationElementByAutomationIdInWindowController
    {
        public async Task<string> Index([FromQuery] long windowHandle, [FromQuery] string automationId)
        {
            await Dispatcher.UIThread.InvokeTaskAsync(() =>
                                                      {
                                                          var xWindow = Window.OpenWindows.FirstOrDefault(i => i.PlatformImpl.Handle.Handle.ToInt64() == windowHandle);
                                                          if (xWindow == null)
                                                          {
                                                              throw new Exception("Window not found!");
                                                          }
                                                          var xControl = xWindow.FindControl<Button>(automationId);
                                                          if (xControl.Command == null)
                                                          {
                                                              throw new Exception("Invoking a button is not supported if it doesn't have a command!");
                                                          }
                                                          if (xControl.Command.CanExecute(xControl.CommandParameter))
                                                          {
                                                              xControl.Command.Execute(xControl.CommandParameter);
                                                              // what to do if 
                                                          }
                                                      });
            return "OK";
        }
    }
}