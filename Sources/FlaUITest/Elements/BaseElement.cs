using FlaUI.Core;
using FlaUITest.FlaUIExt;

namespace FlaUITest.Elements
{
    public abstract class BaseElement: BasicAutomationElementBase
    {
        protected BaseElement(OurAutomation automation): base(automation)
        {
        }

        public new OurAutomation Automation => (OurAutomation)base.Automation;
    }
}