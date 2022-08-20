using Awe.Contracts.Settings.Enums;

namespace Awe.Contracts.Settings.ViewerBuild
{
    /// <summary>
    /// DTO for transferring information about the columns of the viewer (list form).
    /// </summary>
    public class CColumnInfo
    {
        /// <summary>Id</summary>
        public int Id { get; set; }

        /// <summary>ViewerId</summary>
        public int ViewerId { get; set; }

        /// <summary>
        /// Column order.
        /// </summary>
        /// <remarks>
        /// If 0, then sorting is ignored.
        /// Default = 0
        /// </remarks>
        public int ColumnOrder { get; set; }

        /// <summary>
        /// The name of the column in the DB for binding.
        /// </summary>
        public string DBColumnName { get; set; }

        /// <summary>
        /// The type of control that will be generated.
        /// </summary>
        /// <remarks>
        /// Currently not used in the grid. Designed for card forms
        /// </remarks>
        public CControlType CControlType { get; set; }

        /// <summary>
        /// Column heading
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// Column change ability
        /// </summary>
        public bool ReadOnly { get; set; }

        /// <summary>
        /// Column or widget visible ability
        /// </summary>
        /// <remarks>
        /// Currently not used in the grid. Designed for card forms
        /// </remarks>
        public bool Visible { get; set; }

        /// <summary>
        /// Column or widget height
        /// </summary>
        /// <remarks>
        /// Currently not used in the grid. Designed for card forms
        /// </remarks>
        public int Height { get; set; }

        /// <summary>
        /// Column or widget width
        /// </summary>
        /// <remarks>
        /// Currently not used in the grid. Designed for card forms
        /// </remarks>
        public int Width { get; set; }

        /// <summary>
        /// Value text format <c>CFormatType</c>
        /// </summary>
        public CFormatType FormatType { get; set; }

        /// <summary>
        /// Indicator of showing the amount by columns below
        /// </summary>
        public bool ShowSum { get; set; }

        /// <summary>
        /// The sort order
        /// </summary>
        public int SortOrder { get; set; }
    }
}