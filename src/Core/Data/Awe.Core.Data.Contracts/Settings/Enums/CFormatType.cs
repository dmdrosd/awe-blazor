namespace Awe.Contracts.Settings.Enums
{
    /// <summary>
    /// Тип форматирования в контроле/гриде
    /// </summary>
    public enum CFormatType
    {
        /// <summary>Без форматирования</summary>
        None = 0,

        /// <summary>xxx,yy</summary>
        Num2 = 1,

        /// <summary>xxx,yyyyyy</summary>
        Num6 = 2,

        /// <summary>xxx</summary>
        Num0 = 3,

        /// <summary>dd.MM.YYYY HH:mm</summary>
        DateTime = 4
    }
}
