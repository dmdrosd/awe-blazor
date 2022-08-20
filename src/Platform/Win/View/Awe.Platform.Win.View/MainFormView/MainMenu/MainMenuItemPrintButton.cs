using DevExpress.XtraBars;

namespace Awe.Platform.Win.View.MainFormView.MainMenu;

public class MainMenuItemPrintButton : MainMenuItemButton, IMainMenuItemPrintButtonView
{
    private const int PrintImageIndex = 0;

    public MainMenuItemPrintButton(BarButtonItem barItem) : base(barItem)
    {
        barItem.ImageIndex = PrintImageIndex;
    }
}