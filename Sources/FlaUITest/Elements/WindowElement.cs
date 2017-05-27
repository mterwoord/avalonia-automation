using System;
using AvaloniaExtension.Data;
using FlaUI.Core;
using FlaUI.Core.AutomationElements.Infrastructure;
using FlaUI.Core.Conditions;
using FlaUI.Core.Definitions;
using FlaUI.Core.EventHandlers;
using FlaUI.Core.Identifiers;
using FlaUI.Core.Shapes;
using FlaUITest.FlaUIExt;

namespace FlaUITest.Elements
{
    public class WindowElement: BaseElement
    {
        private readonly WindowInfo mInfo;

        public WindowElement(WindowInfo info, OurAutomation automation):base(automation)
        {
            mInfo = info;
            //
        }

        public override void SetFocus()
        {
            throw new NotImplementedException();
        }

        protected override object InternalGetPropertyValue(int propertyId, bool cached, bool useDefaultIfNotSupported)
        {
            switch (propertyId)
            {
                case AutomationElementIdentifiers.NamePropertyId:
                    return mInfo.Title;
                default:
                    throw new NotImplementedException("Property '" + propertyId + "' not implemented!");
            }
        }

        protected override object InternalGetPattern(int patternId, bool cached)
        {
            throw new NotImplementedException();
        }

        public override AutomationElement[] FindAll(TreeScope treeScope, ConditionBase condition)
        {
            throw new NotImplementedException();
        }

        public override AutomationElement FindFirst(TreeScope treeScope, ConditionBase condition)
        {
            throw new NotImplementedException();
        }

        public override bool TryGetClickablePoint(out Point point)
        {
            throw new NotImplementedException();
        }

        public override IAutomationEventHandler RegisterEvent(EventId @event, TreeScope treeScope, Action<AutomationElement, EventId> action)
        {
            throw new NotImplementedException();
        }

        public override IAutomationPropertyChangedEventHandler RegisterPropertyChangedEvent(TreeScope treeScope, Action<AutomationElement, PropertyId, object> action, PropertyId[] properties)
        {
            throw new NotImplementedException();
        }

        public override IAutomationStructureChangedEventHandler RegisterStructureChangedEvent(TreeScope treeScope, Action<AutomationElement, StructureChangeType, int[]> action)
        {
            throw new NotImplementedException();
        }

        public override void RemoveAutomationEventHandler(EventId @event, IAutomationEventHandler eventHandler)
        {
            throw new NotImplementedException();
        }

        public override void RemovePropertyChangedEventHandler(IAutomationPropertyChangedEventHandler eventHandler)
        {
            throw new NotImplementedException();
        }

        public override void RemoveStructureChangedEventHandler(IAutomationStructureChangedEventHandler eventHandler)
        {
            throw new NotImplementedException();
        }

        public override PatternId[] GetSupportedPatterns()
        {
            throw new NotImplementedException();
        }

        public override PropertyId[] GetSupportedProperties()
        {
            throw new NotImplementedException();
        }

        public override AutomationElement GetUpdatedCache()
        {
            throw new NotImplementedException();
        }

        public override AutomationElement[] GetCachedChildren()
        {
            throw new NotImplementedException();
        }

        public override AutomationElement GetCachedParent()
        {
            throw new NotImplementedException();
        }

        public override AutomationElementPatternValuesBase Patterns
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}