namespace Awe.Contracts.Settings.Enums
{
    /// <summary>
    /// Перечисление по Крудам
    /// </summary>
    public enum CrudMode
    {
        /// <summary>Создание</summary>
        Create = 1,

        /// <summary>Чтение</summary>
        Read = 2,

        /// <summary>Изменение</summary>
        Update = 3,

        /// <summary>Удаление</summary>
        Delete = 4,
        
        //-----------------------------------

        /// <summary>Редактирование</summary>
        Edit = 11,

        /// <summary>Выполнение</summary>
        Exec = 12,

        /// <summary>Иное</summary>
        Other = 51
    }
}