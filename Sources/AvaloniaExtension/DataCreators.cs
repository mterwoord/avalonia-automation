using System;
using Avalonia;
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

        public static AutomationElementInfo Create(Control control)
        {
            var xResultItem = new AutomationElementInfo();
            xResultItem.Name = control.Name;
            xResultItem.Height = control.Bounds.Height;
            xResultItem.Width = control.Bounds.Width;
             
            var xStartPos = control.PointToScreen(new Point(0, 0));
            xResultItem.PositionOnDesktopX = xStartPos.X;
            xResultItem.PositionOnDesktopY = xStartPos.Y;

            return xResultItem;
        }
    }
}