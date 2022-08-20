using System.Windows.Forms;
using TGrant.Awe.Core.Widget.Contracts.View.Page;

namespace TGrant.Awe.Custom.Platform.Win.View.Page;

public partial class PageView : Form, IPageView
{
    public PageView()
    {
        InitializeComponent();
    }

    public string Caption
    {
        get => Text;
        set => Text = value;
    }
}