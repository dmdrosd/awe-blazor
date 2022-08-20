using System;
using DevExpress.XtraBars;

namespace Awe.Platform.Win.View.MainFormView.MainMenu;

public class MainMenuItemButton : MenuItemBaseView<BarButtonItem>, IMainMenuItemButtonView
{
    public MainMenuItemButton(BarButtonItem barItem) : base(barItem)
    {
        innerMenuItem.ItemClick += delegate { OnItemClick(); };
    }

    public event Action ItemClick;
    public override bool IsSeparator => false;

    private void OnItemClick()
    {
        var handler = ItemClick;
        handler?.Invoke();
    }
}