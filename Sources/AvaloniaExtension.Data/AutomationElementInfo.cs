using AvaloniaExtension.Data.Patterns;

namespace AvaloniaExtension.Data
{
    public class AutomationElementInfo
    {
        public string Name
        {
            get;
            set;
        }

        public double Width
        {
            get;
            set;
        }

        public double Height
        {
            get;
            set;
        }

        public double PositionOnDesktopX
        {
            get;
            set;
        }

        public double PositionOnDesktopY
        {
            get;
            set;
        }

        public InvokePatternInfo InvokePattern
        {
            get;
            set;
        }
    }
}