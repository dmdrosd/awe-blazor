using System.Windows.Forms;
using Awe.Core.Widget.Contracts.View.Page;
using Volo.Abp.DependencyInjection;

namespace Awe.Platform.Win.View.Page;

public partial class PageView : Form, IPageView, ITransientDependency
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