using System.IO;
using System.Threading;
using System.Threading.Tasks;
using AvaloniaExtension.Interfaces;
using Microsoft.AspNetCore.Hosting;

namespace AvaloniaExtension.Services
{
    public class AutomationEngineImpl: IAutomationEngine
    {
        public void Shutdown()
        {
            mCancelSource.Cancel();
        }

        private CancellationTokenSource mCancelSource = new CancellationTokenSource();
        public void Initialize()
        {
            var host = new WebHostBuilder()
                .UseKestrel().UseUrls("http://localhost:5000/")
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<OwinStartup>()
                .Build();
            
            Task.Run(() => host.Run(mCancelSource.Token));
        }
    }
}