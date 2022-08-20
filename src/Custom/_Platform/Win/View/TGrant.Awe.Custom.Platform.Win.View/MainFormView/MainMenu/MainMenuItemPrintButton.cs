using DevExpress.XtraBars;
using TGrant.Awe.Core.Widget.Contracts.View.MainMenu.MainMenuItem;

namespace TGrant.Awe.Custom.Platform.Win.View.MainFormView.MainMenu;

public class MainMenuItemPrintButton : MainMenuItemButton, IMainMenuItemPrintButtonView
{
    private const int PrintImageIndex = 0;

    public MainMenuItemPrintButton(BarButtonItem barItem) : base(barItem)
    {
        barItem.ImageIndex = PrintImageIndex;
    }
}