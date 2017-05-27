using System;
using System.Linq;
using System.Collections.Generic;
using System.Net.Http;
using AvaloniaExtension.Data;

namespace FlaUITest.FlaUIExt
{
    public class ProtocolHandler
    {
        private readonly HttpClient mClient;

        public ProtocolHandler(string url)
        {
            mClient = new HttpClient();
            mClient.BaseAddress = new Uri(url);
        }

        public WindowInfo[] GetWindows()
        {
            var xResult = mClient.GetAsync("debug").Result.Content.ReadAsAsync<WindowInfo[]>().Result;

            var xList = new List<WindowInfo>();
            foreach (var xItem in xResult)
            {
                if (!xList.Any(i => i.Handle == xItem.Handle))
                {
                    xList.Add(xItem);
                }
            }
            return xList.ToArray();
        }
    }
}