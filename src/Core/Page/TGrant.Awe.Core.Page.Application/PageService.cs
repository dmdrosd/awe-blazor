using Abp.Application.Services;
using TGrant.Awe.Core.Widget.Contracts.Controller;
using TGrant.Awe.Core.Widget.Contracts.View;
using TGrant.Awe.Core.Widget.Contracts.View.Page;

namespace TGrant.Awe.Core.Page.Application;

public class PageService : ApplicationService, IPageService
{
    private IPageView _pageView;
    private IPageController _pageController;

    public PageService(IPageView pageView, IPageController pageController)
    {
        _pageView = pageView;
        _pageController = pageController;
    }

    public void Show()
    {
        _pageView.Show();
    }
}