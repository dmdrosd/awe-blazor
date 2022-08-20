namespace Awe.Platform.Wasm.View.Shared;

public partial class Language
{
    private void OnLanguageChange(CultureInfo culture)
    {
        I18n.SetCulture(culture);
        GlobalConfig.Culture = culture;
    }
}