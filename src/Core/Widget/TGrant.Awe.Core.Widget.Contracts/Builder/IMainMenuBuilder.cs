using Awe.Contracts.Settings.Menu;

namespace TGrant.Awe.Core.Widget.Contracts.Builder;

public interface IMainMenuBuilder : IBuilder
{
    void Build(IEnumerable<MenuItemInfo> menuItemInfos);
}
