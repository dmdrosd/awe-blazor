using Awe.Contracts.Settings.Enums.Menu;
using Awe.Contracts.Settings.ViewerBuild;

namespace Awe.Contracts.Settings.Menu
{
    public class MenuItemInfo
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public ViewerInfo Viewer { get; set; }

        public int ParentViewerId { get; set; }

        public int ViewerLevel { get; set; }

        public string Caption { get; set; }

        public MenuItemType MenuItemType { get; set; }

        public MenuItemInfo[] MenuSubItems { get; set; }
    }
}