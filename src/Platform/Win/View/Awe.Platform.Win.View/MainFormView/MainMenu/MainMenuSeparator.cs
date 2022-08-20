using Awe.Core.Widget.Contracts.View.MainMenu.MainMenuItem;
using DevExpress.XtraBars;

namespace Awe.Platform.Win.View.MainFormView.MainMenu;

public class MainMenuSeparator : MenuItemBaseView<BarBaseButtonItem>, IMainMenuSeparatorView
{
    public MainMenuSeparator(BarManager barManager, BarBaseButtonItem barItem) : base(barItem)
    {
    }
    
    public override bool IsSeparator => true;
}