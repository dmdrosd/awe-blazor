using Awe.Contracts.Settings.Enums.Viewer;

namespace Awe.Contracts.Settings.ViewerBuild
{
    /// <summary>
    /// Viewer flat information
    /// </summary>
    public class ViewerInfo
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
        /// Viewer type Name</c>
        /// </summary>
        public string ViewerTypeName => ViewerType.ToString();

        /// <summary>
        /// Viewer text title
        /// </summary>
        /// <remarks>
        /// In Russian.
        /// It is displayed on the form.
        /// </remarks>
        public string Caption { get; set; }
    }
}