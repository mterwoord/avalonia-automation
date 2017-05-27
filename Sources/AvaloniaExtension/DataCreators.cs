using System;
using Avalonia.Controls;
using AvaloniaExtension.Data;

namespace AvaloniaExtension
{
    public static class DataCreators
    {
        public static WindowInfo Create(Window window)
        {
            if (window == null)
            {
                throw new ArgumentNullException(nameof(window));
            }

            var xResult = new WindowInfo();

            xResult.Title = window.Title;
            xResult.Handle = window.PlatformImpl.Handle.Handle.ToInt64();
            xResult.ClientHeight = window.ClientSize.Height;
            xResult.ClientWidth = window.ClientSize.Width;

            return xResult;
        }
    }
}