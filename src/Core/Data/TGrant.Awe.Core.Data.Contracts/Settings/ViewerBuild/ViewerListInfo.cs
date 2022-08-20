using Awe.Contracts.Settings.Enums.Viewer;

namespace Awe.Contracts.Settings.ViewerBuild
{
    /// <summary>
    /// Viewer information for list
    /// </summary>
    public class ViewerListInfo
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
        /// Viewer text title
        /// </summary>
        /// <remarks>
        /// In Russian.
        /// It is displayed on the form.
        /// </remarks>
        public string Caption { get; set; }

        /// <summary>
        /// The ability of the viewer to change
        /// </summary>
        /// <remarks>
        /// Not used
        /// </remarks>
        public bool ReadOnly { get; set; }

        /// <summary>
        /// Viewer type <c>ViewerType</c>
        /// </summary>
        public ViewerType ViewerType { get; set; }

        /// <summary>
        /// IsFirmaFilter. For tenant filtering
        /// </summary>
        public bool IsFirmaFilter { get; set; }

        /// <summary>
        /// Viewer full name
        /// </summary>
        public string FullName { get; set; }

        /// <summary>Main Viewer Id</summary>
        public int? MainViewerId { get; set; }

        /// <summary>Main Viewer Alias</summary>
        public string MainViewerAlias { get; set; }

        /// <summary>
        /// Viewer level
        /// </summary>
        /// <remarks>
        /// To indicate the level of the viewer, in the case of complex forms
        /// </remarks>
        public int ViewerLevel { get; set; }
    }
}
