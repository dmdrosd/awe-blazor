namespace Awe.Contracts.Settings.Enums.Action
{
    /// <summary>
    /// Summary description for ActionType.
    /// </summary>
    public enum ActionType
    {
        //Null

        /// <summary> </summary>
        None = 0,

        //==================Viewer==================

        /// <summary> </summary>		
        Open = 1,

        /// <summary> </summary>
        Exit = 10,
        //		Close,

        /// <summary> </summary>
        Confirm = 15,

        /// <summary> </summary>
        Print = 13,

        //==================DataHolder==================
        /// <summary> </summary>
        Load = 6,

        /// <summary> </summary>
        LoadFull = 16,

        /// <summary> </summary>
        Refresh = 5,

        /// <summary> </summary>
        RefreshFull = 17,

        /// <summary> </summary>
        Save = 2,

        /// <summary> </summary>
        SaveFull = 18,

        /// <summary> </summary>
        Mark = 12,

        /// <summary> </summary>
        MarkAll = 31,

        /// <summary> </summary>
        Find = 21,

        /// <summary> </summary>
        CallStoredProc = 22,

        /// <summary> </summary>
        Filter = 23,

        //==================DataRow==================
        /// <summary> </summary>
        Add = 7,

        /// <summary> </summary>
        Edit = 4,

        /// <summary> </summary>
        Delete = 8,

        /// <summary> </summary>
        FEdit = 3,

        /// <summary> </summary>
        MenuClick = 9,

        //==================Control==================

        //==================Navigation==================
        /// <summary> </summary>
        LevelUp = 108,

        /// <summary> </summary>
        LevelDown = 109,

        ////
        //      BarCodeAdd,
        //      BarCodeEdit,
        //   BarCodeScaned,

        //==================Custom==================
        /// <summary> </summary>
        Custom = 151,
    }
}