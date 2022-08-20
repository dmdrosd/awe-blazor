using System;

namespace Awe.Contracts.Settings.Enums.ViewerLinks
{
    /// <summary>
    /// Уровень вьювера.
    /// </summary>
    public enum LevelName
    {
        /// <summary>Не определен</summary>
        None = -1000,

        /// <summary>Шапка</summary>
        Master = 0,

        /// <summary>Подвал</summary>
        Detail = 1,//10,

        /// <summary>Остальные после шапки и подвала</summary>
        [Obsolete]
        Other = /*-1*/100
    }
}