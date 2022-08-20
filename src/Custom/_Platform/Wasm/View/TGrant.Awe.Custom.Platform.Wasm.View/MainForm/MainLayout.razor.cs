namespace TGrant.Awe.Custom.Platform.Wasm.View.MainForm;

public partial class MainLayout
{
    private bool _showSetting;

    protected override void OnInitialized()
    {
        GlobalConfig.OnPageModeChanged += base.StateHasChanged;
    }

    public void Dispose()
    {
        GlobalConfig.OnPageModeChanged -= base.StateHasChanged;
    }
}