using Abp.Application.Services;
using Awe.Core.Action.Contracts;
using Awe.Core.Page.Application;

namespace Awe.Core.Action.Application;

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