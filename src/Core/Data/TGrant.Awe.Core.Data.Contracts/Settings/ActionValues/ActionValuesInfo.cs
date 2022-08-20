using Awe.Contracts.Settings.Enums.Action;
using Awe.Contracts.Settings.Enums.Viewer;

namespace Awe.Contracts.Settings.ActionValues
{
    public class ActionValuesInfo
    {
        public string KeyName { get; set; }
        public int? WinValue { get; set; }
        public bool Control { get; set; }
        public bool Alt { get; set; }
        public bool Shift { get; set; }

        public HotKey HotKey { get; set; }
        public ViewerType ViewerType { get; set; }

        public ActionType ActionType { get; set; }
        public int ActionCode { get; set; }
    }
}
