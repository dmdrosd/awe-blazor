using DevExpress.XtraBars;
using TGrant.Awe.Core.Widget.Contracts.View.MainMenu.MainMenuItem;

namespace TGrant.Awe.Custom.Platform.Win.View.MainFormView.MainMenu;

public class MainMenuSeparator : MenuItemBaseView<BarBaseButtonItem>, IMainMenuSeparatorView
{
    public MainMenuSeparator(BarManager barManager, BarBaseButtonItem barItem) : base(barItem)
    {
    }
    
    public override bool IsSeparator => true;
}