namespace Awe.Platform.Wasm.View.Shared;

public partial class Navigation
{
    protected override Task OnInitializedAsync()
    {
        GlobalConfig.OnLanguageChanged += base.StateHasChanged;

        return base.OnInitializedAsync();
    }

    //public void Dispose()
    //{
    //    GlobalConfig.OnLanguageChanged -= base.StateHasChanged;
    //}
}