namespace Awe.Platform.Wasm.View.Shared;

public partial class Breadcrumb
{
    private List<BreadcrumbItem> breadcrumbs;
    
    protected override void OnInitialized()
    {
        GlobalConfig.OnLanguageChanged += base.StateHasChanged;
        GlobalConfig.OnCurrentNavChanged += base.StateHasChanged;

        breadcrumbs = GetBreadcrumbItems();
    }

    private List<BreadcrumbItem> GetBreadcrumbItems()
    {
        var items = new List<BreadcrumbItem>();
        var currentNav = NavHelper.SameLevelNavs.FirstOrDefault(n => n.Href is not null && Nav.Uri.Contains(n.Href));
        
        if (currentNav is null) return items;
        {
            if (currentNav.ParentId != 0)
            {
                var parentNav = NavHelper.SameLevelNavs.First(n => n.Id == currentNav.ParentId);
                items.Add(new BreadcrumbItem { Text = T(parentNav.Title), Href = parentNav.Href ?? parentNav.Children?.FirstOrDefault()?.Href ?? "" });
            }
            items.Add(new BreadcrumbItem { Text = T(currentNav.Title), Href = currentNav.Href });
            items.Last().Href = currentNav.Href;
        }
        return items;
    }

    public void Dispose()
    {
        GlobalConfig.OnLanguageChanged -= base.StateHasChanged;
        GlobalConfig.OnCurrentNavChanged -= base.StateHasChanged;
    }
}