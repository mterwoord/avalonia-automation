using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlaUI.Core;
using FlaUI.Core.Tools;
using FlaUITest.FlaUIExt;

namespace FlaUITest
{
    class Program
    {
        static void Main(string[] args)
        {
            var xProcess = Retry.WhileException(() => Process.GetProcessesByName("AvaloniaTestApp").Single(), TimeSpan.FromSeconds(10));

            var xAuto = new OurAutomation();
            xAuto.Connect("http://localhost:5000/");
            var xApp = Application.Attach(xProcess);
            xApp.WaitWhileMainHandleIsMissing();

            var xProp = xAuto.PropertyLibrary.Element.Name;
            var xWin = xApp.GetMainWindow(xAuto);
            Console.WriteLine("Window title: '{0}'", xWin.Title);
            var xButton = xWin.FindFirstDescendant(cf => cf.ByAutomationId("ourButton"));
            if (xButton == null)
            {
                Console.WriteLine("Button not found!");
            }
            else
            {
                Console.WriteLine("Button found!!");
            }
            //xButton.Patterns.Invoke.Pattern.Invoke();
            xButton.Click();
        }
    }
}
