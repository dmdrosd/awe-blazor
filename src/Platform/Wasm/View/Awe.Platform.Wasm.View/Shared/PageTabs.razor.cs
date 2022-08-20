namespace Awe.Platform.Wasm.View.Shared;

public partial class Navigation
{
    protected override void OnInitialized()
    {
        GlobalConfig.OnLanguageChanged += base.StateHasChanged;
    }

    public void Dispose()
    {
        GlobalConfig.OnLanguageChanged -= base.StateHasChanged;
    }
}