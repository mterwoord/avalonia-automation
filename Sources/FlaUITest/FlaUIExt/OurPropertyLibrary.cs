using FlaUI.Core;
using FlaUI.Core.AutomationElements.Infrastructure;
using FlaUI.Core.Patterns;
using FlaUI.UIA2;
using FlaUITest.ElemProperties;

namespace FlaUITest.FlaUIExt
{
    public class OurPropertyLibrary: IPropertyLibray
    {
        public OurPropertyLibrary()
        {
            Element = new AutomationElementPropertiesImpl();
        }

        public IAutomationElementPatternAvailabilityProperties PatternAvailability => throw new System.NotImplementedException();

        public IAutomationElementProperties Element
        {
            get;
        }

        public IAnnotationPatternProperties Annotation => throw new System.NotImplementedException();

        public IDockPatternProperties Dock => throw new System.NotImplementedException();

        public IDragPatternProperties Drag => throw new System.NotImplementedException();

        public IDropTargetPatternProperties DropTarget => throw new System.NotImplementedException();

        public IExpandCollapsePatternProperties ExpandCollapse => throw new System.NotImplementedException();

        public IGridItemPatternProperties GridItem => throw new System.NotImplementedException();

        public IGridPatternProperties Grid => throw new System.NotImplementedException();

        public ILegacyIAccessiblePatternProperties LegacyIAccessible => throw new System.NotImplementedException();

        public IMultipleViewPatternProperties MultipleView => throw new System.NotImplementedException();

        public IRangeValuePatternProperties RangeValue => throw new System.NotImplementedException();

        public IScrollPatternProperties Scroll => throw new System.NotImplementedException();

        public ISelectionItemPatternProperties SelectionItem => throw new System.NotImplementedException();

        public ISelectionPatternProperties Selection => throw new System.NotImplementedException();

        public ISpreadsheetItemPatternProperties SpreadsheetItem => throw new System.NotImplementedException();

        public IStylesPatternProperties Styles => throw new System.NotImplementedException();

        public ITableItemPatternProperties TableItem => throw new System.NotImplementedException();

        public ITablePatternProperties Table => throw new System.NotImplementedException();

        public ITogglePatternProperties Toggle => throw new System.NotImplementedException();

        public ITransform2PatternProperties Transform2 => throw new System.NotImplementedException();

        public ITransformPatternProperties Transform => throw new System.NotImplementedException();

        public IValuePatternProperties Value => throw new System.NotImplementedException();

        public IWindowPatternProperties Window => throw new System.NotImplementedException();
    }
}