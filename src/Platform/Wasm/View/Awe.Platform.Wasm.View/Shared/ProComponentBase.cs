namespace Awe.Platform.Wasm.View.Shared;

public abstract class ProComponentBase : ComponentBase, IDisposable
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

    public virtual void Dispose()
    {
    }
}

