using System;

namespace Awe.Contracts.Settings.Enums.ViewerLinks
{
    /// <summary>
    /// Уровень вьювера с флагами.
    /// </summary>
    [Flags]
    public enum LevelFlag
    {
        /// <summary>Не определен</summary>
        Null = -1000,

        /// <summary>Не важен</summary>
        None = 0,

        /// <summary>Шапка</summary>
        Master = 1,

        /// <summary>Подвал</summary>
        Detail = 10,

        /// <summary>Остальные после шапки и подвала</summary>
        [Obsolete]
        Other = 100,

        /// <summary>Любой</summary>
        All = 1000000,
    }
}