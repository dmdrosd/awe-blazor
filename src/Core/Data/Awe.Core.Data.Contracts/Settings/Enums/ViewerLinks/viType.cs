namespace Awe.Contracts.Settings.Enums.ViewerLinks
{
    /// <summary>
    /// Тип перехода.
    /// </summary>
    public enum viType
    {
        /// <summary>Не указан</summary>
        None = 0,

        /// <summary>
        /// Добавление нового значение через карточку простое.
        /// Для связи Каталог<>Карточка.
        /// </summary>
        SimpleAdd = 1,

        /// <summary>
        /// Простой выбор значения.
        /// Для связи Шапка<>ИВ, Подвал<>ИВ (без создания строки).
        /// </summary>
        SimpleSelect = 2,

        /// <summary>
        /// Большинство случаев. Множественный выбор.
        /// Подвал<>ИВ (с созданием строки), Подвал задание знач. по умолчанию. Запрос значения.
        /// </summary>
        IntMultiSelect = 3,

        /// <summary>
        /// Большинство случаев. Множественный выбор.
        /// Подвал<>ИВ (с созданием строки), Подвал задание знач. по умолчанию. Запрос значения.
        /// </summary>
        MultiSelect = 4,

        /// <summary>
        /// Выбор через промедуточный вьювер. Сложен в настройке.
        /// </summary>
        ComplexMultiSelect = 5,

        /// <summary>
        /// То же что и SimpleAdd, но без возможности вставки
        /// </summary>
        Edit = 6,

        /// <summary>
        /// Открывается Двусложная форма выбора.
        /// </summary>
        MultiSelectDoubleBook = 7,

        /// <summary>
        /// Открывается карточка, результат вставляется в начальный вьювер
        /// </summary>
        ComplexEdit = 8,

        /// <summary>Множественное помечание строк</summary>
        SimpleMultiSelect = 9,
        //SimpleEditByCntxMenu = 11,


        /// <summary>Открытие Viewer'а из главного меню</summary>
        Menu2Viewer = 21,

        /// <summary>Открытие Viewer'а из контекстного меню</summary>
        CtxMenu2Viewer = 22,

        /// <summary>Вызов хранимой процедуры из контекстного меню</summary>
        CtxMenu2SP = 23,

        /// <summary>Разделитель меню</summary>
        CtxMenuSplitter = 24,


        /// <summary>Наложение фильтра на Каталог</summary>
        FilterForm = 31,


        /// <summary>Создание Нового по ШК</summary>
        BarCodeAdd = 41,

        /// <summary>Редактирование по ШК</summary>
        BarCodeEdit = 42
    }
}