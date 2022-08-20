using System.ComponentModel;

namespace Awe.Contracts.Settings.Enums
{
    public enum DBSource
    {
        /// <summary>Не указан</summary>
        [Description("Не указан")]
        None = 0,

        /// <summary>Метаданные</summary>
        [Description("Settings")]
        Settings = 1,

        /// <summary>Логи</summary>
        [Description("Логи")]
        LogDB = 5,

        /// <summary>Не указан</summary>
        [Description("Новые рельсы с API")]
        AweApi = 10,

        /// <summary>Обучение. МКБ</summary>
        [Description("Обучение. МКБ")]
        Study = 22,

        /// <summary>Обучение. МКБ</summary>
        [Description("Внутренняя CRM")]
        MiniCRM = 24
    }
}
