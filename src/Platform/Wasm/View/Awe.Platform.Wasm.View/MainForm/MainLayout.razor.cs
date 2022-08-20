﻿namespace Awe.Platform.Wasm.View.MainForm;

public partial class MainLayout
{
    protected override void OnInitialized()
    {
        GlobalConfig.OnPageModeChanged += base.StateHasChanged;
    }

    public void Dispose()
    {
        GlobalConfig.OnPageModeChanged -= base.StateHasChanged;
    }
}