namespace FlaUITest
{
    public static class AutomationElementIdentifiers
    {
        public struct PropertyEntry
        {
            public PropertyEntry(int id)
            {
                Id = id;
            }

            public int Id;
        }

        public const int AcceleratorKeyPropertyId = 1;
        public static PropertyEntry AcceleratorKeyProperty
        {
            get;
        } = new PropertyEntry(AcceleratorKeyPropertyId);

        public const int AccessKeyPropertyId = 2;
        public static PropertyEntry AccessKeyProperty
        {
            get;
        } = new PropertyEntry(AccessKeyPropertyId);

        public const int AriaPropertiesPropertyId = 3;
        public static PropertyEntry AriaPropertiesProperty
        {
            get;
        } = new PropertyEntry(AriaPropertiesPropertyId);

        public const int AriaRolePropertyId = 4;
        public static PropertyEntry AriaRoleProperty
        {
            get;
        } = new PropertyEntry(AriaRolePropertyId);

        public const int AutomationIdPropertyId = 5;
        public static PropertyEntry AutomationIdProperty
        {
            get;
        } = new PropertyEntry(AutomationIdPropertyId);

        public const int BoundingRectanglePropertyId = 6;
        public static PropertyEntry BoundingRectangleProperty
        {
            get;
        } = new PropertyEntry(BoundingRectanglePropertyId);

        public const int ClassNamePropertyId = 7;
        public static PropertyEntry ClassNameProperty
        {
            get;
        } = new PropertyEntry(ClassNamePropertyId);

        public const int ClickablePointPropertyId = 8;
        public static PropertyEntry ClickablePointProperty
        {
            get;
        } = new PropertyEntry(ClickablePointPropertyId);

        public const int ControllerForPropertyId = 9;
        public static PropertyEntry ControllerForProperty
        {
            get;
        } = new PropertyEntry(ControllerForPropertyId);

        public const int ControlTypePropertyId = 10;
        public static PropertyEntry ControlTypeProperty
        {
            get;
        } = new PropertyEntry(ControlTypePropertyId);

        public const int CulturePropertyId = 11;
        public static PropertyEntry CultureProperty
        {
            get;
        } = new PropertyEntry(CulturePropertyId);

        public const int DescribedByPropertyId = 12;
        public static PropertyEntry DescribedByProperty
        {
            get;
        } = new PropertyEntry(DescribedByPropertyId);

        public const int FlowsFromPropertyId = 13;
        public static PropertyEntry FlowsFromProperty
        {
            get;
        } = new PropertyEntry(FlowsFromPropertyId);

        public const int FlowsToPropertyId = 14;
        public static PropertyEntry FlowsToProperty
        {
            get;
        } = new PropertyEntry(FlowsToPropertyId);

        public const int FrameworkIdPropertyId = 15;
        public static PropertyEntry FrameworkIdProperty
        {
            get;
        } = new PropertyEntry(FrameworkIdPropertyId);

        public const int HasKeyboardFocusPropertyId = 16;
        public static PropertyEntry HasKeyboardFocusProperty
        {
            get;
        } = new PropertyEntry(HasKeyboardFocusPropertyId);

        public const int HelpTextPropertyId = 17;
        public static PropertyEntry HelpTextProperty
        {
            get;
        } = new PropertyEntry(HelpTextPropertyId);

        public const int IsContentElementPropertyId = 18;
        public static PropertyEntry IsContentElementProperty
        {
            get;
        } = new PropertyEntry(IsContentElementPropertyId);

        public const int IsControlElementPropertyId = 19;
        public static PropertyEntry IsControlElementProperty
        {
            get;
        } = new PropertyEntry(IsControlElementPropertyId);

        public const int IsDataValidForFormPropertyId = 20;
        public static PropertyEntry IsDataValidForFormProperty
        {
            get;
        } = new PropertyEntry(IsDataValidForFormPropertyId);

        public const int IsEnabledPropertyId = 21;
        public static PropertyEntry IsEnabledProperty
        {
            get;
        } = new PropertyEntry(IsEnabledPropertyId);

        public const int IsKeyboardFocusablePropertyId = 22;
        public static PropertyEntry IsKeyboardFocusableProperty
        {
            get;
        } = new PropertyEntry(IsKeyboardFocusablePropertyId);

        public const int IsOffscreenPropertyId = 23;
        public static PropertyEntry IsOffscreenProperty
        {
            get;
        } = new PropertyEntry(IsOffscreenPropertyId);

        public const int IsPasswordPropertyId = 24;
        public static PropertyEntry IsPasswordProperty
        {
            get;
        } = new PropertyEntry(IsPasswordPropertyId);

