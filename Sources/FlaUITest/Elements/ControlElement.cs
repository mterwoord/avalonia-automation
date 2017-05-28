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
    public class ControlElement: BaseElement
    {
        private readonly AutomationElementInfo mInfo;
        private readonly WindowInfo mParentWindow;
        private readonly ConditionBase mFindCondition;

        public ControlElement(WindowInfo parentWindow, ConditionBase findCondition, AutomationElementInfo info, OurAutomation automation): base(automation)
        {
            mInfo = info ?? throw new ArgumentNullException(nameof(info));
            mParentWindow = parentWindow ?? throw new ArgumentNullException(nameof(parentWindow));
            mFindCondition = findCondition ?? throw new ArgumentNullException(nameof(findCondition));
        }

        public override void SetFocus()
        {
            throw new NotImplementedException();
        }

        protected override object InternalGetPropertyValue(int propertyId, bool cached, bool useDefaultIfNotSupported)
        {
            throw new NotImplementedException();
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
            point = new Point(x: mInfo.PositionOnDesktopX + mInfo.Width / 2,
                              y: mInfo.PositionOnDesktopY + mInfo.Height / 2);
            return true;
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