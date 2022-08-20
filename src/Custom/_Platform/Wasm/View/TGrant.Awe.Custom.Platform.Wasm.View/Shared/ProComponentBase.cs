using BlazorComponent.I18n;
using Microsoft.AspNetCore.Components;

namespace TGrant.Awe.Custom.Platform.Wasm.View.Shared;

public abstract class ProComponentBase : ComponentBase
{
    private I18n? _languageProvider;

    [Inject]
    public I18n LanguageProvider
    {
        get => _languageProvider ?? throw new Exception("please Inject I18n!");
        set => _languageProvider = value;
    }

    public string T(string key)
    {
        return LanguageProvider.T(key) ?? key;
    }
}

