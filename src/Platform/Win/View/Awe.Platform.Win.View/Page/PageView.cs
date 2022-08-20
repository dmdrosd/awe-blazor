using System.Windows.Forms;
using Awe.Core.Widget.Contracts.View.Page;

namespace Awe.Platform.Win.View.Page;

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