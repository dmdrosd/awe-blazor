namespace Awe.Contracts.Settings.Enums.Viewer
{
    /// <summary>
    /// Свойство вьювера.
    /// </summary>
    public enum ViewerExtType
    {
        /// <summary>Панель уровня</summary>
        LevelView = 1,

        /// <summary>Панель всего уровня (устарело)</summary>
        ViewerHost = 2,

        /// <summary>Хранилище данных</summary>
        DataStateManager = 3,

        /// <summary>Контроллер</summary>
        LevelController = 4,

        /// <summary>Свойство</summary>
        PropVal = 5,

        /// <summary>Позиция панелей</summary>
        ListViewPosition = 6
    }
}