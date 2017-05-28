using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Platform;
using Avalonia.Threading;
using AvaloniaExtension.Data;

namespace AvaloniaExtension.Controllers
{
    public class GetWindowsController
    {
        private string mResult;

        public async Task<List<WindowInfo>> Index()
        {
            var xWindows = new List<WindowInfo>();

            await Dispatcher.UIThread.InvokeTaskAsync(() =>
                                                      {
                                                          foreach (var xWindow in Window.OpenWindows)
                                                          {
                                                              xWindows.Add(DataCreators.Create(xWindow));
                                                          }
                                                      });
            
            return xWindows;
        }
    }
}