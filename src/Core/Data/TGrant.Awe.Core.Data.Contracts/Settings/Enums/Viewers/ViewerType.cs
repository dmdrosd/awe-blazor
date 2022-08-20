using System;
using System.ComponentModel;

namespace Awe.Contracts.Settings.Enums.Viewer
{
    /// <summary>
    /// Тип вьювера.
    /// </summary>
    public enum ViewerType
    {
        //*****************************
        /// <summary>Не указан</summary>
        [Description("Не указан")]
        None = 50,

        //*****************************
        /// <summary>Все</summary>
        [Description("Все")]
        All = 0,
        //*****************************
        /// <summary>Каталог обобщенный</summary>
        [Description("Каталог обобщенный")]
        Book = 1,

        /// <summary>Карточка обобщенный</summary>
        [Description("Карточка обобщенный")]
        Card = 2,

        /// <summary>Карточка смешанный</summary>
        [Obsolete]
        [Description("Карточка смешанный")]
        CardMix = 5,
        //*****************************
        /// <summary>Каталог без выбора</summary>
        [Description("Каталог без выбора")]
        Katalog = 11,

        /// <summary>Каталог с выбором</summary>
        [Description("Каталог с выбором")]
        viBook = 12,

        /// <summary>Подвал каталога с выбором</summary>
        [Description("Подвал каталога с выбором")]
        viBookDetail = 13,

        /// <summary>Форма с деревом</summary>
        [Description("Форма с деревом")]
        TreeBook = 14,
        //BookReport = 15,
        //CardReport = 16,

        /// <summary>Двойной каталог обобщенный</summary>
        [Description("Двойной каталог обобщенный")]
        DoubleBook = 17,

        /// <summary>Подвал двйоного каталога обобщенного</summary>
        [Description("Подвал двйоного каталога обобщенного")]
        DoubleBookDetail = 18,

        /// <summary>Двойной каталог обобщенный с выбором</summary>
        [Description("Двойной каталог обобщенный с выбором")]
        viDoubleBook = 19,

        //*****************************
        /// <summary>Простая карточка односложная</summary>
        [Description("Простая карточка односложная")]
        SimpleCard = 21,

        /// <summary>Шапка карточки многосложной</summary>
        [Description("Шапка карточки многосложной")]
        DoubleCard = 22,

        /// <summary>Подвал карточки многосложной</summary>
        [Description("Подвал карточки многосложной")]
        DoubleCardDetail = 23,

        //*****************************
        //        DoubleReport = 32,
        //        DoubleReportDetail = 33,

        /// <summary>Отчет ОО/ЛО односложный</summary>
        [Description("Отчет ОО/ЛО односложный")]
        OOCardReport = 34,

        /// <summary>Шапка отчета ОО/ЛО многосложного</summary>
        [Description("Шапка отчета ОО/ЛО многосложного")]
        OODoubleReport = 35,

        /// <summary>Подвал отчета ОО/ЛО многосложного</summary>
        [Description("Подвал отчета ОО/ЛО многосложного")]
        OODoubleReportDetail = 36,

        /// <summary>Термотрансверный отчет</summary>
        [Description("Термотрансверный отчет")]
        TTCardReport = 37,

        /// <summary>Отчет простой текстовый</summary>
        [Description("Отчет простой текстовый")]
        FileCardReport = 38,

        /// <summary>Подвал сложной формы-дерева</summary>
        [Description("Подвал сложной формы-дерева")]
        DoubleTreeDetail = 39,

        //*****************************
        /// <summary>Хранимая процедура</summary>
        [Description("Хранимая процедура")]
        StoredProc = 41,

        /// <summary>Главное меню итем</summary>
        [Description("Главное меню итем")]
        MainMenu = 42,

        /// <summary>Разделитель главного меню</summary>
        [Description("Разделитель главного меню")]
        MenuSeparator = 43,

        /// <summary>Главное меню с итемом печати</summary>
        [Description(">Главное меню с итемом печати")]
        MainMenuPrint = 44,

        /// <summary>Главное меню группа</summary>
        [Description("Главное меню группа")]
        MainMenuExtender = 45,


        /// <summary>Главное меню боковое группа</summary>
        [Description("Главное меню боковое группа")]
        SideMenuGroup = 46,

        /// <summary>Главное меню боковое итем</summary>
        [Description("Главное меню боковое итем")]
        SideMenu = 47,

        //*****************************
        /// <summary>Файловое хранилище</summary>
        [Description("Файловое хранилище")]
        FileStorage = 48,

        //*****************************
        /// <summary>Автоматизрованное рабочее место</summary>
        [Description("Автоматизрованное рабочее место")]
        ARM = 3,
    }
}