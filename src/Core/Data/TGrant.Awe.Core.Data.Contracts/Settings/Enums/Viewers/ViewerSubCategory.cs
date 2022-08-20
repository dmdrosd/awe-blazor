using System;

namespace Awe.Contracts.Settings.Enums.Viewer
{
    /// <summary>
    /// Подкатегория вьювера.
    /// </summary>
    [Flags]
    public enum ViewerSubCategory : short
    {
        /// <summary>Значение по-умолчанию</summary>
        Default = 0,

        /// <summary>Фильтр-форма</summary>
        FilterCard = 1,

        /// <summary>Логин-форма</summary>
        UserLogin = 2,

        /// <summary>Карточка обычная</summary>
        Card = 4,

        /// <summary>Форма с выбором</summary>
        viForm = 8,

        /// <summary>Отчет</summary>
        Report = 16
    }
}