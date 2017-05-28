using System;
using System.CodeDom;
using AvaloniaExtension.Data;
using FlaUI.Core;
using FlaUI.Core.AutomationElements.Infrastructure;
using FlaUI.Core.Conditions;
using FlaUI.Core.Definitions;
using FlaUI.Core.EventHandlers;
using FlaUI.Core.Identifiers;
using FlaUI.Core.Shapes;
using FlaUITest.FlaUIExt;
using FlaUITest.Patterns;

namespace FlaUITest.Elements
{
    public class ControlElement: BaseElement
    {
        internal readonly AutomationElementInfo mInfo;
        internal readonly WindowInfo mParentWindow;
        private readonly ConditionBase mFindCondition;

        public ControlElement(WindowInfo parentWindow, ConditionBase findCondition, AutomationElementInfo info, OurAutomation automation): base(automation)
        {
            mInfo = info ?? throw new ArgumentNullException(nameof(info));
            mParentWindow = parentWindow ?? throw new ArgumentNullException(nameof(parentWindow));
            mFindCondition = findCondition ?? throw new ArgumentNullException(nameof(findCondition));
            Patterns = new ControlElementPatterns(this);
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
            switch (patternId)
            {
                case PatternIds.InvokeId:
                    return new OurInvokePatternImpl();
                default:
                    throw new Exception($"Pattern #{patternId} not implemented!");
            }
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
            get;
        }


        internal void Invoke()
        {
            Automation.CheckConnected();
            switch (mFindCondition)
            {
                case PropertyCondition xPropCondition:
                    if (xPropCondition.PropertyConditionFlags != PropertyConditionFlags.None)
                    {
                        throw new NotImplementedException("PropertyConditionFlags not yet implemented!");
                    }

                    switch (xPropCondition.Property.Id)
                    {
                        case AutomationElementIdentifiers.AutomationIdPropertyId:
                            Automation.Client.InvokeAutomationElementByAutomationIdInWindowController(mParentWindow, (string)xPropCondition.Value);
                            return;
                        default:
                            throw new Exception($"Property '{xPropCondition.Property.Name}' (#{xPropCondition.Property.Id}) not implemented!");
                    }
                default:
                    throw new NotImplementedException();
            }
        }
    }
}