        public const int IsPeripheralPropertyId = 25;
        public static PropertyEntry IsPeripheralProperty
        {
            get;
        } = new PropertyEntry(IsPeripheralPropertyId);

        public const int IsRequiredForFormPropertyId = 26;
        public static PropertyEntry IsRequiredForFormProperty
        {
            get;
        } = new PropertyEntry(IsRequiredForFormPropertyId);

        public const int ItemStatusPropertyId = 27;
        public static PropertyEntry ItemStatusProperty
        {
            get;
        } = new PropertyEntry(ItemStatusPropertyId);

        public const int ItemTypePropertyId = 28;
        public static PropertyEntry ItemTypeProperty
        {
            get;
        } = new PropertyEntry(ItemTypePropertyId);

        public const int LabeledByPropertyId = 29;
        public static PropertyEntry LabeledByProperty
        {
            get;
        } = new PropertyEntry(LabeledByPropertyId);

        public const int LiveSettingPropertyId = 30;
        public static PropertyEntry LiveSettingProperty
        {
            get;
        } = new PropertyEntry(LiveSettingPropertyId);

        public const int LocalizedControlTypePropertyId = 31;
        public static PropertyEntry LocalizedControlTypeProperty
        {
            get;
        } = new PropertyEntry(LocalizedControlTypePropertyId);

        public const int NamePropertyId = 32;
        public static PropertyEntry NameProperty
        {
            get;
        } = new PropertyEntry(NamePropertyId);

        public const int NativeWindowHandlePropertyId = 33;
        public static PropertyEntry NativeWindowHandleProperty
        {
            get;
        } = new PropertyEntry(NativeWindowHandlePropertyId);

        public const int OptimizeForVisualContentPropertyId = 34;
        public static PropertyEntry OptimizeForVisualContentProperty
        {
            get;
        } = new PropertyEntry(OptimizeForVisualContentPropertyId);

        public const int OrientationPropertyId = 35;
        public static PropertyEntry OrientationProperty
        {
            get;
        } = new PropertyEntry(OrientationPropertyId);

        public const int ProcessIdPropertyId = 36;
        public static PropertyEntry ProcessIdProperty
        {
            get;
        } = new PropertyEntry(ProcessIdPropertyId);

        public const int ProviderDescriptionPropertyId = 37;
        public static PropertyEntry ProviderDescriptionProperty
        {
            get;
        } = new PropertyEntry(ProviderDescriptionPropertyId);

        public const int RuntimeIdPropertyId = 38;
        public static PropertyEntry RuntimeIdProperty
        {
            get;
        } = new PropertyEntry(RuntimeIdPropertyId);

        public const int NotSupportedPropertyId = 50;
        public static PropertyEntry NotSupportedProperty
        {
            get;
        } = new PropertyEntry(NotSupportedPropertyId);

        public const int IsDockPatternAvailablePropertyId = 78;
        public static PropertyEntry IsDockPatternAvailableProperty
        {
            get;
        } = new PropertyEntry(IsDockPatternAvailablePropertyId);

        public const int IsExpandCollapsePatternAvailablePropertyId = 79;
        public static PropertyEntry IsExpandCollapsePatternAvailableProperty
        {
            get;
        } = new PropertyEntry(IsExpandCollapsePatternAvailablePropertyId);

        public const int IsGridItemPatternAvailablePropertyId = 80;
        public static PropertyEntry IsGridItemPatternAvailableProperty
        {
            get;
        } = new PropertyEntry(IsGridItemPatternAvailablePropertyId);

        public const int IsGridPatternAvailablePropertyId = 81;
        public static PropertyEntry IsGridPatternAvailableProperty
        {
            get;
        } = new PropertyEntry(IsGridPatternAvailablePropertyId);

        public const int IsInvokePatternAvailablePropertyId = 82;
        public static PropertyEntry IsInvokePatternAvailableProperty
        {
            get;
        } = new PropertyEntry(IsInvokePatternAvailablePropertyId);

        public const int IsMultipleViewPatternAvailablePropertyId = 83;
        public static PropertyEntry IsMultipleViewPatternAvailableProperty
        {
            get;
        } = new PropertyEntry(IsMultipleViewPatternAvailablePropertyId);

        public const int IsRangeValuePatternAvailablePropertyId = 84;
        public static PropertyEntry IsRangeValuePatternAvailableProperty
        {
            get;
        } = new PropertyEntry(IsRangeValuePatternAvailablePropertyId);

        public const int IsSelectionItemPatternAvailablePropertyId = 85;
        public static PropertyEntry IsSelectionItemPatternAvailableProperty
        {
            get;
        } = new PropertyEntry(IsSelectionItemPatternAvailablePropertyId);

