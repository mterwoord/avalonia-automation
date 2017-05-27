using System;
using Avalonia;
using Avalonia.Controls;
using AvaloniaExtension.Interfaces;
using AvaloniaExtension.Services;

namespace AvaloniaExtension
{
    public static class Extensions
    {
        public static AppBuilderBase<T> WithAvaloniaAutomation<T>(this AppBuilderBase<T> aThis)
            where T: AppBuilderBase<T>, new()
        {
            var xEngine = new AutomationEngineImpl();
            AvaloniaLocator.CurrentMutable.Bind<IAutomationEngine>().ToConstant(xEngine);

            xEngine.Initialize();
            aThis.Instance.OnExit += (a,b)=>xEngine.Shutdown();

            return aThis;
        }
    }
}
