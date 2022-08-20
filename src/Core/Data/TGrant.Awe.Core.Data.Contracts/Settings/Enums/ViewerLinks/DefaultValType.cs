namespace Awe.Contracts.Settings.Enums.ViewerLinks
{
    /// <summary>
    /// Как рассчитывать/взять значение по строке перехода.
    /// </summary>
    public enum DefaultValType
    {
        /// <summary>Копирование значения простое</summary>
        Copy = 0,

        /// <summary>Подстановка явно указанного значения</summary>
        Value = 1,

        /// <summary>Текущая дата</summary>
        CurDate = 2,

        /// <summary>Пустая строка</summary>
        EmptyString = 3,

        /// <summary>Значение из шапки (устарело. Использовать источник значения)</summary>
        MasterRowVal = 4,

        /// <summary>ИД персоны</summary>
        PersonID = 5,

        /// <summary>Рассчитать сумму</summary>
        CalcSum = 6,

        /// <summary>ИД пользователя</summary>
        UserID = 7,

        //SourceValue = 8

        /// <summary>Взять значение из текущей строки</summary>
        CurColumn = 8,

        /// <summary>Рассчитать указанную формулу.</summary>
        CustomFunc = 10,

        /// <summary>Подставить фильтр указанный в строку фильтрации грида</summary>
        LiteFilter = 21
    }
}
