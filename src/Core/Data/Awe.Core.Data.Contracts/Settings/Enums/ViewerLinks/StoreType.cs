namespace Awe.Contracts.Settings.Enums.ViewerLinks
{
    /// <summary>
    /// Источник данных в переходе.
    /// </summary>
    public enum StoreType
    {
        /// <summary>Не указан</summary>
        None = 0,

        /// <summary>Из текущей строки формы Источника-Выбора (ИВ)</summary>
        viCurRow = 1,

        /// <summary>Из шапки текущей формы</summary>
        MasterRow = 2,

        /// <summary>Из хранилища формы</summary>
        ViewerStore = 3,

        /// <summary>Из хранилища приложения</summary>
        ApplStore = 4,

        /// <summary>Из текущей строки текущей формы</summary>
        SourceRow = 5,

        /// <summary>Из шапки формы Источника-Выбора (ИВ)</summary>
        viMasterRow = 6,

        /// <summary>Из sql-параметров </summary>
        SqlParam = 7,

        /// <summary>Из хранилища компьютера</summary>
        MashineConfig = 8,

        /// <summary>Из хранилища пользователя</summary>
        UserStore = 9
    }
}
