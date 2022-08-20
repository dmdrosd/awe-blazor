using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;

namespace Awe.Platform.Win.View.MainFormView.MainMenu;

public class MainMenuItemGroup : IMainMenuItemGroupView
{
    private readonly RibbonPageGroup _barSubItem;

    public MainMenuItemGroup(RibbonPageGroup barSubItem)
    {
        _barSubItem = barSubItem;
    }

    public void AddSubItems(IEnumerable<IMenuItemView> childMenuItems)
    {
        _barSubItem.ItemLinks.AddRange(childMenuItems
            .Select(mi => (BarItem)mi.InnerItem)
            .ToArray()
        );
    }

    public bool IsSeparator => false;
    public object InnerItem => _barSubItem;
    public string Caption
    {
        get => _barSubItem.Text;
        set => _barSubItem.Text = value;
    }
}