        public const int IsSelectionPatternAvailablePropertyId = 86;
        public static PropertyEntry IsSelectionPatternAvailableProperty
        {
            get;
        } = new PropertyEntry(IsSelectionPatternAvailablePropertyId);

        public const int IsScrollPatternAvailablePropertyId = 87;
        public static PropertyEntry IsScrollPatternAvailableProperty
        {
            get;
        } = new PropertyEntry(IsScrollPatternAvailablePropertyId);

        public const int IsSynchronizedInputPatternAvailablePropertyId = 88;
        public static PropertyEntry IsSynchronizedInputPatternAvailableProperty
        {
            get;
        } = new PropertyEntry(IsSynchronizedInputPatternAvailablePropertyId);

        public const int IsScrollItemPatternAvailablePropertyId = 89;
        public static PropertyEntry IsScrollItemPatternAvailableProperty
        {
            get;
        } = new PropertyEntry(IsScrollItemPatternAvailablePropertyId);

        public const int IsVirtualizedItemPatternAvailablePropertyId = 90;
        public static PropertyEntry IsVirtualizedItemPatternAvailableProperty
        {
            get;
        } = new PropertyEntry(IsVirtualizedItemPatternAvailablePropertyId);

        public const int IsItemContainerPatternAvailablePropertyId = 91;
        public static PropertyEntry IsItemContainerPatternAvailableProperty
        {
            get;
        } = new PropertyEntry(IsItemContainerPatternAvailablePropertyId);

        public const int IsTablePatternAvailablePropertyId = 92;
        public static PropertyEntry IsTablePatternAvailableProperty
        {
            get;
        } = new PropertyEntry(IsTablePatternAvailablePropertyId);

        public const int IsTableItemPatternAvailablePropertyId = 93;
        public static PropertyEntry IsTableItemPatternAvailableProperty
        {
            get;
        } = new PropertyEntry(IsTableItemPatternAvailablePropertyId);

        public const int IsTextPatternAvailablePropertyId = 94;
        public static PropertyEntry IsTextPatternAvailableProperty
        {
            get;
        } = new PropertyEntry(IsTextPatternAvailablePropertyId);

        public const int IsTogglePatternAvailablePropertyId = 95;
        public static PropertyEntry IsTogglePatternAvailableProperty
        {
            get;
        } = new PropertyEntry(IsTogglePatternAvailablePropertyId);

        public const int IsTransformPatternAvailablePropertyId = 96;
        public static PropertyEntry IsTransformPatternAvailableProperty
        {
            get;
        } = new PropertyEntry(IsTransformPatternAvailablePropertyId);

        public const int IsValuePatternAvailablePropertyId = 97;
        public static PropertyEntry IsValuePatternAvailableProperty
        {
            get;
        } = new PropertyEntry(IsValuePatternAvailablePropertyId);

        public const int IsWindowPatternAvailablePropertyId = 98;
        public static PropertyEntry IsWindowPatternAvailableProperty
        {
            get;
        } = new PropertyEntry(IsWindowPatternAvailablePropertyId);

        public const int ToolTipOpenedEventId = 99;
        public static PropertyEntry ToolTipOpenedEvent
        {
            get;
        } = new PropertyEntry(ToolTipOpenedEventId);

        public const int ToolTipClosedEventId = 100;
        public static PropertyEntry ToolTipClosedEvent
        {
            get;
        } = new PropertyEntry(ToolTipClosedEventId);

        public const int StructureChangedEventId = 101;
        public static PropertyEntry StructureChangedEvent
        {
            get;
        } = new PropertyEntry(StructureChangedEventId);

        public const int MenuOpenedEventId = 102;
        public static PropertyEntry MenuOpenedEvent
        {
            get;
        } = new PropertyEntry(MenuOpenedEventId);

        public const int AutomationPropertyChangedEventId = 103;
        public static PropertyEntry AutomationPropertyChangedEvent
        {
            get;
        } = new PropertyEntry(AutomationPropertyChangedEventId);

        public const int AutomationFocusChangedEventId = 104;
        public static PropertyEntry AutomationFocusChangedEvent
        {
            get;
        } = new PropertyEntry(AutomationFocusChangedEventId);

        public const int AsyncContentLoadedEventId = 105;
        public static PropertyEntry AsyncContentLoadedEvent
        {
            get;
        } = new PropertyEntry(AsyncContentLoadedEventId);

        public const int MenuClosedEventId = 106;
        public static PropertyEntry MenuClosedEvent
        {
            get;
        } = new PropertyEntry(MenuClosedEventId);

        public const int LayoutInvalidatedEventId = 107;
        public static PropertyEntry LayoutInvalidatedEvent
        {
            get;
        } = new PropertyEntry(LayoutInvalidatedEventId);
    }
}