using System;
using FlaUI.Core;
using FlaUI.Core.Identifiers;
using FlaUI.Core.Patterns;
using FlaUI.UIA2.Patterns;
using FlaUITest.Patterns;

namespace FlaUITest.Elements
{
    public class ControlElementPatterns: AutomationElementPatternValuesBase
    {
        private readonly ControlElement mBasicAutomationElement;

        public ControlElementPatterns(ControlElement basicAutomationElement): base(basicAutomationElement)
        {
            mBasicAutomationElement = basicAutomationElement;
        }

        protected override IAutomationPattern<IAnnotationPattern> InitializeAnnotationPattern()
        {
            throw new NotImplementedException();
        }

        protected override IAutomationPattern<IDockPattern> InitializeDockPattern()
        {
            throw new NotImplementedException();
        }

        protected override IAutomationPattern<IDragPattern> InitializeDragPattern()
        {
            throw new NotImplementedException();
        }

        protected override IAutomationPattern<IDropTargetPattern> InitializeDropTargetPattern()
        {
            throw new NotImplementedException();
        }

        protected override IAutomationPattern<IExpandCollapsePattern> InitializeExpandCollapsePattern()
        {
            throw new NotImplementedException();
        }

        protected override IAutomationPattern<IGridItemPattern> InitializeGridItemPattern()
        {
            throw new NotImplementedException();
        }

        protected override IAutomationPattern<IGridPattern> InitializeGridPattern()
        {
            throw new NotImplementedException();
        }

        protected override IAutomationPattern<IInvokePattern> InitializeInvokePattern()
        {
            return new AutomationPattern<IInvokePattern, OurInvokePatternImpl>(OurInvokePattern.Pattern, mBasicAutomationElement, (elem, ourPattern) => new OurInvokePattern((ControlElement)elem, ourPattern));
        }

        protected override IAutomationPattern<IItemContainerPattern> InitializeItemContainerPattern()
        {
            throw new NotImplementedException();
        }

        protected override IAutomationPattern<ILegacyIAccessiblePattern> InitializeLegacyIAccessiblePattern()
        {
            throw new NotImplementedException();
        }

        protected override IAutomationPattern<IMultipleViewPattern> InitializeMultipleViewPattern()
        {
            throw new NotImplementedException();
        }

        protected override IAutomationPattern<IObjectModelPattern> InitializeObjectModelPattern()
        {
            throw new NotImplementedException();
        }

        protected override IAutomationPattern<IRangeValuePattern> InitializeRangeValuePattern()
        {
            throw new NotImplementedException();
        }

        protected override IAutomationPattern<IScrollItemPattern> InitializeScrollItemPattern()
        {
            throw new NotImplementedException();
        }

        protected override IAutomationPattern<IScrollPattern> InitializeScrollPattern()
        {
            throw new NotImplementedException();
        }

        protected override IAutomationPattern<ISelectionItemPattern> InitializeSelectionItemPattern()
        {
            throw new NotImplementedException();
        }

        protected override IAutomationPattern<ISelectionPattern> InitializeSelectionPattern()
        {
            throw new NotImplementedException();
        }

        protected override IAutomationPattern<ISpreadsheetItemPattern> InitializeSpreadsheetItemPattern()
        {
            throw new NotImplementedException();
        }

        protected override IAutomationPattern<ISpreadsheetPattern> InitializeSpreadsheetPattern()
        {
            throw new NotImplementedException();
        }

        protected override IAutomationPattern<IStylesPattern> InitializeStylesPattern()
        {
            throw new NotImplementedException();
        }

        protected override IAutomationPattern<ISynchronizedInputPattern> InitializeSynchronizedInputPattern()
        {
            throw new NotImplementedException();
        }

        protected override IAutomationPattern<ITableItemPattern> InitializeTableItemPattern()
        {
            throw new NotImplementedException();
        }

        protected override IAutomationPattern<ITablePattern> InitializeTablePattern()
        {
            throw new NotImplementedException();
        }

        protected override IAutomationPattern<ITextChildPattern> InitializeTextChildPattern()
        {
            throw new NotImplementedException();
        }

        protected override IAutomationPattern<ITextEditPattern> InitializeTextEditPattern()
        {
            throw new NotImplementedException();
        }

        protected override IAutomationPattern<IText2Pattern> InitializeText2Pattern()
        {
            throw new NotImplementedException();
        }

        protected override IAutomationPattern<ITextPattern> InitializeTextPattern()
        {
            throw new NotImplementedException();
        }

        protected override IAutomationPattern<ITogglePattern> InitializeTogglePattern()
        {
            throw new NotImplementedException();
        }

        protected override IAutomationPattern<ITransform2Pattern> InitializeTransform2Pattern()
        {
            throw new NotImplementedException();
        }

        protected override IAutomationPattern<ITransformPattern> InitializeTransformPattern()
        {
            throw new NotImplementedException();
        }

        protected override IAutomationPattern<IValuePattern> InitializeValuePattern()
        {
            throw new NotImplementedException();
        }

        protected override IAutomationPattern<IVirtualizedItemPattern> InitializeVirtualizedItemPattern()
        {
            throw new NotImplementedException();
        }

        protected override IAutomationPattern<IWindowPattern> InitializeWindowPattern()
        {
            throw new NotImplementedException();
        }

        public override IAutomationPattern<T> GetCustomPattern<T, TNative>(PatternId pattern, Func<BasicAutomationElementBase, TNative, T> patternCreateFunc)
        {
            throw new NotImplementedException();
        }
    }
}