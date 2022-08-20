using Awe.Contracts.Settings.ActionValues;
using Awe.Contracts.Settings.Enums.Viewer;

namespace Awe.Contracts.Settings.ViewerBuild
{
    /// <summary>
    /// DTO for building the viewer (properties, columns)
    /// </summary>
    public class ViewerFullInfo
    {
        /// <summary>Id</summary>
        public int Id { get; set; }

        /// <summary>
        /// Viewer name
        /// </summary>
        /// <remarks>
        /// In English.
        /// </remarks>
        public string Alias { get; set; }

        /// <summary>
        /// Viewer group <c>ViewerGroup</c>
        /// </summary>
        public ViewerGroup ViewerGroup { get; set; }

        /// <summary>
        /// Viewer type <c>ViewerType</c>
        /// </summary>
        public ViewerType ViewerType { get; set; }

        /// <summary>
        /// Viewer text title
        /// </summary>
        /// <remarks>
        /// In Russian.
        /// It is displayed on the form.
        /// </remarks>
        public string Caption { get; set; }

        /// <summary>
        /// Viewer level
        /// </summary>
        /// <remarks>
        /// To indicate the level of the viewer, in the case of complex forms
        /// </remarks>
        public int ViewerLevel { get; set; }

        /// <summary>
        /// Link to parent viewer or container viewer
        /// </summary>
        /// <remarks>
        /// The default is 0
        /// </remarks>
        public ViewerInfo MainViewer { get; set; }

        /// <summary>Main Viewer Id</summary>
        public int? MainViewerId { get; set; }

        /// <summary>
        /// The ability of the viewer to change
        /// </summary>
        /// <remarks>
        /// Not used
        /// </remarks>
        public bool ReadOnly { get; set; }

        /// <summary>
        /// Viewer height
        /// </summary>
        /// <remarks>
        /// For Desktop
        /// </remarks>
        public int Height { get; set; }

        /// <summary>
        /// Viewer Width
        /// </summary>
        /// <remarks>
        /// For Desktop
        /// </remarks>
        public int Width { get; set; }

        /// <summary>
        /// IsFirmaFilter. For tenant filtering
        /// </summary>
        public bool IsFirmaFilter { get; set; }

        /// <summary>
        /// Name of the column by which the period-end closing is checked
        /// </summary>
        public string ClosingPeriodDateClmnName { get; set; }

        /// <summary>
        /// Allowed inserted
        /// </summary>
        public bool AllowInsert { get; set; }

        /// <summary>
        /// Allowed update
        /// </summary>
        public bool AllowUpdate { get; set; }

        /// <summary>
        /// Allowed delete
        /// </summary>
        public bool AllowDelete { get; set; }

        /// <summary>
        /// Viewer columns
        /// </summary>
        /// <remarks>
        /// Used for gridable viewers
        /// </remarks>
        public CColumnInfo[] CColumns { get; set; }

        /// <summary>
        /// Viewer properties
        /// </summary>
        public ViewerPropInfo[] ViewerProps { get; set; }

        /// <summary>
        /// Hot key map
        /// </summary>
        public ActionValuesInfo[] ActionValues { get; set; }

        /// <summary>
        /// Crud
        /// </summary>
        public CrudInfo Crud { get; set; }
    }
}