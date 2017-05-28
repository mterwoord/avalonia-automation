using System;
using System.Linq;
using System.Net.Http;
using FlaUI.Core;
using FlaUI.Core.AutomationElements.Infrastructure;
using FlaUI.Core.EventHandlers;
using FlaUI.Core.Shapes;
using FlaUITest.Elements;

namespace FlaUITest.FlaUIExt
{
    public class OurAutomation: AutomationBase
    {
        internal ProtocolHandler Client;

        public OurAutomation(): base(new OurPropertyLibrary(), new OurEventLibrary(), new OurPatternLibrary())
        {
            
        }

        public void Connect(string url)
        {
            Client = new ProtocolHandler(url);
        }

        internal void CheckConnected()
        {
            if (Client == null)
            {
                throw new InvalidOperationException("Not connected!");
            }
        }

        public override AutomationElement GetDesktop()
        {
            throw new NotImplementedException();
        }

        public override AutomationElement FromPoint(Point point)
        {
            throw new NotImplementedException();
        }

        public override AutomationElement FromHandle(IntPtr hwnd)
        {
            CheckConnected();
            var xWinElem = new WindowElement(Client.GetWindows().Single(i => i.Handle == hwnd.ToInt64()), this);
            return new AutomationElement(xWinElem);
        }

        public override AutomationElement FocusedElement()
        {
            throw new NotImplementedException();
        }

        public override IAutomationFocusChangedEventHandler RegisterFocusChangedEvent(Action<AutomationElement> action)
        {
            throw new NotImplementedException();
        }

        public override void UnRegisterFocusChangedEvent(IAutomationFocusChangedEventHandler eventHandler)
        {
            throw new NotImplementedException();
        }

        public override void UnregisterAllEvents()
        {
            throw new NotImplementedException();
        }

        public override bool Compare(AutomationElement element1, AutomationElement element2)
        {
            throw new NotImplementedException();
        }

        public override ITreeWalkerFactory TreeWalkerFactory
        {
            get;
        }

        public override AutomationType AutomationType
        {
            get;
        }

        public override object NotSupportedValue
        {
            get;
        }
    }
}