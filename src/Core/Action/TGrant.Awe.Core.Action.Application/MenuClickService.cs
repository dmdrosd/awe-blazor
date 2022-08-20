using Abp.Application.Services;
using TGrant.Awe.Core.Action.Contracts;
using TGrant.Awe.Core.Page.Application;

namespace TGrant.Awe.Core.Action.Application;

public class MenuClickService : ApplicationService, IActionEventService<MenuClickEventData>
{
    private readonly IPageService _page;

    public MenuClickService(IPageService pageService)
    {
        _page = pageService;
    }

    public Task HandleEventAsync(MenuClickEventData eventData)
    {
        return Task.Run(() => _page.Show());
    }
}