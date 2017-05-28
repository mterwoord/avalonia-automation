using System;
using FlaUI.Core;
using FlaUI.Core.Identifiers;
using FlaUI.Core.Patterns;
using FlaUITest.Elements;
using FlaUITest.FlaUIExt;

namespace FlaUITest.Patterns
{
    public class OurInvokePattern: InvokePatternBase<OurInvokePatternImpl>
    {
        private readonly ControlElement mControlElement;
        public static readonly PatternId Pattern = PatternId.Register(AutomationType.UIA3, PatternIds.InvokeId, "Invoke", AutomationObjectIds.IsInvokePatternAvailableProperty);

        public OurInvokePattern(ControlElement controlElement, OurInvokePatternImpl nativePattern): base(controlElement, nativePattern)
        {
            mControlElement = controlElement;
        }

        public new OurAutomation Automation => (OurAutomation)base.Automation;

        public override void Invoke()
        {
            if (mControlElement.mInfo.InvokePattern == null)
            {
                throw new InvalidOperationException("Invoke pattern not available on control!");
            }

            mControlElement.Invoke();
        }
    }
}