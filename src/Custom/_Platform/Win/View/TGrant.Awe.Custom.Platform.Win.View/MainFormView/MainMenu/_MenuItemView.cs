using Abp.Dependency;
using DevExpress.XtraBars;
using TGrant.Awe.Core.Widget.Contracts.View.MainMenu.MainMenuItem;

namespace TGrant.Awe.Custom.Platform.Win.View.MainFormView.MainMenu;

public abstract class MenuItemBaseView<T> : IMenuItemView, ITransientDependency
    where T : BarItem
{
    protected readonly T innerMenuItem;
    
    public MenuItemBaseView(T barItem)
    {
        innerMenuItem = barItem;
    }

    public abstract bool IsSeparator { get; }
    public object InnerItem  => innerMenuItem;

    public string Caption 
    { 
        get => innerMenuItem.Caption;
        set => innerMenuItem.Caption = value;
    }
}